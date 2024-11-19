using CD.Controller;
using CD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD.View
{
    public partial class ReturnRequest : Form
    {
        RentalRequestController rentalRequestController = new RentalRequestController();
        public ReturnRequest()
        {
            InitializeComponent();
            LoadPMComboBox();
            ConfigureDataGridView();
        }
        private void ConfigureDataGridView()
        {
            // Xóa các cột hiện tại trong DataGridView (nếu có)
            dataGridReturn.Columns.Clear();

            // Thêm cột vào DataGridView
            dataGridReturn.Columns.Add("MaKhach", "Mã Khách");
            dataGridReturn.Columns.Add("NgayMuon", "Ngày Mượn");
            dataGridReturn.Columns.Add("NgayTra", "Hạn Ngày Trả");
            dataGridReturn.Columns.Add("TienCoc", "Tiền Cọc");
            /*dataGridReturn.Columns.Add("HoatDong", "Hoạt Động");*/
            dataGridReturn.Columns.Add("TienTra", "Tiền Trả");
        }
        private void LoadPMComboBox()
        {
            // Giả sử bạn có phương thức để lấy danh sách các RentalRequestModel từ controller
            var rentalRequests = rentalRequestController.GetAllRentalRequests();
            cbbPM.Items.Clear();

            // Lặp qua danh sách các RentalRequestModel và thêm MaHDMuon vào ComboBox
            foreach (var rentalRequest in rentalRequests)
            {
                cbbPM.Items.Add(rentalRequest.MaHDMuon); // Thêm mã phiếu mượn vào ComboBox
            }
        }

        private void cbbPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaHDMuon = cbbPM.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedMaHDMuon))
            {
                MessageBox.Show("Vui lòng chọn một mã hóa đơn hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RentalRequestModel rentalRequest = rentalRequestController.GetRentalRequestByMaHDMuon(selectedMaHDMuon);

            if (rentalRequest != null)
            {
                dataGridReturn.Rows.Clear();

                // Thêm một dòng vào DataGridView
                dataGridReturn.Rows.Add(
                    rentalRequest.MaKhach,
                    rentalRequest.NgayMuon.ToString("dd/MM/yyyy"),
                    rentalRequest.NgayTra.ToString("dd/MM/yyyy"),
                    rentalRequest.TienCoc.ToString("N2"),
                    /*rentalRequest.HoatDong ? "Hoạt động" : "Không hoạt động",*/
                    rentalRequest.TienTra.HasValue ? rentalRequest.TienTra.Value.ToString("N2") : "Không cần trả tiền");
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin chi tiết cho mã hóa đơn mượn được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string maHDTra = txtMaPT.Text.Trim();
            string maHDMuon = cbbPM.Text.Trim(); 
            DateTime ngayTraHang = DateTime.Now;
            float tongTienTra = 0;
            if (dataGridReturn.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridReturn.SelectedRows[0];
                if (selectedRow.Cells["TienTra"].Value != null &&
                    float.TryParse(selectedRow.Cells["TienTra"].Value.ToString(), out tongTienTra))
                {
                }
                else
                {
                    MessageBox.Show("Số tiền trả không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong DataGridView.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(maHDTra) || string.IsNullOrWhiteSpace(maHDMuon))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin mã phiếu trả và mã hóa đơn mượn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var returnRequest = new ReturnRequestModel
            {
                MaHDTra = maHDTra,
                MaHDMuon = maHDMuon,
                NgayTraHang = ngayTraHang,
                TongTienTra = tongTienTra
            };

            var returnRequestController = new ReturnRequestController();
            if (returnRequestController.IsExist(maHDTra))
            {
                MessageBox.Show("Mã phiếu trả đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool success = returnRequestController.Create(returnRequest);

            if (success)
            {
                var rentalRequestController = new RentalRequestController();
                var rentalRequest = new RentalRequestModel
                {
                    MaHDMuon = maHDMuon,
                    HoatDong = true
                };

                bool updateSuccess = rentalRequestController.Update(rentalRequest);

                if (updateSuccess)
                {
                    MessageBox.Show("Phiếu trả đã được lưu thành công và trạng thái phiếu mượn đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi cập nhật trạng thái phiếu mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Làm sạch form
                ClearForm();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu phiếu trả. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            txtMaPT.Clear();         
        }
    }
}
