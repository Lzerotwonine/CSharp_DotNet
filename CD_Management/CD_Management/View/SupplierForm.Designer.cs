namespace CD_Management.View
{
    partial class SupplierForm
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

        private void InitializeComponent()
        {
            this.textBoxMaNCC = new System.Windows.Forms.TextBox();
            this.textBoxTenNCC = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.groupBoxButton = new System.Windows.Forms.GroupBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.labelSoDienThoai = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelTenNCC = new System.Windows.Forms.Label();
            this.labelMaNCC = new System.Windows.Forms.Label();
            this.titleMain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.groupBoxButton.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMaNCC
            // 
            this.textBoxMaNCC.Location = new System.Drawing.Point(144, 25);
            this.textBoxMaNCC.Name = "textBoxMaNCC";
            this.textBoxMaNCC.Size = new System.Drawing.Size(200, 22);
            this.textBoxMaNCC.TabIndex = 0;
            // 
            // textBoxTenNCC
            // 
            this.textBoxTenNCC.Location = new System.Drawing.Point(144, 65);
            this.textBoxTenNCC.Name = "textBoxTenNCC";
            this.textBoxTenNCC.Size = new System.Drawing.Size(200, 22);
            this.textBoxTenNCC.TabIndex = 1;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(144, 105);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(200, 22);
            this.textBoxDiaChi.TabIndex = 2;
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(144, 145);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(200, 22);
            this.textBoxSoDienThoai.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(18, 48);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 30);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(18, 88);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 30);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(18, 128);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 30);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Xoá";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(138, 48);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 30);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(138, 88);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 30);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Bỏ";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuppliers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(12, 253);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.RowHeadersWidth = 51;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(594, 218);
            this.dataGridViewSuppliers.TabIndex = 9;
            this.dataGridViewSuppliers.SelectionChanged += new System.EventHandler(this.dataGridViewSuppliers_SelectionChanged);
            // 
            // groupBoxButton
            // 
            this.groupBoxButton.Controls.Add(this.buttonAdd);
            this.groupBoxButton.Controls.Add(this.buttonClear);
            this.groupBoxButton.Controls.Add(this.buttonSearch);
            this.groupBoxButton.Controls.Add(this.buttonDelete);
            this.groupBoxButton.Controls.Add(this.buttonUpdate);
            this.groupBoxButton.Location = new System.Drawing.Point(378, 63);
            this.groupBoxButton.Name = "groupBoxButton";
            this.groupBoxButton.Size = new System.Drawing.Size(228, 184);
            this.groupBoxButton.TabIndex = 10;
            this.groupBoxButton.TabStop = false;
            this.groupBoxButton.Text = "Công cụ";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.labelSoDienThoai);
            this.groupBoxDetails.Controls.Add(this.labelDiaChi);
            this.groupBoxDetails.Controls.Add(this.labelTenNCC);
            this.groupBoxDetails.Controls.Add(this.labelMaNCC);
            this.groupBoxDetails.Controls.Add(this.textBoxMaNCC);
            this.groupBoxDetails.Controls.Add(this.textBoxSoDienThoai);
            this.groupBoxDetails.Controls.Add(this.textBoxDiaChi);
            this.groupBoxDetails.Controls.Add(this.textBoxTenNCC);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 63);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(360, 184);
            this.groupBoxDetails.TabIndex = 11;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Thông tin nhà cung cấp";
            // 
            // labelSoDienThoai
            // 
            this.labelSoDienThoai.AutoSize = true;
            this.labelSoDienThoai.Location = new System.Drawing.Point(17, 148);
            this.labelSoDienThoai.Name = "labelSoDienThoai";
            this.labelSoDienThoai.Size = new System.Drawing.Size(92, 16);
            this.labelSoDienThoai.TabIndex = 7;
            this.labelSoDienThoai.Text = "Số Điện Thoại";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(17, 108);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(49, 16);
            this.labelDiaChi.TabIndex = 6;
            this.labelDiaChi.Text = "Địa Chỉ";
            // 
            // labelTenNCC
            // 
            this.labelTenNCC.AutoSize = true;
            this.labelTenNCC.Location = new System.Drawing.Point(17, 68);
            this.labelTenNCC.Name = "labelTenNCC";
            this.labelTenNCC.Size = new System.Drawing.Size(121, 16);
            this.labelTenNCC.TabIndex = 5;
            this.labelTenNCC.Text = "Tên Nhà Cung Cấp";
            // 
            // labelMaNCC
            // 
            this.labelMaNCC.AutoSize = true;
            this.labelMaNCC.Location = new System.Drawing.Point(17, 28);
            this.labelMaNCC.Name = "labelMaNCC";
            this.labelMaNCC.Size = new System.Drawing.Size(116, 16);
            this.labelMaNCC.TabIndex = 4;
            this.labelMaNCC.Text = "Mã Nhà Cung Cấp";
            // 
            // titleMain
            // 
            this.titleMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleMain.Location = new System.Drawing.Point(179, 18);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(249, 35);
            this.titleMain.TabIndex = 12;
            this.titleMain.Text = "NHÀ CUNG CẤP";
            this.titleMain.UseWaitCursor = true;
            // 
            // SupplierForm
            // 
            this.ClientSize = new System.Drawing.Size(618, 481);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxButton);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Name = "SupplierForm";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.groupBoxButton.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxMaNCC;
        private System.Windows.Forms.TextBox textBoxTenNCC;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.GroupBox groupBoxButton;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label labelTenNCC;
        private System.Windows.Forms.Label labelMaNCC;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelSoDienThoai;
        private System.Windows.Forms.Label titleMain;
    }
}
