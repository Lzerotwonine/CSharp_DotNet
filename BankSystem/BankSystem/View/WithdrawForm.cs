﻿using BankSystem.Controller;
using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.View
{
    public partial class WithdrawForm : Form, IView
    {
        private TransactionController transactionController;
        private AccountController accountController;
        private AccountModel currentAccount;

        public WithdrawForm()
        {
            InitializeComponent();
            transactionController = new TransactionController(); // Sử dụng TransactionController

            // Tìm mã giao dịch mới nhất có Type là Withdraw
            int? latestTransactionId = transactionController.GetLatestTransactionId(0);
            textBoxTransactionId.Text = (latestTransactionId.HasValue ? latestTransactionId.Value + 1 : 1).ToString(); // +1 cho mã giao dịch mới
        }

        public void SetDataToText(Object item)
        {
            if (item is BankTransactionModel transaction)
            {
                textBoxAccountId.Text = transaction.AccountFromId?.ToString();
                textBoxBranchId.Text = transaction.BranchId.ToString();
                textBoxEmployeeId.Text = transaction.EmployeeId.ToString();
                textBoxWithdrawAmount.Text = transaction.Amount.ToString();
                textBoxDescription.Text = transaction.Description;
            }
        }

        public void GetDataFromText()
        {
            try
            {
                int accountId = int.Parse(textBoxAccountId.Text);
                double depositAmount = double.Parse(textBoxWithdrawAmount.Text);
                string employeeId = textBoxEmployeeId.Text;
                string branchId = textBoxBranchId.Text;
                string description = textBoxDescription.Text;
                string pin = textBoxWithdrawPin.Text; // Lấy mã PIN từ TextBox

                // Kiểm tra điều kiện nạp tiền
                if (depositAmount <= 0)
                {
                    MessageBox.Show("Số tiền rút phải lớn hơn 0.");
                    return;
                }

                // Gọi phương thức ProcessTransaction
                if (transactionController.ProcessTransaction(accountId, depositAmount, "Withdraw", employeeId, branchId, description, pin))
                {
                    MessageBox.Show("Rút tiền thành công!");
                }
                else
                {
                    MessageBox.Show("Rút tiền thất bại. Hãy kiểm tra dữ liệu nhập.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho các trường dữ liệu.");
            }
        }

        // Hiển thị thông tin người nhận
        private void textBoxAccountId_TextChanged(object sender, EventArgs e)
        {
            int accountId;
            if (int.TryParse(textBoxAccountId.Text, out accountId))
            {
                var (customerName, balance, pin) = transactionController.GetCustomerInfoByAccountId(accountId);
                if (customerName != null)
                {
                    textBoxCustomerName.Text = customerName;
                    textBoxBalance.Text = balance.ToString("N2");
                    textBoxWithdrawPin.Text = pin; // Hiển thị mã PIN

                    // Thêm mô tả tự động
                    textBoxDescription.Text = $"{customerName.ToUpper()} RUT TIEN"; // Viết hoa tên khách hàng
                    int? latestTransactionId = transactionController.GetLatestTransactionId(0);
                    textBoxTransactionId.Text = (latestTransactionId.HasValue ? latestTransactionId.Value + 1 : 1).ToString();
                }
                else
                {
                    ClearWithdrawFields();
                }
            }
            else
            {
                ClearWithdrawFields();
            }
        }

        private void ClearWithdrawFields()
        {
            textBoxCustomerName.Clear();
            textBoxBalance.Clear();
            textBoxWithdrawPin.Clear(); // Xóa mã PIN nếu không tìm thấy
            textBoxDescription.Clear(); // Xóa mô tả nếu không tìm thấy
        }
        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            GetDataFromText();
        }

        // Xử lý sự kiện nhấn nút Clear
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAccountId.Clear();
            textBoxCustomerName.Clear();
            textBoxBalance.Clear();
            textBoxWithdrawPin.Clear();
            textBoxWithdrawAmount.Clear();
            textBoxEmployeeId.Clear();
            textBoxBranchId.Clear();
            textBoxDescription.Clear();
            textBoxTransactionId.Clear();
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

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            textBoxDescription.Text = textBoxDescription.Text.ToUpper(); // Chuyển đổi các ký tự thành chữ hoa
        }
    }
}
