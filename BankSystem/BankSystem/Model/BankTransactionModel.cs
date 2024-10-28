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

        public BankTransactionModel(BankTransaction transaction)
        {
            Id = transaction.Id;
            Type = transaction.Type;
            AccountFromId = transaction.AccountFromId;
            AccountToId = transaction.AccountToId;
            Amount = transaction.Amount;
            DateOfTrans = transaction.DateOfTrans;
            EmployeeId = transaction.EmployeeId;
            BranchId = transaction.BranchId;
            Description = transaction.Description;
            Pin = transaction.Pin;
        }

        public override string ToString()
        {
            return $"Transaction: {Type}, Amount: {Amount}, Date: {DateOfTrans.ToShortDateString()}, Description: {Description}, Pin: {Pin}";
        }
    }
}
