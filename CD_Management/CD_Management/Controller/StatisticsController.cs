using System;
using System.Collections.Generic;
using System.Linq;
using CD_Management.Model;

namespace CD_Management.Controller
{
    public class StatisticsController : IController
    {
        private CDDataContext db; // LINQ DataContext
        private List<IModel> statistics;

        public List<IModel> Items => statistics;

        public StatisticsController()
        {
            db = new CDDataContext();
            statistics = new List<IModel>();
        }

        // Thống kê sản phẩm còn trong kho
        public bool GetProductsInStock()
        {
            var products = db.Bangs.Select(b => new StatisticsModel
            {
                Key = b.MaBang,               // Mã Băng
                Name = b.TenBang,             // Tên Băng
                Quantity = b.SoLuong,         // Số Lượng
                Value = (float)b.DonGiaBan,   // Đơn Giá Bán
                Description = b.TheLoai,      // Thể Loại
                Additional = b.TacGia         // Tác Giả
            }).Cast<IModel>().ToList();

            statistics = products;
            return statistics.Count > 0;
        }

        // Thống kê các phiếu quá hạn trả
        public bool GetOverdueReceipts()
        {
            var overdueReceipts = db.PhieuMuons
                .Where(pm => pm.NgayTra < DateTime.Now && !pm.HoatDong)  // Dữ liệu phiếu quá hạn
                .Select(pm => new StatisticsModel
                {
                    Key = pm.MaHDMuon,              // Mã Phiếu
                    BorrowDate = pm.NgayMuon,       // Ngày Mượn
                    Date = pm.NgayTra,              // Ngày Trả
                    CustomerID = pm.MaKhach,        // Mã Khách
                    Deposit = (float)pm.TienCoc,    // Tiền Cọc
                    Active = pm.HoatDong.ToString() // Hoạt Động (0 hoặc 1)
                }).Cast<IModel>().ToList();

            statistics = overdueReceipts;
            return statistics.Count > 0;
        }

        // Thống kê khách hàng đã mượn sản phẩm
        public bool GetBorrowingCustomers()
        {
            var customers = db.Khaches
                .Join(db.PhieuMuons, k => k.MaKhach, pm => pm.MaKhach, (k, pm) => new { k, pm })
                .Where(x => x.pm.HoatDong)  // Lọc khách hàng đang mượn
                .Distinct()
                .Select(x => new StatisticsModel
                {
                    Key = x.k.MaKhach,                  // Mã Khách
                    Name = x.k.TenKhach,                // Tên Khách
                    Description = x.k.DiaChi,           // Địa Chỉ
                    Phone = x.k.DienThoai,              // Điện Thoại
                    ReceiptID = x.pm.MaHDMuon,          // Mã Phiếu Mượn
                    Active = x.pm.HoatDong.ToString()   // Hoạt Động
                }).Cast<IModel>().ToList();

            statistics = customers;
            return statistics.Count > 0;
        }

        // Thống kê các sản phẩm đã mượn
        public bool GetBorrowedProducts()
        {
            var borrowedProducts = db.Bangs
                .Join(db.ChiTietPhieuMuons, b => b.MaBang, ctp => ctp.MaBang, (b, ctp) => new { b, ctp })
                .Distinct()
                .Select(x => new StatisticsModel
                {
                    ReceiptID = x.ctp.MaHDBan,    // Mã Phiếu
                    Key = x.b.MaBang,             // Mã Băng
                    Name = x.b.TenBang,           // Tên Băng
                    Description = x.b.TheLoai,    // Thể Loại
                    Additional = x.b.TacGia,      // Tác Giả
                    Quantity = x.ctp.SoLuong,     // Số Lượng
                    Value = (float)x.b.DonGiaBan  // Đơn Giá Bán
                }).Cast<IModel>().ToList();

            statistics = borrowedProducts;
            return statistics.Count > 0;
        }

        public bool Create(IModel model) => false;
        public bool Update(IModel model) => false;
        public bool Delete(object id) => false;  
        public IModel Read(object id) => null;   
        public bool Load() => false;             
        public bool Load(object id) => false;    
        public bool IsExist(object id) => false; 
        public bool IsExist(IModel model) => false;
    }
}
