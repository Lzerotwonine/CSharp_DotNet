using CD_Management.Controller;
using CD_Management.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CD_Management.View
{
    public partial class SupplierForm : Form, IView
    {
        private SupplierController supplierController = new SupplierController();
        private SupplierModel currentSupplier;

        public SupplierForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadSuppliersFromDatabase();
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewSuppliers.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn supplierIdColumn = new DataGridViewTextBoxColumn();
            supplierIdColumn.HeaderText = "Mã NCC";
            supplierIdColumn.DataPropertyName = "MaNhaCungCap";
            dataGridViewSuppliers.Columns.Add(supplierIdColumn);

            DataGridViewTextBoxColumn supplierNameColumn = new DataGridViewTextBoxColumn();
            supplierNameColumn.HeaderText = "Tên NCC";
            supplierNameColumn.DataPropertyName = "TenNhaCungCap";
            dataGridViewSuppliers.Columns.Add(supplierNameColumn);

            DataGridViewTextBoxColumn addressColumn = new DataGridViewTextBoxColumn();
            addressColumn.HeaderText = "Địa chỉ";
            addressColumn.DataPropertyName = "DiaChi";
            dataGridViewSuppliers.Columns.Add(addressColumn);

            DataGridViewTextBoxColumn phoneColumn = new DataGridViewTextBoxColumn();
            phoneColumn.HeaderText = "Số điện thoại";
            phoneColumn.DataPropertyName = "SoDienThoai";
            dataGridViewSuppliers.Columns.Add(phoneColumn);
        }

        // Load danh sách nhà cung cấp từ CSDL
        private void LoadSuppliersFromDatabase()
        {
            supplierController.Load();
            var suppliers = supplierController.Items.Cast<SupplierModel>().ToList();
            dataGridViewSuppliers.DataSource = suppliers;
        }

        // Lấy dữ liệu từ form
        public void GetDataFromText()
        {
            if (currentSupplier == null) currentSupplier = new SupplierModel();

            currentSupplier.MaNhaCungCap = textBoxMaNCC.Text;
            currentSupplier.TenNhaCungCap = textBoxTenNCC.Text;
            currentSupplier.DiaChi = textBoxDiaChi.Text;
            currentSupplier.SoDienThoai = textBoxSoDienThoai.Text;
        }

        // Đưa dữ liệu lên form
        public void SetDataToText(object item)
        {
            var supplier = item as SupplierModel;
            if (supplier != null)
            {
                textBoxMaNCC.Text = supplier.MaNhaCungCap;
                textBoxTenNCC.Text = supplier.TenNhaCungCap;
                textBoxDiaChi.Text = supplier.DiaChi;
                textBoxSoDienThoai.Text = supplier.SoDienThoai;
            }
        }

        // Thêm nhà cung cấp
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaNCC.Text) || string.IsNullOrEmpty(textBoxTenNCC.Text))
            {
                MessageBox.Show("Cần nhập Mã và Tên nhà cung cấp.");
                return;
            }

            GetDataFromText();
            if (supplierController.Create(currentSupplier))
            {
                LoadSuppliersFromDatabase();
                MessageBox.Show("Đã thêm nhà cung cấp thành công.");
            }
            else
            {
                MessageBox.Show("Không thể thêm nhà cung cấp.");
            }
        }

        // Cập nhật nhà cung cấp
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewSuppliers.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                GetDataFromText();
                if (supplierController.Update(currentSupplier))
                {
                    LoadSuppliersFromDatabase();
                    MessageBox.Show("Cập nhật nhà cung cấp thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật nhà cung cấp.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhà cung cấp để cập nhật.");
            }
        }

        // Xóa nhà cung cấp
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewSuppliers.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                SupplierModel supplier = selectedRow.DataBoundItem as SupplierModel;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (supplierController.Delete(supplier.MaNhaCungCap))
                    {
                        LoadSuppliersFromDatabase();
                        MessageBox.Show("Đã xoá nhà cung cấp thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá nhà cung cấp.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn nhà cung cấp để xoá.");
            }
        }

        // Tìm kiếm nhà cung cấp
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string maNCC = textBoxMaNCC.Text.Trim();
            string tenNCC = textBoxTenNCC.Text.Trim();

            // Gọi phương thức Search để tìm kiếm
            var result = supplierController.Search(maNCC, tenNCC);

            if (result != null && result.Count > 0)
            {
                // Cập nhật DataGridView với kết quả
                dataGridViewSuppliers.DataSource = result;
            }
            else
            {
                // Thông báo nếu không có kết quả tìm kiếm
                MessageBox.Show("Không tìm thấy nhà cung cấp nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đặt lại DataGridView về danh sách ban đầu (tất cả nhà cung cấp)
                LoadSuppliersFromDatabase();
            }
        }


        // Xóa các trường văn bản
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMaNCC.Clear();
            textBoxTenNCC.Clear();
            textBoxDiaChi.Clear();
            textBoxSoDienThoai.Clear();
        }

        // Hiển thị thông tin nhà cung cấp khi chọn trong DataGridView
        private void dataGridViewSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewSuppliers.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var supplier = (SupplierModel)selectedRow.DataBoundItem;
                SetDataToText(supplier);
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
