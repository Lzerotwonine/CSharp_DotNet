using BankSystem.Controller;
using BankSystem.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BankSystem.View
{
    public partial class DepositForm : Form, IView
    {
        private TransactionController transactionController;
        private AccountModel currentAccount;

        public DepositForm()
        {
            InitializeComponent();
            transactionController = new TransactionController(); // Sử dụng TransactionController
        }

        // Implement IView methods
        public void SetDataToText(object item)
        {
            var account = item as AccountModel;
            if (account != null)
            {
                textBoxAccountId.Text = account.Id.ToString();
                dateTimePickerDepositDate.Value = DateTime.Now;
            }
        }

        public void GetDataFromText()
        {
            if (currentAccount == null) currentAccount = new AccountModel();

            currentAccount.Id = int.Parse(textBoxAccountId.Text);
            currentAccount.Balance += float.Parse(textBoxDepositAmount.Text);
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin nhập
            if (string.IsNullOrWhiteSpace(textBoxAccountId.Text) || string.IsNullOrWhiteSpace(textBoxDepositAmount.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin (ID tài khoản và số tiền).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra số tiền nhập vào có phải là số hợp lệ không
            if (!float.TryParse(textBoxDepositAmount.Text, out float amount) || amount <= 0)
            {
                MessageBox.Show("Số tiền nạp vào không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy tài khoản theo ID
            var account = transactionController.GetAccountById(textBoxAccountId.Text); // Gọi phương thức từ TransactionController
            if (account == null)
            {
                MessageBox.Show("Tài khoản không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra số dư
            if (account.Balance < amount)
            {
                MessageBox.Show("Số dư không đủ để thực hiện giao dịch này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu tất cả các kiểm tra đều hợp lệ, thực hiện nạp tiền
            account.Balance += amount;
            transactionController.UpdateAccount(account); // Gọi phương thức từ TransactionController để cập nhật tài khoản
            MessageBox.Show("Nạp tiền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxAccountId_TextChanged(object sender, EventArgs e)
        {
            string accountId = textBoxAccountId.Text;

            if (string.IsNullOrWhiteSpace(accountId))
            {
                textBoxCustomerName.Text = string.Empty; // Xóa tên khách hàng nếu ID trống
                return;
            }

            // Tìm kiếm khách hàng từ CSDL
            var customer = transactionController.GetCustomersByPartialId(accountId).FirstOrDefault(); // Lấy khách hàng đầu tiên nếu có
            if (customer != null)
            {
                textBoxCustomerName.Text = customer.Name; // Hiển thị tên khách hàng
            }
            else
            {
                textBoxCustomerName.Text = "Không tìm thấy khách hàng"; // Không tìm thấy khách hàng
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
