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
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxTotal = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.groupBoxRentalDetails.Location = new System.Drawing.Point(13, 101);
            this.groupBoxRentalDetails.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRentalDetails.Name = "groupBoxRentalDetails";
            this.groupBoxRentalDetails.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRentalDetails.Size = new System.Drawing.Size(323, 199);
            this.groupBoxRentalDetails.TabIndex = 0;
            this.groupBoxRentalDetails.TabStop = false;
            this.groupBoxRentalDetails.Text = "Thông tin phiếu mượn";
            // 
            // txtIdPM
            // 
            this.txtIdPM.Location = new System.Drawing.Point(132, 44);
            this.txtIdPM.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPM.Name = "txtIdPM";
            this.txtIdPM.ReadOnly = true;
            this.txtIdPM.Size = new System.Drawing.Size(160, 22);
            this.txtIdPM.TabIndex = 7;
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayTra.Location = new System.Drawing.Point(132, 119);
            this.dateNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Size = new System.Drawing.Size(160, 22);
            this.dateNgayTra.TabIndex = 6;
            // 
            // dateNgayMuon
            // 
            this.dateNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayMuon.Location = new System.Drawing.Point(132, 82);
            this.dateNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgayMuon.Name = "dateNgayMuon";
            this.dateNgayMuon.Size = new System.Drawing.Size(160, 22);
            this.dateNgayMuon.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã phiếu mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày mượn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
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
            this.groupBoxCustomerDetails.Location = new System.Drawing.Point(344, 101);
            this.groupBoxCustomerDetails.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCustomerDetails.Name = "groupBoxCustomerDetails";
            this.groupBoxCustomerDetails.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCustomerDetails.Size = new System.Drawing.Size(388, 199);
            this.groupBoxCustomerDetails.TabIndex = 0;
            this.groupBoxCustomerDetails.TabStop = false;
            this.groupBoxCustomerDetails.Text = "Thông tin khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khach hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã khách hàng";
            // 
            // ccbIdKH
            // 
            this.ccbIdKH.FormattingEnabled = true;
            this.ccbIdKH.Location = new System.Drawing.Point(179, 44);
            this.ccbIdKH.Margin = new System.Windows.Forms.Padding(4);
            this.ccbIdKH.Name = "ccbIdKH";
            this.ccbIdKH.Size = new System.Drawing.Size(200, 24);
            this.ccbIdKH.TabIndex = 4;
            this.ccbIdKH.SelectedIndexChanged += new System.EventHandler(this.ccbIdKH_SelectedIndexChanged_1);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(179, 156);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(179, 119);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // txtNameKH
            // 
            this.txtNameKH.Location = new System.Drawing.Point(179, 82);
            this.txtNameKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameKH.Name = "txtNameKH";
            this.txtNameKH.ReadOnly = true;
            this.txtNameKH.Size = new System.Drawing.Size(200, 22);
            this.txtNameKH.TabIndex = 1;
            // 
            // groupBoxCDList
            // 
            this.groupBoxCDList.Controls.Add(this.dataGridCD);
            this.groupBoxCDList.Location = new System.Drawing.Point(13, 303);
            this.groupBoxCDList.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCDList.Name = "groupBoxCDList";
            this.groupBoxCDList.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCDList.Size = new System.Drawing.Size(719, 269);
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
            this.dataGridCD.Location = new System.Drawing.Point(4, 19);
            this.dataGridCD.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridCD.Name = "dataGridCD";
            this.dataGridCD.RowHeadersWidth = 51;
            this.dataGridCD.Size = new System.Drawing.Size(711, 246);
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
            this.groupBoxCDDetails.Location = new System.Drawing.Point(740, 101);
            this.groupBoxCDDetails.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCDDetails.Name = "groupBoxCDDetails";
            this.groupBoxCDDetails.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCDDetails.Size = new System.Drawing.Size(342, 548);
            this.groupBoxCDDetails.TabIndex = 1;
            this.groupBoxCDDetails.TabStop = false;
            this.groupBoxCDDetails.Text = "Thông tin băng đĩa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 413);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "Tên tác giả";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 359);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Tiền cọc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 305);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Phần trăm cọc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 256);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 196);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Thể loại băng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 143);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tên băng đĩa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mã băng đĩa";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(123, 410);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.ReadOnly = true;
            this.txtTacGia.Size = new System.Drawing.Size(200, 22);
            this.txtTacGia.TabIndex = 16;
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(123, 356);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.ReadOnly = true;
            this.txtTienCoc.Size = new System.Drawing.Size(200, 22);
            this.txtTienCoc.TabIndex = 15;
            this.txtTienCoc.TextChanged += new System.EventHandler(this.txtTienCoc_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(123, 247);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(200, 22);
            this.txtSoLuong.TabIndex = 13;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtCoc
            // 
            this.txtCoc.Location = new System.Drawing.Point(123, 302);
            this.txtCoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoc.Name = "txtCoc";
            this.txtCoc.ReadOnly = true;
            this.txtCoc.Size = new System.Drawing.Size(200, 22);
            this.txtCoc.TabIndex = 14;
            this.txtCoc.TextChanged += new System.EventHandler(this.txtCoc_TextChanged);
            // 
            // ccbMaBang
            // 
            this.ccbMaBang.FormattingEnabled = true;
            this.ccbMaBang.Location = new System.Drawing.Point(123, 30);
            this.ccbMaBang.Margin = new System.Windows.Forms.Padding(4);
            this.ccbMaBang.Name = "ccbMaBang";
            this.ccbMaBang.Size = new System.Drawing.Size(200, 24);
            this.ccbMaBang.TabIndex = 12;
            this.ccbMaBang.SelectedIndexChanged += new System.EventHandler(this.ccbMaBang_SelectedIndexChanged_1);
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(123, 193);
            this.txtTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.ReadOnly = true;
            this.txtTheLoai.Size = new System.Drawing.Size(200, 22);
            this.txtTheLoai.TabIndex = 11;
            // 
            // txtTenBang
            // 
            this.txtTenBang.Location = new System.Drawing.Point(123, 85);
            this.txtTenBang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBang.Name = "txtTenBang";
            this.txtTenBang.ReadOnly = true;
            this.txtTenBang.Size = new System.Drawing.Size(200, 22);
            this.txtTenBang.TabIndex = 9;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(123, 139);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(200, 22);
            this.txtDonGia.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 479);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBoxTotal
            // 
            this.groupBoxTotal.Controls.Add(this.txtTongTien);
            this.groupBoxTotal.Controls.Add(this.labelTotal);
            this.groupBoxTotal.Location = new System.Drawing.Point(17, 580);
            this.groupBoxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTotal.Name = "groupBoxTotal";
            this.groupBoxTotal.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTotal.Size = new System.Drawing.Size(715, 70);
            this.groupBoxTotal.TabIndex = 2;
            this.groupBoxTotal.TabStop = false;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTongTien.Location = new System.Drawing.Point(368, 19);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(251, 34);
            this.txtTongTien.TabIndex = 5;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.IndianRed;
            this.labelTotal.Location = new System.Drawing.Point(236, 22);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(124, 29);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Tổng tiền";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(220, 479);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // titleMain
            // 
            this.titleMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleMain.Location = new System.Drawing.Point(451, 23);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(213, 35);
            this.titleMain.TabIndex = 14;
            this.titleMain.Text = "PHIẾU MƯỢN";
            // 
            // RentalRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1096, 662);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.groupBoxTotal);
            this.Controls.Add(this.groupBoxCDDetails);
            this.Controls.Add(this.groupBoxCDList);
            this.Controls.Add(this.groupBoxCustomerDetails);
            this.Controls.Add(this.groupBoxRentalDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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

