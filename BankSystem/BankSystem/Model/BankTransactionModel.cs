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
        public string Pin { get; set; }

        public BankTransactionModel() { }

        public BankTransactionModel(int id, int fromAccountId, int toAccountId, DateTime dateOfTrans, double amount, string employeeId, string branchId, string description, string pin)
        {
            Id = id;
            AccountFromId = fromAccountId;
            AccountToId = toAccountId;
            DateOfTrans = dateOfTrans;
            Amount = amount;
            EmployeeId = employeeId;
            BranchId = branchId;
            Description = description;
            Pin = pin;
        }
        public bool isValidate()
        {
            return true;
        }
    }
}
