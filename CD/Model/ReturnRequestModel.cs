using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Model
{
    internal class ReturnRequestModel : IModel
    {
        public string MaHDTra { get; set; } // Mã hóa đơn trả
        public string MaHDMuon { get; set; } // Mã hóa đơn mượn
        public DateTime NgayTraHang { get; set; } // Ngày trả hàng
        public float TongTienTra { get; set; } // Tổng tiền trả
        public ReturnRequestModel() { }

        // Constructor với tham số
        public ReturnRequestModel(string maHDTra, string maHDMuon, DateTime ngayTraHang, float tongTienTra)
        {
            MaHDTra = maHDTra;
            MaHDMuon = maHDMuon;
            NgayTraHang = ngayTraHang;
            TongTienTra = tongTienTra;
        }

        public bool Isvalidate()
        {
            throw new NotImplementedException();
        }
    }
}
