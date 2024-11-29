using System.Drawing;
using System.Windows.Forms;

namespace CD_Management.View
{
    partial class Login
    {
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label titleMain;
        private System.Windows.Forms.Label titleSub;
        private System.Windows.Forms.Panel panelButtons;

        private void InitializeComponent()
        {
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.titleMain = new System.Windows.Forms.Label();
            this.titleSub = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.groupBoxLogin.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.labelId);
            this.groupBoxLogin.Controls.Add(this.textBoxId);
            this.groupBoxLogin.Controls.Add(this.labelPassword);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Location = new System.Drawing.Point(10, 76);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLogin.Size = new System.Drawing.Size(288, 89);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Đăng nhập";
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(22, 26);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(80, 18);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(106, 26);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(161, 20);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(22, 50);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 18);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Mật khẩu:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(106, 50);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(161, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 8);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(80, 24);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(197, 8);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 24);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // titleMain
            // 
            this.titleMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleMain.AutoSize = true;
            this.titleMain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.titleMain.ForeColor = System.Drawing.Color.Black;
            this.titleMain.Location = new System.Drawing.Point(36, 12);
            this.titleMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleMain.Name = "titleMain";
            this.titleMain.Size = new System.Drawing.Size(233, 29);
            this.titleMain.TabIndex = 0;
            this.titleMain.Text = "BĂNG ĐĨA HÀ NAM";
            this.titleMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleSub
            // 
            this.titleSub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleSub.AutoSize = true;
            this.titleSub.Font = new System.Drawing.Font("Arial", 11F);
            this.titleSub.ForeColor = System.Drawing.Color.Black;
            this.titleSub.Location = new System.Drawing.Point(10, 40);
            this.titleSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleSub.Name = "titleSub";
            this.titleSub.Size = new System.Drawing.Size(270, 17);
            this.titleSub.TabIndex = 1;
            this.titleSub.Text = "GIÚP BẠN TÌM LẠI NHỮNG KÝ ỨC XƯA";
            this.titleSub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonLogin);
            this.panelButtons.Controls.Add(this.buttonExit);
            this.panelButtons.Location = new System.Drawing.Point(10, 170);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(288, 40);
            this.panelButtons.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(307, 216);
            this.Controls.Add(this.titleMain);
            this.Controls.Add(this.titleSub);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
