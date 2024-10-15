namespace BankSystem.View
{
    partial class EmployeeForm
    {
        private System.Windows.Forms.GroupBox groupBoxEmployeeDetails;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label titleMain;
        private System.Windows.Forms.Label titleSub;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.CheckBox checkBoxUser;

        private void InitializeComponent()
        {
            this.groupBoxEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.checkBoxUser = new System.Windows.Forms.CheckBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.titleMain = new System.Windows.Forms.Label();
            this.titleSub = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.groupBoxEmployeeDetails.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEmployeeDetails
            // 
            this.groupBoxEmployeeDetails.Controls.Add(this.checkBoxAdmin);
            this.groupBoxEmployeeDetails.Controls.Add(this.checkBoxUser);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelId);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxId);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelName);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxName);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelPassword);
            this.groupBoxEmployeeDetails.Controls.Add(this.textBoxPassword);
            this.groupBoxEmployeeDetails.Controls.Add(this.labelRole);
            this.groupBoxEmployeeDetails.Location = new System.Drawing.Point(12, 75);
            this.groupBoxEmployeeDetails.Name = "groupBoxEmployeeDetails";
            this.groupBoxEmployeeDetails.Size = new System.Drawing.Size(441, 170);
            this.groupBoxEmployeeDetails.TabIndex = 0;
            this.groupBoxEmployeeDetails.TabStop = false;
            this.groupBoxEmployeeDetails.Text = "Thông tin nhân viên";
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.Location = new System.Drawing.Point(180, 127);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(80, 24);
            this.checkBoxAdmin.TabIndex = 7;
            this.checkBoxAdmin.Text = "Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            this.checkBoxAdmin.CheckedChanged += new System.EventHandler(this.checkBoxAdmin_CheckedChanged);
            // 
            // checkBoxUser
            // 
            this.checkBoxUser.Location = new System.Drawing.Point(260, 127);
            this.checkBoxUser.Name = "checkBoxUser";
            this.checkBoxUser.Size = new System.Drawing.Size(100, 24);
            this.checkBoxUser.TabIndex = 8;
            this.checkBoxUser.Text = "User";
            this.checkBoxUser.UseVisualStyleBackColor = true;
            this.checkBoxUser.CheckedChanged += new System.EventHandler(this.checkBoxUser_CheckedChanged);
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(75, 42);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(100, 23);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(180, 70);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(200, 22);
            this.textBoxId.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(75, 67);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 23);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Tài khoản:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(180, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(75, 97);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 23);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Mật khẩu:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(180, 97);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 22);
            this.textBoxPassword.TabIndex = 5;
            // 
            // labelRole
            // 
            this.labelRole.Location = new System.Drawing.Point(75, 127);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(100, 23);
            this.labelRole.TabIndex = 6;
            this.labelRole.Text = "Vai trò:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Controls.Add(this.buttonUpdate);
            this.panelButtons.Controls.Add(this.buttonDelete);
            this.panelButtons.Location = new System.Drawing.Point(12, 408);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(441, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(171, 10);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 30);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Cập nhật";
            this.buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(326, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Xoá";
            this.buttonDelete.Click += buttonDelete_Click;
            // 
            // titleMain
            // 
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.titleMain.ForeColor = System.Drawing.Color.Red;
            this.titleMain.Location = new System.Drawing.Point(87, 9);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(291, 35);
            this.titleMain.TabIndex = 0;
            this.titleMain.Text = "ANTAMTAICHINH™";
            this.titleMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleSub
            // 
            this.titleSub.AutoSize = true;
            this.titleSub.Font = new System.Drawing.Font("Arial", 11F);
            this.titleSub.ForeColor = System.Drawing.Color.Black;
            this.titleSub.Location = new System.Drawing.Point(64, 44);
            this.titleSub.Name = "titleSub";
            this.titleSub.Size = new System.Drawing.Size(358, 22);
            this.titleSub.TabIndex = 1;
            this.titleSub.Text = "AN TÂM ĐẦU TƯ, SINH LỜI BỀN VỮNG";
            this.titleSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 251);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 51;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(441, 150);
            this.dataGridViewEmployees.TabIndex = 2;
            this.dataGridViewEmployees.SelectionChanged += dataGridViewEmployees_SelectionChanged;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(464, 470);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.titleSub);
            this.Controls.Add(this.groupBoxEmployeeDetails);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.groupBoxEmployeeDetails.ResumeLayout(false);
            this.groupBoxEmployeeDetails.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
