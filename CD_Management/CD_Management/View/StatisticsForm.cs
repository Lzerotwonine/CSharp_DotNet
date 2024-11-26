using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CD_Management.Controller;
using CD_Management.Model;

namespace CD_Management.View
{
    public partial class StatisticsForm : Form, IView
    {
        private StatisticsController statisticsController;
        private List<IModel> currentStatistics;

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
                comboBoxSearch.DataSource = null; // Xóa dữ liệu trong ComboBox
                return;
            }

            var keys = currentStatistics
                        .OfType<StatisticsModel>() // Lọc chỉ các đối tượng StatisticsModel
                        .Select(stat => stat.Key) // Lấy thuộc tính Key
                        .Distinct()
                        .ToList();

            if (keys.Any())
            {
                comboBoxSearch.DataSource = keys;
                comboBoxSearch.SelectedIndex = -1; // Không chọn gì ban đầu
            }
            else
            {
                comboBoxSearch.DataSource = null; // Xóa dữ liệu nếu không có Key
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var selectedKey = comboBoxSearch.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedKey))
            {
                // Tìm hàng có mã tương ứng
                var row = dataGridViewStatistics.Rows
                          .Cast<DataGridViewRow>()
                          .FirstOrDefault(r => ((StatisticsModel)r.DataBoundItem).Key == selectedKey);

                if (row != null)
                {
                    dataGridViewStatistics.ClearSelection();
                    row.Selected = true;
                    dataGridViewStatistics.FirstDisplayedScrollingRowIndex = row.Index;
                    MessageBox.Show($"Đã tìm thấy mã {selectedKey}.");
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy mã {selectedKey}.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mã để tìm kiếm.");
            }
        }

    }
}
