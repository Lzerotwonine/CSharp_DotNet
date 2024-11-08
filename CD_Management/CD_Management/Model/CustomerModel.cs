using System;
using CD_Management.Model;

namespace CD_Management.Model
{
    public class CustomerModel : IModel
    {
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }

        public CustomerModel() { }

        public bool isValidate()
        {
            // Thêm các điều kiện kiểm tra dữ liệu nếu cần
            return !string.IsNullOrEmpty(MaKhach) && !string.IsNullOrEmpty(TenKhach);
        }
    }
}
