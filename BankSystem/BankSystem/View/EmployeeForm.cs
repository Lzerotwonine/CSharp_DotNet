
using BankSystem.Controller;
using BankSystem.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BankSystem.View
{
    public partial class EmployeeForm : Form
    {
        private EmployeeController employeeController = new EmployeeController();

        public EmployeeForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadEmployeesFromDatabase();
        }

        // Khởi tạo DataGridView
        private void InitializeDataGridView()
        {
            dataGridViewEmployees.AutoGenerateColumns = false;
            dataGridViewEmployees.Columns.Add("Id", "ID");
            dataGridViewEmployees.Columns.Add("Name", "Name");
            dataGridViewEmployees.Columns.Add("Role", "Role");
        }

        // Load danh sách nhân viên từ CSDL
        private void LoadEmployeesFromDatabase()
        {
            var employees = employeeController.LoadEmployees();
            dataGridViewEmployees.DataSource = employees;
        }

        // Thêm nhân viên
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Cần nhập ID và Mật khẩu.");
                return;
            }

            Employee employee = new Employee
            {
                Id = textBoxId.Text,
                Name = textBoxName.Text,
                Password = textBoxPassword.Text,
                Role = checkBoxAdmin.Checked ? "Admin" : "Employee"
            };

            if (employeeController.Create(employee))
            {
                LoadEmployeesFromDatabase();
                MessageBox.Show("Đã thêm Nhân viên thành công.");
            }
            else
            {
                MessageBox.Show("Không thể thêm Nhân viên.");
            }
        }

        // Cập nhật nhân viên
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewEmployees.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                Employee employee = selectedRow.DataBoundItem as Employee;

                employee.Id = textBoxId.Text;
                employee.Name = textBoxName.Text;
                employee.Password = textBoxPassword.Text;
                employee.Role = checkBoxAdmin.Checked ? "Admin" : "Employee";

                if (employeeController.Update(employee))
                {
                    LoadEmployeesFromDatabase();
                    MessageBox.Show("Cập nhật Nhân viên thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật Nhân viên.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Nhân viên để cập nhật.");
            }
        }

        // Xóa nhân viên
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewEmployees.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                Employee employee = selectedRow.DataBoundItem as Employee;

                if (employeeController.Delete(employee.Id))
                {
                    LoadEmployeesFromDatabase();
                    MessageBox.Show("Đã xoá Nhân viên thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể xoá Nhân viên.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Nhân viên để xoá.");
            }
        }

        // Hiển thị thông tin nhân viên khi chọn trong DataGridView
        private void dataGridViewEmployees_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewEmployees.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (selectedRow != null)
            {
                var employee = (Employee)selectedRow.DataBoundItem;
                textBoxId.Text = employee.Id;
                textBoxName.Text = employee.Name;
                textBoxPassword.Text = employee.Password;
                checkBoxAdmin.Checked = employee.Role == "Admin";
            }
        }
    }
}
