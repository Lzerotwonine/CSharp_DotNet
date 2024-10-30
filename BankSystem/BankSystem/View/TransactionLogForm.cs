using BankSystem.Controller;
using BankSystem.Model;
using System;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using iText.Layout;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Kernel.Font;
using System.IO;

namespace BankSystem.View
{
    public partial class TransactionLogForm : Form, IView
    {
        private TransactionController transactionController;

        public TransactionLogForm()
        {
            InitializeComponent();
            transactionController = new TransactionController();
            InitializeDataGridView();
            LoadTransactionLogsFromDatabase();
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewTransactions.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "Mã giao dịch";
            idColumn.DataPropertyName = "Id";
            idColumn.ReadOnly = true;
            dataGridViewTransactions.Columns.Add(idColumn);

            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.HeaderText = "Loại giao dịch";
            typeColumn.DataPropertyName = "Type";
            typeColumn.ReadOnly = true;
            dataGridViewTransactions.Columns.Add(typeColumn);

            DataGridViewTextBoxColumn accountFromColumn = new DataGridViewTextBoxColumn();
            accountFromColumn.HeaderText = "Tài khoản gửi";
            accountFromColumn.DataPropertyName = "AccountFromId";
            accountFromColumn.ReadOnly = true;
            dataGridViewTransactions.Columns.Add(accountFromColumn);

            DataGridViewTextBoxColumn accountToColumn = new DataGridViewTextBoxColumn();
            accountToColumn.HeaderText = "Tài khoản nhận";
            accountToColumn.DataPropertyName = "AccountToId";
            accountToColumn.ReadOnly = true;
            dataGridViewTransactions.Columns.Add(accountToColumn);

            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.HeaderText = "Số tiền";
            amountColumn.DataPropertyName = "Amount";
            amountColumn.ReadOnly = true;
            dataGridViewTransactions.Columns.Add(amountColumn);

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.HeaderText = "Ngày giao dịch";
            dateColumn.DataPropertyName = "DateOfTrans";
            dateColumn.ReadOnly = true;
            dataGridViewTransactions.Columns.Add(dateColumn);

            DataGridViewTextBoxColumn employeeIdColumn = new DataGridViewTextBoxColumn();
            employeeIdColumn.HeaderText = "ID nhân viên";
            employeeIdColumn.DataPropertyName = "EmployeeId";
            employeeIdColumn.ReadOnly = true;
            dataGridViewTransactions.Columns.Add(employeeIdColumn);

            DataGridViewTextBoxColumn branchIdColumn = new DataGridViewTextBoxColumn();
            branchIdColumn.HeaderText = "ID chi nhánh";
            branchIdColumn.DataPropertyName = "BranchId";
            branchIdColumn.ReadOnly = true;
            dataGridViewTransactions.Columns.Add(branchIdColumn);

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.HeaderText = "Mô tả";
            descriptionColumn.DataPropertyName = "Description";
            descriptionColumn.ReadOnly = true;
            dataGridViewTransactions.Columns.Add(descriptionColumn);
        }

        // Load danh sách giao dịch từ CSDL
        private void LoadTransactionLogsFromDatabase()
        {
            transactionController.Load();
            var transactions = transactionController.Items.Cast<BankTransactionModel>()
                .Select(t => new
                {
                    t.Id,
                    t.Type,
                    t.AccountFromId,
                    t.AccountToId,
                    t.Amount,
                    t.DateOfTrans,
                    t.EmployeeId,
                    t.BranchId,
                    t.Description
                }).ToList();

            dataGridViewTransactions.DataSource = transactions;
        }

        // Hiển thị thông tin giao dịch khi chọn trong DataGridView
        private void dataGridViewTransactions_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTransactions.SelectedRows[0];
                SetDataToText(selectedRow.DataBoundItem);
            }
        }

        // Đưa dữ liệu lên form
        public void SetDataToText(object item)
        {
            var transaction = item as dynamic; // Sử dụng dynamic để lấy thông tin
            if (transaction != null)
            {
                textBoxTransactionId.Text = transaction.Id.ToString();
                textBoxTransactionType.Text = transaction.Type.ToString();
                textBoxAccountFromId.Text = transaction.AccountFromId != null ? transaction.AccountFromId.ToString() : string.Empty;
                textBoxAccountToId.Text = transaction.AccountToId != null ? transaction.AccountToId.ToString() : string.Empty;
                textBoxAmount.Text = transaction.Amount.ToString("N2");
                textBoxDateOfTrans.Text = transaction.DateOfTrans.ToString("dd/MM/yyyy");
                textBoxEmployeeId.Text = transaction.EmployeeId.ToString();
                textBoxBranchId.Text = transaction.BranchId.ToString();
                textBoxDescription.Text = transaction.Description;
            }
        }

        // Lấy dữ liệu từ form
        public void GetDataFromText()
        {
        }

        // Xử lý sự kiện nhấn nút Clear
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxTransactionId.Clear();
            textBoxTransactionType.Clear();
            textBoxAccountFromId.Clear();
            textBoxAccountToId.Clear();
            textBoxAmount.Clear();
            textBoxDateOfTrans.Clear();
            textBoxEmployeeId.Clear();
            textBoxBranchId.Clear();
            textBoxDescription.Clear();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count > 0)
            {
                // Tạo tên file PDF
                string fileName = "Nhật ký giao dịch.pdf";
                string filePath = Path.Combine(@"D:\", fileName);
                int counter = 1;

                // Kiểm tra nếu file đã tồn tại và tạo tên mới nếu cần
                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(@"D:\", $"Nhật ký giao dịch ({counter}).pdf");
                    counter++;
                }

                // Đường dẫn đến font hỗ trợ Unicode (Arial hoặc Times New Roman)
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");

                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfWriter writer = new PdfWriter(fs);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);

                    // Tạo font hỗ trợ Unicode
                    PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

                    // Thêm tiêu đề
                    document.Add(new Paragraph("Nhật ký giao dịch").SetFont(font).SetBold().SetFontSize(20));

                    // Tạo bảng với số cột bằng số cột trong DataGridView
                    Table table = new Table(dataGridViewTransactions.Columns.Count);
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    // Thêm tiêu đề cột vào bảng
                    foreach (DataGridViewColumn column in dataGridViewTransactions.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText).SetFont(font).SetBold()));
                    }

                    // Thêm dữ liệu từ DataGridView vào bảng
                    foreach (DataGridViewRow row in dataGridViewTransactions.SelectedRows)
                    {
                        if (row.IsNewRow) continue; // Bỏ qua hàng mới

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? "").SetFont(font)));
                        }
                    }

                    // Thêm bảng vào tài liệu PDF
                    document.Add(table);
                    document.Close();
                }

                MessageBox.Show($"In thành công vào file: {filePath}");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để in.");
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