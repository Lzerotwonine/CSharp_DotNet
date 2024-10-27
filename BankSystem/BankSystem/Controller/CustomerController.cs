using System;
using System.Collections.Generic;
using System.Linq;
using BankSystem.Model;

namespace BankSystem.Controller
{
    public class CustomerController : IController
    {
        private BankSystemDataContext db; // LINQ DataContext
        private List<IModel> customers;

        public List<IModel> Items => customers;

        public CustomerController()
        {
            customers = new List<IModel>();
            db = new BankSystemDataContext(); // Khởi tạo DataContext
        }

        // Phương thức thêm khách hàng
        public bool Create(IModel model)
        {
            var customer = model as CustomerModel;
            if (IsExist(customer.Id)) return false;

            var dbCustomer = new Customer
            {
                Id = customer.Id,
                Name = customer.Name,
                Phone = customer.Phone,
                Email = customer.Email,
                HouseNo = customer.HouseNo,
                City = customer.City,
                Pin = customer.Pin
            };

            db.Customers.InsertOnSubmit(dbCustomer);
            db.SubmitChanges();

            customers.Add(customer); // Thêm vào danh sách khách hàng trong bộ nhớ
            return true;
        }

        // Phương thức cập nhật khách hàng
        public bool Update(IModel model)
        {
            var customer = model as CustomerModel;
            var dbCustomer = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
            if (dbCustomer == null) return false;

            dbCustomer.Name = customer.Name;
            dbCustomer.Phone = customer.Phone;
            dbCustomer.Email = customer.Email;
            dbCustomer.HouseNo = customer.HouseNo;
            dbCustomer.City = customer.City;
            dbCustomer.Pin = customer.Pin;

            db.SubmitChanges();

            // Cập nhật khách hàng trong danh sách bộ nhớ
            var existingCustomer = Read(customer.Id) as CustomerModel;
            existingCustomer.Name = customer.Name;
            existingCustomer.Phone = customer.Phone;
            existingCustomer.Email = customer.Email;
            existingCustomer.HouseNo = customer.HouseNo;
            existingCustomer.City = customer.City;
            existingCustomer.Pin = customer.Pin;

            return true;
        }

        // Phương thức xóa khách hàng
        public bool Delete(object id)
        {
            var dbCustomer = db.Customers.FirstOrDefault(c => c.Id == (string)id);
            if (dbCustomer == null) return false;

            db.Customers.DeleteOnSubmit(dbCustomer);
            db.SubmitChanges();

            // Xóa khách hàng khỏi danh sách bộ nhớ
            var customer = Read(id) as CustomerModel;
            if (customer != null)
            {
                customers.Remove(customer);
            }

            return true;
        }

        // Đọc khách hàng theo ID
        public IModel Read(object id)
        {
            return customers.FirstOrDefault(c => (c as CustomerModel).Id == (string)id);
        }

        // Load tất cả khách hàng từ CSDL
        public bool Load()
        {
            var dbCustomers = db.Customers.ToList();
            customers = dbCustomers.Select(c => new CustomerModel
            {
                Id = c.Id,
                Name = c.Name,
                Phone = c.Phone,
                Email = c.Email,
                HouseNo = c.HouseNo,
                City = c.City,
                Pin = c.Pin
            }).Cast<IModel>().ToList();

            return customers.Count > 0;
        }

        // Load khách hàng theo id
        public bool Load(object id)
        {
            var dbCustomer = db.Customers.FirstOrDefault(c => c.Id == (string)id);
            if (dbCustomer == null) return false;

            var customerModel = new CustomerModel
            {
                Id = dbCustomer.Id,
                Name = dbCustomer.Name,
                Phone = dbCustomer.Phone,
                Email = dbCustomer.Email,
                HouseNo = dbCustomer.HouseNo,
                City = dbCustomer.City,
                Pin = dbCustomer.Pin
            };

            customers.Clear(); // Xóa danh sách cũ
            customers.Add(customerModel); // Thêm khách hàng vào danh sách

            return true;
        }

        // Kiểm tra tồn tại khách hàng theo ID
        public bool IsExist(object id)
        {
            return customers.Any(c => (c as CustomerModel).Id == (string)id);
        }

        public bool IsExist(IModel model)
        {
            var customer = model as CustomerModel;
            return IsExist(customer.Id);
        }
    }
}
