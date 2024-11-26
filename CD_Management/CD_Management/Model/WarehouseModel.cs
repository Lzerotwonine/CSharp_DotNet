using System;
using CD_Management.Model;

namespace CD_Management.Model
{
    public class WarehouseModel : IModel
    {
        public string Id { get; set; }          // Mã giao dịch
        public string ItemId { get; set; }      // Mã băng (MaBang)
        public string TransactionType { get; set; } // Loại giao dịch: "Nhập" hoặc "Xuất"
        public int Quantity { get; set; }       // Số lượng
        public DateTime TransactionDate { get; set; } // Ngày giao dịch
        public string SupplierId { get; set; }  // Mã nhà cung cấp (NhaCungCapId)
        public string Notes { get; set; }       // Ghi chú (nếu có)

        public WarehouseModel() { }

        public bool isValidate()
        {
            return !string.IsNullOrEmpty(Id) && !string.IsNullOrEmpty(ItemId) && Quantity > 0;
        }
    }
}
