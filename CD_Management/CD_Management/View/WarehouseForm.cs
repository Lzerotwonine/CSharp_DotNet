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
            Import,
            Export
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewWarehouse.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "Transaction ID";
            idColumn.DataPropertyName = "Id";
            dataGridViewWarehouse.Columns.Add(idColumn);

            DataGridViewTextBoxColumn itemIdColumn = new DataGridViewTextBoxColumn();
            itemIdColumn.HeaderText = "Item ID";
            itemIdColumn.DataPropertyName = "ItemId";
            dataGridViewWarehouse.Columns.Add(itemIdColumn);

            DataGridViewTextBoxColumn transactionTypeColumn = new DataGridViewTextBoxColumn();
            transactionTypeColumn.HeaderText = "Transaction Type";
            transactionTypeColumn.DataPropertyName = "TransactionType";
            dataGridViewWarehouse.Columns.Add(transactionTypeColumn);

            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.HeaderText = "Quantity";
            quantityColumn.DataPropertyName = "Quantity";
            dataGridViewWarehouse.Columns.Add(quantityColumn);

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.HeaderText = "Transaction Date";
            dateColumn.DataPropertyName = "TransactionDate";
            dataGridViewWarehouse.Columns.Add(dateColumn);

            DataGridViewTextBoxColumn supplierColumn = new DataGridViewTextBoxColumn();
            supplierColumn.HeaderText = "Supplier ID";
            supplierColumn.DataPropertyName = "SupplierId";
            dataGridViewWarehouse.Columns.Add(supplierColumn);

            DataGridViewTextBoxColumn notesColumn = new DataGridViewTextBoxColumn();
            notesColumn.HeaderText = "Notes";
            notesColumn.DataPropertyName = "Notes";
            dataGridViewWarehouse.Columns.Add(notesColumn);
        }

        // Load danh sách giao dịch từ CSDL
        private void LoadTransactionsFromDatabase()
        {
            warehouseController.Load();
            var transactions = warehouseController.Items.Cast<WarehouseModel>().ToList();

            if (rbtnImport.Checked)
                transactions = transactions.Where(t => t.TransactionType == "Import").ToList();
            else if (rbtnExport.Checked)
                transactions = transactions.Where(t => t.TransactionType == "Export").ToList();

            dataGridViewWarehouse.DataSource = transactions;
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            LoadTransactionsFromDatabase();
        }

        // Lấy dữ liệu từ form
        public void GetDataFromText()
        {
            if (currentTransaction == null) currentTransaction = new WarehouseModel();

            currentTransaction.Id = textBoxTransactionId.Text;
            currentTransaction.ItemId = textBoxItemId.Text;
            currentTransaction.TransactionType = rbtnImport.Checked ? "Import" : "Export";
            currentTransaction.Quantity = int.TryParse(textBoxQuantity.Text, out int quantity) ? quantity : 0;
            currentTransaction.TransactionDate = dateTimePickerTransactionDate.Value;
            currentTransaction.SupplierId = textBoxSupplierId.Text;
            currentTransaction.Notes = textBoxNotes.Text;
        }

        // Đưa dữ liệu lên form
        // Đưa dữ liệu lên form
        public void SetDataToText(object item)
        {
            var transaction = item as WarehouseModel;
            if (transaction != null)
            {
                textBoxTransactionId.Text = transaction.Id;
                textBoxItemId.Text = transaction.ItemId;

                // So sánh với chuỗi
                if (transaction.TransactionType == "Import")
                {
                    rbtnImport.Checked = true;
                }
                else if (transaction.TransactionType == "Export")
                {
                    rbtnExport.Checked = true;
                }

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

        private void buttonImport_Click(object sender, EventArgs e)
        {
            rbtnImport.Checked = true; // Đảm bảo chế độ là Nhập kho
            GetDataFromText();
            currentTransaction.TransactionType = "Import";

            if (warehouseController.Create(currentTransaction))
            {
                LoadTransactionsFromDatabase();
                MessageBox.Show("Đã thêm Nhập kho thành công.");
            }
            else
            {
                MessageBox.Show("Không thể thêm Nhập kho.");
            }
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            rbtnExport.Checked = true; // Đảm bảo chế độ là Xuất kho
            GetDataFromText();
            currentTransaction.TransactionType = "Export";

            if (warehouseController.Create(currentTransaction))
            {
                LoadTransactionsFromDatabase();
                MessageBox.Show("Đã thêm Xuất kho thành công.");
            }
            else
            {
                MessageBox.Show("Không thể thêm Xuất kho.");
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
