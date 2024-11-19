namespace CD.View
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu trả";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(115, 50);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(150, 20);
            this.txtMaPT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu mượn";
            // 
            // cbbPM
            // 
            this.cbbPM.FormattingEnabled = true;
            this.cbbPM.Location = new System.Drawing.Point(389, 49);
            this.cbbPM.Name = "cbbPM";
            this.cbbPM.Size = new System.Drawing.Size(150, 21);
            this.cbbPM.TabIndex = 3;
            this.cbbPM.SelectedIndexChanged += new System.EventHandler(this.cbbPM_SelectedIndexChanged);
            // 
            // dataGridReturn
            // 
            this.dataGridReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReturn.Location = new System.Drawing.Point(8, 96);
            this.dataGridReturn.Name = "dataGridReturn";
            this.dataGridReturn.Size = new System.Drawing.Size(548, 76);
            this.dataGridReturn.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(481, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ReturnRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 340);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridReturn);
            this.Controls.Add(this.cbbPM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.label1);
            this.Name = "ReturnRequest";
            this.Text = "ReturnRequest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReturn)).EndInit();
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
    }
}