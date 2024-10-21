using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankSystem.Controller
{
    internal class AccountController : IController
    {
        private List<IModel> accounts;
        private BankSystemDataContext db; // DataContext từ LINQ to SQL

        public List<IModel> Items => accounts;

        public AccountController()
        {
            accounts = new List<IModel>();
            db = new BankSystemDataContext(); // Khởi tạo DataContext
        }

        // Tạo tài khoản mới
        public bool Create(IModel model)
        {
            var account = model as AccountModel;
            if (IsExist(account.Id)) return false;

            var dbAccount = new Account
            {
                Id = account.Id,
                CustomerId = account.CustomerId,
                DateOpened = account.DateOpened,
                Balance = account.Balance
            };

            db.Accounts.InsertOnSubmit(dbAccount);
            db.SubmitChanges();

            accounts.Add(account);
            return true;
        }

        // Cập nhật tài khoản
        public bool Update(IModel model)
        {
            var account = model as AccountModel;
            var dbAccount = db.Accounts.FirstOrDefault(a => a.Id == account.Id);
            if (dbAccount == null) return false;

            dbAccount.CustomerId = account.CustomerId;
            dbAccount.DateOpened = account.DateOpened;
            dbAccount.Balance = account.Balance;

            db.SubmitChanges();

            var existingAccount = Read(account.Id) as AccountModel;
            existingAccount.CustomerId = account.CustomerId;
            existingAccount.DateOpened = account.DateOpened;
            existingAccount.Balance = account.Balance;

            return true;
        }

        // Xóa tài khoản
        public bool Delete(object id)
        {
            var dbAccount = db.Accounts.FirstOrDefault(a => a.Id == (int)id);
            if (dbAccount == null) return false;

            db.Accounts.DeleteOnSubmit(dbAccount);
            db.SubmitChanges();

            var account = Read(id) as AccountModel;
            if (account != null)
            {
                accounts.Remove(account);
            }

            return true;
        }

        // Đọc tài khoản
        public IModel Read(object id)
        {
            return accounts.FirstOrDefault(a => (a as AccountModel).Id == (int)id);
        }

        // Load tất cả tài khoản từ CSDL
        public bool Load()
        {
            var dbAccounts = db.Accounts.ToList();
            accounts = dbAccounts.Select(a => new AccountModel
            {
                Id = a.Id,
                CustomerId = a.CustomerId,
                DateOpened = a.DateOpened ?? DateTime.Now,
                Balance = (float)a.Balance
            }).Cast<IModel>().ToList();

            return true;
        }

        // Phương thức Load tài khoản theo id
        public bool Load(object id)
        {
            var dbAccount = db.Accounts.FirstOrDefault(a => a.Id == (int)id);
            if (dbAccount == null)
            {
                return false; // Không tìm thấy tài khoản với ID này
            }

            var accountModel = new AccountModel
            {
                Id = dbAccount.Id,
                CustomerId = dbAccount.CustomerId,
                DateOpened = dbAccount.DateOpened ?? DateTime.Now,
                Balance = (float)dbAccount.Balance
            };

            accounts.Clear();
            accounts.Add(accountModel);

            return true;
        }

        // Kiểm tra tồn tại tài khoản theo ID
        public bool IsExist(object id)
        {
            return accounts.Any(a => (a as AccountModel).Id == (int)id);
        }

        public bool IsExist(IModel model)
        {
            var account = model as AccountModel;
            return IsExist(account.Id);
        }
    }
}
