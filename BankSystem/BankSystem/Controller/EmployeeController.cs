using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;

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
}
