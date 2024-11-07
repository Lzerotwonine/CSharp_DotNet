using CD_Management.Controller;
using CD_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CD_Management.Controller
{
    public class AccountController : IController
    {
        private List<IModel> accounts;
        private CDDataContext db; // DataContext từ LINQ to SQL

        public List<IModel> Items => accounts;

        public AccountController()
        {
            accounts = new List<IModel>();
            db = new CDDataContext(); // Khởi tạo DataContext
        }
        // Thêm nhân viên mới
        public bool Create(IModel model)
        {
            try
            {
                var account = model as AccountModel;
                if (IsExist(account.Id)) return false;

                var dbAccounts = new Account
                {
                    Id = account.Id,
                    Name = account.Name,
                    Password = PasswordHelper.HashPassword(account.Password),
                    Role = account.Role
                };

                db.Accounts.InsertOnSubmit(dbAccounts);
                db.SubmitChanges();

                accounts.Add(account);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Cập nhật thông tin nhân viên
        public bool Update(IModel model)
        {
            try
            {
                var account = model as AccountModel;
                var dbAccounts = db.Accounts.SingleOrDefault(e => e.Id == account.Id);
                if (dbAccounts != null)
                {
                    dbAccounts.Name = account.Name;
                    dbAccounts.Role = account.Role;
                    db.SubmitChanges();

                    var existingAccount = Read(account.Id) as AccountModel;
                    existingAccount.Name = account.Name;
                    existingAccount.Role = account.Role;

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Xóa nhân viên
        public bool Delete(object id)
        {
            try
            {
                var dbAccount = db.Accounts.SingleOrDefault(e => e.Id == (string)id);
                if (dbAccount != null)
                {
                    db.Accounts.DeleteOnSubmit(dbAccount);
                    db.SubmitChanges();

                    var account = Read(id) as AccountModel;
                    if (account != null)
                    {
                        accounts.Remove(account);
                    }
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Đọc nhân viên
        public IModel Read(object id)
        {
            return accounts.FirstOrDefault(a => (a as AccountModel).Id == (string)id);
        }

        // Load tất cả nhân viên từ CSDL
        public bool Load()
        {
            var dbAccount = db.Accounts.ToList();
            accounts = dbAccount.Select(a => new AccountModel
            {
                Id = a.Id,
                Name = a.Name,
                Password = a.Password,
                Role = a.Role
            }).Cast<IModel>().ToList();

            return true;
        }

        // Phương thức Load nhân viên theo id
        public bool Load(object id)
        {
            var dbAccount = db.Accounts.FirstOrDefault(a => a.Id == (string)id);
            if (dbAccount == null)
            {
                return false; // Không tìm thấy nhân viên với ID này
            }

            var accountModel = new AccountModel
            {
                Id = dbAccount.Id,
                Name = dbAccount.Name,
                Password = dbAccount.Password,
                Role = dbAccount.Role
            };

            accounts.Clear();
            accounts.Add(accountModel);

            return true;
        }

        // Kiểm tra tồn tại nhân viên theo ID
        public bool IsExist(object id)
        {
            if (accounts == null || !accounts.Any())
            {
                return false;
            }

            return accounts.Any(a => (a as AccountModel).Id == (string)id);
        }

        public bool IsExist(IModel model)
        {
            var account = model as AccountModel;
            return IsExist(account.Id);
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
}
