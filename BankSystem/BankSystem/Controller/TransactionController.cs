using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankSystem.Controller
{
    internal class TransactionController : IController
    {
        private BankSystemDataContext db = new BankSystemDataContext(); // LINQ DataContext
        public List<IModel> Items { get; private set; } = new List<IModel>();

        private AccountController accountController;
        private CustomerController customerController;

        public TransactionController()
        {
            accountController = new AccountController();
            customerController = new CustomerController();
        }

        // Tạo giao dịch mới
        public bool Create(IModel model)
        {
            try
            {
                BankTransactionModel transactionModel = (BankTransactionModel)model;

                // Chuyển đổi từ BankTransactionModel sang BankTransaction
                BankTransaction transaction = new BankTransaction
                {
                    Type = transactionModel.Type,
                    AccountFromId = transactionModel.AccountFromId,
                    AccountToId = transactionModel.AccountToId,
                    Amount = transactionModel.Amount,
                    DateOfTrans = transactionModel.DateOfTrans,
                    EmployeeId = transactionModel.EmployeeId,
                    BranchId = transactionModel.BranchId,
                    Description = transactionModel.Description
                };

                db.BankTransactions.InsertOnSubmit(transaction);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Cập nhật thông tin giao dịch
        public bool Update(IModel model)
        {
            try
            {
                BankTransactionModel transaction = (BankTransactionModel)model;
                var existingTransaction = db.BankTransactions.SingleOrDefault(t => t.Id == transaction.Id);

                if (existingTransaction != null)
                {
                    existingTransaction.Type = transaction.Type;
                    existingTransaction.Amount = transaction.Amount;
                    existingTransaction.AccountFromId = transaction.AccountFromId;
                    existingTransaction.AccountToId = transaction.AccountToId;
                    existingTransaction.DateOfTrans = transaction.DateOfTrans;
                    existingTransaction.Description = transaction.Description;

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

        // Xoá giao dịch
        public bool Delete(object id)
        {
            try
            {
                var transaction = db.BankTransactions.SingleOrDefault(t => t.Id == (int)id);
                if (transaction != null)
                {
                    db.BankTransactions.DeleteOnSubmit(transaction);
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

        // Đọc giao dịch theo ID
        public IModel Read(object id)
        {
            var transaction = db.BankTransactions.SingleOrDefault(t => t.Id == (int)id);
            if (transaction != null)
            {
                return new BankTransactionModel
                {
                    Id = transaction.Id,
                    Type = transaction.Type,
                    AccountFromId = transaction.AccountFromId,
                    AccountToId = transaction.AccountToId,
                    Amount = transaction.Amount,
                    DateOfTrans = transaction.DateOfTrans,
                    EmployeeId = transaction.EmployeeId,
                    BranchId = transaction.BranchId,
                    Description = transaction.Description
                };
            }
            return null;
        }

        // Tải tất cả giao dịch
        public bool Load()
        {
            try
            {
                Items = db.BankTransactions.Select(t => new BankTransactionModel
                {
                    Id = t.Id,
                    Type = t.Type,
                    AccountFromId = t.AccountFromId,
                    AccountToId = t.AccountToId,
                    Amount = t.Amount,
                    DateOfTrans = t.DateOfTrans,
                    EmployeeId = t.EmployeeId,
                    BranchId = t.BranchId,
                    Description = t.Description
                }).ToList<IModel>();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Phương thức Load giao dịch theo id
        public bool Load(object id)
        {
            try
            {
                int transactionId = (int)id;
                var transaction = db.BankTransactions.SingleOrDefault(t => t.Id == transactionId);

                if (transaction != null)
                {
                    Items.Clear();
                    Items.Add(new BankTransactionModel
                    {
                        Id = transaction.Id,
                        Type = transaction.Type,
                        AccountFromId = transaction.AccountFromId,
                        AccountToId = transaction.AccountToId,
                        Amount = transaction.Amount,
                        DateOfTrans = transaction.DateOfTrans,
                        EmployeeId = transaction.EmployeeId,
                        BranchId = transaction.BranchId,
                        Description = transaction.Description
                    });
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

            return false;
        }

        // Kiểm tra nếu tồn tại giao dịch theo ID
        public bool IsExist(object id)
        {
            return db.BankTransactions.Any(t => t.Id == (int)id);
        }

        // Kiểm tra nếu giao dịch tồn tại
        public bool IsExist(IModel model)
        {
            BankTransactionModel transaction = (BankTransactionModel)model;
            return db.BankTransactions.Any(t => t.Id == transaction.Id);
        }

        // Phương thức nạp và rút tiền chung
        public bool ProcessTransaction(int accountId, double amount, string transactionType, string employeeId, string branchId, string description, string pin)
        {
            try
            {
                var account = db.Accounts.SingleOrDefault(a => a.Id == accountId);
                if (account != null && (transactionType == "Deposit" ? amount > 0 : account.Balance >= amount))
                {
                    if (transactionType == "Deposit")
                    {
                        account.Balance += amount;
                    }
                    else if (transactionType == "Withdraw")
                    {
                        account.Balance -= amount;
                    }

                    // Tạo giao dịch
                    var transaction = new BankTransaction
                    {
                        Type = transactionType,
                        AccountFromId = transactionType == "Withdraw" ? (int?)account.Id : null,
                        AccountToId = transactionType == "Deposit" ? (int?)account.Id : null, // Lưu AccountToId khi nạp tiền
                        Amount = amount,
                        DateOfTrans = DateTime.Now, // Tự động gán thời gian hiện tại
                        EmployeeId = employeeId,
                        BranchId = branchId,
                        Description = description,
                        Pin = pin
                    };

                    db.BankTransactions.InsertOnSubmit(transaction);
                    db.SubmitChanges();

                    // Cập nhật số dư tài khoản
                    Update((IModel)account);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Chuyển tiền (Transaction Amount)
        public bool Transfer(int fromAccountId, int toAccountId, double amount, string employeeId, string branchId, string description)
        {
            try
            {
                var fromAccount = db.Accounts.SingleOrDefault(a => a.Id == fromAccountId);
                var toAccount = db.Accounts.SingleOrDefault(a => a.Id == toAccountId);

                if (fromAccount != null && toAccount != null && fromAccount.Balance >= amount)
                {
                    fromAccount.Balance -= amount;
                    toAccount.Balance += amount;

                    // Tạo giao dịch chuyển tiền
                    var transferTransaction = new BankTransaction
                    {
                        Type = "Transfer",
                        AccountFromId = fromAccountId,
                        AccountToId = toAccountId,
                        Amount = amount,
                        DateOfTrans = DateTime.Now,
                        EmployeeId = employeeId,
                        BranchId = branchId,
                        Description = description
                    };

                    db.BankTransactions.InsertOnSubmit(transferTransaction);
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

        // Xem số dư tài khoản (Balance Account)
        public double GetBalance(int accountId)
        {
            var account = db.Accounts.SingleOrDefault(a => a.Id == accountId);
            return account != null ? (double)account.Balance : -1;
        }

        // Xem nhật ký giao dịch (Transaction log)
        public List<BankTransactionModel> GetTransactionLog(int accountId)
        {
            return db.BankTransactions
                     .Where(t => t.AccountFromId == accountId || t.AccountToId == accountId)
                     .Select(t => new BankTransactionModel
                     {
                         Id = t.Id,
                         Type = t.Type,
                         AccountFromId = t.AccountFromId,
                         AccountToId = t.AccountToId,
                         Amount = t.Amount,
                         DateOfTrans = t.DateOfTrans,
                         EmployeeId = t.EmployeeId,
                         BranchId = t.BranchId,
                         Description = t.Description
                     }).ToList();
        }

        // Phương thức lấy thông tin tài khoản và khách hàng theo AccountId
        public (string Name, float Balance, string Pin) GetCustomerInfoByAccountId(int accountId)
        {
            var account = db.Accounts.SingleOrDefault(a => a.Id == accountId);
            if (account != null)
            {
                var customer = db.Customers.SingleOrDefault(c => c.Id == account.CustomerId);
                if (customer != null)
                {
                    return (customer.Name, (float)account.Balance, customer.Pin);
                }
            }
            return (null, -1, null); // Giá trị mặc định nếu không tìm thấy
        }

        // Phương thức lấy tài khoản theo ID
        public AccountModel GetAccountById(object id)
        {
            var account = db.Accounts.SingleOrDefault(a => a.Id == (int)id);
            if (account != null)
            {
                return new AccountModel
                {
                    Id = account.Id,
                    Balance = (float)account.Balance,
                    CustomerId = account.CustomerId
                };
            }
            return null;
        }

        // Phương thức lấy tất cả tài khoản
        public List<AccountModel> GetAllAccounts()
        {
            return db.Accounts.Select(a => new AccountModel
            {
                Id = a.Id,
                Balance = (float)a.Balance,
                CustomerId = a.CustomerId
            }).ToList();
        }

        public int? GetLatestDepositTransactionId()
        {
            return db.BankTransactions
                     .Where(t => t.Type == "Deposit")
                     .OrderByDescending(t => t.DateOfTrans)
                     .Select(t => (int?)t.Id)
                     .FirstOrDefault();
        }
    }
}
