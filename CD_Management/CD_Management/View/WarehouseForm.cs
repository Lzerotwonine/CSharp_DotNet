using CD_Management.Controller;
using CD_Management.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CD_Management.View
{
    public partial class WarehouseForm : Form, IView
    {
        private WarehouseController warehouseController = new WarehouseController();
        private WarehouseModel currentTransaction;

        public WarehouseForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadTransactionsFromDatabase();
        }
        public enum TransactionType
        {
            Nhập,
            Xuất
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewWarehouse.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "Mã Giao Dịch";
            idColumn.DataPropertyName = "Id";
            dataGridViewWarehouse.Columns.Add(idColumn);

            DataGridViewTextBoxColumn itemIdColumn = new DataGridViewTextBoxColumn();
            itemIdColumn.HeaderText = "Mã Băng";
            itemIdColumn.DataPropertyName = "ItemId";
            dataGridViewWarehouse.Columns.Add(itemIdColumn);

            DataGridViewTextBoxColumn transactionTypeColumn = new DataGridViewTextBoxColumn();
            transactionTypeColumn.HeaderText = "Loại Giao Dịch";
            transactionTypeColumn.DataPropertyName = "TransactionType";
            dataGridViewWarehouse.Columns.Add(transactionTypeColumn);

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.HeaderText = "Số Lượng";
            quantityColumn.DataPropertyName = "Quantity";
            dataGridViewWarehouse.Columns.Add(quantityColumn);

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.HeaderText = "Ngày Giao Dịch";
            dateColumn.DataPropertyName = "TransactionDate";
            dataGridViewWarehouse.Columns.Add(dateColumn);

            DataGridViewTextBoxColumn supplierColumn = new DataGridViewTextBoxColumn();
            supplierColumn.HeaderText = "Mã Nhà Cung Cấp";
            supplierColumn.DataPropertyName = "SupplierId";
            dataGridViewWarehouse.Columns.Add(supplierColumn);

            DataGridViewTextBoxColumn notesColumn = new DataGridViewTextBoxColumn();
            notesColumn.HeaderText = "Ghi chú";
            notesColumn.DataPropertyName = "Notes";
            dataGridViewWarehouse.Columns.Add(notesColumn);
        }

        // Load danh sách giao dịch từ CSDL
        private void LoadTransactionsFromDatabase()
        {
            warehouseController.Load();
            var transactions = warehouseController.Items.Cast<WarehouseModel>().ToList();

            dataGridViewWarehouse.DataSource = transactions;
        }

        private void TransactionType_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnImport.Checked)
            {
                // Khi chọn Nhập, cập nhật ghi chú
                textBoxNotes.Text = $"Nhập hàng từ {textBoxSupplierId.Text}";
            }
            else if (rbtnExport.Checked)
            {
                // Khi chọn Xuất, cập nhật ghi chú
                textBoxNotes.Text = "Xuất hàng cho khách";
            }
        }
        private void SupplierId_TextChanged(object sender, EventArgs e)
        {
            if (rbtnImport.Checked)
            {
                // Cập nhật ghi chú khi Mã Nhà Cung Cấp thay đổi
                textBoxNotes.Text = $"Nhập hàng từ {textBoxSupplierId.Text}";
            }
        }

        // Lấy dữ liệu từ form
        public void GetDataFromText()
        {
            if (currentTransaction == null) currentTransaction = new WarehouseModel();

            currentTransaction.Id = textBoxTransactionId.Text;
            currentTransaction.ItemId = textBoxItemId.Text;
            currentTransaction.TransactionType = rbtnImport.Checked ? "Nhập" : "Xuất";
            currentTransaction.Quantity = int.TryParse(textBoxQuantity.Text, out int quantity) ? quantity : 0;
            currentTransaction.TransactionDate = dateTimePickerTransactionDate.Value;
            currentTransaction.SupplierId = textBoxSupplierId.Text;
            currentTransaction.Notes = textBoxNotes.Text;
        }

        // Đưa dữ liệu lên form
        public void SetDataToText(object item)
        {
            var transaction = item as WarehouseModel;
            if (transaction != null)
            {
                textBoxTransactionId.Text = transaction.Id;
                textBoxItemId.Text = transaction.ItemId;

                // Cập nhật loại giao dịch lên Radio Button
                rbtnImport.Checked = transaction.TransactionType == "Nhập";
                rbtnExport.Checked = transaction.TransactionType == "Xuất";

                textBoxQuantity.Text = transaction.Quantity.ToString();
                dateTimePickerTransactionDate.Value = transaction.TransactionDate;
                textBoxSupplierId.Text = transaction.SupplierId;
                textBoxNotes.Text = transaction.Notes;
            }
        }

        // Thêm giao dịch
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTransactionId.Text) || string.IsNullOrEmpty(textBoxItemId.Text))
            {
                MessageBox.Show("Cần nhập Mã giao dịch và Mã băng.");
                return;
            }

            GetDataFromText();
            if (warehouseController.Create(currentTransaction))
            {
                LoadTransactionsFromDatabase();
                MessageBox.Show("Đã thêm giao dịch thành công.");
            }
            else
            {
                MessageBox.Show("Không thể thêm giao dịch.");
            }
        }

        // Cập nhật giao dịch
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewWarehouse.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                GetDataFromText();
                if (warehouseController.Update(currentTransaction))
                {
                    LoadTransactionsFromDatabase();
                    MessageBox.Show("Cập nhật giao dịch thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật giao dịch.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn giao dịch để cập nhật.");
            }
        }

        // Xóa giao dịch
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewWarehouse.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                WarehouseModel transaction = selectedRow.DataBoundItem as WarehouseModel;

                if (warehouseController.Delete(transaction.Id))
                {
                    ConfirmDelete();
                }
                else
                {
                    MessageBox.Show("Không thể xoá giao dịch.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn giao dịch để xoá.");
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các TextBox
            textBoxTransactionId.Clear();
            textBoxItemId.Clear();
            textBoxQuantity.Clear();
            textBoxSupplierId.Clear();
            textBoxNotes.Clear();

            // Đặt giá trị mặc định cho các điều khiển khác
            dateTimePickerTransactionDate.Value = DateTime.Now; // Ngày giao dịch về ngày hiện tại
            rbtnImport.Checked = false; // Bỏ chọn cả hai loại giao dịch
            rbtnExport.Checked = false;

            LoadTransactionsFromDatabase();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string id = textBoxTransactionId.Text.Trim();
            string itemId = textBoxItemId.Text.Trim();
            string transactionType = rbtnImport.Checked ? "Nhập" : rbtnExport.Checked ? "Xuất" : "";
            string supplierId = textBoxSupplierId.Text.Trim();

            // Gọi phương thức tìm kiếm từ Controller
            var results = warehouseController.Search(id, itemId, transactionType, supplierId);

            if (results != null && results.Count > 0)
            {
                // Hiển thị kết quả tìm kiếm
                dataGridViewWarehouse.DataSource = results.Cast<WarehouseModel>().ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy giao dịch nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTransactionsFromDatabase(); // Tải lại tất cả giao dịch nếu không tìm thấy
            }
        }

        private void ConfirmDelete()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadTransactionsFromDatabase();
                MessageBox.Show("Đã xoá giao dịch thành công.");
            }
        }

        // Hiển thị thông tin giao dịch khi chọn trong DataGridView
        private void dataGridViewWarehouse_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewWarehouse.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var transaction = (WarehouseModel)selectedRow.DataBoundItem;
                SetDataToText(transaction);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
