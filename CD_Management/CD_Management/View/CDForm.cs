using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CD_Management.Controller;
using CD_Management.Model;

namespace CD_Management.View
{
    public partial class CDForm : Form, IView
    {
        private CDController bangController = new CDController();
        private CDModel currentBang;

        public CDForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadBangFromDatabase();
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewCD.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn maBangColumn = new DataGridViewTextBoxColumn { HeaderText = "Mã Băng", DataPropertyName = "MaBang", ReadOnly = true };
            dataGridViewCD.Columns.Add(maBangColumn);

            DataGridViewTextBoxColumn tenBangColumn = new DataGridViewTextBoxColumn { HeaderText = "Tên Băng", DataPropertyName = "TenBang", ReadOnly = true };
            dataGridViewCD.Columns.Add(tenBangColumn);

            DataGridViewTextBoxColumn soLuongColumn = new DataGridViewTextBoxColumn { HeaderText = "Số Lượng", DataPropertyName = "SoLuong", ReadOnly = true };
            dataGridViewCD.Columns.Add(soLuongColumn);

            DataGridViewTextBoxColumn donGiaColumn = new DataGridViewTextBoxColumn { HeaderText = "Đơn Giá Bán", DataPropertyName = "DonGiaBan", ReadOnly = true };
            dataGridViewCD.Columns.Add(donGiaColumn);

            DataGridViewTextBoxColumn theLoaiColumn = new DataGridViewTextBoxColumn { HeaderText = "Thể Loại", DataPropertyName = "TheLoai", ReadOnly = true };
            dataGridViewCD.Columns.Add(theLoaiColumn);

            DataGridViewTextBoxColumn tacGiaColumn = new DataGridViewTextBoxColumn { HeaderText = "Tác Giả", DataPropertyName = "TacGia", ReadOnly = true };
            dataGridViewCD.Columns.Add(tacGiaColumn);
        }

        // Load dữ liệu từ CSDL
        private void LoadBangFromDatabase()
        {
            bangController.Load();
            var bangs = bangController.Items.Cast<CDModel>().ToList();
            dataGridViewCD.DataSource = bangs;
        }

        // Lấy dữ liệu từ form
        public void GetDataFromText()
        {
            if (currentBang == null) currentBang = new CDModel();

            currentBang.MaBang = textBoxMaBang.Text;
            currentBang.TenBang = textBoxTenBang.Text;
            currentBang.SoLuong = int.Parse(textBoxSoLuong.Text);
            currentBang.DonGiaBan = double.Parse(textBoxDonGiaBan.Text);
            currentBang.TheLoai = textBoxTheLoai.Text;
            currentBang.TacGia = textBoxTacGia.Text;
        }

        // Đưa dữ liệu lên form
        public void SetDataToText(object item)
        {   
            var bang = item as CDModel;
            if (bang != null)
            {
                textBoxMaBang.Text = bang.MaBang;
                textBoxTenBang.Text = bang.TenBang;
                textBoxSoLuong.Text = bang.SoLuong.ToString();
                textBoxDonGiaBan.Text = bang.DonGiaBan.ToString();
                textBoxTheLoai.Text = bang.TheLoai;
                textBoxTacGia.Text = bang.TacGia;
            }
        }

        // Nút thêm mới băng
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            GetDataFromText();
            if (bangController.Create(currentBang))
            {
                LoadBangFromDatabase();
                MessageBox.Show("Thêm Băng thành công.");
            }
            else
            {
                MessageBox.Show("Không thể thêm Băng.");
            }
        }

        // Nút cập nhật băng
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            GetDataFromText();
            if (bangController.Update(currentBang))
            {
                LoadBangFromDatabase();
                MessageBox.Show("Cập nhật Băng thành công.");
            }
            else
            {
                MessageBox.Show("Không thể cập nhật Băng.");
            }
        }

        // Nút xóa băng
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (bangController.Delete(currentBang.MaBang))
            {
                LoadBangFromDatabase();
                MessageBox.Show("Xóa Băng thành công.");
            }
            else
            {
                MessageBox.Show("Không thể xóa Băng.");
            }
        }

        // Nút tìm kiếm băng
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string maBang = textBoxMaBang.Text;
            string tenBang = textBoxTenBang.Text;
            string tacGia = textBoxTacGia.Text;
            string theLoai = textBoxTheLoai.Text;
        
            // Gọi phương thức tìm kiếm
            List<IModel> result = bangController.Search(
                string.IsNullOrEmpty(maBang) ? null : maBang,
                string.IsNullOrEmpty(tenBang) ? null : tenBang,
                string.IsNullOrEmpty(tacGia) ? null : tacGia,
                string.IsNullOrEmpty(theLoai) ? null : theLoai
            );
        
            // Ép kiểu từ IModel sang CDModel
            var cdResults = result.Cast<CDModel>().ToList();
        
            // Gán lại DataSource cho DataGridView
            dataGridViewCD.DataSource = cdResults;
        }

        // Nút xóa dữ liệu nhập trên các TextBox
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMaBang.ReadOnly = false;
            textBoxMaBang.Clear();
            textBoxTenBang.Clear();
            textBoxSoLuong.Clear();
            textBoxDonGiaBan.Clear();
            textBoxTheLoai.Clear();
            textBoxTacGia.Clear();
        }

        // Sự kiện hiển thị thông tin băng khi chọn dòng trong DataGridView
        private void dataGridViewCD_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewCD.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var bang = (CDModel)selectedRow.DataBoundItem;
                textBoxMaBang.ReadOnly = true;
                SetDataToText(bang);
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
