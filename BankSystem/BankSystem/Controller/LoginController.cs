using BankSystem.Model;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BankSystem.Controller
{
    public class LoginController
    {
        private BankSystemDataContext db = new BankSystemDataContext(); // LINQ DataContext

        // Phương thức xác thực tài khoản
        public bool Authenticate(string id, string password)
        {
            // Tìm kiếm nhân viên theo ID
            var employee = db.Employees.SingleOrDefault(e => e.Id == id);
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
        public Employee GetEmployeeById(string id)
        {
            return db.Employees.SingleOrDefault(e => e.Id == id);
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
    }
}
