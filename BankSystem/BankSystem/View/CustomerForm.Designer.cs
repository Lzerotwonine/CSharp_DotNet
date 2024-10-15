using System.Drawing;
using System.Windows.Forms;

namespace BankSystem.View
{
	partial class CustomerForm
	{
		private System.Windows.Forms.GroupBox groupBoxCustomerDetails;
		private System.Windows.Forms.Label labelId;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelHouseNo;
		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.Label labelPin;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Label titleMain;
		private System.Windows.Forms.Label titleSub;
		private System.Windows.Forms.TextBox textBoxId;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.TextBox textBoxHouseNo;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.TextBox textBoxPin;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDelete;

		private void InitializeComponent()
		{
            this.groupBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelHouseNo = new System.Windows.Forms.Label();
            this.textBoxHouseNo = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelPin = new System.Windows.Forms.Label();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.titleMain = new System.Windows.Forms.Label();
            this.titleSub = new System.Windows.Forms.Label();
            this.groupBoxCustomerDetails.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCustomerDetails
            // 
            this.groupBoxCustomerDetails.Controls.Add(this.labelId);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxId);
            this.groupBoxCustomerDetails.Controls.Add(this.labelName);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxName);
            this.groupBoxCustomerDetails.Controls.Add(this.labelPhone);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxPhone);
            this.groupBoxCustomerDetails.Controls.Add(this.labelEmail);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxEmail);
            this.groupBoxCustomerDetails.Controls.Add(this.labelHouseNo);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxHouseNo);
            this.groupBoxCustomerDetails.Controls.Add(this.labelCity);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxCity);
            this.groupBoxCustomerDetails.Controls.Add(this.labelPin);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxPin);
            this.groupBoxCustomerDetails.Location = new System.Drawing.Point(12, 95);
            this.groupBoxCustomerDetails.Name = "groupBoxCustomerDetails";
            this.groupBoxCustomerDetails.Size = new System.Drawing.Size(360, 250);
            this.groupBoxCustomerDetails.TabIndex = 0;
            this.groupBoxCustomerDetails.TabStop = false;
            this.groupBoxCustomerDetails.Text = "Thông tin chi tiết";
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(15, 30);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(100, 23);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(120, 30);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(200, 22);
            this.textBoxId.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(15, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 23);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Tên:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 60);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // labelPhone
            // 
            this.labelPhone.Location = new System.Drawing.Point(15, 90);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(100, 23);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Số điện thoại:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(120, 90);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(200, 22);
            this.textBoxPhone.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(15, 120);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(100, 23);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(120, 120);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 22);
            this.textBoxEmail.TabIndex = 7;
            // 
            // labelHouseNo
            // 
            this.labelHouseNo.Location = new System.Drawing.Point(15, 150);
            this.labelHouseNo.Name = "labelHouseNo";
            this.labelHouseNo.Size = new System.Drawing.Size(100, 23);
            this.labelHouseNo.TabIndex = 8;
            this.labelHouseNo.Text = "Số nhà:";
            // 
            // textBoxHouseNo
            // 
            this.textBoxHouseNo.Location = new System.Drawing.Point(120, 150);
            this.textBoxHouseNo.Name = "textBoxHouseNo";
            this.textBoxHouseNo.Size = new System.Drawing.Size(200, 22);
            this.textBoxHouseNo.TabIndex = 9;
            // 
            // labelCity
            // 
            this.labelCity.Location = new System.Drawing.Point(15, 180);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(100, 23);
            this.labelCity.TabIndex = 10;
            this.labelCity.Text = "Thành phố:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(120, 180);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(200, 22);
            this.textBoxCity.TabIndex = 11;
            // 
            // labelPin
            // 
            this.labelPin.Location = new System.Drawing.Point(15, 210);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(100, 23);
            this.labelPin.TabIndex = 12;
            this.labelPin.Text = "Pin:";
            // 
            // textBoxPin
            // 
            this.textBoxPin.Location = new System.Drawing.Point(120, 210);
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(200, 22);
            this.textBoxPin.TabIndex = 13;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Controls.Add(this.buttonUpdate);
            this.panelButtons.Controls.Add(this.buttonDelete);
            this.panelButtons.Location = new System.Drawing.Point(12, 353);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(360, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Thêm";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(135, 10);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 30);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Cập nhật";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(255, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Xoá";
            // 
            // titleMain
            // 
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.titleMain.ForeColor = System.Drawing.Color.Red;
            this.titleMain.Location = new System.Drawing.Point(41, 15);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(291, 35);
            this.titleMain.TabIndex = 0;
            this.titleMain.Text = "ANTAMTAICHINH™";
            // 
            // titleSub
            // 
            this.titleSub.AutoSize = true;
            this.titleSub.Font = new System.Drawing.Font("Arial", 11F);
            this.titleSub.ForeColor = System.Drawing.Color.Black;
            this.titleSub.Location = new System.Drawing.Point(12, 50);
            this.titleSub.Name = "titleSub";
            this.titleSub.Size = new System.Drawing.Size(358, 22);
            this.titleSub.TabIndex = 1;
            this.titleSub.Text = "AN TÂM ĐẦU TƯ, SINH LỜI BỀN VỮNG";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(384, 415);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.titleSub);
            this.Controls.Add(this.groupBoxCustomerDetails);
            this.Controls.Add(this.panelButtons);
            this.Name = "CustomerForm";
            this.Text = "Quản lý khách hàng";
            this.groupBoxCustomerDetails.ResumeLayout(false);
            this.groupBoxCustomerDetails.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}