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
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
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
            this.toolStripMenu.Size = new System.Drawing.Size(784, 28);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItemProductsInStock
            // 
            this.toolStripMenuItemProductsInStock.Name = "toolStripMenuItemProductsInStock";
            this.toolStripMenuItemProductsInStock.Size = new System.Drawing.Size(157, 24);
            this.toolStripMenuItemProductsInStock.Text = "Sản phẩm trong kho";
            this.toolStripMenuItemProductsInStock.Click += new System.EventHandler(this.toolStripMenuItemProductsInStock_Click);
            // 
            // toolStripMenuItemOverdueReceipts
            // 
            this.toolStripMenuItemOverdueReceipts.Name = "toolStripMenuItemOverdueReceipts";
            this.toolStripMenuItemOverdueReceipts.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItemOverdueReceipts.Text = "Phiếu quá hạn trả";
            this.toolStripMenuItemOverdueReceipts.Click += new System.EventHandler(this.toolStripMenuItemOverdueReceipts_Click);
            // 
            // toolStripMenuItemBorrowingCustomers
            // 
            this.toolStripMenuItemBorrowingCustomers.Name = "toolStripMenuItemBorrowingCustomers";
            this.toolStripMenuItemBorrowingCustomers.Size = new System.Drawing.Size(164, 24);
            this.toolStripMenuItemBorrowingCustomers.Text = "Khách hàng đã mượn";
            this.toolStripMenuItemBorrowingCustomers.Click += new System.EventHandler(this.toolStripMenuItemBorrowingCustomers_Click);
            // 
            // toolStripMenuItemBorrowedProducts
            // 
            this.toolStripMenuItemBorrowedProducts.Name = "toolStripMenuItemBorrowedProducts";
            this.toolStripMenuItemBorrowedProducts.Size = new System.Drawing.Size(153, 24);
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
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(174, 43);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(128, 24);
            this.comboBoxSearch.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(432, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.comboBoxSearch);
            this.groupBoxDetails.Controls.Add(this.btnDelete);
            this.groupBoxDetails.Controls.Add(this.btnSearch);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 437);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(760, 103);
            this.groupBoxDetails.TabIndex = 13;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Công cụ";
            // 
            // StatisticsForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 569);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.dataGridViewStatistics);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MainMenuStrip = this.toolStripMenu;
            this.Name = "StatisticsForm";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBoxDetails;
    }
}
