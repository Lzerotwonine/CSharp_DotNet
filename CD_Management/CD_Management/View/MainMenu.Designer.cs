using System.Windows.Forms;

namespace CD_Management.View
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cdMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stasticMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripUserLabel;
        private System.Windows.Forms.StatusStrip statusStrip;

        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stasticMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripUserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.cdMenuItem,
            this.customerMenuItem,
            this.supplierMenuItem,
            this.storageMenuItem,
            this.borrowMenuItem,
            this.returnMenuItem,
            this.stasticMenuItem});
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
            this.loginMenuItem.Click += new System.EventHandler(this.loginMenuItem_Click);
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutMenuItem.Text = "Logout";
            this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(139, 26);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // cdMenuItem
            // 
            this.cdMenuItem.Name = "cdMenuItem";
            this.cdMenuItem.Size = new System.Drawing.Size(82, 24);
            this.cdMenuItem.Text = "Băng đĩa";
            this.cdMenuItem.Click += new System.EventHandler(this.cdMenuItem_Click);
            // 
            // customerMenuItem
            // 
            this.customerMenuItem.Name = "customerMenuItem";
            this.customerMenuItem.Size = new System.Drawing.Size(103, 24);
            this.customerMenuItem.Text = "Khách Hàng";
            this.customerMenuItem.Click += new System.EventHandler(this.customerMenuItem_Click);
            // 
            // supplierMenuItem
            // 
            this.supplierMenuItem.Name = "supplierMenuItem";
            this.supplierMenuItem.Size = new System.Drawing.Size(118, 24);
            this.supplierMenuItem.Text = "Nhà Cung Cấp";
            this.supplierMenuItem.Click += new System.EventHandler(this.supplierMenuItem_Click);
            // 
            // storageMenuItem
            // 
            this.storageMenuItem.Name = "storageMenuItem";
            this.storageMenuItem.Size = new System.Drawing.Size(49, 24);
            this.storageMenuItem.Text = "Kho";
            // 
            // borrowMenuItem
            // 
            this.borrowMenuItem.Name = "borrowMenuItem";
            this.borrowMenuItem.Size = new System.Drawing.Size(102, 24);
            this.borrowMenuItem.Text = "Phiếu Mượn";
            // 
            // returnMenuItem
            // 
            this.returnMenuItem.Name = "returnMenuItem";
            this.returnMenuItem.Size = new System.Drawing.Size(83, 24);
            this.returnMenuItem.Text = "Phiếu Trả";
            // 
            // stasticMenuItem
            // 
            this.stasticMenuItem.Name = "stasticMenuItem";
            this.stasticMenuItem.Size = new System.Drawing.Size(86, 24);
            this.stasticMenuItem.Text = "Thống Kê";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUserLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 698);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(960, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripUserLabel
            // 
            this.toolStripUserLabel.Name = "toolStripUserLabel";
            this.toolStripUserLabel.Size = new System.Drawing.Size(0, 16);
            this.toolStripUserLabel.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}