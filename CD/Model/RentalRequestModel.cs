using CD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Model
{
    internal class RentalRequestModel : IModel
    {
        public string MaHDMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public string MaKhach { get; set; }
        public float TienCoc { get; set; }
        public bool HoatDong { get; set; }
        public float? TienTra { get; set; }

        public bool Isvalidate()
        {
            if (string.IsNullOrWhiteSpace(MaHDMuon) || string.IsNullOrWhiteSpace(MaKhach))
                return false;

            if (NgayMuon > NgayTra)
                return false;

            if (TienCoc < 0)
                return false;

            return true;
        }
    }
}
