using CD_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CD_Management.Controller
{
    public class LoginController : IController
    {
        private CDDataContext db = new CDDataContext(); // LINQ DataContext
        private List<IModel> employees = new List<IModel>();

        public List<IModel> Items { get; private set; } = new List<IModel>();

        // Phương thức xác thực tài khoản
        public bool Authenticate(string id, string password)
        {
            // Tìm kiếm nhân viên theo ID trong CSDL
            var employee = db.Accounts.SingleOrDefault(e => e.Id == id);
            if (employee != null)
            {
                // Băm mật khẩu nhập vào và so sánh với mật khẩu trong cơ sở dữ liệu
                string hashedPassword = HashPassword(password);
                if (employee.Password == hashedPassword)
                {
                    return true; // Xác thực thành công
                }
            }
            return false; // Xác thực thất bại
        }

        // Lấy Account theo ID
        public AccountModel GetAccountById(string id)
        {
            // Truy vấn trong CSDL để lấy nhân viên theo ID
            var employee = db.Accounts.SingleOrDefault(e => e.Id == id);
            if (employee != null)
            {
                return new AccountModel
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Password = employee.Password,
                    Role = employee.Role
                };
            }
            return null;
        }

        // Phương thức băm mật khẩu
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        // Các phương thức từ interface không thực hiện chức năng gì, chỉ trả về giá trị mặc định

        public bool Create(IModel model)
        {
            // Không thực hiện chức năng gì, trả về false
            return false;
        }

        public bool Update(IModel model)
        {
            // Không thực hiện chức năng gì, trả về false
            return false;
        }

        public bool Delete(object id)
        {
            // Không thực hiện chức năng gì, trả về false
            return false;
        }

        public IModel Read(object id)
        {
            // Không thực hiện chức năng gì, trả về null
            return null;
        }

        public bool Load()
        {
            // Không thực hiện chức năng gì, trả về false
            return false;
        }

        public bool Load(object id)
        {
            // Không thực hiện chức năng gì, trả về false
            return false;
        }

        public bool IsExist(object id)
        {
            // Không thực hiện chức năng gì, trả về false
            return false;
        }

        public bool IsExist(IModel model)
        {
            // Không thực hiện chức năng gì, trả về false
            return false;
        }
    }

}
