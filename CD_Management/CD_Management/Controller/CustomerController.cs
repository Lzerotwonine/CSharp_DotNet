using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CD_Management.Model;

namespace CD_Management.Controller
{
    public class CustomerController : IController
    {
        private CDDataContext db; // LINQ DataContext
        private List<IModel> khachList;

        public List<IModel> Items => khachList;

        public CustomerController()
        {
            khachList = new List<IModel>();
            db = new CDDataContext(); // Khởi tạo DataContext
        }

        // Phương thức tìm kiếm khách hàng
        public List<IModel> Search(string maKhach = null, string tenKhach = null)
        {
            var query = db.Khaches.AsQueryable();

            if (!string.IsNullOrEmpty(maKhach))
            {
                query = query.Where(k => k.MaKhach.Contains(maKhach));
            }

            if (!string.IsNullOrEmpty(tenKhach))
            {
                query = query.Where(k => k.TenKhach.Contains(tenKhach));
            }

            return query.Select(k => new CustomerModel
            {
                MaKhach = k.MaKhach,
                TenKhach = k.TenKhach,
                DienThoai = k.DienThoai,
                DiaChi = k.DiaChi
            }).Cast<IModel>().ToList();
        }

        // Phương thức thêm khách hàng
        public bool Create(IModel model)
        {
            var khach = model as CustomerModel;
            if (IsExist(khach.MaKhach)) return false;

            var dbKhach = new Khach
            {
                MaKhach = khach.MaKhach,
                TenKhach = khach.TenKhach,
                DienThoai = khach.DienThoai,
                DiaChi = khach.DiaChi
            };

            db.Khaches.InsertOnSubmit(dbKhach);
            db.SubmitChanges();

            khachList.Add(khach); // Thêm vào danh sách trong bộ nhớ
            return true;
        }

        // Phương thức cập nhật thông tin khách hàng
        public bool Update(IModel model)
        {
            var khach = model as CustomerModel;
            var dbKhach = db.Khaches.FirstOrDefault(k => k.MaKhach == khach.MaKhach);
            if (dbKhach == null) return false;

            // Kiểm tra độ dài của DiaChi trước khi cập nhật
            if (khach.DiaChi.Length > 50)
            {
                MessageBox.Show("Địa chỉ không được dài quá 50 ký tự. Vui lòng nhập lại.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            dbKhach.TenKhach = khach.TenKhach;
            dbKhach.DienThoai = khach.DienThoai;
            dbKhach.DiaChi = khach.DiaChi;

            db.SubmitChanges();

            // Cập nhật thông tin trong danh sách bộ nhớ
            var existingKhach = Read(khach.MaKhach) as CustomerModel;
            existingKhach.TenKhach = khach.TenKhach;
            existingKhach.DienThoai = khach.DienThoai;
            existingKhach.DiaChi = khach.DiaChi;

            return true;
        }


        // Phương thức xóa khách hàng
        public bool Delete(object id)
        {
            var dbKhach = db.Khaches.FirstOrDefault(k => k.MaKhach == (string)id);
            if (dbKhach == null) return false;

            db.Khaches.DeleteOnSubmit(dbKhach);
            db.SubmitChanges();

            // Xóa khách hàng khỏi danh sách bộ nhớ
            var khach = Read(id) as CustomerModel;
            if (khach != null)
            {
                khachList.Remove(khach);
            }

            return true;
        }

        // Đọc khách hàng theo ID
        public IModel Read(object id)
        {
            if (id is string maKhach)
            {
                return khachList.FirstOrDefault(k => (k as CustomerModel).MaKhach == maKhach);
            }
            return null;
        }

        // Load tất cả khách hàng từ CSDL
        public bool Load()
        {
            var dbKhachList = db.Khaches.ToList();
            khachList = dbKhachList.Select(k => new CustomerModel
            {
                MaKhach = k.MaKhach,
                TenKhach = k.TenKhach,
                DienThoai = k.DienThoai,
                DiaChi = k.DiaChi
            }).Cast<IModel>().ToList();

            return khachList.Count > 0;
        }

        // Load khách hàng theo ID
        public bool Load(object id)
        {
            var dbKhach = db.Khaches.FirstOrDefault(k => k.MaKhach == (string)id);
            if (dbKhach == null) return false;

            var khachModel = new CustomerModel
            {
                MaKhach = dbKhach.MaKhach,
                TenKhach = dbKhach.TenKhach,
                DienThoai = dbKhach.DienThoai,
                DiaChi = dbKhach.DiaChi
            };

            khachList.Clear(); // Xóa danh sách cũ
            khachList.Add(khachModel); // Thêm khách hàng vào danh sách

            return true;
        }

        // Kiểm tra sự tồn tại của khách hàng theo ID
        public bool IsExist(object id)
        {
            return khachList.Any(k => (k as CustomerModel).MaKhach == (string)id);
        }

        public bool IsExist(IModel model)
        {
            var khach = model as CustomerModel;
            return IsExist(khach.MaKhach);
        }
    }
}
