using CD_Management.Controller;
using CD_Management.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CD_Management.View
{
    public partial class RentalRequest : Form, IView
    {
        CDController cdController = new CDController();
        CustomerController customerController = new CustomerController();
        public RentalRequest()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridCD.Columns.Count == 0)
            {
                dataGridCD.Columns.Add("MaBang", "Mã Băng");
                dataGridCD.Columns.Add("SoLuong", "Số Lượng");
                dataGridCD.Columns.Add("DonGia", "Đơn Giá");
                dataGridCD.Columns.Add("Coc", "Phần trăm cọc");
                dataGridCD.Columns.Add("TienCoc", "Tiền cọc");
            }
            if (string.IsNullOrWhiteSpace(ccbMaBang.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                string.IsNullOrWhiteSpace(txtCoc.Text) ||
                string.IsNullOrWhiteSpace(txtTienCoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) ||
                !float.TryParse(txtDonGia.Text, out float donGia) ||
                !float.TryParse(txtCoc.Text, out float coc) ||
                !float.TryParse(txtTienCoc.Text, out float tienCoc))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho các trường Số lượng, Đơn giá, Tiền cọc.");
                return;
            }
            dataGridCD.Rows.Add(
                ccbMaBang.Text,
                soLuong,
                donGia,
                coc,
                tienCoc
            );

            txtIdPM.Text = GenerateMaPhieuMuon();
            UpdateTongTienCoc();

            // Clear các ô nhập liệu
            ccbMaBang.Text = "";
            txtTenBang.Clear();
            txtTacGia.Clear();
            txtTheLoai.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtTienCoc.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPM.Text) || string.IsNullOrWhiteSpace(ccbIdKH.Text))
            {
                MessageBox.Show("Mã phiếu mượn và Mã khách hàng không được để trống.");
                return;
            }
            float totalTienCoc = 0;
            float totalTienSanPham = 0;
            float tienTra = 0;


            var rentalRequest = new RentalRequestModel
            {
                MaHDMuon = txtIdPM.Text,
                NgayMuon = dateNgayMuon.Value,
                NgayTra = dateNgayTra.Value,
                MaKhach = ccbIdKH.Text,
                HoatDong = false
            };

            var detailRequests = new List<DetailRentalRequestModel>();

            foreach (DataGridViewRow row in dataGridCD.Rows)
            {
                if (row.Cells["MaBang"].Value == null) continue;

                int soLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                float donGia = float.Parse(row.Cells["DonGia"].Value.ToString());
                float phanTramCoc = float.Parse(row.Cells["Coc"].Value.ToString());

                float tienCocProduct = soLuong * donGia * phanTramCoc / 100;
                totalTienCoc += tienCocProduct;
                float tienSanPham = soLuong * donGia;
                totalTienSanPham += tienSanPham;
                tienTra = totalTienSanPham - totalTienCoc;

                detailRequests.Add(new DetailRentalRequestModel
                {
                    MaHDBan = rentalRequest.MaHDMuon,
                    MaBang = row.Cells["MaBang"].Value.ToString(),
                    SoLuong = soLuong,
                    DonGia = donGia,
                    Coc = phanTramCoc,
                    TienCoc = tienCocProduct
                });
            }

            rentalRequest.TienCoc = totalTienCoc;
            rentalRequest.TienTra = tienTra;

            var rentalRequestController = new RentalRequestController();
            var detailRentalRequestController = new DetailRentalRequestController();
            //"System.Configuration.ConfigurationManager.ConnectionStrings[\"CD_Management.Properties.Settings.CD_ManagementConnectionString\"].ConnectionString"  
            using (var connection = new SqlConnection("Data Source=THIEN\\SQLEXPRESS;Initial Catalog=CD_Management;Integrated Security=True"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        rentalRequestController.Create(rentalRequest);

                        foreach (var detail in detailRequests)
                        {
                            detailRentalRequestController.Create(detail);
                        }

                        foreach (var detail in detailRequests)
                        {
                            bool updateSuccess = cdController.UpdateSoLuong(detail.MaBang, detail.SoLuong);
                            if (!updateSuccess)
                            {
                                throw new Exception($"Cập nhật số lượng băng đĩa {detail.MaBang} không thành công.");
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Lưu dữ liệu thành công.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadBangComboBox();
            LoadCustomerComboBox();
            dateNgayTra.Value = DateTime.Now.AddDays(14);

        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {

        }
        private void TinhTienCoc()
        {
            if (int.TryParse(txtSoLuong.Text, out int soLuong) && float.TryParse(txtCoc.Text, out float phanTramCoc) && int.TryParse(txtDonGia.Text, out int dongia))
            {
                float tienCoc = soLuong * dongia * phanTramCoc / 100;
                txtTienCoc.Text = tienCoc.ToString("0.00");
            }
            else
            {

                txtTienCoc.Text = "0";
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhTienCoc();

            if (int.TryParse(txtSoLuong.Text, out int soLuongNhap))
            {
                if (soLuongNhap <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0.");
                    txtSoLuong.Text = ""; 
                    return;
                }

                if (ccbMaBang.SelectedItem != null)
                {
                    string selectedMaBang = ccbMaBang.SelectedItem.ToString();

                    int availableQuantity = cdController.GetAvailableQuantity(selectedMaBang);

                    if (soLuongNhap > availableQuantity)
                    {
                        MessageBox.Show("Số lượng nhập vượt quá số lượng có sẵn trong kho.");
                        txtSoLuong.Text = availableQuantity.ToString();
                    }
                }
            }
            else if (txtSoLuong.Text != "")
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                txtSoLuong.Text = ""; // Xóa giá trị không hợp lệ
            }
        }


        private void txtCoc_TextChanged(object sender, EventArgs e)
        {
            TinhTienCoc();
        }
        private void LoadBangComboBox()
        {
            List<string> maBangList = cdController.LoadBangComboBox();
            ccbMaBang.Items.Clear();

            foreach (var maBang in maBangList)
            {
                ccbMaBang.Items.Add(maBang);
            }
        }


        private void ccbMaBang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedMaBang = ccbMaBang.SelectedItem.ToString();
            LoadBangDetails(selectedMaBang);
        }
        private void LoadBangDetails(string maBang)
        {
            CDModel bang = cdController.LoadBangDetails(maBang);

            if (bang != null)
            {
                txtTenBang.Text = bang.TenBang;
                txtSoLuong.Text = "";
                txtDonGia.Text = bang.DonGiaBan.ToString();
                txtTheLoai.Text = bang.TheLoai;
                txtTacGia.Text = bang.TacGia;
                // Các trường khác nếu có thể tính toán
                txtCoc.Text = "30";
                txtTienCoc.Text = "";
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin cho mã băng đĩa này.");
            }
        }
        private void LoadCustomerComboBox()
        {
            var customers = customerController.GetAllCustomers();
            ccbIdKH.Items.Clear();

            foreach (var customer in customers)
            {
                ccbIdKH.Items.Add(customer.MaKhach);
            }
        }


        private void ccbIdKH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedMaKhach = ccbIdKH.SelectedItem.ToString();

            CustomerModel customer = customerController.GetCustomerById(selectedMaKhach);

            if (customer != null)
            {
                txtNameKH.Text = customer.TenKhach;
                txtPhone.Text = customer.DienThoai;
                txtAddress.Text = customer.DiaChi;
            }
        }
        private string GenerateMaPhieuMuon()
        {
            Random random = new Random();
            string randomNumbers = random.Next(100000, 999999).ToString();
            return "PM" + randomNumbers;
        }

        private void dataGridCD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác nhận", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dataGridCD.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        private void UpdateTongTienCoc()
        {
            float totalTienCoc = 0;
            foreach (DataGridViewRow row in dataGridCD.Rows)
            {
                if (row.Cells["MaBang"].Value == null) continue;
                int soLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                float donGia = float.Parse(row.Cells["DonGia"].Value.ToString());
                float phanTramCoc = float.Parse(row.Cells["Coc"].Value.ToString());
                float tienCocProduct = soLuong * donGia * phanTramCoc / 100;
                totalTienCoc += tienCocProduct;
            }

            txtTongTien.Text = totalTienCoc.ToString("0.00");
        }

        public void SetDataToText(object item)
        {
            if (item is RentalRequestModel rentalRequest)
            {
                txtIdPM.Text = rentalRequest.MaHDMuon;
                dateNgayMuon.Value = rentalRequest.NgayMuon;
                dateNgayTra.Value = rentalRequest.NgayTra;
                ccbIdKH.SelectedItem = rentalRequest.MaKhach;
                // Bạn có thể gán thêm dữ liệu cho các trường khác nếu cần
            }
            else if (item is DetailRentalRequestModel detailRequest)
            {
                ccbMaBang.SelectedItem = detailRequest.MaBang;
                txtSoLuong.Text = detailRequest.SoLuong.ToString();
                txtDonGia.Text = detailRequest.DonGia.ToString();
                txtCoc.Text = detailRequest.Coc.ToString();
                txtTienCoc.Text = detailRequest.TienCoc.ToString("0.00");
            }
        }

        public void GetDataFromText()
        {
            if (string.IsNullOrWhiteSpace(txtIdPM.Text) || string.IsNullOrWhiteSpace(ccbIdKH.Text))
            {
                MessageBox.Show("Mã phiếu mượn và Mã khách hàng không được để trống.");
                return;
            }

            RentalRequestModel rentalRequest = new RentalRequestModel
            {
                MaHDMuon = txtIdPM.Text,
                NgayMuon = dateNgayMuon.Value,
                NgayTra = dateNgayTra.Value,
                MaKhach = ccbIdKH.Text,
                HoatDong = false
            };

            List<DetailRentalRequestModel> detailRequests = new List<DetailRentalRequestModel>();

            foreach (DataGridViewRow row in dataGridCD.Rows)
            {
                if (row.Cells["MaBang"].Value == null) continue;

                int soLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                float donGia = float.Parse(row.Cells["DonGia"].Value.ToString());
                float phanTramCoc = float.Parse(row.Cells["Coc"].Value.ToString());

                float tienCocProduct = soLuong * donGia * phanTramCoc / 100;

                detailRequests.Add(new DetailRentalRequestModel
                {
                    MaHDBan = rentalRequest.MaHDMuon,
                    MaBang = row.Cells["MaBang"].Value.ToString(),
                    SoLuong = soLuong,
                    DonGia = donGia,
                    Coc = phanTramCoc,
                    TienCoc = tienCocProduct
                });
            }

            rentalRequest.TienCoc = detailRequests.Sum(d => d.TienCoc);
        }

        private void ClearForm()
        {
            txtIdPM.Clear();
            dateNgayMuon.Value = DateTime.Now;
            dateNgayTra.Value = DateTime.Now.AddDays(14);
            ccbIdKH.SelectedIndex = -1;
            dataGridCD.Rows.Clear();
            txtTongTien.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
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
