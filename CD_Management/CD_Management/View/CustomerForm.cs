using CD_Management.Controller;
using CD_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CD_Management.View
{
    public partial class CustomerForm : Form, IView
    {
        private CustomerController customerController = new CustomerController();
        private CustomerModel currentKhach;

        public CustomerForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadKhachList();
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewCustomer.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn maKhachColumn = new DataGridViewTextBoxColumn();
            maKhachColumn.HeaderText = "Mã Khách";
            maKhachColumn.DataPropertyName = "MaKhach";
            dataGridViewCustomer.Columns.Add(maKhachColumn);

            DataGridViewTextBoxColumn tenKhachColumn = new DataGridViewTextBoxColumn();
            tenKhachColumn.HeaderText = "Tên Khách";
            tenKhachColumn.DataPropertyName = "TenKhach";
            dataGridViewCustomer.Columns.Add(tenKhachColumn);

            DataGridViewTextBoxColumn dienThoaiColumn = new DataGridViewTextBoxColumn();
            dienThoaiColumn.HeaderText = "Điện Thoại";
            dienThoaiColumn.DataPropertyName = "DienThoai";
            dataGridViewCustomer.Columns.Add(dienThoaiColumn);

            DataGridViewTextBoxColumn diaChiColumn = new DataGridViewTextBoxColumn();
            diaChiColumn.HeaderText = "Địa Chỉ";
            diaChiColumn.DataPropertyName = "DiaChi";
            dataGridViewCustomer.Columns.Add(diaChiColumn);
        }

        // Load danh sách khách hàng từ CSDL
        private void LoadKhachList()
        {
            customerController.Load();
            var customerList = customerController.Items.Cast<CustomerModel>().ToList();
            dataGridViewCustomer.DataSource = customerList;
        }

        // Lấy dữ liệu từ form
        public void GetDataFromText()
        {
            if (currentKhach == null) currentKhach = new CustomerModel();

            currentKhach.MaKhach = textBoxMaKhach.Text;
            currentKhach.TenKhach = textBoxTenKhach.Text;
            currentKhach.DienThoai = textBoxSoDienThoai.Text;
            currentKhach.DiaChi = textBoxDiaChi.Text;
        }

        // Đưa dữ liệu lên form
        public void SetDataToText(object item)
        {
            var khach = item as CustomerModel;
            if (khach != null)
            {
                textBoxMaKhach.Text = khach.MaKhach;
                textBoxTenKhach.Text = khach.TenKhach;
                textBoxSoDienThoai.Text = khach.DienThoai;
                textBoxDiaChi.Text = khach.DiaChi;
            }
        }

        // Thêm khách hàng
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaKhach.Text) || string.IsNullOrEmpty(textBoxTenKhach.Text))
            {
                MessageBox.Show("Cần nhập Mã Khách và Tên Khách.");
                return;
            }

            GetDataFromText();
            if (customerController.Create(currentKhach))
            {
                LoadKhachList();
                MessageBox.Show("Đã thêm Khách hàng thành công.");
            }
            else
            {
                MessageBox.Show("Không thể thêm Khách hàng.");
            }
        }

        // Cập nhật khách hàng
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewCustomer.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                GetDataFromText();
                if (customerController.Update(currentKhach))
                {
                    LoadKhachList();
                    MessageBox.Show("Cập nhật Khách hàng thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật Khách hàng.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Khách hàng để cập nhật.");
            }
        }

        // Xóa khách hàng
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewCustomer.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                CustomerModel khach = selectedRow.DataBoundItem as CustomerModel;

                if (customerController.Delete(khach.MaKhach))
                {
                    ConfirmDelete();
                }
                else
                {
                    MessageBox.Show("Không thể xoá Khách hàng.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Khách hàng để xoá.");
            }
        }

        // Xác nhận xóa
        private void ConfirmDelete()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadKhachList();
                MessageBox.Show("Đã xoá Khách hàng thành công.");
            }
        }

        // Tìm kiếm khách hàng
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string maKhach = textBoxMaKhach.Text;
            string tenKhach = textBoxTenKhach.Text;

            var searchResults = customerController.Search(maKhach, tenKhach).Cast<CustomerModel>().ToList();
            dataGridViewCustomer.DataSource = searchResults;
        }

        // Xóa dữ liệu trong TextBox
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMaKhach.Clear();
            textBoxTenKhach.Clear();
            textBoxSoDienThoai.Clear();
            textBoxDiaChi.Clear();
        }

        // Hiển thị thông tin khách hàng khi chọn trong DataGridView
        private void dataGridViewCustomer_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewCustomer.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var khach = (CustomerModel)selectedRow.DataBoundItem;
                SetDataToText(khach);
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
