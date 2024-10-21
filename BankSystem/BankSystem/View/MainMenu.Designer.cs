using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankSystem.View
{
	partial class MainMenu
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loginMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem systemMenuItem;
		private System.Windows.Forms.ToolStripMenuItem employeeMenuItem;
		private System.Windows.Forms.ToolStripMenuItem branchMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bankingMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createCustomerMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createAccountMenuItem;
		private System.Windows.Forms.ToolStripMenuItem depositMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withdrawMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transactionMenuItem;
		private System.Windows.Forms.ToolStripMenuItem balanceMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transactionLogMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userGuideMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;

		private void InitializeComponent()
		{
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.systemMenuItem,
            this.bankingMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(960, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginMenuItem,
            this.logoutMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileMenuItem.Text = "File";
            // 
            // loginMenuItem
            // 
            this.loginMenuItem.Name = "loginMenuItem";
            this.loginMenuItem.Size = new System.Drawing.Size(139, 26);
            this.loginMenuItem.Text = "Login";
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutMenuItem.Text = "Logout";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(139, 26);
            this.exitMenuItem.Text = "Exit";
            // 
            // systemMenuItem
            // 
            this.systemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeMenuItem,
            this.branchMenuItem});
            this.systemMenuItem.Name = "systemMenuItem";
            this.systemMenuItem.Size = new System.Drawing.Size(70, 24);
            this.systemMenuItem.Text = "System";
            // 
            // employeeMenuItem
            // 
            this.employeeMenuItem.Name = "employeeMenuItem";
            this.employeeMenuItem.Size = new System.Drawing.Size(158, 26);
            this.employeeMenuItem.Text = "Employee";
            // 
            // branchMenuItem
            // 
            this.branchMenuItem.Name = "branchMenuItem";
            this.branchMenuItem.Size = new System.Drawing.Size(158, 26);
            this.branchMenuItem.Text = "Branch";
            // 
            // bankingMenuItem
            // 
            this.bankingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerMenuItem,
            this.createAccountMenuItem,
            this.depositMenuItem,
            this.withdrawMenuItem,
            this.transactionMenuItem,
            this.balanceMenuItem,
            this.transactionLogMenuItem});
            this.bankingMenuItem.Name = "bankingMenuItem";
            this.bankingMenuItem.Size = new System.Drawing.Size(76, 24);
            this.bankingMenuItem.Text = "Banking";
            // 
            // createCustomerMenuItem
            // 
            this.createCustomerMenuItem.Name = "createCustomerMenuItem";
            this.createCustomerMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createCustomerMenuItem.Text = "Create Customer";
            // 
            // createAccountMenuItem
            // 
            this.createAccountMenuItem.Name = "createAccountMenuItem";
            this.createAccountMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createAccountMenuItem.Text = "Create Account";
            // 
            // depositMenuItem
            // 
            this.depositMenuItem.Name = "depositMenuItem";
            this.depositMenuItem.Size = new System.Drawing.Size(224, 26);
            this.depositMenuItem.Text = "Deposit Amount";
            // 
            // withdrawMenuItem
            // 
            this.withdrawMenuItem.Name = "withdrawMenuItem";
            this.withdrawMenuItem.Size = new System.Drawing.Size(224, 26);
            this.withdrawMenuItem.Text = "Withdraw Amount";
            // 
            // transactionMenuItem
            // 
            this.transactionMenuItem.Name = "transactionMenuItem";
            this.transactionMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transactionMenuItem.Text = "Transaction Amount";
            // 
            // balanceMenuItem
            // 
            this.balanceMenuItem.Name = "balanceMenuItem";
            this.balanceMenuItem.Size = new System.Drawing.Size(224, 26);
            this.balanceMenuItem.Text = "Balance Account";
            // 
            // transactionLogMenuItem
            // 
            this.transactionLogMenuItem.Name = "transactionLogMenuItem";
            this.transactionLogMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transactionLogMenuItem.Text = "Transaction log";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideMenuItem,
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpMenuItem.Text = "Help";
            // 
            // userGuideMenuItem
            // 
            this.userGuideMenuItem.Name = "userGuideMenuItem";
            this.userGuideMenuItem.Size = new System.Drawing.Size(164, 26);
            this.userGuideMenuItem.Text = "User Guide";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(164, 26);
            this.aboutMenuItem.Text = "About";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}