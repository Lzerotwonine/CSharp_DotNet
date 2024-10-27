using System;

namespace BankSystem.Model
{
    public class BankTransactionModel : IModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? AccountFromId { get; set; }
        public int? AccountToId { get; set; }
        public double Amount { get; set; }
        public DateTime DateOfTrans { get; set; }
        public string EmployeeId { get; set; }
        public string BranchId { get; set; }
        public string Description { get; set; }

        public BankTransactionModel() { }

        // Khởi tạo có tham số
        public BankTransactionModel(string type, int? accountFromId, int? accountToId, double amount, DateTime dateOfTrans, string employeeId, string branchId, string description)
        {
            Type = type;
            AccountFromId = accountFromId;
            AccountToId = accountToId;
            Amount = amount;
            DateOfTrans = dateOfTrans;
            EmployeeId = employeeId;
            BranchId = branchId;
            Description = description;
        }

        // Overriding method ToString để hiển thị thông tin giao dịch dễ đọc hơn
        public override string ToString()
        {
            return $"Transaction: {Type}, Amount: {Amount}, Date: {DateOfTrans.ToShortDateString()}, Description: {Description}";
        }
    }
}
