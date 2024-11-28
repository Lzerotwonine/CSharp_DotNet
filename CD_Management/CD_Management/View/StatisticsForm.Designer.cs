namespace CD_Management.View
{
    partial class StatisticsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridViewStatistics = new System.Windows.Forms.DataGridView();
            this.toolStripMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemProductsInStock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOverdueReceipts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBorrowingCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBorrowedProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStatistics
            // 
            this.dataGridViewStatistics.AllowUserToAddRows = false;
            this.dataGridViewStatistics.AllowUserToDeleteRows = false;
            this.dataGridViewStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistics.Location = new System.Drawing.Point(12, 31);
            this.dataGridViewStatistics.Name = "dataGridViewStatistics";
            this.dataGridViewStatistics.RowHeadersWidth = 51;
            this.dataGridViewStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStatistics.Size = new System.Drawing.Size(760, 400);
            this.dataGridViewStatistics.TabIndex = 0;
            this.dataGridViewStatistics.SelectionChanged += new System.EventHandler(this.dataGridViewStatistics_SelectionChanged);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemProductsInStock,
            this.toolStripMenuItemOverdueReceipts,
            this.toolStripMenuItemBorrowingCustomers,
            this.toolStripMenuItemBorrowedProducts});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(784, 24);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItemProductsInStock
            // 
            this.toolStripMenuItemProductsInStock.Name = "toolStripMenuItemProductsInStock";
            this.toolStripMenuItemProductsInStock.Size = new System.Drawing.Size(127, 20);
            this.toolStripMenuItemProductsInStock.Text = "Sản phẩm trong kho";
            this.toolStripMenuItemProductsInStock.Click += new System.EventHandler(this.toolStripMenuItemProductsInStock_Click);
            // 
            // toolStripMenuItemOverdueReceipts
            // 
            this.toolStripMenuItemOverdueReceipts.Name = "toolStripMenuItemOverdueReceipts";
            this.toolStripMenuItemOverdueReceipts.Size = new System.Drawing.Size(112, 20);
            this.toolStripMenuItemOverdueReceipts.Text = "Phiếu quá hạn trả";
            this.toolStripMenuItemOverdueReceipts.Click += new System.EventHandler(this.toolStripMenuItemOverdueReceipts_Click);
            // 
            // toolStripMenuItemBorrowingCustomers
            // 
            this.toolStripMenuItemBorrowingCustomers.Name = "toolStripMenuItemBorrowingCustomers";
            this.toolStripMenuItemBorrowingCustomers.Size = new System.Drawing.Size(133, 20);
            this.toolStripMenuItemBorrowingCustomers.Text = "Khách hàng đã mượn";
            this.toolStripMenuItemBorrowingCustomers.Click += new System.EventHandler(this.toolStripMenuItemBorrowingCustomers_Click);
            // 
            // toolStripMenuItemBorrowedProducts
            // 
            this.toolStripMenuItemBorrowedProducts.Name = "toolStripMenuItemBorrowedProducts";
            this.toolStripMenuItemBorrowedProducts.Size = new System.Drawing.Size(123, 20);
            this.toolStripMenuItemBorrowedProducts.Text = "Sản phẩm đã mượn";
            this.toolStripMenuItemBorrowedProducts.Click += new System.EventHandler(this.toolStripMenuItemBorrowedProducts_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(326, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.label1);
            this.groupBoxDetails.Controls.Add(this.textBoxSearch);
            this.groupBoxDetails.Controls.Add(this.btnExportToExcel);
            this.groupBoxDetails.Controls.Add(this.btnSearch);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 437);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(760, 103);
            this.groupBoxDetails.TabIndex = 13;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Công cụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vui lòng nhập ID";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(175, 45);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(128, 20);
            this.textBoxSearch.TabIndex = 14;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(432, 34);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(122, 40);
            this.btnExportToExcel.TabIndex = 5;
            this.btnExportToExcel.Text = "Xuất ra Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // StatisticsForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 569);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.dataGridViewStatistics);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.toolStripMenu;
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStatistics;
        private System.Windows.Forms.MenuStrip toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProductsInStock;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOverdueReceipts;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBorrowingCustomers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBorrowedProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxDetails;

        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}
