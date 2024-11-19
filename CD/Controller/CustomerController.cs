using CD.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Controller
{
    internal class CustomerController : IController
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
        public List<CustomerModel> GetAllCustomers()
        {
            var customers = new List<CustomerModel>();

            string query = "SELECT MaKhach, TenKhach FROM Khach"; 

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var customer = new CustomerModel
                            {
                                MaKhach = reader["MaKhach"].ToString(),
                                TenKhach = reader["TenKhach"].ToString()
                            };
                            customers.Add(customer);
                        }
                    }
                }
            }
            return customers;
        }

        // Lấy thông tin khách hàng theo MaKhach
        public CustomerModel GetCustomerById(string maKhach)
        {
            CustomerModel customer = null;
            string query = "SELECT MaKhach, TenKhach, DienThoai, DiaChi FROM Khach WHERE MaKhach = @MaKhach";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKhach", maKhach);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer = new CustomerModel
                            {
                                MaKhach = reader["MaKhach"].ToString(),
                                TenKhach = reader["TenKhach"].ToString(),
                                DienThoai = reader["DienThoai"].ToString(),
                                DiaChi = reader["DiaChi"].ToString()
                            };
                        }
                    }
                }
            }
            return customer;
        }
    }
}
