using CD_Management.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CD_Management.Controller
{
    internal class RentalRequestController : IController
    {
        private readonly string connectionString = "Data Source=DESKTOP-08N8TNO\\SQLEXPRESS;Initial Catalog=CD_Management;Integrated Security=True";
        public List<IModel> Items { get; private set; }

        public RentalRequestController()
        {
            Items = new List<IModel>();
        }
        private SqlConnection GetDatabaseConnection()
        {
            return new SqlConnection(connectionString);
        }
        public bool Create(IModel model)
        {
            // Validate the input model
            if (!(model is RentalRequestModel rentalModel) || !rentalModel.isValidate())
            {
                return false;
            }

            using (var connection = GetDatabaseConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    // Cập nhật câu lệnh SQL để thêm cột TienTra
                    command.CommandText = @"
                INSERT INTO PhieuMuon (MaHDMuon, NgayMuon, NgayTra, MaKhach, TienCoc, TienTra, HoatDong) 
                VALUES (@MaHDMuon, @NgayMuon, @NgayTra, @MaKhach, @TienCoc, @TienTra, @HoatDong)";

                    // Thêm các tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@MaHDMuon", rentalModel.MaHDMuon);
                    command.Parameters.AddWithValue("@NgayMuon", rentalModel.NgayMuon);
                    command.Parameters.AddWithValue("@NgayTra", rentalModel.NgayTra);
                    command.Parameters.AddWithValue("@MaKhach", rentalModel.MaKhach);
                    command.Parameters.AddWithValue("@TienCoc", rentalModel.TienCoc);
                    command.Parameters.AddWithValue("@TienTra", rentalModel.TienTra);  // Thêm tham số TienTra
                    command.Parameters.AddWithValue("@HoatDong", rentalModel.HoatDong);

                    // Thực thi câu lệnh SQL
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
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
            if (model is RentalRequestModel rentalRequest)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = @"
                            UPDATE PhieuMuon
                            SET 
                                HoatDong = @HoatDong
                            WHERE MaHDMuon = @MaHDMuon";

                        // Tạo command với câu lệnh SQL và kết nối
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@HoatDong", rentalRequest.HoatDong);
                            command.Parameters.AddWithValue("@MaHDMuon", rentalRequest.MaHDMuon);
                            int rowsAffected = command.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

        }

        public RentalRequestModel GetRentalRequestByMaHDMuon(string maHDMuon)
        {
            RentalRequestModel rentalRequest = null;
            string query = "SELECT MaHDMuon, NgayMuon, NgayTra, MaKhach, TienCoc, HoatDong, TienTra FROM PhieuMuon WHERE MaHDMuon = @MaHDMuon";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaHDMuon", maHDMuon);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rentalRequest = new RentalRequestModel
                            {
                                MaHDMuon = reader["MaHDMuon"]?.ToString(),
                                NgayMuon = reader["NgayMuon"] != DBNull.Value ? Convert.ToDateTime(reader["NgayMuon"]) : DateTime.MinValue,
                                NgayTra = reader["NgayTra"] != DBNull.Value ? Convert.ToDateTime(reader["NgayTra"]) : DateTime.MinValue,
                                MaKhach = reader["MaKhach"]?.ToString(),
                                TienCoc = reader["TienCoc"] != DBNull.Value ? Convert.ToSingle(reader["TienCoc"]) : 0,
                                HoatDong = reader["HoatDong"] != DBNull.Value && Convert.ToBoolean(reader["HoatDong"]),
                                TienTra = reader["TienTra"] != DBNull.Value ? (float?)Convert.ToSingle(reader["TienTra"]) : null
                            };
                        }
                    }
                }
            }
            return rentalRequest;
        }

        public RentalRequestModel GetById(string maPhieuMuon)
        {
            RentalRequestModel rentalRequest = null;

            string query = "SELECT * FROM PhieuMuon WHERE MaHDMuon = @MaHDMuon";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHDMuon", maPhieuMuon);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rentalRequest = new RentalRequestModel
                        {
                            MaHDMuon = reader["MaHDMuon"].ToString(),
                            NgayMuon = DateTime.Parse(reader["NgayMuon"].ToString()),
                            NgayTra = DateTime.Parse(reader["NgayTra"].ToString()),
                            MaKhach = reader["MaKhach"].ToString(),
                            HoatDong = bool.Parse(reader["HoatDong"].ToString())
                        };
                    }
                }
            }

            return rentalRequest;
        }

        public void Delete(string maPhieuMuon)
        {
            string query = "DELETE FROM PhieuMuon WHERE MaHDMuon = @MaHDMuon";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHDMuon", maPhieuMuon);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<string> GetAllMaPhieuMuon()
        {
            var maPhieuMuonList = new List<string>();
            string query = "SELECT MaHDMuon FROM PhieuMuon WHERE HoatDong = 0";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Thêm mã phiếu mượn vào danh sách
                            maPhieuMuonList.Add(reader["MaHDMuon"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    Console.WriteLine("Lỗi khi lấy danh sách mã phiếu mượn: " + ex.Message);
                }
            }

            return maPhieuMuonList;
        }

    }
}
