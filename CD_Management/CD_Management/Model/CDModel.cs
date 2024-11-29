namespace CD_Management.Model
{
    public class CDModel : IModel
    {
        public string MaBang { get; set; }
        public string TenBang { get; set; }
        public int SoLuong { get; set; }
        public double DonGiaBan { get; set; }
        public string TheLoai { get; set; }
        public string TacGia { get; set; }

        public CDModel() { }

        // Hàm kiểm tra dữ liệu hợp lệ
        public bool isValidate()
        {
            return !string.IsNullOrEmpty(MaBang) &&
                   !string.IsNullOrEmpty(TenBang) &&
                   SoLuong >= 0 &&
                   DonGiaBan >= 0;
        }
    }
}
