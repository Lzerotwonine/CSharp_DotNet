using System;
using System.Collections.Generic;
using System.Linq;
using CD_Management.Model;
using System.Data.SqlClient;

namespace CD_Management.Controller
{
    public class CDController : IController
    {
        private readonly string connectionString = "Data Source=DESKTOP-GF6DKHM;Initial Catalog=CD_Management;Integrated Security=True;TrustServerCertificate=True";
        private CDDataContext db; // LINQ DataContext
        private List<IModel> items;

        public List<IModel> Items => items;

        public CDController()
        {
            items = new List<IModel>();
            db = new CDDataContext(); // Khởi tạo DataContext
        }

        // Tìm kiếm băng theo tên, tác giả, thể loại
        public List<IModel> Search(string tenBang = null, string tacGia = null, string theLoai = null)
        {
            var query = db.Bangs.AsQueryable();

            if (!string.IsNullOrEmpty(tenBang))
                query = query.Where(b => b.TenBang.Contains(tenBang));
            if (!string.IsNullOrEmpty(tacGia))
                query = query.Where(b => b.TacGia.Contains(tacGia));
            if (!string.IsNullOrEmpty(theLoai))
                query = query.Where(b => b.TheLoai.Contains(theLoai));

            return query.Select(b => new CDModel
            {
                MaBang = b.MaBang,
                TenBang = b.TenBang,
                SoLuong = b.SoLuong,
                DonGiaBan = b.DonGiaBan,
                TheLoai = b.TheLoai,
                TacGia = b.TacGia
            }).Cast<IModel>().ToList();
        }

        // Thêm mới Băng
        public bool Create(IModel model)
        {
            var bang = model as CDModel;
            if (IsExist(bang.MaBang)) return false;

            var dbBang = new Bang
            {
                MaBang = bang.MaBang,
                TenBang = bang.TenBang,
                SoLuong = bang.SoLuong,
                DonGiaBan = bang.DonGiaBan,
                TheLoai = bang.TheLoai,
                TacGia = bang.TacGia
            };

            db.Bangs.InsertOnSubmit(dbBang);
            db.SubmitChanges();

            items.Add(bang);
            return true;
        }

        // Cập nhật thông tin Băng
        public bool Update(IModel model)
        {
            var bang = model as CDModel;
            var dbBang = db.Bangs.FirstOrDefault(b => b.MaBang == bang.MaBang);
            if (dbBang == null) return false;

            dbBang.TenBang = bang.TenBang;
            dbBang.SoLuong = bang.SoLuong;
            dbBang.DonGiaBan = bang.DonGiaBan;
            dbBang.TheLoai = bang.TheLoai;
            dbBang.TacGia = bang.TacGia;

            db.SubmitChanges();

            var existingBang = Read(bang.MaBang) as CDModel;
            existingBang.TenBang = bang.TenBang;
            existingBang.SoLuong = bang.SoLuong;
            existingBang.DonGiaBan = bang.DonGiaBan;
            existingBang.TheLoai = bang.TheLoai;
            existingBang.TacGia = bang.TacGia;

            return true;
        }

        // Xóa Băng
        public bool Delete(object id)
        {
            var dbBang = db.Bangs.FirstOrDefault(b => b.MaBang == (string)id);
            if (dbBang == null) return false;

            db.Bangs.DeleteOnSubmit(dbBang);
            db.SubmitChanges();

            var bang = Read(id) as CDModel;
            if (bang != null)
            {
                items.Remove(bang);
            }

            return true;
        }

        // Đọc thông tin Băng theo ID
        public IModel Read(object id)
        {
            if (id is string maBang)
            {
                return items.FirstOrDefault(b => (b as CDModel).MaBang == maBang);
            }
            return null;
        }

        // Load tất cả Băng từ CSDL
        public bool Load()
        {
            var dbBangs = db.Bangs.ToList();
            items = dbBangs.Select(b => new CDModel
            {
                MaBang = b.MaBang,
                TenBang = b.TenBang,
                SoLuong = b.SoLuong,
                DonGiaBan = b.DonGiaBan,
                TheLoai = b.TheLoai,
                TacGia = b.TacGia
            }).Cast<IModel>().ToList();

            return items.Count > 0;
        }

        // Load thông tin Băng theo ID
        public bool Load(object id)
        {
            var dbBang = db.Bangs.FirstOrDefault(b => b.MaBang == (string)id);
            if (dbBang == null) return false;

            var bangModel = new CDModel
            {
                MaBang = dbBang.MaBang,
                TenBang = dbBang.TenBang,
                SoLuong = dbBang.SoLuong,
                DonGiaBan = dbBang.DonGiaBan,
                TheLoai = dbBang.TheLoai,
                TacGia = dbBang.TacGia
            };

            items.Clear();
            items.Add(bangModel);

            return true;
        }

        // Kiểm tra tồn tại của Băng theo mã
        public bool IsExist(object id)
        {
            return items.Any(b => (b as CDModel).MaBang == (string)id);
        }

        public bool IsExist(IModel model)
        {
            var bang = model as CDModel;
            return IsExist(bang.MaBang);
        }

        public List<string> LoadBangComboBox()
        {
            List<string> maBangList = new List<string>();
            string query = "SELECT MaBang FROM Bang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    maBangList.Add(reader["MaBang"].ToString());
                }
            }
            return maBangList;
        }
        public CDModel LoadBangDetails(string maBang)
        {
            CDModel bang = null;
            string query = "SELECT * FROM Bang WHERE MaBang = @MaBang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaBang", maBang);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    bang = new CDModel
                    {
                        MaBang = reader["MaBang"].ToString(),
                        TenBang = reader["TenBang"].ToString(),
                        SoLuong = Convert.ToInt32(reader["SoLuong"]),
                        DonGiaBan = (float)Convert.ToDouble(reader["DonGiaBan"]),
                        TheLoai = reader["TheLoai"].ToString(),
                        TacGia = reader["TacGia"].ToString()
                    };
                }
            }
            return bang;
        }
        public int GetAvailableQuantity(string maBang)
        {
            int quantity = 0;
            string query = "SELECT SoLuong FROM Bang WHERE MaBang = @MaBang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaBang", maBang);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    quantity = Convert.ToInt32(reader["SoLuong"]);
                }
            }
            return quantity;
        }
        public bool UpdateSoLuong(string maBang, int soLuong)
        {
            try
            {
                string updateQuery = "UPDATE Bang SET SoLuong = SoLuong - @SoLuong WHERE MaBang = @MaBang";

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SoLuong", soLuong);
                        command.Parameters.AddWithValue("@MaBang", maBang);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi, log lỗi và trả về false
                Console.WriteLine($"Lỗi khi cập nhật số lượng băng đĩa: {ex.Message}");
                return false;
            }
        }
    }
}
