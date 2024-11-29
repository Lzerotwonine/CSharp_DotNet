using CD_Management.Controller;
using System;
using System.Windows.Forms;

namespace CD_Management.View
{
    public partial class MainMenu : Form
    {
        private LoginController loginController;
        private string currentUserRole;
        private string currentUserId;

        public MainMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.KeyPreview = true;

            // Ẩn các mục menu khi chưa đăng nhập
            HideMenuItems();

            // Thêm event xử lý khi đóng form để yêu cầu xác nhận
            this.FormClosing += MainMenu_FormClosing;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            OpenLoginForm();
        }

        private void HideMenuItems()
        {
            logoutMenuItem.Visible = false;
            cdMenuItem.Visible = false;
            borrowMenuItem.Visible = false;
            returnMenuItem.Visible = false;
            borrowMenuItem.Visible = false;
            stasticMenuItem.Visible = false;
            customerMenuItem.Visible = false;
            supplierMenuItem.Visible = false;
            storageMenuItem.Visible = false;
        }

        private void ShowMenuItems(string role)
        {
            logoutMenuItem.Visible = true;
            cdMenuItem.Visible = true;
            borrowMenuItem.Visible = true;
            returnMenuItem.Visible = true;
            borrowMenuItem.Visible = true;
            stasticMenuItem.Visible = true;
            customerMenuItem.Visible = true;
            supplierMenuItem.Visible = true;
            storageMenuItem.Visible = true;
        }

        private void OpenLoginForm()
        {
            Login loginForm = new Login();
            loginForm.StartPosition = FormStartPosition.CenterScreen;

            loginForm.ShowDialog();

            if (loginForm.IsAuthenticated)
            {
                currentUserId = loginForm.AuthenticatedUserId;
                currentUserRole = loginForm.AuthenticatedUserRole;
                ShowMenuItems(currentUserRole);

                toolStripUserLabel.Text = $"Chào: {currentUserId}";
                toolStripUserLabel.Visible = true;
                loginMenuItem.Visible = false;
            }
            else
            {
                Application.Exit();
            }
        }

        private void loginMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            currentUserId = null;
            currentUserRole = null;
            toolStripUserLabel.Visible = false;
            loginMenuItem.Visible = true;
            HideMenuItems();

            MessageBox.Show("Bạn đã đăng xuất thành công!", "Đăng xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenLoginForm();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

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

        private void OpenChildForm(Form childForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void cdMenuItem_Click(object sender, EventArgs e)
        {
            CDForm cdForm = new CDForm();
            OpenChildForm(cdForm);
        }

        private void customerMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            OpenChildForm(customerForm);
        }

        private void supplierMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            OpenChildForm(supplierForm);
        }

        private void rentalRequestMenuItem_Click(object sender, EventArgs e)
        {
            RentalRequest rentalRequest = new RentalRequest();
            OpenChildForm(rentalRequest);
        }

        private void returnRequestMenuItem_Click(object sender, EventArgs e)
        {
            ReturnRequest returnRequest = new ReturnRequest();
            OpenChildForm(returnRequest);
        }

        private void statisticsFormMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            OpenChildForm(statisticsForm);
        }

        private void warehouseFormMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouseForm = new WarehouseForm();
            OpenChildForm(warehouseForm);
        }

        //Xác nhận khi người dùng đóng MainMenu
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy đóng form nếu người dùng chọn No
            }
        }

        private void loginMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
