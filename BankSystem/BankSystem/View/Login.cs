using System;
using System.Windows.Forms;

namespace BankSystem.View
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
			textBoxId.TabIndex = 0;
			textBoxPassword.TabIndex = 1;
			buttonLogin.TabIndex = 2;
			buttonLogin.Enabled = false;
			this.KeyPreview = true;
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			string id = textBoxId.Text;
			string password = textBoxPassword.Text;

			if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Vui lòng nhập ID và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (id.Length > 255)
			{
				MessageBox.Show("ID không được quá 255 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MainMenu mainMenu = (MainMenu)this.MdiParent;

			// Tài khoản mẫu
			if (id == "admin" && password == "123")
			{
				EmployeeForm employeeForm = new EmployeeForm();
				employeeForm.MdiParent = mainMenu; // Set MDI Parent
				employeeForm.StartPosition = FormStartPosition.CenterScreen; // Center in MainMenu
				employeeForm.Show();

				this.Close();
			}
			else if (id == "user" && password == "123")
			{
				CustomerForm customerForm = new CustomerForm();
				customerForm.MdiParent = mainMenu; // Set MDI Parent
				customerForm.StartPosition = FormStartPosition.CenterScreen; // Center in MainMenu
				customerForm.Show();

				this.Close();
			}
			else
			{
				MessageBox.Show("ID hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			ConfirmExit();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			textBoxId.Focus();
		}

		private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				buttonLogin_Click(sender, e);
			}
		}

		private void textBoxId_TextChanged(object sender, EventArgs e)
		{
			CheckLoginButtonState();
		}

		private void textBoxPassword_TextChanged(object sender, EventArgs e)
		{
			CheckLoginButtonState();
		}

		private void CheckLoginButtonState()
		{
			buttonLogin.Enabled = !string.IsNullOrEmpty(textBoxId.Text) && !string.IsNullOrEmpty(textBoxPassword.Text);
		}

		private void ConfirmExit()
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void Login_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				ConfirmExit();
			}
		}

		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					e.Cancel = true;
				}
			}
		}


	}
}
