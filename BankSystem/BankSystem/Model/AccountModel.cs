using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    public class AccountModel : IModel
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime DateOpened { get; set; }
        public float Balance { get; set; }

        public AccountModel() { }

        public bool isValidate()
        {
            return true;
        }
    }
    
}
