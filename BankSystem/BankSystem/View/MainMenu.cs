using System;
using System.Windows.Forms;

namespace BankSystem.View
{
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
			this.IsMdiContainer = true;
            this.KeyPreview = true;
        }

		// Event handler for Login menu item
		private void loginMenuItem_Click(object sender, EventArgs e)
		{
			Login loginForm = new Login
			{
				MdiParent = this,
				StartPosition = FormStartPosition.CenterScreen
			};
			loginForm.Show();
		}

		// Event handler for Exit menu item
		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
