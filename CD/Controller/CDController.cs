using CD.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Controller
{
    internal class CDController : IController
    {
        private readonly string connectionString = "Data Source=DESKTOP-42MF9J5;Initial Catalog=CD_Management;Integrated Security=True";
        public List<IModel> Items => throw new NotImplementedException();

        public bool Create(IModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(object id)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(IModel model)
        {
            throw new NotImplementedException();
        }

        public bool Load()
        {
            throw new NotImplementedException();
        }

        public bool Load(object id)
        {
            throw new NotImplementedException();
        }

        public IModel Read(object id)
        {
            throw new NotImplementedException();
        }

        public bool Update(IModel model)
        {
            throw new NotImplementedException();
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

                using (var connection = new SqlConnection("Data Source=DESKTOP-42MF9J5;Initial Catalog=CD_Management;Integrated Security=True"))
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
