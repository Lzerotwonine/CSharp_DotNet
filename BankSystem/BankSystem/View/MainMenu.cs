using System;
using System.Windows.Forms;
using BankSystem.Controller;

namespace BankSystem.View
{
    public partial class MainMenu : Form
    {
        private LoginController loginController; // Đối tượng LoginController để xử lý logic đăng nhập
        private string currentUserRole; // Lưu trữ role của người dùng đã đăng nhập
        private string currentUserId; // Lưu trữ ID của người dùng đã đăng nhập

        public MainMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.KeyPreview = true;

            // Ẩn các mục menu khi chưa đăng nhập
            HideMenuItems();
        }

        // Phương thức ẩn các mục menu, gọi khi chưa đăng nhập hoặc logout
        private void HideMenuItems()
        {
            systemMenuItem.Visible = false;
            bankingMenuItem.Visible = false;
            helpMenuItem.Visible = false;
            logoutMenuItem.Visible = false;
        }

        // Phương thức hiển thị các mục menu theo role sau khi đăng nhập thành công
        private void ShowMenuItems(string role)
        {
            // Hiển thị các systemMenuItemmenu chung
            systemMenuItem.Visible = true;
            bankingMenuItem.Visible = true;
            helpMenuItem.Visible = true;
            logoutMenuItem.Visible = true;

            // Nếu là Admin, hiển thị thêm các mục liên quan tới quản lý
            if (role == "Admin")
            {
                employeeMenuItem.Visible = true; // Hiển thị mục Employee
            }
            else
            {
                employeeMenuItem.Visible = false; // Ẩn mục Employee nếu là User
            }
        }

        // Event handler khi chọn mục Login
        private void loginMenuItem_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); // Tạo một instance mới của Login
            loginForm.StartPosition = FormStartPosition.CenterScreen; // Đặt vị trí hiển thị

            // Hiển thị form đăng nhập như một dialog modal
            loginForm.ShowDialog(); // Gọi ShowDialog mà không cần thiết lập MdiParent

            // Nếu đăng nhập thành công, hiển thị menu tương ứng
            if (loginForm.IsAuthenticated)
            {
                currentUserId = loginForm.AuthenticatedUserId;
                currentUserRole = loginForm.AuthenticatedUserRole;
                ShowMenuItems(currentUserRole);

                // Hiển thị tên đăng nhập trên góc phải của MainMenu
                userLabel.Text = $"Chào: {currentUserId}";
                userLabel.Visible = true;

                loginMenuItem.Visible = false; // Ẩn mục Login khi đã đăng nhập
            }
        }

        // Event handler khi chọn mục Logout
        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        // Phương thức xử lý việc logout
        private void Logout()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close(); // Đóng form con
            }
            currentUserId = null;
            currentUserRole = null;
            userLabel.Visible = false; // Ẩn thông tin người dùng
            loginMenuItem.Visible = true; // Hiển thị lại mục Login
            HideMenuItems(); // Ẩn tất cả các menu

            MessageBox.Show("Bạn đã đăng xuất thành công!", "Đăng xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Event handler cho mục Exit
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Xử lý ESC để logout nếu đã đăng nhập
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape && currentUserId != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Logout();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Phương thức chung để mở form con (MDI Child)
        private void OpenChildForm(Form childForm)
        {
            // Đóng tất cả các form con khác nếu cần
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            // Thiết lập form con
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        // Employee menu item
        private void employeeMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            OpenChildForm(employeeForm);
        }

        // Branch menu item
        private void branchMenuItem_Click(object sender, EventArgs e)
        {
            BranchForm branchForm = new BranchForm();
            OpenChildForm(branchForm);
        }

        // Customer menu item
        private void customerMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            OpenChildForm(customerForm);
        }

        // Account menu item
        private void accountMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            OpenChildForm(accountForm);
        }
    }
}
