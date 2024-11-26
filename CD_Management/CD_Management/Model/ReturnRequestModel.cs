using System;
using System.Collections.Generic;
using System.Linq;
namespace CD_Management.Model
{
    public class ReturnRequestModel : IModel
    {
        public string MaHDTra { get; set; }
        public string MaHDMuon { get; set; }
        public DateTime NgayTraHang { get; set; }
        public float TongTienTra { get; set; }
        public ReturnRequestModel() { }

        // Constructor với tham số
        public ReturnRequestModel(string maHDTra, string maHDMuon, DateTime ngayTraHang, float tongTienTra)
        {
            MaHDTra = maHDTra;
            MaHDMuon = maHDMuon;
            NgayTraHang = ngayTraHang;
            TongTienTra = tongTienTra;
        }

        public bool isValidate()
        {
            throw new NotImplementedException();
        }
    }
}
