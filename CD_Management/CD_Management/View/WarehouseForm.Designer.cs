namespace CD_Management.View
{
    partial class WarehouseForm
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
            this.dataGridViewWarehouse = new System.Windows.Forms.DataGridView();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.rbtnExport = new System.Windows.Forms.RadioButton();
            this.rbtnImport = new System.Windows.Forms.RadioButton();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.labelFilters = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxSupplierId = new System.Windows.Forms.TextBox();
            this.labelSupplierId = new System.Windows.Forms.Label();
            this.dateTimePickerTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.labelTransactionDate = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxItemId = new System.Windows.Forms.TextBox();
            this.labelItemId = new System.Windows.Forms.Label();
            this.textBoxTransactionId = new System.Windows.Forms.TextBox();
            this.labelTransactionId = new System.Windows.Forms.Label();
            this.titleMain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).BeginInit();
            this.groupBoxTools.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewWarehouse
            // 
            this.dataGridViewWarehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWarehouse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouse.Location = new System.Drawing.Point(13, 271);
            this.dataGridViewWarehouse.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewWarehouse.Name = "dataGridViewWarehouse";
            this.dataGridViewWarehouse.RowHeadersWidth = 51;
            this.dataGridViewWarehouse.Size = new System.Drawing.Size(1019, 324);
            this.dataGridViewWarehouse.TabIndex = 0;
            this.dataGridViewWarehouse.SelectionChanged += new System.EventHandler(this.dataGridViewWarehouse_SelectionChanged);
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.buttonAdd);
            this.groupBoxTools.Controls.Add(this.buttonClear);
            this.groupBoxTools.Controls.Add(this.buttonUpdate);
            this.groupBoxTools.Controls.Add(this.buttonSearch);
            this.groupBoxTools.Controls.Add(this.buttonDelete);
            this.groupBoxTools.Location = new System.Drawing.Point(753, 77);
            this.groupBoxTools.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTools.Size = new System.Drawing.Size(279, 186);
            this.groupBoxTools.TabIndex = 1;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Công cụ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(44, 42);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 30);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(154, 82);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 30);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Bỏ";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(44, 82);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 30);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(154, 42);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 30);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(44, 122);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 30);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Xoá";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // rbtnExport
            // 
            this.rbtnExport.AutoSize = true;
            this.rbtnExport.Location = new System.Drawing.Point(244, 108);
            this.rbtnExport.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnExport.Name = "rbtnExport";
            this.rbtnExport.Size = new System.Drawing.Size(79, 20);
            this.rbtnExport.TabIndex = 1;
            this.rbtnExport.TabStop = true;
            this.rbtnExport.Text = "Xuất kho";
            this.rbtnExport.UseVisualStyleBackColor = true;
            this.rbtnExport.CheckedChanged += new System.EventHandler(this.TransactionType_CheckedChanged);
            // 
            // rbtnImport
            // 
            this.rbtnImport.AutoSize = true;
            this.rbtnImport.Location = new System.Drawing.Point(123, 108);
            this.rbtnImport.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnImport.Name = "rbtnImport";
            this.rbtnImport.Size = new System.Drawing.Size(86, 20);
            this.rbtnImport.TabIndex = 0;
            this.rbtnImport.TabStop = true;
            this.rbtnImport.Text = "Nhập kho";
            this.rbtnImport.UseVisualStyleBackColor = true;
            this.rbtnImport.CheckedChanged += new System.EventHandler(this.TransactionType_CheckedChanged);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.rbtnExport);
            this.groupBoxDetails.Controls.Add(this.labelFilters);
            this.groupBoxDetails.Controls.Add(this.rbtnImport);
            this.groupBoxDetails.Controls.Add(this.textBoxNotes);
            this.groupBoxDetails.Controls.Add(this.labelNotes);
            this.groupBoxDetails.Controls.Add(this.textBoxSupplierId);
            this.groupBoxDetails.Controls.Add(this.labelSupplierId);
            this.groupBoxDetails.Controls.Add(this.dateTimePickerTransactionDate);
            this.groupBoxDetails.Controls.Add(this.labelTransactionDate);
            this.groupBoxDetails.Controls.Add(this.textBoxQuantity);
            this.groupBoxDetails.Controls.Add(this.labelQuantity);
            this.groupBoxDetails.Controls.Add(this.textBoxItemId);
            this.groupBoxDetails.Controls.Add(this.labelItemId);
            this.groupBoxDetails.Controls.Add(this.textBoxTransactionId);
            this.groupBoxDetails.Controls.Add(this.labelTransactionId);
            this.groupBoxDetails.Location = new System.Drawing.Point(13, 77);
            this.groupBoxDetails.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDetails.Size = new System.Drawing.Size(732, 186);
            this.groupBoxDetails.TabIndex = 4;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Quản lý chi tiết";
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Location = new System.Drawing.Point(13, 108);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(91, 16);
            this.labelFilters.TabIndex = 12;
            this.labelFilters.Text = "Loại giao dịch";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(508, 114);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(200, 56);
            this.textBoxNotes.TabIndex = 10;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(368, 114);
            this.labelNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(53, 16);
            this.labelNotes.TabIndex = 11;
            this.labelNotes.Text = "Ghi Chú";
            // 
            // textBoxSupplierId
            // 
            this.textBoxSupplierId.Location = new System.Drawing.Point(508, 68);
            this.textBoxSupplierId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSupplierId.Name = "textBoxSupplierId";
            this.textBoxSupplierId.Size = new System.Drawing.Size(200, 22);
            this.textBoxSupplierId.TabIndex = 8;
            this.textBoxSupplierId.TextChanged += new System.EventHandler(this.SupplierId_TextChanged);
            // 
            // labelSupplierId
            // 
            this.labelSupplierId.AutoSize = true;
            this.labelSupplierId.Location = new System.Drawing.Point(368, 71);
            this.labelSupplierId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupplierId.Name = "labelSupplierId";
            this.labelSupplierId.Size = new System.Drawing.Size(116, 16);
            this.labelSupplierId.TabIndex = 9;
            this.labelSupplierId.Text = "Mã Nhà Cung Cấp";
            // 
            // dateTimePickerTransactionDate
            // 
            this.dateTimePickerTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransactionDate.Location = new System.Drawing.Point(508, 25);
            this.dateTimePickerTransactionDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerTransactionDate.Name = "dateTimePickerTransactionDate";
            this.dateTimePickerTransactionDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTransactionDate.TabIndex = 6;
            // 
            // labelTransactionDate
            // 
            this.labelTransactionDate.AutoSize = true;
            this.labelTransactionDate.Location = new System.Drawing.Point(366, 25);
            this.labelTransactionDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTransactionDate.Name = "labelTransactionDate";
            this.labelTransactionDate.Size = new System.Drawing.Size(102, 16);
            this.labelTransactionDate.TabIndex = 7;
            this.labelTransactionDate.Text = "Ngày Giao Dịch";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(123, 148);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(200, 22);
            this.textBoxQuantity.TabIndex = 4;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(13, 148);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(64, 16);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Số Lượng";
            // 
            // textBoxItemId
            // 
            this.textBoxItemId.Location = new System.Drawing.Point(123, 68);
            this.textBoxItemId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxItemId.Name = "textBoxItemId";
            this.textBoxItemId.Size = new System.Drawing.Size(200, 22);
            this.textBoxItemId.TabIndex = 2;
            // 
            // labelItemId
            // 
            this.labelItemId.AutoSize = true;
            this.labelItemId.Location = new System.Drawing.Point(13, 68);
            this.labelItemId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItemId.Name = "labelItemId";
            this.labelItemId.Size = new System.Drawing.Size(61, 16);
            this.labelItemId.TabIndex = 3;
            this.labelItemId.Text = "Mã Băng";
            // 
            // textBoxTransactionId
            // 
            this.textBoxTransactionId.Location = new System.Drawing.Point(123, 25);
            this.textBoxTransactionId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTransactionId.Name = "textBoxTransactionId";
            this.textBoxTransactionId.Size = new System.Drawing.Size(200, 22);
            this.textBoxTransactionId.TabIndex = 0;
            // 
            // labelTransactionId
            // 
            this.labelTransactionId.AutoSize = true;
            this.labelTransactionId.Location = new System.Drawing.Point(13, 28);
            this.labelTransactionId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTransactionId.Name = "labelTransactionId";
            this.labelTransactionId.Size = new System.Drawing.Size(88, 16);
            this.labelTransactionId.TabIndex = 1;
            this.labelTransactionId.Text = "Mã Giao Dịch";
            // 
            // titleMain
            // 
            this.titleMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleMain.Location = new System.Drawing.Point(390, 23);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(224, 35);
            this.titleMain.TabIndex = 14;
            this.titleMain.Text = "QUẢN LÝ KHO";
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 608);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.dataGridViewWarehouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WarehouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).EndInit();
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewWarehouse;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.RadioButton rbtnExport;
        private System.Windows.Forms.RadioButton rbtnImport;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.TextBox textBoxTransactionId;
        private System.Windows.Forms.Label labelTransactionId;
        private System.Windows.Forms.TextBox textBoxItemId;
        private System.Windows.Forms.Label labelItemId;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionDate;
        private System.Windows.Forms.Label labelTransactionDate;
        private System.Windows.Forms.TextBox textBoxSupplierId;
        private System.Windows.Forms.Label labelSupplierId;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label titleMain;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
    }
}
