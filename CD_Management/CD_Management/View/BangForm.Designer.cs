using System.Windows.Forms;

namespace CD_Management.View
{
    partial class BangForm
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


        private System.Windows.Forms.TextBox textBoxMaBang;
        private System.Windows.Forms.TextBox textBoxTenBang;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.TextBox textBoxDonGiaBan;
        private System.Windows.Forms.TextBox textBoxTheLoai;
        private System.Windows.Forms.TextBox textBoxTacGia;

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;

        private System.Windows.Forms.DataGridView dataGridViewBang;

        private System.Windows.Forms.Label labelMaBang;
        private System.Windows.Forms.Label labelTenBang;
        private System.Windows.Forms.Label labelSoLuong;
        private System.Windows.Forms.Label labelDonGiaBan;
        private System.Windows.Forms.Label labelTheLoai;
        private System.Windows.Forms.Label labelTacGia;

        private System.Windows.Forms.GroupBox groupBoxDetails;

        private void InitializeComponent()
        {
            this.textBoxMaBang = new System.Windows.Forms.TextBox();
            this.textBoxTenBang = new System.Windows.Forms.TextBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.textBoxDonGiaBan = new System.Windows.Forms.TextBox();
            this.textBoxTheLoai = new System.Windows.Forms.TextBox();
            this.textBoxTacGia = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewBang = new System.Windows.Forms.DataGridView();
            this.labelMaBang = new System.Windows.Forms.Label();
            this.labelTenBang = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.labelDonGiaBan = new System.Windows.Forms.Label();
            this.labelTheLoai = new System.Windows.Forms.Label();
            this.labelTacGia = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxButton = new System.Windows.Forms.GroupBox();
            this.titleMain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBang)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMaBang
            // 
            this.textBoxMaBang.Location = new System.Drawing.Point(100, 32);
            this.textBoxMaBang.Name = "textBoxMaBang";
            this.textBoxMaBang.Size = new System.Drawing.Size(200, 22);
            this.textBoxMaBang.TabIndex = 0;
            this.textBoxMaBang.ReadOnly = true;
            // 
            // textBoxTenBang
            // 
            this.textBoxTenBang.Location = new System.Drawing.Point(100, 72);
            this.textBoxTenBang.Name = "textBoxTenBang";
            this.textBoxTenBang.Size = new System.Drawing.Size(200, 22);
            this.textBoxTenBang.TabIndex = 1;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(100, 112);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(200, 22);
            this.textBoxSoLuong.TabIndex = 2;
            // 
            // textBoxDonGiaBan
            // 
            this.textBoxDonGiaBan.Location = new System.Drawing.Point(411, 32);
            this.textBoxDonGiaBan.Name = "textBoxDonGiaBan";
            this.textBoxDonGiaBan.Size = new System.Drawing.Size(200, 22);
            this.textBoxDonGiaBan.TabIndex = 3;
            // 
            // textBoxTheLoai
            // 
            this.textBoxTheLoai.Location = new System.Drawing.Point(411, 72);
            this.textBoxTheLoai.Name = "textBoxTheLoai";
            this.textBoxTheLoai.Size = new System.Drawing.Size(200, 22);
            this.textBoxTheLoai.TabIndex = 4;
            // 
            // textBoxTacGia
            // 
            this.textBoxTacGia.Location = new System.Drawing.Point(411, 112);
            this.textBoxTacGia.Name = "textBoxTacGia";
            this.textBoxTacGia.Size = new System.Drawing.Size(200, 22);
            this.textBoxTacGia.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 28);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 30);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(16, 68);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 30);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(16, 108);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 30);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Xoá";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(129, 31);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 30);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(129, 71);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 30);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Bỏ";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridViewBang
            // 
            this.dataGridViewBang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBang.Location = new System.Drawing.Point(12, 237);
            this.dataGridViewBang.Name = "dataGridViewBang";
            this.dataGridViewBang.RowHeadersWidth = 51;
            this.dataGridViewBang.RowTemplate.Height = 24;
            this.dataGridViewBang.Size = new System.Drawing.Size(876, 295);
            this.dataGridViewBang.TabIndex = 11;
            this.dataGridViewBang.SelectionChanged += new System.EventHandler(this.dataGridViewBang_SelectionChanged);
            // 
            // labelMaBang
            // 
            this.labelMaBang.AutoSize = true;
            this.labelMaBang.Location = new System.Drawing.Point(20, 32);
            this.labelMaBang.Name = "labelMaBang";
            this.labelMaBang.Size = new System.Drawing.Size(61, 16);
            this.labelMaBang.TabIndex = 12;
            this.labelMaBang.Text = "Mã Băng";
            // 
            // labelTenBang
            // 
            this.labelTenBang.AutoSize = true;
            this.labelTenBang.Location = new System.Drawing.Point(20, 72);
            this.labelTenBang.Name = "labelTenBang";
            this.labelTenBang.Size = new System.Drawing.Size(66, 16);
            this.labelTenBang.TabIndex = 13;
            this.labelTenBang.Text = "Tên Băng";
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Location = new System.Drawing.Point(20, 112);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(64, 16);
            this.labelSoLuong.TabIndex = 14;
            this.labelSoLuong.Text = "Số Lượng";
            // 
            // labelDonGiaBan
            // 
            this.labelDonGiaBan.AutoSize = true;
            this.labelDonGiaBan.Location = new System.Drawing.Point(331, 32);
            this.labelDonGiaBan.Name = "labelDonGiaBan";
            this.labelDonGiaBan.Size = new System.Drawing.Size(82, 16);
            this.labelDonGiaBan.TabIndex = 15;
            this.labelDonGiaBan.Text = "Đơn Giá Bán";
            // 
            // labelTheLoai
            // 
            this.labelTheLoai.AutoSize = true;
            this.labelTheLoai.Location = new System.Drawing.Point(331, 72);
            this.labelTheLoai.Name = "labelTheLoai";
            this.labelTheLoai.Size = new System.Drawing.Size(60, 16);
            this.labelTheLoai.TabIndex = 16;
            this.labelTheLoai.Text = "Thể Loại";
            // 
            // labelTacGia
            // 
            this.labelTacGia.AutoSize = true;
            this.labelTacGia.Location = new System.Drawing.Point(331, 112);
            this.labelTacGia.Name = "labelTacGia";
            this.labelTacGia.Size = new System.Drawing.Size(55, 16);
            this.labelTacGia.TabIndex = 17;
            this.labelTacGia.Text = "Tác Giả";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.textBoxMaBang);
            this.groupBoxDetails.Controls.Add(this.textBoxTenBang);
            this.groupBoxDetails.Controls.Add(this.labelTacGia);
            this.groupBoxDetails.Controls.Add(this.textBoxSoLuong);
            this.groupBoxDetails.Controls.Add(this.labelTheLoai);
            this.groupBoxDetails.Controls.Add(this.textBoxDonGiaBan);
            this.groupBoxDetails.Controls.Add(this.labelDonGiaBan);
            this.groupBoxDetails.Controls.Add(this.textBoxTheLoai);
            this.groupBoxDetails.Controls.Add(this.labelSoLuong);
            this.groupBoxDetails.Controls.Add(this.textBoxTacGia);
            this.groupBoxDetails.Controls.Add(this.labelTenBang);
            this.groupBoxDetails.Controls.Add(this.labelMaBang);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 79);
            this.groupBoxDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDetails.Size = new System.Drawing.Size(636, 153);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Thông tin băng đĩa";
            // 
            // groupBoxButton
            // 
            this.groupBoxButton.Controls.Add(this.buttonAdd);
            this.groupBoxButton.Controls.Add(this.buttonClear);
            this.groupBoxButton.Controls.Add(this.buttonUpdate);
            this.groupBoxButton.Controls.Add(this.buttonSearch);
            this.groupBoxButton.Controls.Add(this.buttonDelete);
            this.groupBoxButton.Location = new System.Drawing.Point(664, 79);
            this.groupBoxButton.Name = "groupBoxButton";
            this.groupBoxButton.Size = new System.Drawing.Size(224, 152);
            this.groupBoxButton.TabIndex = 12;
            this.groupBoxButton.TabStop = false;
            this.groupBoxButton.Text = "Công cụ";
            // 
            // titleMain
            // 
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleMain.Location = new System.Drawing.Point(368, 23);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(161, 35);
            this.titleMain.TabIndex = 13;
            this.titleMain.Text = "BĂNG ĐĨA";
            // 
            // BangForm
            // 
            this.ClientSize = new System.Drawing.Size(903, 544);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.groupBoxButton);
            this.Controls.Add(this.dataGridViewBang);
            this.Controls.Add(this.groupBoxDetails);
            this.Name = "BangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin băng đĩa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBang)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBoxButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private GroupBox groupBoxButton;
        private Label titleMain;
    }
}
