using System;
using System.Collections.Generic;
using System.Linq;
using CD_Management.Model;

namespace CD_Management.Controller
{
    public class WarehouseController : IController
    {
        private CDDataContext db; // LINQ DataContext
        private List<IModel> transactions;

        public List<IModel> Items => transactions;

        public WarehouseController()
        {
            transactions = new List<IModel>();
            db = new CDDataContext(); // Khởi tạo DataContext
        }

        // Tìm kiếm giao dịch
        public List<IModel> Search(string id = "", string itemId = "", string transactionType = "", string supplierId = "")
        {
            var results = transactions.Cast<WarehouseModel>()
                .Where(t =>
                    (string.IsNullOrEmpty(id) || t.Id.IndexOf(id, StringComparison.OrdinalIgnoreCase) >= 0) &&
                    (string.IsNullOrEmpty(itemId) || t.ItemId.IndexOf(itemId, StringComparison.OrdinalIgnoreCase) >= 0) &&
                    (string.IsNullOrEmpty(transactionType) || t.TransactionType.Equals(transactionType, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrEmpty(supplierId) || t.SupplierId.IndexOf(supplierId, StringComparison.OrdinalIgnoreCase) >= 0)
                ).Cast<IModel>()
                .ToList();

            return results;
        }

        // Thêm giao dịch
        public bool Create(IModel model)
        {
            var transaction = model as WarehouseModel;
            if (transaction == null || !transaction.isValidate() || IsExist(transaction.Id))
                return false;

            var dbTransaction = new QuanLyKho
            {
                MaKho = transaction.Id,
                MaBang = transaction.ItemId,
                LoaiGiaoDich = transaction.TransactionType,
                SoLuong = transaction.Quantity,
                NgayGiaoDich = transaction.TransactionDate,
                NhaCungCapId = transaction.SupplierId,
                GhiChu = transaction.Notes
            };

            db.QuanLyKhos.InsertOnSubmit(dbTransaction);
            db.SubmitChanges();

            transactions.Add(transaction); // Cập nhật bộ nhớ
            return true;
        }

        // Cập nhật giao dịch
        public bool Update(IModel model)
        {
            var transaction = model as WarehouseModel;
            if (transaction == null || !transaction.isValidate())
                return false;

            var dbTransaction = db.QuanLyKhos.FirstOrDefault(t => t.MaKho == transaction.Id);
            if (dbTransaction == null)
                return false;

            dbTransaction.MaBang = transaction.ItemId;
            dbTransaction.LoaiGiaoDich = transaction.TransactionType;
            dbTransaction.SoLuong = transaction.Quantity;
            dbTransaction.NgayGiaoDich = transaction.TransactionDate;
            dbTransaction.NhaCungCapId = transaction.SupplierId;
            dbTransaction.GhiChu = transaction.Notes;

            db.SubmitChanges();

            // Cập nhật bộ nhớ
            var existingTransaction = Read(transaction.Id) as WarehouseModel;
            if (existingTransaction != null)
            {
                existingTransaction.ItemId = transaction.ItemId;
                existingTransaction.TransactionType = transaction.TransactionType;
                existingTransaction.Quantity = transaction.Quantity;
                existingTransaction.TransactionDate = transaction.TransactionDate;
                existingTransaction.SupplierId = transaction.SupplierId;
                existingTransaction.Notes = transaction.Notes;
            }

            return true;
        }

        // Xóa giao dịch
        public bool Delete(object id)
        {
            var dbTransaction = db.QuanLyKhos.FirstOrDefault(t => t.MaKho == (string)id);
            if (dbTransaction == null)
                return false;

            db.QuanLyKhos.DeleteOnSubmit(dbTransaction);
            db.SubmitChanges();

            var transaction = Read(id) as WarehouseModel;
            if (transaction != null)
                transactions.Remove(transaction);

            return true;
        }

        // Đọc giao dịch theo ID
        public IModel Read(object id)
        {
            return transactions.FirstOrDefault(t => (t as WarehouseModel)?.Id == (string)id);
        }

        // Load tất cả giao dịch từ CSDL
        public bool Load()
        {
            var dbTransactions = db.QuanLyKhos.ToList();
            transactions = dbTransactions.Select(t => new WarehouseModel
            {
                Id = t.MaKho,
                ItemId = t.MaBang,
                TransactionType = t.LoaiGiaoDich,
                Quantity = t.SoLuong,
                TransactionDate = t.NgayGiaoDich,
                SupplierId = t.NhaCungCapId,
                Notes = t.GhiChu
            }).Cast<IModel>().ToList();

            return transactions.Count > 0;
        }

        // Load giao dịch theo ID
        public bool Load(object id)
        {
            var dbTransaction = db.QuanLyKhos.FirstOrDefault(t => t.MaKho == (string)id);
            if (dbTransaction == null)
                return false;

            transactions.Clear(); // Xóa danh sách cũ
            transactions.Add(new WarehouseModel
            {
                Id = dbTransaction.MaKho,
                ItemId = dbTransaction.MaBang,
                TransactionType = dbTransaction.LoaiGiaoDich,
                Quantity = dbTransaction.SoLuong,
                TransactionDate = dbTransaction.NgayGiaoDich,
                SupplierId = dbTransaction.NhaCungCapId,
                Notes = dbTransaction.GhiChu
            });

            return true;
        }

        // Kiểm tra tồn tại giao dịch
        public bool IsExist(object id)
        {
            return transactions.Any(t => (t as WarehouseModel)?.Id == (string)id);
        }

        public bool IsExist(IModel model)
        {
            var transaction = model as WarehouseModel;
            return transaction != null && IsExist(transaction.Id);
        }
    }
}
