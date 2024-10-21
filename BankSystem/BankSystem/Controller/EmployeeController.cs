using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BankSystem.Controller
{
    public class EmployeeController
    {
        private BankSystemDataContext db = new BankSystemDataContext(); // LINQ DataContext

        // Thêm nhân viên mới
        public bool Create(Employee employee)
        {
            try
            {
                if (db.Employees.Any(e => e.Id == employee.Id))
                {
                    return false;
                }

                // Hash the password before saving
                employee.Password = PasswordHelper.HashPassword(employee.Password);

                db.Employees.InsertOnSubmit(employee);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        // Cập nhật thông tin nhân viên
        public bool Update(Employee employee)
        {
            try
            {
                var existingEmployee = db.Employees.SingleOrDefault(e => e.Id == employee.Id);
                if (existingEmployee != null)
                {
                    existingEmployee.Name = employee.Name;
                    existingEmployee.Password = employee.Password;
                    existingEmployee.Role = employee.Role;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Xóa nhân viên
        public bool Delete(string id)
        {
            try
            {
                var employeeToDelete = db.Employees.SingleOrDefault(e => e.Id == id);
                if (employeeToDelete != null)
                {
                    db.Employees.DeleteOnSubmit(employeeToDelete);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Lấy danh sách tất cả nhân viên
        public List<Employee> LoadEmployees()
        {
            return db.Employees.ToList();
        }
    }
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
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
