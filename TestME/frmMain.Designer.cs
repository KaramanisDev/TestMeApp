namespace TestME
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.frmSkin = new CustomForm();
            this.tabMain = new XylosTabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnMin = new CustomButton();
            this.btnClose = new CustomButton();
            this.lbl1 = new BonfireLabel();
            this.lbl2 = new BonfireLabel();
            this.btnLogin = new BonfireButton();
            this.txtUser = new XylosTextBox();
            this.txtPassword = new XylosTextBox();
            this.notificationBox1 = new NotificationBox();
            this.frmSkin.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmSkin
            // 
            this.frmSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(25)))));
            this.frmSkin.BorderSize = 10;
            this.frmSkin.Controls.Add(this.tabMain);
            this.frmSkin.Controls.Add(this.btnMin);
            this.frmSkin.Controls.Add(this.btnClose);
            this.frmSkin.Darker = false;
            this.frmSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSkin.InsideBorderSize = 3;
            this.frmSkin.Location = new System.Drawing.Point(0, 0);
            this.frmSkin.MinimumSize = new System.Drawing.Size(305, 150);
            this.frmSkin.Name = "frmSkin";
            this.frmSkin.Padding = new System.Windows.Forms.Padding(13, 38, 13, 13);
            this.frmSkin.Sizable = false;
            this.frmSkin.Size = new System.Drawing.Size(623, 349);
            this.frmSkin.TabIndex = 0;
            this.frmSkin.Text = "TestME";
            this.frmSkin.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.frmSkin.TitleColor = System.Drawing.Color.WhiteSmoke;
            this.frmSkin.TitleFont = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmSkin.TitleYOffset = 0;
            this.frmSkin.TopSize = 35;
            this.frmSkin.TopSpace = 0;
            // 
            // tabMain
            // 
            this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabMain.Controls.Add(this.tabPage5);
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabPage4);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.FirstHeaderBorder = false;
            this.tabMain.ItemSize = new System.Drawing.Size(40, 180);
            this.tabMain.Location = new System.Drawing.Point(13, 38);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(597, 298);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage5.Location = new System.Drawing.Point(184, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(409, 290);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Tag = "Dashboard";
            this.tabPage5.Text = "Dashboard";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.notificationBox1);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.txtUser);
            this.tabPage1.Controls.Add(this.btnLogin);
            this.tabPage1.Controls.Add(this.lbl2);
            this.tabPage1.Controls.Add(this.lbl1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(409, 290);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(409, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage3.Location = new System.Drawing.Point(184, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(409, 290);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = "Info";
            this.tabPage3.Text = "Information";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabPage4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabPage4.Location = new System.Drawing.Point(184, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(409, 290);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.btnMin.DrawSeparator = false;
            this.btnMin.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMin.Location = new System.Drawing.Point(547, 4);
            this.btnMin.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnMin.Name = "btnMin";
            this.btnMin.OverlayCol = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMin.Size = new System.Drawing.Size(30, 26);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "0";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.btnClose.DrawSeparator = false;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(583, 4);
            this.btnClose.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.OverlayCol = System.Drawing.Color.Maroon;
            this.btnClose.Size = new System.Drawing.Size(30, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.lbl1.Location = new System.Drawing.Point(49, 71);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(71, 18);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Username:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.lbl2.Location = new System.Drawing.Point(50, 122);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(66, 18);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.ButtonStyle = BonfireButton.Style.Dark;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Image = null;
            this.btnLogin.Location = new System.Drawing.Point(262, 194);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RoundedCorners = true;
            this.btnLogin.Size = new System.Drawing.Size(65, 26);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            // 
            // txtUser
            // 
            this.txtUser.EnabledCalc = true;
            this.txtUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtUser.Location = new System.Drawing.Point(126, 66);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MultiLine = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = false;
            this.txtUser.Size = new System.Drawing.Size(200, 29);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.EnabledCalc = true;
            this.txtPassword.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtPassword.Location = new System.Drawing.Point(126, 116);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MultiLine = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(200, 29);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // notificationBox1
            // 
            this.notificationBox1.BorderCurve = 15;
            this.notificationBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationBox1.Image = null;
            this.notificationBox1.Location = new System.Drawing.Point(53, 226);
            this.notificationBox1.MinimumSize = new System.Drawing.Size(100, 40);
            this.notificationBox1.Name = "notificationBox1";
            this.notificationBox1.NotificationType = NotificationBox.Type.Error;
            this.notificationBox1.RoundCorners = true;
            this.notificationBox1.ShowCloseButton = true;
            this.notificationBox1.Size = new System.Drawing.Size(274, 40);
            this.notificationBox1.TabIndex = 5;
            this.notificationBox1.Text = "Username or Password were incorrect!";
            this.notificationBox1.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 349);
            this.Controls.Add(this.frmSkin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(305, 150);
            this.Name = "frmMain";
            this.Text = "TestMe";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.frmSkin.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomForm frmSkin;
        private CustomButton btnClose;
        private CustomButton btnMin;
        private XylosTabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private NotificationBox notificationBox1;
        private XylosTextBox txtPassword;
        private XylosTextBox txtUser;
        private BonfireButton btnLogin;
        private BonfireLabel lbl2;
        private BonfireLabel lbl1;
    }
}

