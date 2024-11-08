namespace CD_Management.View
{
    partial class CustomerForm
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
            this.textBoxMaKhach = new System.Windows.Forms.TextBox();
            this.textBoxTenKhach = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.labelMaKhach = new System.Windows.Forms.Label();
            this.labelTenKhach = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelSoDienThoai = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxButton = new System.Windows.Forms.GroupBox();
            this.titleMain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMaKhach
            // 
            this.textBoxMaKhach.Location = new System.Drawing.Point(110, 32);
            this.textBoxMaKhach.Name = "textBoxMaKhach";
            this.textBoxMaKhach.Size = new System.Drawing.Size(200, 22);
            this.textBoxMaKhach.TabIndex = 0;
            // 
            // textBoxTenKhach
            // 
            this.textBoxTenKhach.Location = new System.Drawing.Point(110, 72);
            this.textBoxTenKhach.Name = "textBoxTenKhach";
            this.textBoxTenKhach.Size = new System.Drawing.Size(200, 22);
            this.textBoxTenKhach.TabIndex = 1;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(110, 112);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(200, 22);
            this.textBoxDiaChi.TabIndex = 2;
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(110, 152);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(200, 22);
            this.textBoxSoDienThoai.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(19, 51);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 30);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(19, 91);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 30);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(19, 131);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 30);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(139, 51);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 30);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(139, 91);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 30);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Bỏ";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(10, 254);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(575, 200);
            this.dataGridViewCustomer.TabIndex = 9;
            this.dataGridViewCustomer.SelectionChanged += new System.EventHandler(this.dataGridViewCustomer_SelectionChanged);
            // 
            // labelMaKhach
            // 
            this.labelMaKhach.AutoSize = true;
            this.labelMaKhach.Location = new System.Drawing.Point(12, 39);
            this.labelMaKhach.Name = "labelMaKhach";
            this.labelMaKhach.Size = new System.Drawing.Size(66, 16);
            this.labelMaKhach.TabIndex = 10;
            this.labelMaKhach.Text = "Mã Khách";
            // 
            // labelTenKhach
            // 
            this.labelTenKhach.AutoSize = true;
            this.labelTenKhach.Location = new System.Drawing.Point(12, 78);
            this.labelTenKhach.Name = "labelTenKhach";
            this.labelTenKhach.Size = new System.Drawing.Size(71, 16);
            this.labelTenKhach.TabIndex = 11;
            this.labelTenKhach.Text = "Tên Khách";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(12, 119);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(49, 16);
            this.labelDiaChi.TabIndex = 12;
            this.labelDiaChi.Text = "Địa Chỉ";
            // 
            // labelSoDienThoai
            // 
            this.labelSoDienThoai.AutoSize = true;
            this.labelSoDienThoai.Location = new System.Drawing.Point(12, 159);
            this.labelSoDienThoai.Name = "labelSoDienThoai";
            this.labelSoDienThoai.Size = new System.Drawing.Size(92, 16);
            this.labelSoDienThoai.TabIndex = 13;
            this.labelSoDienThoai.Text = "Số Điện Thoại";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.textBoxTenKhach);
            this.groupBoxDetails.Controls.Add(this.labelSoDienThoai);
            this.groupBoxDetails.Controls.Add(this.textBoxSoDienThoai);
            this.groupBoxDetails.Controls.Add(this.labelDiaChi);
            this.groupBoxDetails.Controls.Add(this.textBoxDiaChi);
            this.groupBoxDetails.Controls.Add(this.labelTenKhach);
            this.groupBoxDetails.Controls.Add(this.textBoxMaKhach);
            this.groupBoxDetails.Controls.Add(this.labelMaKhach);
            this.groupBoxDetails.Location = new System.Drawing.Point(10, 54);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(324, 194);
            this.groupBoxDetails.TabIndex = 14;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Thông tin khách hàng";
            // 
            // groupBoxButton
            // 
            this.groupBoxButton.Controls.Add(this.buttonUpdate);
            this.groupBoxButton.Controls.Add(this.buttonClear);
            this.groupBoxButton.Controls.Add(this.buttonAdd);
            this.groupBoxButton.Controls.Add(this.buttonSearch);
            this.groupBoxButton.Controls.Add(this.buttonDelete);
            this.groupBoxButton.Location = new System.Drawing.Point(350, 54);
            this.groupBoxButton.Name = "groupBoxButton";
            this.groupBoxButton.Size = new System.Drawing.Size(235, 194);
            this.groupBoxButton.TabIndex = 15;
            this.groupBoxButton.TabStop = false;
            this.groupBoxButton.Text = "Công cụ";
            // 
            // titleMain
            // 
            this.titleMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleMain.Location = new System.Drawing.Point(191, 16);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(222, 35);
            this.titleMain.TabIndex = 16;
            this.titleMain.Text = "KHÁCH HÀNG";
            // 
            // CustomerForm
            // 
            this.ClientSize = new System.Drawing.Size(599, 465);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.groupBoxButton);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.dataGridViewCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBoxButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxMaKhach;
        private System.Windows.Forms.TextBox textBoxTenKhach;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Label labelMaKhach;
        private System.Windows.Forms.Label labelTenKhach;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelSoDienThoai;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.GroupBox groupBoxButton;
        private System.Windows.Forms.Label titleMain;
    }
}
