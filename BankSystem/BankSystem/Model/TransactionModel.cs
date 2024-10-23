using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    public class TransactionModel : IModel
    {
        public int Id {  get; set; }
        public string Type { get; set; }
        public int AccountFromId { get; set; }
        public int AccountToId { get; set; }
        public float Amount { get; set; }
        public DateTime DateOfTrans { get; set; }
        public string EmployeeId { get; set; }
        public string BranchId { get; set; }
        public string Description { get; set; }
    }
}
