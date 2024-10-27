namespace BankSystem.View
{
    partial class DepositForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxDepositDetails;
        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.TextBox textBoxAccountId;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelDepositAmount;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.Label labelDepositDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepositDate;
        private System.Windows.Forms.Button buttonDeposit;

        private void InitializeComponent()
        {
            this.groupBoxDepositDetails = new System.Windows.Forms.GroupBox();
            this.labelAccountId = new System.Windows.Forms.Label();
            this.textBoxAccountId = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelDepositAmount = new System.Windows.Forms.Label();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.labelDepositDate = new System.Windows.Forms.Label();
            this.dateTimePickerDepositDate = new System.Windows.Forms.DateTimePicker();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.groupBoxDepositDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDepositDetails
            // 
            this.groupBoxDepositDetails.Controls.Add(this.labelAccountId);
            this.groupBoxDepositDetails.Controls.Add(this.textBoxAccountId);
            this.groupBoxDepositDetails.Controls.Add(this.labelCustomerName);
            this.groupBoxDepositDetails.Controls.Add(this.textBoxCustomerName);
            this.groupBoxDepositDetails.Controls.Add(this.labelDepositAmount);
            this.groupBoxDepositDetails.Controls.Add(this.textBoxDepositAmount);
            this.groupBoxDepositDetails.Controls.Add(this.labelDepositDate);
            this.groupBoxDepositDetails.Controls.Add(this.dateTimePickerDepositDate);
            this.groupBoxDepositDetails.Location = new System.Drawing.Point(12, 38);
            this.groupBoxDepositDetails.Name = "groupBoxDepositDetails";
            this.groupBoxDepositDetails.Size = new System.Drawing.Size(360, 185);
            this.groupBoxDepositDetails.TabIndex = 0;
            this.groupBoxDepositDetails.TabStop = false;
            this.groupBoxDepositDetails.Text = "Thông tin người nhận";
            // 
            // labelAccountId
            // 
            this.labelAccountId.Location = new System.Drawing.Point(25, 28);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(100, 20);
            this.labelAccountId.TabIndex = 0;
            this.labelAccountId.Text = "Mã tài khoản:";
            // 
            // textBoxAccountId
            // 
            this.textBoxAccountId.Location = new System.Drawing.Point(135, 27);
            this.textBoxAccountId.Name = "textBoxAccountId";
            this.textBoxAccountId.Size = new System.Drawing.Size(200, 22);
            this.textBoxAccountId.TabIndex = 1;
            this.textBoxAccountId.TextChanged += new System.EventHandler(this.textBoxAccountId_TextChanged);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Location = new System.Drawing.Point(25, 68);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(100, 20);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "Tên tài khoản:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(135, 67);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(200, 22);
            this.textBoxCustomerName.TabIndex = 3;
            // 
            // labelDepositAmount
            // 
            this.labelDepositAmount.Location = new System.Drawing.Point(25, 107);
            this.labelDepositAmount.Name = "labelDepositAmount";
            this.labelDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.labelDepositAmount.TabIndex = 2;
            this.labelDepositAmount.Text = "Số tiền gửi:";
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.Location = new System.Drawing.Point(135, 107);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(200, 22);
            this.textBoxDepositAmount.TabIndex = 3;
            // 
            // labelDepositDate
            // 
            this.labelDepositDate.Location = new System.Drawing.Point(25, 147);
            this.labelDepositDate.Name = "labelDepositDate";
            this.labelDepositDate.Size = new System.Drawing.Size(100, 20);
            this.labelDepositDate.TabIndex = 4;
            this.labelDepositDate.Text = "Ngày gửi:";
            // 
            // dateTimePickerDepositDate
            // 
            this.dateTimePickerDepositDate.Location = new System.Drawing.Point(135, 147);
            this.dateTimePickerDepositDate.Name = "dateTimePickerDepositDate";
            this.dateTimePickerDepositDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDepositDate.TabIndex = 5;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(147, 238);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(100, 30);
            this.buttonDeposit.TabIndex = 6;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // DepositForm
            // 
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(382, 278);
            this.Controls.Add(this.groupBoxDepositDetails);
            this.Controls.Add(this.buttonDeposit);
            this.Name = "DepositForm";
            this.Text = "Deposit Form";
            this.groupBoxDepositDetails.ResumeLayout(false);
            this.groupBoxDepositDetails.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
