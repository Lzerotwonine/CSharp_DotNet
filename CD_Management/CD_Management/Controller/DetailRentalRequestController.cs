using CD_Management.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_Management.Controller
{
    internal class DetailRentalRequestController : IController
    {
        private readonly string connectionString = "Data Source=THIEN\\SQLEXPRESS;Initial Catalog=CD_Management;Integrated Security=True;TrustServerCertificate=True";
        //private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CD_Management.Properties.Settings.CD_ManagementConnectionString"].ConnectionString;

        public List<IModel> Items { get; private set; }

        public DetailRentalRequestController()
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
            if (!(model is DetailRentalRequestModel detailRentalModel) || !detailRentalModel.isValidate())
            {
                return false;
            }

  
            using (var connection = GetDatabaseConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"
                INSERT INTO ChiTietPhieuMuon (MaHDBan, MaBang, SoLuong, DonGia, Coc, TienCoc) 
                VALUES (@MaHDBan, @MaBang, @SoLuong, @DonGia, @Coc, @TienCoc)";
                    command.Parameters.AddWithValue("@MaHDBan", detailRentalModel.MaHDBan);
                    command.Parameters.AddWithValue("@MaBang", detailRentalModel.MaBang);
                    command.Parameters.AddWithValue("@SoLuong", detailRentalModel.SoLuong);
                    command.Parameters.AddWithValue("@DonGia", detailRentalModel.DonGia);
                    command.Parameters.AddWithValue("@Coc", detailRentalModel.Coc);
                    command.Parameters.AddWithValue("@TienCoc", detailRentalModel.TienCoc);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public List<DetailRentalRequestModel> GetByMaHDMuon(string maHDMuon)
        {
            var details = new List<DetailRentalRequestModel>();

            string query = "SELECT * FROM ChiTietPhieuMuon WHERE MaHDBan = @MaHDBan";

            using (var connection = new SqlConnection("Data Source=DESKTOP-42MF9J5;Initial Catalog=CD_Management;Integrated Security=True"))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHDBan", maHDMuon);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        details.Add(new DetailRentalRequestModel
                        {
                            MaHDBan = reader["MaHDBan"].ToString(),
                            MaBang = reader["MaBang"].ToString(),
                            SoLuong = int.Parse(reader["SoLuong"].ToString()),
                            DonGia = float.Parse(reader["DonGia"].ToString()),
                            Coc = float.Parse(reader["Coc"].ToString()),
                            TienCoc = float.Parse(reader["TienCoc"].ToString())
                        });
                    }
                }
            }

            return details;
        }

        public void DeleteByMaHDMuon(string maHDMuon)
        {
            string query = "DELETE FROM ChiTietPhieuMuon WHERE MaHDBan = @MaHDBan";

            using (var connection = new SqlConnection("Data Source=DESKTOP-GF6DKHM;Initial Catalog=CD_Management;Integrated Security=True;TrustServerCertificate=True"))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHDBan", maHDMuon);
                connection.Open();
                command.ExecuteNonQuery();
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
            throw new NotImplementedException();
        }

    }
}
