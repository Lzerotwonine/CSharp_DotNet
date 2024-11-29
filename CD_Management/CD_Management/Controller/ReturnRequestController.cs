using CD_Management.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Management.Controller
{
    internal class ReturnRequestController : IController
    {
        private string connectionString = "Data Source=THIEN\\SQLEXPRESS;Initial Catalog=CD_Management;Integrated Security=True"; // Cập nhật kết nối cơ sở dữ liệu
        //private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CD_Management.Properties.Settings.CD_ManagementConnectionString"].ConnectionString;

        public List<IModel> Items { get; private set; }

        public ReturnRequestController()
        {
            Items = new List<IModel>();
            Load(); // Load tất cả các phiếu trả khi khởi tạo controller
        }

        public bool Create(IModel model)
        {
            if (model is ReturnRequestModel returnRequest)
            {
                string query = "INSERT INTO PhieuTra (MaHDTra, MaHDMuon, NgayTraHang, TongTien) " +
                               "VALUES (@MaHDTra, @MaHDMuon, @NgayTraHang, @TongTien)";

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaHDTra", returnRequest.MaHDTra);
                        command.Parameters.AddWithValue("@MaHDMuon", returnRequest.MaHDMuon);
                        command.Parameters.AddWithValue("@NgayTraHang", returnRequest.NgayTraHang);
                        command.Parameters.AddWithValue("@TongTien", returnRequest.TongTien);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu thành công
                    }
                }
            }
            return false;
        }

        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(object id)
        {
            string query = "SELECT COUNT(1) FROM PhieuTra WHERE MaHDTra = @MaHDTra";
            bool exists = false;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaHDTra", id);
                    exists = Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
            return exists;
        }

        public bool IsExist(IModel model)
        {
            throw new NotImplementedException();
        }

        public bool Load()
        {
            Items.Clear();
            string query = "SELECT MaHDTra, MaHDMuon, NgayTraHang, TongTien FROM PhieuTra";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var returnRequest = new ReturnRequestModel
                            {
                                MaHDTra = reader["MaHDTra"].ToString(),
                                MaHDMuon = reader["MaHDMuon"].ToString(),
                                NgayTraHang = Convert.ToDateTime(reader["NgayTraHang"]),
                                TongTien = Convert.ToSingle(reader["TongTien"])
                            };
                            Items.Add(returnRequest);
                        }
                    }
                }
            }
            return Items.Count > 0;
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
    }
}
