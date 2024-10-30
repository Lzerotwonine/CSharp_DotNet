using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    public class EmployeeModel : IModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public EmployeeModel() { }

        public bool isValidate()
        {
            return true;
        }
    }
}
