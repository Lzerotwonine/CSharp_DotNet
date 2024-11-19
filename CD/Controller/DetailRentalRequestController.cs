using CD.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Controller
{
    internal class DetailRentalRequestController : IController
    {
        private readonly string connectionString = "Data Source=DESKTOP-42MF9J5;Initial Catalog=CD_Management;Integrated Security=True";
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
            if (!(model is DetailRentalRequestModel detailRentalModel) || !detailRentalModel.Isvalidate())
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
