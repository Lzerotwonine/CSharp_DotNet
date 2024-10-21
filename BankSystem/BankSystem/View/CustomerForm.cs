using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankSystem.View
{
    public partial class CustomerForm : Form
    {
        // Tạo danh sách lưu trữ khách hàng
        private List<Customer> customers = new List<Customer>();

        public CustomerForm()
        {
            InitializeComponent();
        }

        // Thêm khách hàng
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text) || string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Cần nhập ID và Tên.");
                return;
            }

            // Thêm khách hàng và đưa vào danh sách
            Customer customer = new Customer()
            {
                Id = textBoxId.Text,
                Name = textBoxName.Text,
                Phone = textBoxPhone.Text,
                Email = textBoxEmail.Text,
                HouseNo = textBoxHouseNo.Text,
                City = textBoxCity.Text,
                Pin = textBoxPin.Text
            };
            customers.Add(customer);
            MessageBox.Show("Đã thêm Khách hàng.");
            ClearInputs();
        }

        // Cập nhật khách hàng
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var customer = customers.FirstOrDefault(c => c.Id == textBoxId.Text);
            if (customer != null)
            {
                customer.Name = textBoxName.Text;
                customer.Phone = textBoxPhone.Text;
                customer.Email = textBoxEmail.Text;
                customer.HouseNo = textBoxHouseNo.Text;
                customer.City = textBoxCity.Text;
                customer.Pin = textBoxPin.Text;
                MessageBox.Show("Đã cập nhật Khách hàng.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy Khách hàng.");
            }
            ClearInputs();
        }

        // Xoá khách hàng
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var customer = customers.FirstOrDefault(c => c.Id == textBoxId.Text);
            if (customer != null)
            {
                customers.Remove(customer);
                MessageBox.Show("Đã xoá Khách hàng.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy Khách hàng.");
            }
            ClearInputs();
        }

        // Xoá dữ liệu nhập
        private void ClearInputs()
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxHouseNo.Clear();
            textBoxCity.Clear();
            textBoxPin.Clear();
        }
    }
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string HouseNo { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
    }

}
