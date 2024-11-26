namespace CD_Management.View
{
    partial class ReturnRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPM = new System.Windows.Forms.ComboBox();
            this.dataGridReturn = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.titleMain = new System.Windows.Forms.Label();
            this.groupBoxReturnDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReturn)).BeginInit();
            this.groupBoxReturnDetails.SuspendLayout();
            this.groupBoxTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu trả";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(220, 30);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(200, 22);
            this.txtMaPT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // cbbPM
            // 
            this.cbbPM.FormattingEnabled = true;
            this.cbbPM.Location = new System.Drawing.Point(220, 58);
            this.cbbPM.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPM.Name = "cbbPM";
            this.cbbPM.Size = new System.Drawing.Size(200, 24);
            this.cbbPM.TabIndex = 3;
            this.cbbPM.SelectedIndexChanged += new System.EventHandler(this.cbbPM_SelectedIndexChanged);
            // 
            // dataGridReturn
            // 
            this.dataGridReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReturn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReturn.Location = new System.Drawing.Point(12, 164);
            this.dataGridReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridReturn.Name = "dataGridReturn";
            this.dataGridReturn.RowHeadersWidth = 51;
            this.dataGridReturn.Size = new System.Drawing.Size(688, 237);
            this.dataGridReturn.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(52, 33);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // titleMain
            // 
            this.titleMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleMain.Location = new System.Drawing.Point(256, 19);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(176, 35);
            this.titleMain.TabIndex = 14;
            this.titleMain.Text = "PHIẾU TRẢ";
            // 
            // groupBoxReturnDetails
            // 
            this.groupBoxReturnDetails.Controls.Add(this.label1);
            this.groupBoxReturnDetails.Controls.Add(this.txtMaPT);
            this.groupBoxReturnDetails.Controls.Add(this.label2);
            this.groupBoxReturnDetails.Controls.Add(this.cbbPM);
            this.groupBoxReturnDetails.Location = new System.Drawing.Point(12, 57);
            this.groupBoxReturnDetails.Name = "groupBoxReturnDetails";
            this.groupBoxReturnDetails.Size = new System.Drawing.Size(482, 100);
            this.groupBoxReturnDetails.TabIndex = 15;
            this.groupBoxReturnDetails.TabStop = false;
            this.groupBoxReturnDetails.Text = "Thông tin phiếu trả";
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.btnSave);
            this.groupBoxTools.Location = new System.Drawing.Point(500, 57);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTools.TabIndex = 16;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Công cụ";
            // 
            // ReturnRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 416);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.groupBoxReturnDetails);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.dataGridReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReturnRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnRequest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReturn)).EndInit();
            this.groupBoxReturnDetails.ResumeLayout(false);
            this.groupBoxReturnDetails.PerformLayout();
            this.groupBoxTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbPM;
        private System.Windows.Forms.DataGridView dataGridReturn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label titleMain;
        private System.Windows.Forms.GroupBox groupBoxReturnDetails;
        private System.Windows.Forms.GroupBox groupBoxTools;
    }
}