using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CD_Management.Controller;
using CD_Management.Model;
using System.Text;
using System.IO;
using ClosedXML.Excel;



namespace CD_Management.View
{
    public partial class StatisticsForm : Form, IView
    {
        private StatisticsController statisticsController;
        private List<IModel> currentStatistics;
        private string currentStatisticType = "";

        public StatisticsForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            statisticsController = new StatisticsController();
            currentStatistics = new List<IModel>();
            this.MainMenuStrip = toolStripMenu;
        }

        // Khởi tạo DataGridView với cấu hình mặc định
        private void InitializeDataGridView()
        {
            dataGridViewStatistics.AutoGenerateColumns = true;
            dataGridViewStatistics.AllowUserToAddRows = false;
            dataGridViewStatistics.AllowUserToDeleteRows = false;
            dataGridViewStatistics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Cập nhật tiêu đề của form
        private void UpdateTitle(string title)
        {
            this.Text = $"Thống kê - {title}";
        }

        // Hiển thị dữ liệu lên DataGridView
        private void DisplayData(string title, List<(string Header, string Property)> columns)
        {
            UpdateTitle(title);

            dataGridViewStatistics.Columns.Clear();

            dataGridViewStatistics.AutoGenerateColumns = false;

            foreach (var column in columns)
            {
                dataGridViewStatistics.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = column.Header,
                    DataPropertyName = column.Property,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }

            // Gắn dữ liệu từ controller
            var data = statisticsController.Items.Cast<StatisticsModel>().ToList();
            dataGridViewStatistics.DataSource = data;
        }

        // Set dữ liệu từ item vào form
        public void SetDataToText(object item)
        {
            var statisticsItem = item as StatisticsModel;
            if (statisticsItem != null)
            {
                //// Gắn dữ liệu từ item vào các điều khiển trong form
                //textBoxKey.Text = statisticsItem.Key;
                //textBoxName.Text = statisticsItem.Name;
                //textBoxDescription.Text = statisticsItem.Description;
                //dateTimePickerDate.Value = statisticsItem.Date ?? DateTime.Now;
            }
        }

        // Lấy dữ liệu từ form và chuyển về item
        public void GetDataFromText()
        {
            var newStatisticsItem = new StatisticsModel
            {
                //Key = textBoxKey.Text,
                //Name = textBoxName.Text,
                //Description = textBoxDescription.Text,
                //Date = dateTimePickerDate.Value
            };

            // Thêm hoặc cập nhật thống kê mới vào danh sách
            currentStatistics.Add(newStatisticsItem);
        }

        // Xử lý khi chọn menu "Thống kê sản phẩm còn trong kho"
        private void toolStripMenuItemProductsInStock_Click(object sender, EventArgs e)
        {
            if (statisticsController.GetProductsInStock())
            {
                currentStatisticType = "ProductsInStock"; // Thiết lập loại thống kê
                DisplayData("Sản phẩm còn trong kho", new List<(string, string)>
                {
                    ("Mã Băng", "Key"),
                    ("Tên Băng", "Name"),
                    ("Số Lượng", "Quantity"),
                    ("Đơn Giá Bán", "Value"),
                    ("Thể Loại", "Description"),
                    ("Tác Giả", "Additional")
                });

                UpdateSearchComboBox();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.");
                currentStatistics.Clear();
                UpdateSearchComboBox();
            }
        }


        // Xử lý khi chọn menu "Thống kê các phiếu quá hạn trả"
        private void toolStripMenuItemOverdueReceipts_Click(object sender, EventArgs e)
        {
            if (statisticsController.GetOverdueReceipts())
            {
                currentStatisticType = "OverdueReceipts"; // Thiết lập loại thống kê
                DisplayData("Phiếu quá hạn trả", new List<(string, string)>
                {
                    ("Mã Phiếu", "Key"),
                    ("Ngày Mượn", "BorrowDate"),
                    ("Ngày Trả", "Date"),
                    ("Mã Khách", "CustomerID"),
                    ("Tiền Cọc", "Deposit"),
                    ("Hoạt Động", "Active")
                });

                UpdateSearchComboBox();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.");
                currentStatistics.Clear();
                UpdateSearchComboBox();
            }
        }


        // Xử lý khi chọn menu "Thống kê khách hàng đã mượn sản phẩm"
        private void toolStripMenuItemBorrowingCustomers_Click(object sender, EventArgs e)
        {
            if (statisticsController.GetBorrowingCustomers())
            {
                currentStatisticType = "BorrowingCustomers"; // Thiết lập loại thống kê
                DisplayData("Khách hàng đã mượn sản phẩm", new List<(string, string)>
                {
                    ("Mã Khách", "Key"),
                    ("Tên Khách", "Name"),
                    ("Địa Chỉ", "Description"),
                    ("Điện Thoại", "Phone"),
                    ("Mã Phiếu Mượn", "ReceiptID"),
                    ("Hoạt Động", "Active")
                });

                UpdateSearchComboBox();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.");
                currentStatistics.Clear();
                UpdateSearchComboBox();
            }
        }


        // Xử lý khi chọn menu "Thống kê các sản phẩm đã mượn"
        private void toolStripMenuItemBorrowedProducts_Click(object sender, EventArgs e)
        {
            if (statisticsController.GetBorrowedProducts())
            {
                currentStatisticType = "BorrowedProducts"; // Thiết lập loại thống kê
                DisplayData("Sản phẩm đã mượn", new List<(string, string)>
                {
                    ("Mã Phiếu", "ReceiptID"),
                    ("Mã Băng", "Key"),
                    ("Tên Băng", "Name"),
                    ("Thể Loại", "Description"),
                    ("Tác Giả", "Author"),
                    ("Số Lượng", "Quantity"),
                    ("Đơn Giá Bán", "Value")
                });

                UpdateSearchComboBox();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu.");
                currentStatistics.Clear();
                UpdateSearchComboBox();
            }
        }


        // Phím tắt ESC để đóng form
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Sự kiện chọn một thống kê trong DataGridView
        private void dataGridViewStatistics_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewStatistics.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var selectedStatistics = (StatisticsModel)selectedRow.DataBoundItem;
                SetDataToText(selectedStatistics); // Hiển thị thông tin chi tiết khi chọn dòng
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatistics.SelectedRows.Count > 0)
            {
                // Lấy danh sách các hàng được chọn
                var selectedItems = dataGridViewStatistics.SelectedRows
                                    .Cast<DataGridViewRow>()
                                    .Select(row => (StatisticsModel)row.DataBoundItem)
                                    .ToList();

                // Xóa các hàng khỏi danh sách trong controller
                foreach (var item in selectedItems)
                {
                    // Implement logic in Controller to delete item (if required)
                    currentStatistics.Remove(item); // Xóa từ danh sách hiện tại
                }

                // Cập nhật lại DataGridView
                dataGridViewStatistics.DataSource = null;
                dataGridViewStatistics.DataSource = currentStatistics;
                MessageBox.Show("Đã xóa các dòng được chọn.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.");
            }
        }
        private void UpdateSearchComboBox()
        {
            if (currentStatistics == null || !currentStatistics.Any())
            {
                textBoxSearch.Text = ""; // Xóa dữ liệu trong TextBox
                return;
            }

            List<string> keys = new List<string>();

            // Dựa trên loại thống kê đang chọn, cập nhật danh sách khóa cho TextBox
            if (currentStatisticType == "ProductsInStock")
            {
                keys = currentStatistics
                    .OfType<StatisticsModel>()
                    .Select(stat => stat.Key) // Mã Băng
                    .Distinct()
                    .ToList();
            }
            else if (currentStatisticType == "OverdueReceipts")
            {
                keys = currentStatistics
                    .OfType<StatisticsModel>()
                    .Select(stat => stat.CustomerID) // Mã Khách
                    .Distinct()
                    .ToList();
            }
            else if (currentStatisticType == "BorrowingCustomers")
            {
                keys = currentStatistics
                    .OfType<StatisticsModel>()
                    .Select(stat => stat.Key) // Mã Khách
                    .Distinct()
                    .ToList();
            }
            else if (currentStatisticType == "BorrowedProducts")
            {
                keys = currentStatistics
                    .OfType<StatisticsModel>()
                    .Select(stat => stat.ReceiptID) // Mã Phiếu
                    .Distinct()
                    .ToList();
            }

            // Cập nhật TextBox với các khóa tìm được
            if (keys.Any())
            {
                textBoxSearch.Text = keys.FirstOrDefault(); // Tự động điền dữ liệu đầu tiên vào TextBox
            }
            else
            {
                textBoxSearch.Text = ""; // Xóa dữ liệu nếu không có Key
            }
        }



        private int currentSearchIndex = -1; // Chỉ số hiện tại khi tìm kiếm

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchTerm = textBoxSearch.Text.Trim(); // Lấy giá trị từ TextBox tìm kiếm
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.");
                return;
            }

            // Tìm tất cả các dòng có giá trị tương ứng
            var matchingRows = dataGridViewStatistics.Rows.Cast<DataGridViewRow>()
                .Where(r => ((StatisticsModel)r.DataBoundItem).Key.Contains(searchTerm)) // Tìm các phần tử có chứa từ khóa
                .ToList();

            if (matchingRows.Any())
            {
                // Nếu có kết quả tìm thấy, di chuyển đến phần tử tiếp theo
                currentSearchIndex = (currentSearchIndex + 1) % matchingRows.Count; // Chuyển sang phần tử tiếp theo

                var selectedRow = matchingRows[currentSearchIndex];
                dataGridViewStatistics.ClearSelection();
                selectedRow.Selected = true;
                dataGridViewStatistics.FirstDisplayedScrollingRowIndex = selectedRow.Index; // Cuộn đến dòng đã chọn

                //MessageBox.Show($"Đã tìm thấy: {((StatisticsModel)selectedRow.DataBoundItem).Key}");
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả.");
            }
        }




        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo workbook mới
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Thống kê");

                    // Thêm tiêu đề cột vào Excel
                    for (int i = 0; i < dataGridViewStatistics.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridViewStatistics.Columns[i].HeaderText;
                    }

                    // Thêm dữ liệu từ DataGridView vào Excel
                    for (int i = 0; i < dataGridViewStatistics.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewStatistics.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value =
                                dataGridViewStatistics.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                    }

                    // Lưu file Excel
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel Files|*.xlsx";
                    saveDialog.Title = "Lưu dữ liệu vào Excel";
                    saveDialog.FileName = "ThongKe_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Dữ liệu đã được xuất ra Excel!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất dữ liệu ra Excel: {ex.Message}");
            }
        }

        
    }
}