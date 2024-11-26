using System;

namespace CD_Management.Model
{
    public class StatisticsModel : IModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public float Value { get; set; }
        public DateTime? Date { get; set; }

        // Bổ sung các thuộc tính cần thiết
        public string Additional { get; set; } // Ví dụ: Tác giả
        public DateTime BorrowDate { get; set; }
        public string CustomerID { get; set; }
        public float Deposit { get; set; }
        public string Active { get; set; }
        public string ReceiptID { get; set; }
        public string Phone { get; set; }

        public StatisticsModel() { }
        public bool isValidate()
        {
            return true;
        }
    }
}
