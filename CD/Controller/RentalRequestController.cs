﻿using CD.Controller;
using CD.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Controller
{
    internal class RentalRequestController : IController
    {
        private readonly string connectionString = "Data Source=DESKTOP-42MF9J5;Initial Catalog=CD_Management;Integrated Security=True";
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
            if (!(model is RentalRequestModel rentalModel) || !rentalModel.Isvalidate())
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
        public List<RentalRequestModel> GetAllRentalRequests()
        {
            var rentalRequests = new List<RentalRequestModel>();

            string query = "SELECT MaHDMuon, NgayMuon, NgayTra, MaKhach, TienCoc, HoatDong, TienTra FROM PhieuMuon WHERE HoatDong = 0";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rentalRequest = new RentalRequestModel
                            {
                                MaHDMuon = reader["MaHDMuon"]?.ToString(),
                                NgayMuon = reader["NgayMuon"] != DBNull.Value ? Convert.ToDateTime(reader["NgayMuon"]) : DateTime.MinValue,
                                NgayTra = reader["NgayTra"] != DBNull.Value ? Convert.ToDateTime(reader["NgayTra"]) : DateTime.MinValue,
                                MaKhach = reader["MaKhach"]?.ToString(),
                                TienCoc = reader["TienCoc"] != DBNull.Value ? Convert.ToSingle(reader["TienCoc"]) : 0,
                                HoatDong = reader["HoatDong"] != DBNull.Value && Convert.ToBoolean(reader["HoatDong"]),
                                TienTra = reader["TienTra"] != DBNull.Value ? (float?)Convert.ToSingle(reader["TienTra"]) : null
                            };
                            rentalRequests.Add(rentalRequest);
                        }
                    }
                }
            }

            return rentalRequests;
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

    }
}