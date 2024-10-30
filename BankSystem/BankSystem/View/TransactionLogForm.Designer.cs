using System.Windows.Forms;

namespace BankSystem.View
{
    partial class TransactionLogForm
    {
        private System.Windows.Forms.GroupBox groupBoxTransactionDetails;
        private System.Windows.Forms.Label labelTransactionId;
        private System.Windows.Forms.Label labelTransactionType;
        private System.Windows.Forms.Label labelAccountFromId;
        private System.Windows.Forms.Label labelAccountToId;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDateOfTrans;
        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label labelBranchId;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxTransactionId;
        private System.Windows.Forms.TextBox textBoxTransactionType;
        private System.Windows.Forms.TextBox textBoxAccountFromId;
        private System.Windows.Forms.TextBox textBoxAccountToId;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxDateOfTrans;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.TextBox textBoxBranchId;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.Label titleMain;
        private System.Windows.Forms.Label titleSub;

        private void InitializeComponent()
        {
            this.groupBoxTransactionDetails = new System.Windows.Forms.GroupBox();
            this.labelTransactionId = new System.Windows.Forms.Label();
            this.labelTransactionType = new System.Windows.Forms.Label();
            this.labelAccountFromId = new System.Windows.Forms.Label();
            this.labelAccountToId = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDateOfTrans = new System.Windows.Forms.Label();
            this.labelEmployeeId = new System.Windows.Forms.Label();
            this.labelBranchId = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxTransactionId = new System.Windows.Forms.TextBox();
            this.textBoxTransactionType = new System.Windows.Forms.TextBox();
            this.textBoxAccountFromId = new System.Windows.Forms.TextBox();
            this.textBoxAccountToId = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxDateOfTrans = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.textBoxBranchId = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.titleMain = new System.Windows.Forms.Label();
            this.titleSub = new System.Windows.Forms.Label();
            this.groupBoxTransactionDetails.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTransactionDetails
            // 
            this.groupBoxTransactionDetails.Controls.Add(this.labelTransactionId);
            this.groupBoxTransactionDetails.Controls.Add(this.labelTransactionType);
            this.groupBoxTransactionDetails.Controls.Add(this.labelAccountFromId);
            this.groupBoxTransactionDetails.Controls.Add(this.labelAccountToId);
            this.groupBoxTransactionDetails.Controls.Add(this.labelAmount);
            this.groupBoxTransactionDetails.Controls.Add(this.labelDateOfTrans);
            this.groupBoxTransactionDetails.Controls.Add(this.labelEmployeeId);
            this.groupBoxTransactionDetails.Controls.Add(this.labelBranchId);
            this.groupBoxTransactionDetails.Controls.Add(this.labelDescription);
            this.groupBoxTransactionDetails.Controls.Add(this.textBoxTransactionId);
            this.groupBoxTransactionDetails.Controls.Add(this.textBoxTransactionType);
            this.groupBoxTransactionDetails.Controls.Add(this.textBoxAccountFromId);
            this.groupBoxTransactionDetails.Controls.Add(this.textBoxAccountToId);
            this.groupBoxTransactionDetails.Controls.Add(this.textBoxAmount);
            this.groupBoxTransactionDetails.Controls.Add(this.textBoxDateOfTrans);
            this.groupBoxTransactionDetails.Controls.Add(this.textBoxEmployeeId);
            this.groupBoxTransactionDetails.Controls.Add(this.textBoxBranchId);
            this.groupBoxTransactionDetails.Controls.Add(this.textBoxDescription);
            this.groupBoxTransactionDetails.Location = new System.Drawing.Point(12, 75);
            this.groupBoxTransactionDetails.Name = "groupBoxTransactionDetails";
            this.groupBoxTransactionDetails.Size = new System.Drawing.Size(768, 206);
            this.groupBoxTransactionDetails.TabIndex = 0;
            this.groupBoxTransactionDetails.TabStop = false;
            this.groupBoxTransactionDetails.Text = "Thông tin giao dịch";
            // 
            // labelTransactionId
            // 
            this.labelTransactionId.Location = new System.Drawing.Point(41, 36);
            this.labelTransactionId.Name = "labelTransactionId";
            this.labelTransactionId.Size = new System.Drawing.Size(100, 23);
            this.labelTransactionId.TabIndex = 0;
            this.labelTransactionId.Text = "Mã giao dịch:";
            // 
            // labelTransactionType
            // 
            this.labelTransactionType.Location = new System.Drawing.Point(41, 66);
            this.labelTransactionType.Name = "labelTransactionType";
            this.labelTransactionType.Size = new System.Drawing.Size(100, 23);
            this.labelTransactionType.TabIndex = 1;
            this.labelTransactionType.Text = "Loại giao dịch:";
            // 
            // labelAccountFromId
            // 
            this.labelAccountFromId.Location = new System.Drawing.Point(41, 96);
            this.labelAccountFromId.Name = "labelAccountFromId";
            this.labelAccountFromId.Size = new System.Drawing.Size(100, 23);
            this.labelAccountFromId.TabIndex = 2;
            this.labelAccountFromId.Text = "Tài khoản gửi:";
            // 
            // labelAccountToId
            // 
            this.labelAccountToId.Location = new System.Drawing.Point(41, 126);
            this.labelAccountToId.Name = "labelAccountToId";
            this.labelAccountToId.Size = new System.Drawing.Size(100, 23);
            this.labelAccountToId.TabIndex = 3;
            this.labelAccountToId.Text = "Tài khoản nhận:";
            // 
            // labelAmount
            // 
            this.labelAmount.Location = new System.Drawing.Point(41, 156);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(100, 23);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Số tiền:";
            // 
            // labelDateOfTrans
            // 
            this.labelDateOfTrans.Location = new System.Drawing.Point(421, 36);
            this.labelDateOfTrans.Name = "labelDateOfTrans";
            this.labelDateOfTrans.Size = new System.Drawing.Size(100, 23);
            this.labelDateOfTrans.TabIndex = 5;
            this.labelDateOfTrans.Text = "Ngày giao dịch:";
            // 
            // labelEmployeeId
            // 
            this.labelEmployeeId.Location = new System.Drawing.Point(421, 66);
            this.labelEmployeeId.Name = "labelEmployeeId";
            this.labelEmployeeId.Size = new System.Drawing.Size(100, 23);
            this.labelEmployeeId.TabIndex = 6;
            this.labelEmployeeId.Text = "ID nhân viên:";
            // 
            // labelBranchId
            // 
            this.labelBranchId.Location = new System.Drawing.Point(421, 96);
            this.labelBranchId.Name = "labelBranchId";
            this.labelBranchId.Size = new System.Drawing.Size(100, 23);
            this.labelBranchId.TabIndex = 7;
            this.labelBranchId.Text = "ID chi nhánh:";
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(421, 126);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 23);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Mô tả:";
            // 
            // textBoxTransactionId
            // 
            this.textBoxTransactionId.Location = new System.Drawing.Point(151, 36);
            this.textBoxTransactionId.Name = "textBoxTransactionId";
            this.textBoxTransactionId.ReadOnly = true;
            this.textBoxTransactionId.Size = new System.Drawing.Size(200, 22);
            this.textBoxTransactionId.TabIndex = 9;
            // 
            // textBoxTransactionType
            // 
            this.textBoxTransactionType.Location = new System.Drawing.Point(151, 66);
            this.textBoxTransactionType.Name = "textBoxTransactionType";
            this.textBoxTransactionType.ReadOnly = true;
            this.textBoxTransactionType.Size = new System.Drawing.Size(200, 22);
            this.textBoxTransactionType.TabIndex = 10;
            // 
            // textBoxAccountFromId
            // 
            this.textBoxAccountFromId.Location = new System.Drawing.Point(151, 96);
            this.textBoxAccountFromId.Name = "textBoxAccountFromId";
            this.textBoxAccountFromId.ReadOnly = true;
            this.textBoxAccountFromId.Size = new System.Drawing.Size(200, 22);
            this.textBoxAccountFromId.TabIndex = 11;
            // 
            // textBoxAccountToId
            // 
            this.textBoxAccountToId.Location = new System.Drawing.Point(151, 126);
            this.textBoxAccountToId.Name = "textBoxAccountToId";
            this.textBoxAccountToId.ReadOnly = true;
            this.textBoxAccountToId.Size = new System.Drawing.Size(200, 22);
            this.textBoxAccountToId.TabIndex = 12;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(151, 156);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.ReadOnly = true;
            this.textBoxAmount.Size = new System.Drawing.Size(200, 22);
            this.textBoxAmount.TabIndex = 13;
            // 
            // textBoxDateOfTrans
            // 
            this.textBoxDateOfTrans.Location = new System.Drawing.Point(531, 36);
            this.textBoxDateOfTrans.Name = "textBoxDateOfTrans";
            this.textBoxDateOfTrans.ReadOnly = true;
            this.textBoxDateOfTrans.Size = new System.Drawing.Size(200, 22);
            this.textBoxDateOfTrans.TabIndex = 14;
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(531, 66);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.ReadOnly = true;
            this.textBoxEmployeeId.Size = new System.Drawing.Size(200, 22);
            this.textBoxEmployeeId.TabIndex = 15;
            // 
            // textBoxBranchId
            // 
            this.textBoxBranchId.Location = new System.Drawing.Point(531, 96);
            this.textBoxBranchId.Name = "textBoxBranchId";
            this.textBoxBranchId.ReadOnly = true;
            this.textBoxBranchId.Size = new System.Drawing.Size(200, 22);
            this.textBoxBranchId.TabIndex = 16;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(531, 126);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(200, 22);
            this.textBoxDescription.TabIndex = 17;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonPrint);
            this.panelButtons.Location = new System.Drawing.Point(12, 513);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(768, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(320, 9);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(100, 30);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "In danh sách";
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(12, 287);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.RowHeadersWidth = 51;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(768, 220);
            this.dataGridViewTransactions.TabIndex = 2;
            this.dataGridViewTransactions.SelectionChanged += new System.EventHandler(this.dataGridViewTransactions_SelectionChanged);
            // 
            // titleMain
            // 
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.titleMain.ForeColor = System.Drawing.Color.Red;
            this.titleMain.Location = new System.Drawing.Point(242, 9);
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
            this.titleSub.Location = new System.Drawing.Point(219, 44);
            this.titleSub.Name = "titleSub";
            this.titleSub.Size = new System.Drawing.Size(358, 22);
            this.titleSub.TabIndex = 1;
            this.titleSub.Text = "AN TÂM ĐẦU TƯ, SINH LỜI BỀN VỮNG";
            this.titleSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransactionLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.titleSub);
            this.Controls.Add(this.groupBoxTransactionDetails);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.dataGridViewTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhật ký giao dịch";
            this.groupBoxTransactionDetails.ResumeLayout(false);
            this.groupBoxTransactionDetails.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}