using BankSystem.Controller;
using BankSystem.Model;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iText.IO.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using iText.Layout;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Kernel.Font;

namespace BankSystem.View
{
    public partial class BalanceForm : Form, IView
    {
        private AccountController accountController;
        private CustomerController customerController;

        public BalanceForm()
        {
            InitializeComponent();
            accountController = new AccountController();
            customerController = new CustomerController();
            InitializeDataGridView();
            LoadAccountsFromDatabase();
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewAccounts.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "Mã tài khoản";
            idColumn.DataPropertyName = "Id";
            idColumn.ReadOnly = true;
            dataGridViewAccounts.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Tên tài khoản";
            nameColumn.DataPropertyName = "CustomerName";
            nameColumn.ReadOnly = true;
            dataGridViewAccounts.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn balanceColumn = new DataGridViewTextBoxColumn();
            balanceColumn.HeaderText = "Số dư";
            balanceColumn.DataPropertyName = "Balance";
            balanceColumn.ReadOnly = true;
            dataGridViewAccounts.Columns.Add(balanceColumn);
        }

        // Lấy dữ liệu từ form
        public void GetDataFromText()
        {
        }

        // Load danh sách tài khoản từ CSDL
        private void LoadAccountsFromDatabase()
        {
            accountController.Load();
            customerController.Load();// Tải tất cả tài khoản từ CSDL
            var accounts = accountController.Items.Cast<AccountModel>()
                .Select(a => new
                {
                    a.Id,
                    CustomerName = customerController.Read(a.CustomerId) is CustomerModel customer ? customer.Name : "Unknown",
                    a.Balance
                }).ToList();

            dataGridViewAccounts.DataSource = accounts;
        }

        // Hiển thị thông tin tài khoản khi chọn trong DataGridView
        private void dataGridViewAccounts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAccounts.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewAccounts.SelectedRows[0];
                SetDataToText(selectedRow.DataBoundItem);
            }
        }

        // Đưa dữ liệu lên form
        public void SetDataToText(object item)
        {
            var account = item as dynamic; // Sử dụng dynamic để lấy thông tin
            if (account != null)
            {
                textBoxAccountId.Text = account.Id.ToString();
                textBoxCustomerName.Text = account.CustomerName.ToString();
                textBoxBalance.Text = account.Balance.ToString();
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridViewAccounts.SelectedRows.Count > 0)
            {
                // Tạo tên file cho PDF
                string fileName = "Xuất số dư tài khoản.pdf";
                string filePath = Path.Combine(@"D:\", fileName);
                int counter = 1;

                // Kiểm tra xem file đã tồn tại và tạo tên mới nếu cần
                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(@"D:\", $"Xuất số dư tài khoản ({counter}).pdf");
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
                    document.Add(new Paragraph("Danh sách tài khoản đã chọn").SetFont(font).SetBold().SetFontSize(20));

                    // Tạo bảng với số cột bằng số cột trong DataGridView
                    Table table = new Table(dataGridViewAccounts.Columns.Count);
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    // Thêm tiêu đề các cột vào bảng
                    foreach (DataGridViewColumn column in dataGridViewAccounts.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText).SetFont(font).SetBold()));
                    }

                    // Thêm dữ liệu các hàng đã chọn vào bảng
                    foreach (DataGridViewRow row in dataGridViewAccounts.SelectedRows)
                    {
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
                MessageBox.Show("Chưa chọn tài khoản để in.");
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