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
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.ntfBox1 = new NotificationBox();
            this.txtPassword = new XylosTextBox();
            this.txtUser = new XylosTextBox();
            this.btnLogin = new BonfireButton();
            this.tabregister = new System.Windows.Forms.TabPage();
            this.btnRegister = new BonfireButton();
            this.ntfBox2 = new NotificationBox();
            this.txtrepeatpass = new XylosTextBox();
            this.txtpass = new XylosTextBox();
            this.txtemail = new XylosTextBox();
            this.txtusername = new XylosTextBox();
            this.lblrepeatpass = new BonfireLabel();
            this.lblpass = new BonfireLabel();
            this.lblemail = new BonfireLabel();
            this.lblusername = new BonfireLabel();
            this.tabsettings = new System.Windows.Forms.TabPage();
            this.ntfBox3 = new NotificationBox();
            this.txttable = new XylosTextBox();
            this.txtpasswd = new XylosTextBox();
            this.txtuname = new XylosTextBox();
            this.txthost = new XylosTextBox();
            this.btnconnect = new BonfireButton();
            this.lbltable = new BonfireLabel();
            this.lblpasswd = new BonfireLabel();
            this.lbluname = new BonfireLabel();
            this.lblhost = new BonfireLabel();
            this.lbltitle = new BonfireLabel();
            this.tabinfo = new System.Windows.Forms.TabPage();
            this.tababout = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label2 = new BonfireLabel();
            this.btnMin = new CustomButton();
            this.btnClose = new CustomButton();
            this.frmSkin.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tablogin.SuspendLayout();
            this.tabregister.SuspendLayout();
            this.tabsettings.SuspendLayout();
            this.tababout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabdashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabdashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabdashboard.Location = new System.Drawing.Point(184, 4);
            this.tabdashboard.Name = "tabdashboard";
            this.tabdashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabdashboard.Size = new System.Drawing.Size(409, 290);
            this.tabdashboard.TabIndex = 4;
            this.tabdashboard.Tag = "Dashboard";
            this.tabdashboard.Text = "Dashboard";
            // 
            // tablogin
            // 
            this.tablogin.BackColor = System.Drawing.Color.White;
            this.tablogin.Controls.Add(this.label3);
            this.tablogin.Controls.Add(this.lblUser);
            this.tablogin.Controls.Add(this.lblPassword);
            this.tablogin.Controls.Add(this.ntfBox1);
            this.tablogin.Controls.Add(this.txtPassword);
            this.tablogin.Controls.Add(this.txtUser);
            this.tablogin.Controls.Add(this.btnLogin);
            this.tablogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tablogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tablogin.ImageIndex = 2;
            this.tablogin.Location = new System.Drawing.Point(184, 4);
            this.tablogin.Name = "tablogin";
            this.tablogin.Padding = new System.Windows.Forms.Padding(3);
            this.tablogin.Size = new System.Drawing.Size(409, 290);
            this.tablogin.TabIndex = 0;
            this.tablogin.Text = "Login";
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
            this.ntfBox1.Location = new System.Drawing.Point(53, 226);
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
            // txtPassword
            // 
            this.txtPassword.EnabledCalc = true;
            this.txtPassword.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
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
            // txtUser
            // 
            this.txtUser.EnabledCalc = true;
            this.txtUser.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
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
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Teal;
            this.btnLogin.ButtonStyle = BonfireButton.Style.Custom;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Image = null;
            this.btnLogin.Location = new System.Drawing.Point(259, 174);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RoundedCorners = true;
            this.btnLogin.Size = new System.Drawing.Size(67, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabregister
            // 
            this.tabregister.BackColor = System.Drawing.Color.White;
            this.tabregister.Controls.Add(this.btnRegister);
            this.tabregister.Controls.Add(this.ntfBox2);
            this.tabregister.Controls.Add(this.txtrepeatpass);
            this.tabregister.Controls.Add(this.txtpass);
            this.tabregister.Controls.Add(this.txtemail);
            this.tabregister.Controls.Add(this.txtusername);
            this.tabregister.Controls.Add(this.lblrepeatpass);
            this.tabregister.Controls.Add(this.lblpass);
            this.tabregister.Controls.Add(this.lblemail);
            this.tabregister.Controls.Add(this.lblusername);
            this.tabregister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabregister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabregister.ImageIndex = 1;
            this.tabregister.Location = new System.Drawing.Point(184, 4);
            this.tabregister.Name = "tabregister";
            this.tabregister.Padding = new System.Windows.Forms.Padding(3);
            this.tabregister.Size = new System.Drawing.Size(409, 290);
            this.tabregister.TabIndex = 1;
            this.tabregister.Text = "Register";
            // 
            // btnRegister
            // 
            this.btnRegister.ButtonStyle = BonfireButton.Style.Dark;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = null;
            this.btnRegister.Location = new System.Drawing.Point(280, 190);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.RoundedCorners = true;
            this.btnRegister.Size = new System.Drawing.Size(80, 35);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            // 
            // ntfBox2
            // 
            this.ntfBox2.BorderCurve = 15;
            this.ntfBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntfBox2.Image = null;
            this.ntfBox2.Location = new System.Drawing.Point(56, 231);
            this.ntfBox2.MinimumSize = new System.Drawing.Size(100, 40);
            this.ntfBox2.Name = "ntfBox2";
            this.ntfBox2.NotificationType = NotificationBox.Type.Warning;
            this.ntfBox2.RoundCorners = true;
            this.ntfBox2.ShowCloseButton = true;
            this.ntfBox2.Size = new System.Drawing.Size(304, 40);
            this.ntfBox2.TabIndex = 8;
            this.ntfBox2.Text = "All fields are necessary";
            this.ntfBox2.Visible = false;
            // 
            // txtrepeatpass
            // 
            this.txtrepeatpass.EnabledCalc = true;
            this.txtrepeatpass.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepeatpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtrepeatpass.Location = new System.Drawing.Point(178, 139);
            this.txtrepeatpass.MaxLength = 32767;
            this.txtrepeatpass.MultiLine = false;
            this.txtrepeatpass.Name = "txtrepeatpass";
            this.txtrepeatpass.ReadOnly = false;
            this.txtrepeatpass.Size = new System.Drawing.Size(182, 29);
            this.txtrepeatpass.TabIndex = 7;
            this.txtrepeatpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtrepeatpass.UseSystemPasswordChar = true;
            // 
            // txtpass
            // 
            this.txtpass.EnabledCalc = true;
            this.txtpass.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtpass.Location = new System.Drawing.Point(178, 104);
            this.txtpass.MaxLength = 32767;
            this.txtpass.MultiLine = false;
            this.txtpass.Name = "txtpass";
            this.txtpass.ReadOnly = false;
            this.txtpass.Size = new System.Drawing.Size(182, 29);
            this.txtpass.TabIndex = 6;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtemail
            // 
            this.txtemail.EnabledCalc = true;
            this.txtemail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.DimGray;
            this.txtemail.Location = new System.Drawing.Point(178, 69);
            this.txtemail.MaxLength = 32767;
            this.txtemail.MultiLine = false;
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = false;
            this.txtemail.Size = new System.Drawing.Size(182, 29);
            this.txtemail.TabIndex = 5;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtemail.UseSystemPasswordChar = false;
            // 
            // txtusername
            // 
            this.txtusername.EnabledCalc = true;
            this.txtusername.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.DimGray;
            this.txtusername.Location = new System.Drawing.Point(178, 34);
            this.txtusername.MaxLength = 32767;
            this.txtusername.MultiLine = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = false;
            this.txtusername.Size = new System.Drawing.Size(182, 29);
            this.txtusername.TabIndex = 4;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusername.UseSystemPasswordChar = false;
            // 
            // lblrepeatpass
            // 
            this.lblrepeatpass.AutoSize = true;
            this.lblrepeatpass.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrepeatpass.ForeColor = System.Drawing.Color.DimGray;
            this.lblrepeatpass.Location = new System.Drawing.Point(53, 145);
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
            this.lblpass.Location = new System.Drawing.Point(53, 110);
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
            this.lblemail.Location = new System.Drawing.Point(53, 75);
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
            this.lblusername.Location = new System.Drawing.Point(53, 41);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(80, 18);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username: *";
            // 
            // tabsettings
            // 
            this.tabsettings.BackColor = System.Drawing.Color.White;
            this.tabsettings.Controls.Add(this.ntfBox3);
            this.tabsettings.Controls.Add(this.txttable);
            this.tabsettings.Controls.Add(this.txtpasswd);
            this.tabsettings.Controls.Add(this.txtuname);
            this.tabsettings.Controls.Add(this.txthost);
            this.tabsettings.Controls.Add(this.btnconnect);
            this.tabsettings.Controls.Add(this.lbltable);
            this.tabsettings.Controls.Add(this.lblpasswd);
            this.tabsettings.Controls.Add(this.lbluname);
            this.tabsettings.Controls.Add(this.lblhost);
            this.tabsettings.Controls.Add(this.lbltitle);
            this.tabsettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabsettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabsettings.ImageIndex = 3;
            this.tabsettings.Location = new System.Drawing.Point(184, 4);
            this.tabsettings.Name = "tabsettings";
            this.tabsettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabsettings.Size = new System.Drawing.Size(409, 290);
            this.tabsettings.TabIndex = 5;
            this.tabsettings.Text = "Settings";
            // 
            // ntfBox3
            // 
            this.ntfBox3.BorderCurve = 15;
            this.ntfBox3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ntfBox3.Image = null;
            this.ntfBox3.Location = new System.Drawing.Point(59, 225);
            this.ntfBox3.MinimumSize = new System.Drawing.Size(100, 40);
            this.ntfBox3.Name = "ntfBox3";
            this.ntfBox3.NotificationType = NotificationBox.Type.Error;
            this.ntfBox3.RoundCorners = true;
            this.ntfBox3.ShowCloseButton = true;
            this.ntfBox3.Size = new System.Drawing.Size(209, 40);
            this.ntfBox3.TabIndex = 10;
            this.ntfBox3.Text = "Connection Failed";
            this.ntfBox3.Visible = false;
            // 
            // txttable
            // 
            this.txttable.EnabledCalc = true;
            this.txttable.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttable.ForeColor = System.Drawing.Color.DimGray;
            this.txttable.Location = new System.Drawing.Point(147, 175);
            this.txttable.MaxLength = 32767;
            this.txttable.MultiLine = false;
            this.txttable.Name = "txttable";
            this.txttable.ReadOnly = false;
            this.txttable.Size = new System.Drawing.Size(151, 29);
            this.txttable.TabIndex = 9;
            this.txttable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txttable.UseSystemPasswordChar = false;
            // 
            // txtpasswd
            // 
            this.txtpasswd.EnabledCalc = true;
            this.txtpasswd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswd.ForeColor = System.Drawing.Color.DimGray;
            this.txtpasswd.Location = new System.Drawing.Point(147, 137);
            this.txtpasswd.MaxLength = 32767;
            this.txtpasswd.MultiLine = false;
            this.txtpasswd.Name = "txtpasswd";
            this.txtpasswd.ReadOnly = false;
            this.txtpasswd.Size = new System.Drawing.Size(151, 29);
            this.txtpasswd.TabIndex = 8;
            this.txtpasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpasswd.UseSystemPasswordChar = false;
            // 
            // txtuname
            // 
            this.txtuname.EnabledCalc = true;
            this.txtuname.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.ForeColor = System.Drawing.Color.DimGray;
            this.txtuname.Location = new System.Drawing.Point(147, 99);
            this.txtuname.MaxLength = 32767;
            this.txtuname.MultiLine = false;
            this.txtuname.Name = "txtuname";
            this.txtuname.ReadOnly = false;
            this.txtuname.Size = new System.Drawing.Size(151, 29);
            this.txtuname.TabIndex = 7;
            this.txtuname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtuname.UseSystemPasswordChar = false;
            // 
            // txthost
            // 
            this.txthost.EnabledCalc = true;
            this.txthost.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthost.ForeColor = System.Drawing.Color.DimGray;
            this.txthost.Location = new System.Drawing.Point(147, 61);
            this.txthost.MaxLength = 32767;
            this.txthost.MultiLine = false;
            this.txthost.Name = "txthost";
            this.txthost.ReadOnly = false;
            this.txthost.Size = new System.Drawing.Size(203, 29);
            this.txthost.TabIndex = 6;
            this.txthost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txthost.UseSystemPasswordChar = false;
            // 
            // btnconnect
            // 
            this.btnconnect.BackColor = System.Drawing.Color.DarkGreen;
            this.btnconnect.ButtonStyle = BonfireButton.Style.Custom;
            this.btnconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconnect.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnect.ForeColor = System.Drawing.Color.White;
            this.btnconnect.Image = null;
            this.btnconnect.Location = new System.Drawing.Point(285, 230);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.RoundedCorners = true;
            this.btnconnect.Size = new System.Drawing.Size(83, 35);
            this.btnconnect.TabIndex = 5;
            this.btnconnect.Text = "Connect";
            // 
            // lbltable
            // 
            this.lbltable.AutoSize = true;
            this.lbltable.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltable.ForeColor = System.Drawing.Color.DimGray;
            this.lbltable.Location = new System.Drawing.Point(56, 183);
            this.lbltable.Name = "lbltable";
            this.lbltable.Size = new System.Drawing.Size(43, 18);
            this.lbltable.TabIndex = 4;
            this.lbltable.Text = "Table:";
            // 
            // lblpasswd
            // 
            this.lblpasswd.AutoSize = true;
            this.lblpasswd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasswd.ForeColor = System.Drawing.Color.DimGray;
            this.lblpasswd.Location = new System.Drawing.Point(56, 143);
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
            this.lbluname.Location = new System.Drawing.Point(56, 105);
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
            this.lblhost.Location = new System.Drawing.Point(56, 71);
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
            this.lbltitle.Location = new System.Drawing.Point(129, 19);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(169, 22);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Database Connection";
            // 
            // tabinfo
            // 
            this.tabinfo.BackColor = System.Drawing.Color.White;
            this.tabinfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabinfo.Location = new System.Drawing.Point(184, 4);
            this.tabinfo.Name = "tabinfo";
            this.tabinfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabinfo.Size = new System.Drawing.Size(409, 290);
            this.tabinfo.TabIndex = 2;
            this.tabinfo.Tag = "Info";
            this.tabinfo.Text = "Information";
            // 
            // tababout
            // 
            this.tababout.BackColor = System.Drawing.Color.White;
            this.tababout.Controls.Add(this.label1);
            this.tababout.Controls.Add(this.pictureBox1);
            this.tababout.Controls.Add(this.linkLabel1);
            this.tababout.Controls.Add(this.Label2);
            this.tababout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tababout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(146, 140);
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
            this.Label2.Location = new System.Drawing.Point(6, 85);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(397, 162);
            this.Label2.TabIndex = 1;
            this.Label2.Text = resources.GetString("Label2.Text");
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Text = "TestMe";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private XylosTextBox txtPassword;
        private XylosTextBox txtUser;
        private BonfireButton btnLogin;
        private BonfireButton btnRegister;
        private NotificationBox ntfBox2;
        private XylosTextBox txtrepeatpass;
        private XylosTextBox txtpass;
        private XylosTextBox txtemail;
        private XylosTextBox txtusername;
        private BonfireLabel lblrepeatpass;
        private BonfireLabel lblpass;
        private BonfireLabel lblemail;
        private BonfireLabel lblusername;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private BonfireLabel Label2;
        private System.Windows.Forms.TabPage tabsettings;
        private NotificationBox ntfBox3;
        private XylosTextBox txttable;
        private XylosTextBox txtpasswd;
        private XylosTextBox txtuname;
        private XylosTextBox txthost;
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
    }
}

