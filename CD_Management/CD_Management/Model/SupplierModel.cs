using System;
using CD_Management.Model;

namespace CD_Management.Model
{
    public class SupplierModel : IModel
    {
        public string MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public SupplierModel() { }

        // Phương thức kiểm tra tính hợp lệ
        public bool isValidate()
        {
            return !string.IsNullOrEmpty(MaNhaCungCap) && !string.IsNullOrEmpty(TenNhaCungCap);
        }
    }
}
