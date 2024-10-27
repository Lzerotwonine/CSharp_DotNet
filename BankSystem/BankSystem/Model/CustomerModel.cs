using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.Model;

namespace BankSystem.Model
{
    public class CustomerModel : IModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string HouseNo { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
    }
}
