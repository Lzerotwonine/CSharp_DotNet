namespace CD_Management.View
{
    partial class RentalRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxRentalDetails = new System.Windows.Forms.GroupBox();
            this.txtIdPM = new System.Windows.Forms.TextBox();
            this.dateNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dateNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ccbIdKH = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNameKH = new System.Windows.Forms.TextBox();
            this.groupBoxCDList = new System.Windows.Forms.GroupBox();
            this.dataGridCD = new System.Windows.Forms.DataGridView();
            this.groupBoxCDDetails = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtCoc = new System.Windows.Forms.TextBox();
            this.ccbMaBang = new System.Windows.Forms.ComboBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtTenBang = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.groupBoxTotal = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.titleMain = new System.Windows.Forms.Label();
            this.groupBoxRentalDetails.SuspendLayout();
            this.groupBoxCustomerDetails.SuspendLayout();
            this.groupBoxCDList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCD)).BeginInit();
            this.groupBoxCDDetails.SuspendLayout();
            this.groupBoxTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRentalDetails
            // 
            this.groupBoxRentalDetails.Controls.Add(this.txtIdPM);
            this.groupBoxRentalDetails.Controls.Add(this.dateNgayTra);
            this.groupBoxRentalDetails.Controls.Add(this.dateNgayMuon);
            this.groupBoxRentalDetails.Controls.Add(this.label5);
            this.groupBoxRentalDetails.Controls.Add(this.label6);
            this.groupBoxRentalDetails.Controls.Add(this.label7);
            this.groupBoxRentalDetails.Location = new System.Drawing.Point(10, 82);
            this.groupBoxRentalDetails.Name = "groupBoxRentalDetails";
            this.groupBoxRentalDetails.Size = new System.Drawing.Size(242, 162);
            this.groupBoxRentalDetails.TabIndex = 0;
            this.groupBoxRentalDetails.TabStop = false;
            this.groupBoxRentalDetails.Text = "Thông tin phiếu mượn";
            // 
            // txtIdPM
            // 
            this.txtIdPM.Location = new System.Drawing.Point(99, 36);
            this.txtIdPM.Name = "txtIdPM";
            this.txtIdPM.ReadOnly = true;
            this.txtIdPM.Size = new System.Drawing.Size(121, 20);
            this.txtIdPM.TabIndex = 7;
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTra.Location = new System.Drawing.Point(99, 97);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(121, 20);
            this.dateNgayTra.TabIndex = 6;
            // 
            // dateNgayMuon
            // 
            this.dateNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayMuon.Location = new System.Drawing.Point(99, 67);
            this.dateNgayMuon.Name = "dateNgayMuon";
            this.dateNgayMuon.Size = new System.Drawing.Size(121, 20);
            this.dateNgayMuon.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã phiếu mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày mượn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày trả";
            // 
            // groupBoxCustomerDetails
            // 
            this.groupBoxCustomerDetails.Controls.Add(this.label4);
            this.groupBoxCustomerDetails.Controls.Add(this.label3);
            this.groupBoxCustomerDetails.Controls.Add(this.label2);
            this.groupBoxCustomerDetails.Controls.Add(this.label1);
            this.groupBoxCustomerDetails.Controls.Add(this.ccbIdKH);
            this.groupBoxCustomerDetails.Controls.Add(this.txtPhone);
            this.groupBoxCustomerDetails.Controls.Add(this.txtAddress);
            this.groupBoxCustomerDetails.Controls.Add(this.txtNameKH);
            this.groupBoxCustomerDetails.Location = new System.Drawing.Point(258, 82);
            this.groupBoxCustomerDetails.Name = "groupBoxCustomerDetails";
            this.groupBoxCustomerDetails.Size = new System.Drawing.Size(291, 162);
            this.groupBoxCustomerDetails.TabIndex = 0;
            this.groupBoxCustomerDetails.TabStop = false;
            this.groupBoxCustomerDetails.Text = "Thông tin khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khach hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã khách hàng";
            // 
            // ccbIdKH
            // 
            this.ccbIdKH.FormattingEnabled = true;
            this.ccbIdKH.Location = new System.Drawing.Point(134, 36);
            this.ccbIdKH.Name = "ccbIdKH";
            this.ccbIdKH.Size = new System.Drawing.Size(151, 21);
            this.ccbIdKH.TabIndex = 4;
            this.ccbIdKH.SelectedIndexChanged += new System.EventHandler(this.ccbIdKH_SelectedIndexChanged_1);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(134, 127);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(151, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(134, 97);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(151, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // txtNameKH
            // 
            this.txtNameKH.Location = new System.Drawing.Point(134, 67);
            this.txtNameKH.Name = "txtNameKH";
            this.txtNameKH.ReadOnly = true;
            this.txtNameKH.Size = new System.Drawing.Size(151, 20);
            this.txtNameKH.TabIndex = 1;
            // 
            // groupBoxCDList
            // 
            this.groupBoxCDList.Controls.Add(this.dataGridCD);
            this.groupBoxCDList.Location = new System.Drawing.Point(10, 246);
            this.groupBoxCDList.Name = "groupBoxCDList";
            this.groupBoxCDList.Size = new System.Drawing.Size(539, 219);
            this.groupBoxCDList.TabIndex = 1;
            this.groupBoxCDList.TabStop = false;
            this.groupBoxCDList.Text = "Danh sách mượn hàng";
            // 
            // dataGridCD
            // 
            this.dataGridCD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCD.Location = new System.Drawing.Point(3, 16);
            this.dataGridCD.Name = "dataGridCD";
            this.dataGridCD.RowHeadersWidth = 51;
            this.dataGridCD.Size = new System.Drawing.Size(533, 200);
            this.dataGridCD.TabIndex = 0;
            this.dataGridCD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCD_CellDoubleClick);
            // 
            // groupBoxCDDetails
            // 
            this.groupBoxCDDetails.Controls.Add(this.btnSave);
            this.groupBoxCDDetails.Controls.Add(this.btnAdd);
            this.groupBoxCDDetails.Controls.Add(this.label15);
            this.groupBoxCDDetails.Controls.Add(this.label14);
            this.groupBoxCDDetails.Controls.Add(this.label13);
            this.groupBoxCDDetails.Controls.Add(this.label12);
            this.groupBoxCDDetails.Controls.Add(this.label11);
            this.groupBoxCDDetails.Controls.Add(this.label9);
            this.groupBoxCDDetails.Controls.Add(this.label8);
            this.groupBoxCDDetails.Controls.Add(this.label10);
            this.groupBoxCDDetails.Controls.Add(this.txtTacGia);
            this.groupBoxCDDetails.Controls.Add(this.txtTienCoc);
            this.groupBoxCDDetails.Controls.Add(this.txtSoLuong);
            this.groupBoxCDDetails.Controls.Add(this.txtCoc);
            this.groupBoxCDDetails.Controls.Add(this.ccbMaBang);
            this.groupBoxCDDetails.Controls.Add(this.txtTheLoai);
            this.groupBoxCDDetails.Controls.Add(this.txtTenBang);
            this.groupBoxCDDetails.Controls.Add(this.txtDonGia);
            this.groupBoxCDDetails.Location = new System.Drawing.Point(555, 82);
            this.groupBoxCDDetails.Name = "groupBoxCDDetails";
            this.groupBoxCDDetails.Size = new System.Drawing.Size(256, 445);
            this.groupBoxCDDetails.TabIndex = 1;
            this.groupBoxCDDetails.TabStop = false;
            this.groupBoxCDDetails.Text = "Thông tin băng đĩa";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(165, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 389);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 336);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Tên tác giả";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Tiền cọc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Phần trăm cọc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Thể loại băng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tên băng đĩa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mã băng đĩa";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(92, 333);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.ReadOnly = true;
            this.txtTacGia.Size = new System.Drawing.Size(151, 20);
            this.txtTacGia.TabIndex = 16;
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(92, 289);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.ReadOnly = true;
            this.txtTienCoc.Size = new System.Drawing.Size(151, 20);
            this.txtTienCoc.TabIndex = 15;
            this.txtTienCoc.TextChanged += new System.EventHandler(this.txtTienCoc_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(92, 201);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(151, 20);
            this.txtSoLuong.TabIndex = 13;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtCoc
            // 
            this.txtCoc.Location = new System.Drawing.Point(92, 245);
            this.txtCoc.Name = "txtCoc";
            this.txtCoc.ReadOnly = true;
            this.txtCoc.Size = new System.Drawing.Size(151, 20);
            this.txtCoc.TabIndex = 14;
            this.txtCoc.TextChanged += new System.EventHandler(this.txtCoc_TextChanged);
            // 
            // ccbMaBang
            // 
            this.ccbMaBang.FormattingEnabled = true;
            this.ccbMaBang.Location = new System.Drawing.Point(92, 24);
            this.ccbMaBang.Name = "ccbMaBang";
            this.ccbMaBang.Size = new System.Drawing.Size(151, 21);
            this.ccbMaBang.TabIndex = 12;
            this.ccbMaBang.SelectedIndexChanged += new System.EventHandler(this.ccbMaBang_SelectedIndexChanged_1);
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(92, 157);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.ReadOnly = true;
            this.txtTheLoai.Size = new System.Drawing.Size(151, 20);
            this.txtTheLoai.TabIndex = 11;
            // 
            // txtTenBang
            // 
            this.txtTenBang.Location = new System.Drawing.Point(92, 69);
            this.txtTenBang.Name = "txtTenBang";
            this.txtTenBang.ReadOnly = true;
            this.txtTenBang.Size = new System.Drawing.Size(151, 20);
            this.txtTenBang.TabIndex = 9;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(92, 113);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(151, 20);
            this.txtDonGia.TabIndex = 10;
            // 
            // groupBoxTotal
            // 
            this.groupBoxTotal.Controls.Add(this.txtTongTien);
            this.groupBoxTotal.Controls.Add(this.labelTotal);
            this.groupBoxTotal.Location = new System.Drawing.Point(13, 471);
            this.groupBoxTotal.Name = "groupBoxTotal";
            this.groupBoxTotal.Size = new System.Drawing.Size(536, 57);
            this.groupBoxTotal.TabIndex = 2;
            this.groupBoxTotal.TabStop = false;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTongTien.Location = new System.Drawing.Point(276, 15);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(189, 29);
            this.txtTongTien.TabIndex = 5;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.IndianRed;
            this.labelTotal.Location = new System.Drawing.Point(177, 18);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(99, 24);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Tổng tiền";
            // 
            // titleMain
            // 
            this.titleMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleMain.Location = new System.Drawing.Point(338, 19);
            this.titleMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(171, 29);
            this.titleMain.TabIndex = 14;
            this.titleMain.Text = "PHIẾU MƯỢN";
            // 
            // RentalRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(822, 538);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.groupBoxTotal);
            this.Controls.Add(this.groupBoxCDDetails);
            this.Controls.Add(this.groupBoxCDList);
            this.Controls.Add(this.groupBoxCustomerDetails);
            this.Controls.Add(this.groupBoxRentalDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentalRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Mượn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRentalDetails.ResumeLayout(false);
            this.groupBoxRentalDetails.PerformLayout();
            this.groupBoxCustomerDetails.ResumeLayout(false);
            this.groupBoxCustomerDetails.PerformLayout();
            this.groupBoxCDList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCD)).EndInit();
            this.groupBoxCDDetails.ResumeLayout(false);
            this.groupBoxCDDetails.PerformLayout();
            this.groupBoxTotal.ResumeLayout(false);
            this.groupBoxTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRentalDetails;
        private System.Windows.Forms.GroupBox groupBoxCustomerDetails;
        private System.Windows.Forms.GroupBox groupBoxCDList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ccbIdKH;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNameKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateNgayTra;
        private System.Windows.Forms.DateTimePicker dateNgayMuon;
        private System.Windows.Forms.DataGridView dataGridCD;
        private System.Windows.Forms.GroupBox groupBoxCDDetails;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtCoc;
        private System.Windows.Forms.ComboBox ccbMaBang;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtTenBang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.GroupBox groupBoxTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtIdPM;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label titleMain;
    }
}

