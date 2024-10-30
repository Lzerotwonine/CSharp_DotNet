using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    public class BranchModel : IModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string HouseNo { get; set; }
        public string City { get; set; }

        public BranchModel() { }

        public bool isValidate()
        {
            return true;
        }
    }
}
