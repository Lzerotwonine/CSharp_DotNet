using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Model
{
    internal class CDModel : IModel
    {
        public string MaBang { get; set; }
        public string TenBang { get; set; }
        public int SoLuong { get; set; }
        public double DonGiaBan { get; set; }
        public string TheLoai { get; set; }
        public string TacGia { get; set; }

        public CDModel() { }
        public bool Isvalidate()
        {
            return !string.IsNullOrEmpty(MaBang) &&
                   !string.IsNullOrEmpty(TenBang) &&
                   SoLuong >= 0 &&
                   DonGiaBan >= 0;
        }
    }
}
