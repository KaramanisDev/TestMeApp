namespace TestME
{
    partial class frmStart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.frmSkin = new CustomForm();
            this.tabMain = new XylosTabControl();
            this.tabdashboard = new System.Windows.Forms.TabPage();
            this.tablogin = new System.Windows.Forms.TabPage();
            this.linkForgot = new System.Windows.Forms.LinkLabel();
            this.ckbLRemember = new XylosCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.ntfBox1 = new NotificationBox();
            this.txtLPass = new XylosTextBox();
            this.txtLUser = new XylosTextBox();
            this.btnLogin = new BonfireButton();
            this.tabregister = new System.Windows.Forms.TabPage();
            this.bonfireLabel1 = new BonfireLabel();
            this.txtRSecurityCode = new XylosTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegister = new BonfireButton();
            this.ntfBox2 = new NotificationBox();
            this.txtRrepeatPass = new XylosTextBox();
            this.txtRPass = new XylosTextBox();
            this.txtREmail = new XylosTextBox();
            this.txtRUser = new XylosTextBox();
            this.lblrepeatpass = new BonfireLabel();
            this.lblpass = new BonfireLabel();
            this.lblemail = new BonfireLabel();
            this.lblusername = new BonfireLabel();
            this.tabsettings = new System.Windows.Forms.TabPage();
            this.checkBoxAutoConnect = new XylosCheckBox();
            this.checkBoxRemember = new XylosCheckBox();
            this.ntfBox3 = new NotificationBox();
            this.txtSDatabase = new XylosTextBox();
            this.txtSPass = new XylosTextBox();
            this.txtSUser = new XylosTextBox();
            this.txtSHost = new XylosTextBox();
            this.lbltable = new BonfireLabel();
            this.lblpasswd = new BonfireLabel();
            this.lbluname = new BonfireLabel();
            this.lblhost = new BonfireLabel();
            this.lbltitle = new BonfireLabel();
            this.btnconnect = new BonfireButton();
            this.tabinfo = new System.Windows.Forms.TabPage();
            this.tababout = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label2 = new BonfireLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabforgot = new System.Windows.Forms.TabPage();
            this.ntfForgot = new NotificationBox();
            this.bonfireLabel2 = new BonfireLabel();
            this.btnPassGenerate = new BonfireButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassPassword = new XylosTextBox();
            this.txtPassCode = new XylosTextBox();
            this.txtPassUser = new XylosTextBox();
            this.btnMin = new CustomButton();
            this.btnClose = new CustomButton();
            this.frmSkin.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tablogin.SuspendLayout();
            this.tabregister.SuspendLayout();
            this.tabsettings.SuspendLayout();
            this.tababout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabforgot.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "about-16.png");
            this.imageList1.Images.SetKeyName(1, "add-user-16.png");
            this.imageList1.Images.SetKeyName(2, "key-16.png");
            this.imageList1.Images.SetKeyName(3, "services-16.png");
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
            this.tabMain.Controls.Add(this.tabdashboard);
            this.tabMain.Controls.Add(this.tablogin);
            this.tabMain.Controls.Add(this.tabregister);
            this.tabMain.Controls.Add(this.tabsettings);
            this.tabMain.Controls.Add(this.tabinfo);
            this.tabMain.Controls.Add(this.tababout);
            this.tabMain.Controls.Add(this.tabforgot);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.FirstHeaderBorder = false;
            this.tabMain.ImageList = this.imageList1;
            this.tabMain.ItemSize = new System.Drawing.Size(40, 180);
            this.tabMain.Location = new System.Drawing.Point(13, 38);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(597, 298);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 2;
            // 
            // tabdashboard
            // 
            this.tabdashboard.BackColor = System.Drawing.Color.White;
            this.tabdashboard.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.tabdashboard.ForeColor = System.Drawing.Color.DimGray;
            this.tabdashboard.Location = new System.Drawing.Point(184, 4);
            this.tabdashboard.Name = "tabdashboard";
            this.tabdashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabdashboard.Size = new System.Drawing.Size(409, 290);
            this.tabdashboard.TabIndex = 4;
            this.tabdashboard.Tag = "header";
            this.tabdashboard.Text = "Dashboard";
            // 
            // tablogin
            // 
            this.tablogin.BackColor = System.Drawing.Color.White;
            this.tablogin.Controls.Add(this.linkForgot);
            this.tablogin.Controls.Add(this.ckbLRemember);
            this.tablogin.Controls.Add(this.label3);
            this.tablogin.Controls.Add(this.lblUser);
            this.tablogin.Controls.Add(this.lblPassword);
            this.tablogin.Controls.Add(this.ntfBox1);
            this.tablogin.Controls.Add(this.txtLPass);
            this.tablogin.Controls.Add(this.txtLUser);
            this.tablogin.Controls.Add(this.btnLogin);
            this.tablogin.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.tablogin.ForeColor = System.Drawing.Color.DimGray;
            this.tablogin.ImageIndex = 2;
            this.tablogin.Location = new System.Drawing.Point(184, 4);
            this.tablogin.Name = "tablogin";
            this.tablogin.Padding = new System.Windows.Forms.Padding(3);
            this.tablogin.Size = new System.Drawing.Size(409, 290);
            this.tablogin.TabIndex = 0;
            this.tablogin.Text = "Login";
            // 
            // linkForgot
            // 
            this.linkForgot.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkForgot.AutoSize = true;
            this.linkForgot.DisabledLinkColor = System.Drawing.Color.Silver;
            this.linkForgot.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.linkForgot.LinkColor = System.Drawing.Color.Teal;
            this.linkForgot.Location = new System.Drawing.Point(54, 161);
            this.linkForgot.Name = "linkForgot";
            this.linkForgot.Size = new System.Drawing.Size(114, 18);
            this.linkForgot.TabIndex = 14;
            this.linkForgot.TabStop = true;
            this.linkForgot.Text = "Forgot Password?";
            this.linkForgot.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgot_LinkClicked);
            // 
            // ckbLRemember
            // 
            this.ckbLRemember.Checked = false;
            this.ckbLRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbLRemember.EnabledCalc = true;
            this.ckbLRemember.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLRemember.ForeColor = System.Drawing.Color.DimGray;
            this.ckbLRemember.Location = new System.Drawing.Point(221, 161);
            this.ckbLRemember.Name = "ckbLRemember";
            this.ckbLRemember.Size = new System.Drawing.Size(113, 18);
            this.ckbLRemember.TabIndex = 13;
            this.ckbLRemember.Text = "Remember Me";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(168, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Welcome !";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblUser.Location = new System.Drawing.Point(51, 71);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(71, 18);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Location = new System.Drawing.Point(54, 121);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 18);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // ntfBox1
            // 
            this.ntfBox1.BorderCurve = 15;
            this.ntfBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntfBox1.Image = null;
            this.ntfBox1.Location = new System.Drawing.Point(53, 235);
            this.ntfBox1.MinimumSize = new System.Drawing.Size(100, 40);
            this.ntfBox1.Name = "ntfBox1";
            this.ntfBox1.NotificationType = NotificationBox.Type.Error;
            this.ntfBox1.RoundCorners = true;
            this.ntfBox1.ShowCloseButton = true;
            this.ntfBox1.Size = new System.Drawing.Size(274, 40);
            this.ntfBox1.TabIndex = 5;
            this.ntfBox1.Text = "Username or Password were incorrect!";
            this.ntfBox1.Visible = false;
            // 
            // txtLPass
            // 
            this.txtLPass.EnabledCalc = true;
            this.txtLPass.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtLPass.Location = new System.Drawing.Point(126, 116);
            this.txtLPass.MaxLength = 32767;
            this.txtLPass.MultiLine = false;
            this.txtLPass.Name = "txtLPass";
            this.txtLPass.ReadOnly = false;
            this.txtLPass.SelectionStart = 0;
            this.txtLPass.Size = new System.Drawing.Size(200, 29);
            this.txtLPass.TabIndex = 4;
            this.txtLPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLPass.UseSystemPasswordChar = true;
            // 
            // txtLUser
            // 
            this.txtLUser.EnabledCalc = true;
            this.txtLUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtLUser.Location = new System.Drawing.Point(126, 66);
            this.txtLUser.MaxLength = 32767;
            this.txtLUser.MultiLine = false;
            this.txtLUser.Name = "txtLUser";
            this.txtLUser.ReadOnly = false;
            this.txtLUser.SelectionStart = 0;
            this.txtLUser.Size = new System.Drawing.Size(200, 29);
            this.txtLUser.TabIndex = 3;
            this.txtLUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLUser.UseSystemPasswordChar = false;
            this.txtLUser.TextChanged += new System.EventHandler(this.txtLUser_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Teal;
            this.btnLogin.ButtonStyle = BonfireButton.Style.Custom;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Image = global::TestME.Properties.Resources.arrow_28_24;
            this.btnLogin.Location = new System.Drawing.Point(221, 194);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RoundedCorners = true;
            this.btnLogin.Size = new System.Drawing.Size(105, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabregister
            // 
            this.tabregister.BackColor = System.Drawing.Color.White;
            this.tabregister.Controls.Add(this.bonfireLabel1);
            this.tabregister.Controls.Add(this.txtRSecurityCode);
            this.tabregister.Controls.Add(this.label4);
            this.tabregister.Controls.Add(this.btnRegister);
            this.tabregister.Controls.Add(this.ntfBox2);
            this.tabregister.Controls.Add(this.txtRrepeatPass);
            this.tabregister.Controls.Add(this.txtRPass);
            this.tabregister.Controls.Add(this.txtREmail);
            this.tabregister.Controls.Add(this.txtRUser);
            this.tabregister.Controls.Add(this.lblrepeatpass);
            this.tabregister.Controls.Add(this.lblpass);
            this.tabregister.Controls.Add(this.lblemail);
            this.tabregister.Controls.Add(this.lblusername);
            this.tabregister.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.tabregister.ForeColor = System.Drawing.Color.DimGray;
            this.tabregister.ImageIndex = 1;
            this.tabregister.Location = new System.Drawing.Point(184, 4);
            this.tabregister.Name = "tabregister";
            this.tabregister.Padding = new System.Windows.Forms.Padding(3);
            this.tabregister.Size = new System.Drawing.Size(409, 290);
            this.tabregister.TabIndex = 1;
            this.tabregister.Text = "Register";
            // 
            // bonfireLabel1
            // 
            this.bonfireLabel1.AutoSize = true;
            this.bonfireLabel1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bonfireLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bonfireLabel1.Location = new System.Drawing.Point(146, 5);
            this.bonfireLabel1.Name = "bonfireLabel1";
            this.bonfireLabel1.Size = new System.Drawing.Size(118, 20);
            this.bonfireLabel1.TabIndex = 12;
            this.bonfireLabel1.Text = "Create Account";
            // 
            // txtRSecurityCode
            // 
            this.txtRSecurityCode.EnabledCalc = true;
            this.txtRSecurityCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRSecurityCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtRSecurityCode.Location = new System.Drawing.Point(178, 181);
            this.txtRSecurityCode.MaxLength = 32767;
            this.txtRSecurityCode.MultiLine = false;
            this.txtRSecurityCode.Name = "txtRSecurityCode";
            this.txtRSecurityCode.ReadOnly = false;
            this.txtRSecurityCode.SelectionStart = 0;
            this.txtRSecurityCode.Size = new System.Drawing.Size(182, 29);
            this.txtRSecurityCode.TabIndex = 11;
            this.txtRSecurityCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRSecurityCode.UseSystemPasswordChar = false;
            this.txtRSecurityCode.TextChanged += new System.EventHandler(this.txtRSecurityCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(54, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Security Code: *";
            // 
            // btnRegister
            // 
            this.btnRegister.ButtonStyle = BonfireButton.Style.Dark;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = global::TestME.Properties.Resources.edit_5_24;
            this.btnRegister.Location = new System.Drawing.Point(263, 232);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.RoundedCorners = true;
            this.btnRegister.Size = new System.Drawing.Size(97, 35);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // ntfBox2
            // 
            this.ntfBox2.BorderCurve = 15;
            this.ntfBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntfBox2.Image = null;
            this.ntfBox2.Location = new System.Drawing.Point(22, 230);
            this.ntfBox2.MinimumSize = new System.Drawing.Size(100, 40);
            this.ntfBox2.Name = "ntfBox2";
            this.ntfBox2.NotificationType = NotificationBox.Type.Warning;
            this.ntfBox2.RoundCorners = true;
            this.ntfBox2.ShowCloseButton = true;
            this.ntfBox2.Size = new System.Drawing.Size(217, 40);
            this.ntfBox2.TabIndex = 8;
            this.ntfBox2.Text = "All fields are necessary";
            this.ntfBox2.Visible = false;
            // 
            // txtRrepeatPass
            // 
            this.txtRrepeatPass.EnabledCalc = true;
            this.txtRrepeatPass.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRrepeatPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtRrepeatPass.Location = new System.Drawing.Point(178, 144);
            this.txtRrepeatPass.MaxLength = 32767;
            this.txtRrepeatPass.MultiLine = false;
            this.txtRrepeatPass.Name = "txtRrepeatPass";
            this.txtRrepeatPass.ReadOnly = false;
            this.txtRrepeatPass.SelectionStart = 0;
            this.txtRrepeatPass.Size = new System.Drawing.Size(182, 29);
            this.txtRrepeatPass.TabIndex = 7;
            this.txtRrepeatPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRrepeatPass.UseSystemPasswordChar = true;
            // 
            // txtRPass
            // 
            this.txtRPass.EnabledCalc = true;
            this.txtRPass.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtRPass.Location = new System.Drawing.Point(178, 109);
            this.txtRPass.MaxLength = 32767;
            this.txtRPass.MultiLine = false;
            this.txtRPass.Name = "txtRPass";
            this.txtRPass.ReadOnly = false;
            this.txtRPass.SelectionStart = 0;
            this.txtRPass.Size = new System.Drawing.Size(182, 29);
            this.txtRPass.TabIndex = 6;
            this.txtRPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRPass.UseSystemPasswordChar = true;
            // 
            // txtREmail
            // 
            this.txtREmail.EnabledCalc = true;
            this.txtREmail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtREmail.Location = new System.Drawing.Point(178, 74);
            this.txtREmail.MaxLength = 32767;
            this.txtREmail.MultiLine = false;
            this.txtREmail.Name = "txtREmail";
            this.txtREmail.ReadOnly = false;
            this.txtREmail.SelectionStart = 0;
            this.txtREmail.Size = new System.Drawing.Size(182, 29);
            this.txtREmail.TabIndex = 5;
            this.txtREmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtREmail.UseSystemPasswordChar = false;
            this.txtREmail.TextChanged += new System.EventHandler(this.txtREmail_TextChanged);
            // 
            // txtRUser
            // 
            this.txtRUser.EnabledCalc = true;
            this.txtRUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtRUser.Location = new System.Drawing.Point(178, 39);
            this.txtRUser.MaxLength = 32767;
            this.txtRUser.MultiLine = false;
            this.txtRUser.Name = "txtRUser";
            this.txtRUser.ReadOnly = false;
            this.txtRUser.SelectionStart = 0;
            this.txtRUser.Size = new System.Drawing.Size(182, 29);
            this.txtRUser.TabIndex = 4;
            this.txtRUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRUser.UseSystemPasswordChar = false;
            this.txtRUser.TextChanged += new System.EventHandler(this.txtRUser_TextChanged);
            // 
            // lblrepeatpass
            // 
            this.lblrepeatpass.AutoSize = true;
            this.lblrepeatpass.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrepeatpass.ForeColor = System.Drawing.Color.DimGray;
            this.lblrepeatpass.Location = new System.Drawing.Point(53, 150);
            this.lblrepeatpass.Name = "lblrepeatpass";
            this.lblrepeatpass.Size = new System.Drawing.Size(119, 18);
            this.lblrepeatpass.TabIndex = 3;
            this.lblrepeatpass.Text = "Repeat Password: *";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.DimGray;
            this.lblpass.Location = new System.Drawing.Point(53, 115);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(75, 18);
            this.lblpass.TabIndex = 2;
            this.lblpass.Text = "Password: *";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.DimGray;
            this.lblemail.Location = new System.Drawing.Point(53, 80);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(54, 18);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email: *";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.DimGray;
            this.lblusername.Location = new System.Drawing.Point(53, 46);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(80, 18);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username: *";
            // 
            // tabsettings
            // 
            this.tabsettings.BackColor = System.Drawing.Color.White;
            this.tabsettings.Controls.Add(this.checkBoxAutoConnect);
            this.tabsettings.Controls.Add(this.checkBoxRemember);
            this.tabsettings.Controls.Add(this.ntfBox3);
            this.tabsettings.Controls.Add(this.txtSDatabase);
            this.tabsettings.Controls.Add(this.txtSPass);
            this.tabsettings.Controls.Add(this.txtSUser);
            this.tabsettings.Controls.Add(this.txtSHost);
            this.tabsettings.Controls.Add(this.lbltable);
            this.tabsettings.Controls.Add(this.lblpasswd);
            this.tabsettings.Controls.Add(this.lbluname);
            this.tabsettings.Controls.Add(this.lblhost);
            this.tabsettings.Controls.Add(this.lbltitle);
            this.tabsettings.Controls.Add(this.btnconnect);
            this.tabsettings.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.tabsettings.ForeColor = System.Drawing.Color.DimGray;
            this.tabsettings.ImageIndex = 3;
            this.tabsettings.Location = new System.Drawing.Point(184, 4);
            this.tabsettings.Name = "tabsettings";
            this.tabsettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabsettings.Size = new System.Drawing.Size(409, 290);
            this.tabsettings.TabIndex = 5;
            this.tabsettings.Text = "Settings";
            // 
            // checkBoxAutoConnect
            // 
            this.checkBoxAutoConnect.Checked = false;
            this.checkBoxAutoConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAutoConnect.EnabledCalc = true;
            this.checkBoxAutoConnect.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutoConnect.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxAutoConnect.Location = new System.Drawing.Point(268, 197);
            this.checkBoxAutoConnect.Name = "checkBoxAutoConnect";
            this.checkBoxAutoConnect.Size = new System.Drawing.Size(112, 18);
            this.checkBoxAutoConnect.TabIndex = 13;
            this.checkBoxAutoConnect.Text = "Auto-Connect";
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.Checked = false;
            this.checkBoxRemember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRemember.EnabledCalc = true;
            this.checkBoxRemember.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRemember.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxRemember.Location = new System.Drawing.Point(149, 197);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(113, 18);
            this.checkBoxRemember.TabIndex = 12;
            this.checkBoxRemember.Text = "Remember Me";
            // 
            // ntfBox3
            // 
            this.ntfBox3.BorderCurve = 15;
            this.ntfBox3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ntfBox3.Image = null;
            this.ntfBox3.Location = new System.Drawing.Point(36, 230);
            this.ntfBox3.MinimumSize = new System.Drawing.Size(100, 40);
            this.ntfBox3.Name = "ntfBox3";
            this.ntfBox3.NotificationType = NotificationBox.Type.Error;
            this.ntfBox3.RoundCorners = true;
            this.ntfBox3.ShowCloseButton = true;
            this.ntfBox3.Size = new System.Drawing.Size(226, 40);
            this.ntfBox3.TabIndex = 10;
            this.ntfBox3.Text = "Connection Successful";
            this.ntfBox3.Visible = false;
            // 
            // txtSDatabase
            // 
            this.txtSDatabase.EnabledCalc = true;
            this.txtSDatabase.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDatabase.ForeColor = System.Drawing.Color.DimGray;
            this.txtSDatabase.Location = new System.Drawing.Point(145, 158);
            this.txtSDatabase.MaxLength = 32767;
            this.txtSDatabase.MultiLine = false;
            this.txtSDatabase.Name = "txtSDatabase";
            this.txtSDatabase.ReadOnly = false;
            this.txtSDatabase.SelectionStart = 0;
            this.txtSDatabase.Size = new System.Drawing.Size(151, 29);
            this.txtSDatabase.TabIndex = 9;
            this.txtSDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSDatabase.UseSystemPasswordChar = false;
            // 
            // txtSPass
            // 
            this.txtSPass.EnabledCalc = true;
            this.txtSPass.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtSPass.Location = new System.Drawing.Point(145, 120);
            this.txtSPass.MaxLength = 32767;
            this.txtSPass.MultiLine = false;
            this.txtSPass.Name = "txtSPass";
            this.txtSPass.ReadOnly = false;
            this.txtSPass.SelectionStart = 0;
            this.txtSPass.Size = new System.Drawing.Size(151, 29);
            this.txtSPass.TabIndex = 8;
            this.txtSPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSPass.UseSystemPasswordChar = true;
            // 
            // txtSUser
            // 
            this.txtSUser.EnabledCalc = true;
            this.txtSUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtSUser.Location = new System.Drawing.Point(145, 82);
            this.txtSUser.MaxLength = 32767;
            this.txtSUser.MultiLine = false;
            this.txtSUser.Name = "txtSUser";
            this.txtSUser.ReadOnly = false;
            this.txtSUser.SelectionStart = 0;
            this.txtSUser.Size = new System.Drawing.Size(151, 29);
            this.txtSUser.TabIndex = 7;
            this.txtSUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSUser.UseSystemPasswordChar = false;
            // 
            // txtSHost
            // 
            this.txtSHost.EnabledCalc = true;
            this.txtSHost.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSHost.ForeColor = System.Drawing.Color.DimGray;
            this.txtSHost.Location = new System.Drawing.Point(145, 44);
            this.txtSHost.MaxLength = 32767;
            this.txtSHost.MultiLine = false;
            this.txtSHost.Name = "txtSHost";
            this.txtSHost.ReadOnly = false;
            this.txtSHost.SelectionStart = 0;
            this.txtSHost.Size = new System.Drawing.Size(203, 29);
            this.txtSHost.TabIndex = 6;
            this.txtSHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSHost.UseSystemPasswordChar = false;
            // 
            // lbltable
            // 
            this.lbltable.AutoSize = true;
            this.lbltable.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltable.ForeColor = System.Drawing.Color.DimGray;
            this.lbltable.Location = new System.Drawing.Point(54, 166);
            this.lbltable.Name = "lbltable";
            this.lbltable.Size = new System.Drawing.Size(67, 18);
            this.lbltable.TabIndex = 4;
            this.lbltable.Text = "Database:";
            // 
            // lblpasswd
            // 
            this.lblpasswd.AutoSize = true;
            this.lblpasswd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasswd.ForeColor = System.Drawing.Color.DimGray;
            this.lblpasswd.Location = new System.Drawing.Point(54, 126);
            this.lblpasswd.Name = "lblpasswd";
            this.lblpasswd.Size = new System.Drawing.Size(66, 18);
            this.lblpasswd.TabIndex = 3;
            this.lblpasswd.Text = "Password:";
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluname.ForeColor = System.Drawing.Color.DimGray;
            this.lbluname.Location = new System.Drawing.Point(54, 88);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(71, 18);
            this.lbluname.TabIndex = 2;
            this.lbluname.Text = "Username:";
            // 
            // lblhost
            // 
            this.lblhost.AutoSize = true;
            this.lblhost.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhost.ForeColor = System.Drawing.Color.DimGray;
            this.lblhost.Location = new System.Drawing.Point(54, 54);
            this.lblhost.Name = "lblhost";
            this.lblhost.Size = new System.Drawing.Size(40, 18);
            this.lblhost.TabIndex = 1;
            this.lblhost.Text = "Host:";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltitle.Location = new System.Drawing.Point(129, 10);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(169, 22);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Database Connection";
            // 
            // btnconnect
            // 
            this.btnconnect.BackColor = System.Drawing.Color.DarkGreen;
            this.btnconnect.ButtonStyle = BonfireButton.Style.Custom;
            this.btnconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconnect.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnect.ForeColor = System.Drawing.Color.White;
            this.btnconnect.Image = global::TestME.Properties.Resources.data_configuration_24;
            this.btnconnect.Location = new System.Drawing.Point(278, 230);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.RoundedCorners = true;
            this.btnconnect.Size = new System.Drawing.Size(102, 35);
            this.btnconnect.TabIndex = 5;
            this.btnconnect.Text = "Connect";
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // tabinfo
            // 
            this.tabinfo.BackColor = System.Drawing.Color.White;
            this.tabinfo.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.tabinfo.ForeColor = System.Drawing.Color.DimGray;
            this.tabinfo.Location = new System.Drawing.Point(184, 4);
            this.tabinfo.Name = "tabinfo";
            this.tabinfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabinfo.Size = new System.Drawing.Size(409, 290);
            this.tabinfo.TabIndex = 2;
            this.tabinfo.Tag = "header";
            this.tabinfo.Text = "Information";
            // 
            // tababout
            // 
            this.tababout.BackColor = System.Drawing.Color.White;
            this.tababout.Controls.Add(this.label1);
            this.tababout.Controls.Add(this.linkLabel1);
            this.tababout.Controls.Add(this.Label2);
            this.tababout.Controls.Add(this.pictureBox1);
            this.tababout.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.tababout.ForeColor = System.Drawing.Color.DimGray;
            this.tababout.ImageIndex = 0;
            this.tababout.Location = new System.Drawing.Point(184, 4);
            this.tababout.Name = "tababout";
            this.tababout.Padding = new System.Windows.Forms.Padding(3);
            this.tababout.Size = new System.Drawing.Size(409, 290);
            this.tababout.TabIndex = 3;
            this.tababout.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(154, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test ME Application";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(145, 140);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(230, 18);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Hli4S/TestMeApp";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Label2.ForeColor = System.Drawing.Color.DimGray;
            this.Label2.Location = new System.Drawing.Point(11, 86);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(386, 162);
            this.Label2.TabIndex = 1;
            this.Label2.Text = resources.GetString("Label2.Text");
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tabforgot
            // 
            this.tabforgot.BackColor = System.Drawing.Color.White;
            this.tabforgot.Controls.Add(this.ntfForgot);
            this.tabforgot.Controls.Add(this.bonfireLabel2);
            this.tabforgot.Controls.Add(this.btnPassGenerate);
            this.tabforgot.Controls.Add(this.label7);
            this.tabforgot.Controls.Add(this.label6);
            this.tabforgot.Controls.Add(this.label5);
            this.tabforgot.Controls.Add(this.txtPassPassword);
            this.tabforgot.Controls.Add(this.txtPassCode);
            this.tabforgot.Controls.Add(this.txtPassUser);
            this.tabforgot.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.tabforgot.ForeColor = System.Drawing.Color.DimGray;
            this.tabforgot.Location = new System.Drawing.Point(184, 4);
            this.tabforgot.Name = "tabforgot";
            this.tabforgot.Padding = new System.Windows.Forms.Padding(3);
            this.tabforgot.Size = new System.Drawing.Size(409, 290);
            this.tabforgot.TabIndex = 6;
            this.tabforgot.Tag = "";
            this.tabforgot.Text = "forget pass";
            this.tabforgot.Leave += new System.EventHandler(this.tabforgot_Leave);
            // 
            // ntfForgot
            // 
            this.ntfForgot.BorderCurve = 8;
            this.ntfForgot.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ntfForgot.Image = null;
            this.ntfForgot.Location = new System.Drawing.Point(54, 226);
            this.ntfForgot.MinimumSize = new System.Drawing.Size(100, 40);
            this.ntfForgot.Name = "ntfForgot";
            this.ntfForgot.NotificationType = NotificationBox.Type.Other;
            this.ntfForgot.RoundCorners = true;
            this.ntfForgot.ShowCloseButton = true;
            this.ntfForgot.Size = new System.Drawing.Size(172, 40);
            this.ntfForgot.TabIndex = 14;
            this.ntfForgot.Text = "Login with new Password!";
            this.ntfForgot.Visible = false;
            // 
            // bonfireLabel2
            // 
            this.bonfireLabel2.AutoSize = true;
            this.bonfireLabel2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bonfireLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bonfireLabel2.Location = new System.Drawing.Point(136, 18);
            this.bonfireLabel2.Name = "bonfireLabel2";
            this.bonfireLabel2.Size = new System.Drawing.Size(143, 20);
            this.bonfireLabel2.TabIndex = 13;
            this.bonfireLabel2.Text = "Generate Password";
            // 
            // btnPassGenerate
            // 
            this.btnPassGenerate.ButtonStyle = BonfireButton.Style.Dark;
            this.btnPassGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassGenerate.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnPassGenerate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPassGenerate.Image = global::TestME.Properties.Resources.undo_5_24;
            this.btnPassGenerate.Location = new System.Drawing.Point(253, 226);
            this.btnPassGenerate.Name = "btnPassGenerate";
            this.btnPassGenerate.RoundedCorners = true;
            this.btnPassGenerate.Size = new System.Drawing.Size(93, 38);
            this.btnPassGenerate.TabIndex = 6;
            this.btnPassGenerate.Text = "Generate";
            this.btnPassGenerate.Click += new System.EventHandler(this.btnPassGenerate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(51, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "New Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(51, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Security Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(51, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username:";
            // 
            // txtPassPassword
            // 
            this.txtPassPassword.EnabledCalc = true;
            this.txtPassPassword.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtPassPassword.ForeColor = System.Drawing.Color.Maroon;
            this.txtPassPassword.Location = new System.Drawing.Point(171, 168);
            this.txtPassPassword.MaxLength = 32767;
            this.txtPassPassword.MultiLine = false;
            this.txtPassPassword.Name = "txtPassPassword";
            this.txtPassPassword.ReadOnly = true;
            this.txtPassPassword.SelectionStart = 0;
            this.txtPassPassword.Size = new System.Drawing.Size(175, 29);
            this.txtPassPassword.TabIndex = 2;
            this.txtPassPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassPassword.UseSystemPasswordChar = false;
            // 
            // txtPassCode
            // 
            this.txtPassCode.EnabledCalc = true;
            this.txtPassCode.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtPassCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtPassCode.Location = new System.Drawing.Point(171, 116);
            this.txtPassCode.MaxLength = 32767;
            this.txtPassCode.MultiLine = false;
            this.txtPassCode.Name = "txtPassCode";
            this.txtPassCode.ReadOnly = false;
            this.txtPassCode.SelectionStart = 0;
            this.txtPassCode.Size = new System.Drawing.Size(175, 29);
            this.txtPassCode.TabIndex = 1;
            this.txtPassCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassCode.UseSystemPasswordChar = false;
            this.txtPassCode.TextChanged += new System.EventHandler(this.txtPassCode_TextChanged);
            // 
            // txtPassUser
            // 
            this.txtPassUser.EnabledCalc = true;
            this.txtPassUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtPassUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.txtPassUser.Location = new System.Drawing.Point(171, 66);
            this.txtPassUser.MaxLength = 32767;
            this.txtPassUser.MultiLine = false;
            this.txtPassUser.Name = "txtPassUser";
            this.txtPassUser.ReadOnly = false;
            this.txtPassUser.SelectionStart = 0;
            this.txtPassUser.Size = new System.Drawing.Size(175, 29);
            this.txtPassUser.TabIndex = 0;
            this.txtPassUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassUser.UseSystemPasswordChar = false;
            this.txtPassUser.TextChanged += new System.EventHandler(this.txtPassUser_TextChanged);
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
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 349);
            this.Controls.Add(this.frmSkin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(305, 150);
            this.Name = "frmStart";
            this.Text = "TestME";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.frmSkin.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tablogin.ResumeLayout(false);
            this.tablogin.PerformLayout();
            this.tabregister.ResumeLayout(false);
            this.tabregister.PerformLayout();
            this.tabsettings.ResumeLayout(false);
            this.tabsettings.PerformLayout();
            this.tababout.ResumeLayout(false);
            this.tababout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabforgot.ResumeLayout(false);
            this.tabforgot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomForm frmSkin;
        private CustomButton btnClose;
        private CustomButton btnMin;
        private XylosTabControl tabMain;
        private System.Windows.Forms.TabPage tablogin;
        private System.Windows.Forms.TabPage tabregister;
        private System.Windows.Forms.TabPage tabinfo;
        private System.Windows.Forms.TabPage tababout;
        private System.Windows.Forms.TabPage tabdashboard;
        private NotificationBox ntfBox1;
        private XylosTextBox txtLPass;
        private XylosTextBox txtLUser;
        private BonfireButton btnLogin;
        private BonfireButton btnRegister;
        private NotificationBox ntfBox2;
        private XylosTextBox txtRrepeatPass;
        private XylosTextBox txtRPass;
        private XylosTextBox txtREmail;
        private XylosTextBox txtRUser;
        private BonfireLabel lblrepeatpass;
        private BonfireLabel lblpass;
        private BonfireLabel lblemail;
        private BonfireLabel lblusername;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private BonfireLabel Label2;
        private System.Windows.Forms.TabPage tabsettings;
        private NotificationBox ntfBox3;
        private XylosTextBox txtSDatabase;
        private XylosTextBox txtSPass;
        private XylosTextBox txtSUser;
        private XylosTextBox txtSHost;
        private BonfireButton btnconnect;
        private BonfireLabel lbltable;
        private BonfireLabel lblpasswd;
        private BonfireLabel lbluname;
        private BonfireLabel lblhost;
        private BonfireLabel lbltitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label3;
        private XylosCheckBox checkBoxRemember;
        private XylosCheckBox checkBoxAutoConnect;
        private XylosCheckBox ckbLRemember;
        private XylosTextBox txtRSecurityCode;
        private System.Windows.Forms.Label label4;
        private BonfireLabel bonfireLabel1;
        private System.Windows.Forms.TabPage tabforgot;
        private System.Windows.Forms.LinkLabel linkForgot;
        private NotificationBox ntfForgot;
        private BonfireLabel bonfireLabel2;
        private BonfireButton btnPassGenerate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private XylosTextBox txtPassPassword;
        private XylosTextBox txtPassCode;
        private XylosTextBox txtPassUser;
    }
}

