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

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "Id";
            idColumn.ReadOnly = true;
            dataGridViewEmployees.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.DataPropertyName = "Name";
            nameColumn.ReadOnly = true;
            dataGridViewEmployees.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
            passwordColumn.HeaderText = "Password";
            passwordColumn.DataPropertyName = "Password";
            passwordColumn.ReadOnly = true;
            dataGridViewEmployees.Columns.Add(passwordColumn);

            DataGridViewTextBoxColumn roleColumn = new DataGridViewTextBoxColumn();
            roleColumn.HeaderText = "Role";
            roleColumn.DataPropertyName = "Role";
            passwordColumn.ReadOnly = true;
            dataGridViewEmployees.Columns.Add(roleColumn);
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
                Role = checkBoxAdmin.Checked ? "Admin" : "User"
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
                employee.Role = checkBoxAdmin.Checked ? "Admin" : "User";

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
                    ConfirmDelete();
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

        private void ConfirmDelete()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadEmployeesFromDatabase();
                MessageBox.Show("Đã xoá Nhân viên thành công.");
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

                // Disable password editing
                textBoxPassword.Text = employee.Password;
                textBoxPassword.ReadOnly = true;

                if (employee.Role == "Admin")
                {
                    checkBoxAdmin.Checked = true;
                    checkBoxUser.Checked = false;
                }
                else if (employee.Role == "User")
                {
                    checkBoxAdmin.Checked = false;
                    checkBoxUser.Checked = true;
                }
            }
        }


        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdmin.Checked)
            {
                checkBoxUser.Checked = false;
            }
        }

        private void checkBoxUser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUser.Checked)
            {
                checkBoxAdmin.Checked = false;
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