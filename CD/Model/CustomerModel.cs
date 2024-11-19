using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Model
{
    public class CustomerModel : IModel
    {
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }

        public CustomerModel() { }
        public bool Isvalidate()
        {
            return !string.IsNullOrEmpty(MaKhach) && !string.IsNullOrEmpty(TenKhach);
        }
    }
}
