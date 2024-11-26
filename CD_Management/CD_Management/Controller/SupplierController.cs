using System;
using System.Collections.Generic;
using System.Linq;
using CD_Management.Model;

namespace CD_Management.Controller
{
    public class SupplierController : IController
    {
        private CDDataContext db;
        private List<IModel> suppliers;

        public List<IModel> Items => suppliers;

        public SupplierController()
        {
            suppliers = new List<IModel>();
            db = new CDDataContext();
        }

        // Thêm nhà cung cấp
        public bool Create(IModel model)
        {
            var supplier = model as SupplierModel;
            if (IsExist(supplier.MaNhaCungCap)) return false;

            var dbSupplier = new NhaCungCap
            {
                MaNhaCungCap = supplier.MaNhaCungCap,
                TenNhaCungCap = supplier.TenNhaCungCap,
                DiaChi = supplier.DiaChi,
                SoDienThoai = supplier.SoDienThoai
            };

            db.NhaCungCaps.InsertOnSubmit(dbSupplier);
            db.SubmitChanges();

            suppliers.Add(supplier);
            return true;
        }

        // Cập nhật nhà cung cấp
        public bool Update(IModel model)
        {
            var supplier = model as SupplierModel;
            var dbSupplier = db.NhaCungCaps.FirstOrDefault(s => s.MaNhaCungCap == supplier.MaNhaCungCap);
            if (dbSupplier == null) return false;

            dbSupplier.TenNhaCungCap = supplier.TenNhaCungCap;
            dbSupplier.DiaChi = supplier.DiaChi;
            dbSupplier.SoDienThoai = supplier.SoDienThoai;

            db.SubmitChanges();

            var existingSupplier = Read(supplier.MaNhaCungCap) as SupplierModel;
            existingSupplier.TenNhaCungCap = supplier.TenNhaCungCap;
            existingSupplier.DiaChi = supplier.DiaChi;
            existingSupplier.SoDienThoai = supplier.SoDienThoai;

            return true;
        }

        // Xóa nhà cung cấp
        public bool Delete(object id)
        {
            var dbSupplier = db.NhaCungCaps.FirstOrDefault(s => s.MaNhaCungCap == (string)id);
            if (dbSupplier == null) return false;

            db.NhaCungCaps.DeleteOnSubmit(dbSupplier);
            db.SubmitChanges();

            var supplier = Read(id) as SupplierModel;
            if (supplier != null)
            {
                suppliers.Remove(supplier);
            }

            return true;
        }

        // Đọc thông tin nhà cung cấp theo mã
        public IModel Read(object id)
        {
            if (id is string maNhaCungCap)
            {
                return suppliers.FirstOrDefault(s => (s as SupplierModel).MaNhaCungCap == maNhaCungCap);
            }
            return null;
        }

        // Tải tất cả nhà cung cấp từ CSDL
        public bool Load()
        {
            var dbNhaCungCaps = db.NhaCungCaps.ToList();
            suppliers = dbNhaCungCaps.Select(s => new SupplierModel
            {
                MaNhaCungCap = s.MaNhaCungCap,
                TenNhaCungCap = s.TenNhaCungCap,
                DiaChi = s.DiaChi,
                SoDienThoai = s.SoDienThoai
            }).Cast<IModel>().ToList();

            return suppliers.Count > 0;
        }

        // Load thông tin Băng theo ID
        public bool Load(object id)
        {
            var dbNhaCungCap = db.NhaCungCaps.FirstOrDefault(b => b.MaNhaCungCap == (string)id);
            if (dbNhaCungCap == null) return false;

            var supplierModel = new SupplierModel
            {
                MaNhaCungCap = dbNhaCungCap.MaNhaCungCap,
                TenNhaCungCap = dbNhaCungCap.TenNhaCungCap,
                DiaChi = dbNhaCungCap.DiaChi,
                SoDienThoai = dbNhaCungCap.SoDienThoai,
            };

            suppliers.Clear();
            suppliers.Add(supplierModel);

            return true;
        }

        // Kiểm tra tồn tại nhà cung cấp theo mã
        public bool IsExist(object id)
        {
            return suppliers.Any(s => (s as SupplierModel).MaNhaCungCap == (string)id);
        }


        public bool IsExist(IModel model)
        {
            var supplier = model as SupplierModel;
            return IsExist(supplier.MaNhaCungCap);
        }

        // Tìm kiếm nhà cung cấp theo mã hoặc tên
        public List<IModel> Search(string maNhaCungCap = null, string tenNhaCungCap = null)
        {
            var query = db.NhaCungCaps.AsQueryable();

            if (!string.IsNullOrEmpty(maNhaCungCap))
            {
                query = query.Where(s => s.MaNhaCungCap.Contains(maNhaCungCap));
            }

            if (!string.IsNullOrEmpty(tenNhaCungCap))
            {
                query = query.Where(s => s.TenNhaCungCap.Contains(tenNhaCungCap));
            }

            return query.Select(s => new SupplierModel
            {
                MaNhaCungCap = s.MaNhaCungCap,
                TenNhaCungCap = s.TenNhaCungCap,
                DiaChi = s.DiaChi,
                SoDienThoai = s.SoDienThoai
            }).Cast<IModel>().ToList();
        }
    }
}
