using CD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Model
{
    internal class DetailRentalRequestModel: IModel
    {
        public string MaHDBan { get; set; } 
        public string MaBang { get; set; }   
        public int SoLuong { get; set; }   
        public float DonGia { get; set; }   
        public float Coc { get; set; }     
        public float TienCoc { get; set; }

        public bool Isvalidate()
        {
            if (string.IsNullOrWhiteSpace(MaHDBan) || string.IsNullOrWhiteSpace(MaBang))
                return false;

            if (SoLuong <= 0)
                return false;

            if (DonGia < 0 || Coc < 0 || TienCoc < 0)
                return false;

            if (TienCoc < Coc * SoLuong)
                return false;

            return true;
        }
    }
}
