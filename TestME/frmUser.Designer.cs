﻿namespace TestME
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.frmskin = new CustomForm();
            this.tabUser = new XylosTabControl();
            this.userpanel = new System.Windows.Forms.TabPage();
            this.tabquestions = new System.Windows.Forms.TabPage();
            this.dgvMyQ = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabAddQ = new System.Windows.Forms.TabPage();
            this.ntfAdd = new NotificationBox();
            this.switchCorrectAnswer = new CustomSwitch();
            this.btnAddAnswer = new BonfireButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.listAnswers = new System.Windows.Forms.ListView();
            this.txtAddQ = new System.Windows.Forms.TextBox();
            this.txtAddTags = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.switchPrivate = new CustomSwitch();
            this.difficultyLvl = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReset = new BonfireButton();
            this.btnAdd = new BonfireButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tabfind = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.switchAllTags = new CustomSwitch();
            this.dgvFoundQ = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new BonfireButton();
            this.switchFindAll = new CustomSwitch();
            this.numericMax = new System.Windows.Forms.NumericUpDown();
            this.numericMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new BonfireButton();
            this.btnMakeTest = new BonfireButton();
            this.label5 = new System.Windows.Forms.Label();
            this.finaltest = new System.Windows.Forms.TabPage();
            this.tabtest = new System.Windows.Forms.TabPage();
            this.dgvMyTest = new System.Windows.Forms.DataGridView();
            this.btnSave = new BonfireButton();
            this.btnPrint = new BonfireButton();
            this.label4 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtTestTitle = new XylosTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnMin = new CustomButton();
            this.btnClose = new CustomButton();
            this.toolTipUser = new System.Windows.Forms.ToolTip(this.components);
            this.frmskin.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabquestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyQ)).BeginInit();
            this.tabAddQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyLvl)).BeginInit();
            this.tabfind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).BeginInit();
            this.tabtest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTest)).BeginInit();
            this.SuspendLayout();
            // 
            // frmskin
            // 
            this.frmskin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(25)))));
            this.frmskin.BorderSize = 10;
            this.frmskin.Controls.Add(this.tabUser);
            this.frmskin.Controls.Add(this.btnMin);
            this.frmskin.Controls.Add(this.btnClose);
            this.frmskin.Darker = false;
            this.frmskin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmskin.InsideBorderSize = 3;
            this.frmskin.Location = new System.Drawing.Point(0, 0);
            this.frmskin.MinimumSize = new System.Drawing.Size(305, 150);
            this.frmskin.Name = "frmskin";
            this.frmskin.Padding = new System.Windows.Forms.Padding(13, 38, 13, 13);
            this.frmskin.Sizable = false;
            this.frmskin.Size = new System.Drawing.Size(833, 461);
            this.frmskin.TabIndex = 0;
            this.frmskin.Text = "TestME";
            this.frmskin.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.frmskin.TitleColor = System.Drawing.Color.WhiteSmoke;
            this.frmskin.TitleFont = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmskin.TitleYOffset = 0;
            this.frmskin.TopSize = 35;
            this.frmskin.TopSpace = 0;
            // 
            // tabUser
            // 
            this.tabUser.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabUser.Controls.Add(this.userpanel);
            this.tabUser.Controls.Add(this.tabquestions);
            this.tabUser.Controls.Add(this.tabAddQ);
            this.tabUser.Controls.Add(this.tabfind);
            this.tabUser.Controls.Add(this.finaltest);
            this.tabUser.Controls.Add(this.tabtest);
            this.tabUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUser.FirstHeaderBorder = false;
            this.tabUser.ImageList = this.imageList1;
            this.tabUser.ItemSize = new System.Drawing.Size(40, 180);
            this.tabUser.Location = new System.Drawing.Point(13, 38);
            this.tabUser.Multiline = true;
            this.tabUser.Name = "tabUser";
            this.tabUser.SelectedIndex = 0;
            this.tabUser.Size = new System.Drawing.Size(807, 410);
            this.tabUser.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabUser.TabIndex = 4;
            // 
            // userpanel
            // 
            this.userpanel.BackColor = System.Drawing.Color.White;
            this.userpanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.userpanel.Location = new System.Drawing.Point(184, 4);
            this.userpanel.Name = "userpanel";
            this.userpanel.Padding = new System.Windows.Forms.Padding(3);
            this.userpanel.Size = new System.Drawing.Size(619, 402);
            this.userpanel.TabIndex = 4;
            this.userpanel.Tag = "User Panel";
            this.userpanel.Text = "User Panel";
            // 
            // tabquestions
            // 
            this.tabquestions.BackColor = System.Drawing.Color.White;
            this.tabquestions.Controls.Add(this.dgvMyQ);
            this.tabquestions.Controls.Add(this.label2);
            this.tabquestions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabquestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabquestions.ImageIndex = 1;
            this.tabquestions.Location = new System.Drawing.Point(184, 4);
            this.tabquestions.Name = "tabquestions";
            this.tabquestions.Padding = new System.Windows.Forms.Padding(3);
            this.tabquestions.Size = new System.Drawing.Size(619, 402);
            this.tabquestions.TabIndex = 0;
            this.tabquestions.Text = "My Questions";
            // 
            // dgvMyQ
            // 
            this.dgvMyQ.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMyQ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMyQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyQ.Location = new System.Drawing.Point(59, 74);
            this.dgvMyQ.Name = "dgvMyQ";
            this.dgvMyQ.Size = new System.Drawing.Size(499, 272);
            this.dgvMyQ.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(255, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Questions";
            // 
            // tabAddQ
            // 
            this.tabAddQ.BackColor = System.Drawing.Color.White;
            this.tabAddQ.Controls.Add(this.ntfAdd);
            this.tabAddQ.Controls.Add(this.switchCorrectAnswer);
            this.tabAddQ.Controls.Add(this.btnAddAnswer);
            this.tabAddQ.Controls.Add(this.label15);
            this.tabAddQ.Controls.Add(this.label14);
            this.tabAddQ.Controls.Add(this.txtAnswer);
            this.tabAddQ.Controls.Add(this.listAnswers);
            this.tabAddQ.Controls.Add(this.txtAddQ);
            this.tabAddQ.Controls.Add(this.txtAddTags);
            this.tabAddQ.Controls.Add(this.label12);
            this.tabAddQ.Controls.Add(this.label11);
            this.tabAddQ.Controls.Add(this.label8);
            this.tabAddQ.Controls.Add(this.switchPrivate);
            this.tabAddQ.Controls.Add(this.difficultyLvl);
            this.tabAddQ.Controls.Add(this.label9);
            this.tabAddQ.Controls.Add(this.btnReset);
            this.tabAddQ.Controls.Add(this.btnAdd);
            this.tabAddQ.Controls.Add(this.label10);
            this.tabAddQ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabAddQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabAddQ.ImageIndex = 2;
            this.tabAddQ.Location = new System.Drawing.Point(184, 4);
            this.tabAddQ.Name = "tabAddQ";
            this.tabAddQ.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddQ.Size = new System.Drawing.Size(619, 402);
            this.tabAddQ.TabIndex = 1;
            this.tabAddQ.Text = "Add Question";
            // 
            // ntfAdd
            // 
            this.ntfAdd.BorderCurve = 15;
            this.ntfAdd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntfAdd.ForeColor = System.Drawing.Color.DimGray;
            this.ntfAdd.Image = null;
            this.ntfAdd.Location = new System.Drawing.Point(273, 324);
            this.ntfAdd.MinimumSize = new System.Drawing.Size(100, 40);
            this.ntfAdd.Name = "ntfAdd";
            this.ntfAdd.NotificationType = NotificationBox.Type.Notice;
            this.ntfAdd.RoundCorners = true;
            this.ntfAdd.ShowCloseButton = true;
            this.ntfAdd.Size = new System.Drawing.Size(325, 40);
            this.ntfAdd.TabIndex = 34;
            this.ntfAdd.Text = "Add up to 5 answers";
            this.ntfAdd.Visible = false;
            // 
            // switchCorrectAnswer
            // 
            this.switchCorrectAnswer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.switchCorrectAnswer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.switchCorrectAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.switchCorrectAnswer.isOn = true;
            this.switchCorrectAnswer.Location = new System.Drawing.Point(553, 233);
            this.switchCorrectAnswer.MinimumSize = new System.Drawing.Size(20, 20);
            this.switchCorrectAnswer.Name = "switchCorrectAnswer";
            this.switchCorrectAnswer.Size = new System.Drawing.Size(45, 20);
            this.switchCorrectAnswer.TabIndex = 33;
            this.toolTipUser.SetToolTip(this.switchCorrectAnswer, "Enable it if your \r\nanswer is correct.");
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.ButtonStyle = BonfireButton.Style.Dark;
            this.btnAddAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAnswer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnswer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddAnswer.Image = null;
            this.btnAddAnswer.Location = new System.Drawing.Point(398, 259);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.RoundedCorners = true;
            this.btnAddAnswer.Size = new System.Drawing.Size(93, 26);
            this.btnAddAnswer.TabIndex = 32;
            this.btnAddAnswer.Text = "Add Answer";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(398, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 18);
            this.label15.TabIndex = 31;
            this.label15.Text = "Correct:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(395, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 18);
            this.label14.TabIndex = 30;
            this.label14.Text = "Write Answer:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.Color.DimGray;
            this.txtAnswer.Location = new System.Drawing.Point(398, 184);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(200, 40);
            this.txtAnswer.TabIndex = 29;
            // 
            // listAnswers
            // 
            this.listAnswers.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAnswers.ForeColor = System.Drawing.Color.DimGray;
            this.listAnswers.Location = new System.Drawing.Point(22, 166);
            this.listAnswers.Name = "listAnswers";
            this.listAnswers.Size = new System.Drawing.Size(358, 119);
            this.listAnswers.TabIndex = 28;
            this.toolTipUser.SetToolTip(this.listAnswers, "See the list of phrases that will \r\nregister as possible answers\r\nfor the questio" +
        "n above.");
            this.listAnswers.UseCompatibleStateImageBehavior = false;
            // 
            // txtAddQ
            // 
            this.txtAddQ.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQ.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddQ.Location = new System.Drawing.Point(22, 53);
            this.txtAddQ.Multiline = true;
            this.txtAddQ.Name = "txtAddQ";
            this.txtAddQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddQ.Size = new System.Drawing.Size(358, 61);
            this.txtAddQ.TabIndex = 27;
            this.toolTipUser.SetToolTip(this.txtAddQ, "Write your question.");
            // 
            // txtAddTags
            // 
            this.txtAddTags.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTags.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddTags.Location = new System.Drawing.Point(398, 53);
            this.txtAddTags.Multiline = true;
            this.txtAddTags.Name = "txtAddTags";
            this.txtAddTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddTags.Size = new System.Drawing.Size(200, 61);
            this.txtAddTags.TabIndex = 26;
            this.toolTipUser.SetToolTip(this.txtAddTags, "Give tags to your question to \r\nmake it easier for searching.");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(19, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Write Question:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(19, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Answer List:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(497, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Private:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // switchPrivate
            // 
            this.switchPrivate.BackColor = System.Drawing.Color.White;
            this.switchPrivate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.switchPrivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.switchPrivate.isOn = false;
            this.switchPrivate.Location = new System.Drawing.Point(554, 125);
            this.switchPrivate.MinimumSize = new System.Drawing.Size(20, 20);
            this.switchPrivate.Name = "switchPrivate";
            this.switchPrivate.Size = new System.Drawing.Size(50, 20);
            this.switchPrivate.TabIndex = 21;
            this.toolTipUser.SetToolTip(this.switchPrivate, "Enable it to prevent other\r\nusers to use your question.");
            // 
            // difficultyLvl
            // 
            this.difficultyLvl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.difficultyLvl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLvl.ForeColor = System.Drawing.Color.DimGray;
            this.difficultyLvl.Location = new System.Drawing.Point(427, 124);
            this.difficultyLvl.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.difficultyLvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.difficultyLvl.Name = "difficultyLvl";
            this.difficultyLvl.Size = new System.Drawing.Size(38, 23);
            this.difficultyLvl.TabIndex = 20;
            this.difficultyLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipUser.SetToolTip(this.difficultyLvl, "Choose a difficulty level\r\n(from easy 1 to very difficult 5).");
            this.difficultyLvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(320, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Difficulty Level:";
            // 
            // btnReset
            // 
            this.btnReset.ButtonStyle = BonfireButton.Style.Dark;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Image = null;
            this.btnReset.Location = new System.Drawing.Point(142, 324);
            this.btnReset.Name = "btnReset";
            this.btnReset.RoundedCorners = true;
            this.btnReset.Size = new System.Drawing.Size(65, 26);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonStyle = BonfireButton.Style.Dark;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Image = null;
            this.btnAdd.Location = new System.Drawing.Point(22, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RoundedCorners = true;
            this.btnAdd.Size = new System.Drawing.Size(96, 26);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add Question";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(397, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tags:";
            // 
            // tabfind
            // 
            this.tabfind.BackColor = System.Drawing.Color.White;
            this.tabfind.Controls.Add(this.label16);
            this.tabfind.Controls.Add(this.txtTags);
            this.tabfind.Controls.Add(this.label13);
            this.tabfind.Controls.Add(this.switchAllTags);
            this.tabfind.Controls.Add(this.dgvFoundQ);
            this.tabfind.Controls.Add(this.label7);
            this.tabfind.Controls.Add(this.btnSearch);
            this.tabfind.Controls.Add(this.switchFindAll);
            this.tabfind.Controls.Add(this.numericMax);
            this.tabfind.Controls.Add(this.numericMin);
            this.tabfind.Controls.Add(this.label6);
            this.tabfind.Controls.Add(this.btnClear);
            this.tabfind.Controls.Add(this.btnMakeTest);
            this.tabfind.Controls.Add(this.label5);
            this.tabfind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabfind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabfind.ImageIndex = 3;
            this.tabfind.Location = new System.Drawing.Point(184, 4);
            this.tabfind.Name = "tabfind";
            this.tabfind.Padding = new System.Windows.Forms.Padding(3);
            this.tabfind.Size = new System.Drawing.Size(619, 402);
            this.tabfind.TabIndex = 2;
            this.tabfind.Text = "Find Question";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(47, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 18);
            this.label16.TabIndex = 19;
            this.label16.Text = "Result:";
            // 
            // txtTags
            // 
            this.txtTags.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTags.ForeColor = System.Drawing.Color.DimGray;
            this.txtTags.Location = new System.Drawing.Point(93, 24);
            this.txtTags.Multiline = true;
            this.txtTags.Name = "txtTags";
            this.txtTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTags.Size = new System.Drawing.Size(239, 61);
            this.txtTags.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(413, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 18);
            this.label13.TabIndex = 17;
            this.label13.Text = "Match All Tags:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // switchAllTags
            // 
            this.switchAllTags.BackColor = System.Drawing.Color.White;
            this.switchAllTags.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.switchAllTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.switchAllTags.isOn = false;
            this.switchAllTags.Location = new System.Drawing.Point(522, 67);
            this.switchAllTags.MinimumSize = new System.Drawing.Size(20, 20);
            this.switchAllTags.Name = "switchAllTags";
            this.switchAllTags.Size = new System.Drawing.Size(50, 20);
            this.switchAllTags.TabIndex = 16;
            this.toolTipUser.SetToolTip(this.switchAllTags, "Enable it to find a question\r\nthat has all the given tags.");
            // 
            // dgvFoundQ
            // 
            this.dgvFoundQ.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFoundQ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFoundQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundQ.Location = new System.Drawing.Point(49, 155);
            this.dgvFoundQ.Name = "dgvFoundQ";
            this.dgvFoundQ.Size = new System.Drawing.Size(523, 185);
            this.dgvFoundQ.TabIndex = 15;
            this.toolTipUser.SetToolTip(this.dgvFoundQ, "List of questions that\r\nmatch with the search.");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(412, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "From All Users:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.ButtonStyle = BonfireButton.Style.Dark;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Image = null;
            this.btnSearch.Location = new System.Drawing.Point(509, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RoundedCorners = true;
            this.btnSearch.Size = new System.Drawing.Size(65, 26);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            // 
            // switchFindAll
            // 
            this.switchFindAll.BackColor = System.Drawing.Color.White;
            this.switchFindAll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.switchFindAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.switchFindAll.isOn = true;
            this.switchFindAll.Location = new System.Drawing.Point(522, 26);
            this.switchFindAll.MinimumSize = new System.Drawing.Size(20, 20);
            this.switchFindAll.Name = "switchFindAll";
            this.switchFindAll.Size = new System.Drawing.Size(50, 20);
            this.switchFindAll.TabIndex = 12;
            this.toolTipUser.SetToolTip(this.switchFindAll, "Enable it to find questions\r\nregistered from all users.");
            // 
            // numericMax
            // 
            this.numericMax.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericMax.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMax.ForeColor = System.Drawing.Color.DimGray;
            this.numericMax.Location = new System.Drawing.Point(296, 103);
            this.numericMax.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMax.Name = "numericMax";
            this.numericMax.Size = new System.Drawing.Size(38, 23);
            this.numericMax.TabIndex = 11;
            this.numericMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipUser.SetToolTip(this.numericMax, "Difficult Question");
            this.numericMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericMin
            // 
            this.numericMin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericMin.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMin.ForeColor = System.Drawing.Color.DimGray;
            this.numericMin.Location = new System.Drawing.Point(213, 103);
            this.numericMin.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMin.Name = "numericMin";
            this.numericMin.Size = new System.Drawing.Size(38, 23);
            this.numericMin.TabIndex = 10;
            this.numericMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipUser.SetToolTip(this.numericMin, "Easy Question");
            this.numericMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(50, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Difficulty Level:        From                 To";
            // 
            // btnClear
            // 
            this.btnClear.ButtonStyle = BonfireButton.Style.Dark;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Image = null;
            this.btnClear.Location = new System.Drawing.Point(509, 356);
            this.btnClear.Name = "btnClear";
            this.btnClear.RoundedCorners = true;
            this.btnClear.Size = new System.Drawing.Size(65, 26);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            // 
            // btnMakeTest
            // 
            this.btnMakeTest.ButtonStyle = BonfireButton.Style.Dark;
            this.btnMakeTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeTest.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeTest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMakeTest.Image = null;
            this.btnMakeTest.Location = new System.Drawing.Point(385, 356);
            this.btnMakeTest.Name = "btnMakeTest";
            this.btnMakeTest.RoundedCorners = true;
            this.btnMakeTest.Size = new System.Drawing.Size(96, 26);
            this.btnMakeTest.TabIndex = 7;
            this.btnMakeTest.Text = "Add To Test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(48, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tags:";
            // 
            // finaltest
            // 
            this.finaltest.BackColor = System.Drawing.Color.White;
            this.finaltest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.finaltest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.finaltest.Location = new System.Drawing.Point(184, 4);
            this.finaltest.Name = "finaltest";
            this.finaltest.Size = new System.Drawing.Size(619, 402);
            this.finaltest.TabIndex = 5;
            this.finaltest.Tag = "Final Test";
            this.finaltest.Text = "Final Test";
            // 
            // tabtest
            // 
            this.tabtest.BackColor = System.Drawing.Color.White;
            this.tabtest.Controls.Add(this.dgvMyTest);
            this.tabtest.Controls.Add(this.btnSave);
            this.tabtest.Controls.Add(this.btnPrint);
            this.tabtest.Controls.Add(this.label4);
            this.tabtest.Controls.Add(this.datePicker);
            this.tabtest.Controls.Add(this.txtTestTitle);
            this.tabtest.Controls.Add(this.label3);
            this.tabtest.Controls.Add(this.label1);
            this.tabtest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabtest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.tabtest.ImageIndex = 0;
            this.tabtest.Location = new System.Drawing.Point(184, 4);
            this.tabtest.Name = "tabtest";
            this.tabtest.Padding = new System.Windows.Forms.Padding(3);
            this.tabtest.Size = new System.Drawing.Size(619, 402);
            this.tabtest.TabIndex = 3;
            this.tabtest.Text = "My Test";
            // 
            // dgvMyTest
            // 
            this.dgvMyTest.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMyTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMyTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyTest.Location = new System.Drawing.Point(39, 122);
            this.dgvMyTest.Name = "dgvMyTest";
            this.dgvMyTest.Size = new System.Drawing.Size(538, 220);
            this.dgvMyTest.TabIndex = 7;
            this.toolTipUser.SetToolTip(this.dgvMyTest, "Final Test Ready For Save Or Print");
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = BonfireButton.Style.Dark;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Image = null;
            this.btnSave.Location = new System.Drawing.Point(513, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.RoundedCorners = true;
            this.btnSave.Size = new System.Drawing.Size(65, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.toolTipUser.SetToolTip(this.btnSave, "Save As PDF");
            // 
            // btnPrint
            // 
            this.btnPrint.ButtonStyle = BonfireButton.Style.Dark;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.Image = null;
            this.btnPrint.Location = new System.Drawing.Point(406, 359);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RoundedCorners = true;
            this.btnPrint.Size = new System.Drawing.Size(65, 26);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(405, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date:";
            // 
            // datePicker
            // 
            this.datePicker.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.datePicker.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.datePicker.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(449, 74);
            this.datePicker.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(128, 23);
            this.datePicker.TabIndex = 3;
            this.toolTipUser.SetToolTip(this.datePicker, "Date that the Test will take place.");
            // 
            // txtTestTitle
            // 
            this.txtTestTitle.EnabledCalc = true;
            this.txtTestTitle.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestTitle.ForeColor = System.Drawing.Color.DimGray;
            this.txtTestTitle.Location = new System.Drawing.Point(81, 71);
            this.txtTestTitle.MaxLength = 32767;
            this.txtTestTitle.MultiLine = false;
            this.txtTestTitle.Name = "txtTestTitle";
            this.txtTestTitle.ReadOnly = false;
            this.txtTestTitle.Size = new System.Drawing.Size(318, 29);
            this.txtTestTitle.TabIndex = 2;
            this.txtTestTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTipUser.SetToolTip(this.txtTestTitle, "Write the title of the final Test.");
            this.txtTestTitle.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(36, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(272, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Test";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit-property-16.png");
            this.imageList1.Images.SetKeyName(1, "home-16.png");
            this.imageList1.Images.SetKeyName(2, "plus-5-16.png");
            this.imageList1.Images.SetKeyName(3, "search-3-16.png");
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.btnMin.DrawSeparator = false;
            this.btnMin.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMin.Location = new System.Drawing.Point(758, 4);
            this.btnMin.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnMin.Name = "btnMin";
            this.btnMin.OverlayCol = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMin.Size = new System.Drawing.Size(30, 26);
            this.btnMin.TabIndex = 3;
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
            this.btnClose.Location = new System.Drawing.Point(794, 4);
            this.btnClose.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.OverlayCol = System.Drawing.Color.Maroon;
            this.btnClose.Size = new System.Drawing.Size(30, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolTipUser
            // 
            this.toolTipUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolTipUser.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.toolTipUser.IsBalloon = true;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 461);
            this.Controls.Add(this.frmskin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(305, 150);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.frmskin.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabquestions.ResumeLayout(false);
            this.tabquestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyQ)).EndInit();
            this.tabAddQ.ResumeLayout(false);
            this.tabAddQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyLvl)).EndInit();
            this.tabfind.ResumeLayout(false);
            this.tabfind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).EndInit();
            this.tabtest.ResumeLayout(false);
            this.tabtest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomForm frmskin;
        private CustomButton btnMin;
        private CustomButton btnClose;
        private XylosTabControl tabUser;
        private System.Windows.Forms.TabPage tabquestions;
        private System.Windows.Forms.TabPage tabAddQ;
        private System.Windows.Forms.TabPage tabfind;
        private System.Windows.Forms.TabPage tabtest;
        private System.Windows.Forms.TabPage userpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private XylosTextBox txtTestTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMyQ;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label4;
        private BonfireButton btnSave;
        private BonfireButton btnPrint;
        private System.Windows.Forms.Label label7;
        private BonfireButton btnSearch;
        private CustomSwitch switchFindAll;
        private System.Windows.Forms.NumericUpDown numericMax;
        private System.Windows.Forms.NumericUpDown numericMin;
        private System.Windows.Forms.Label label6;
        private BonfireButton btnClear;
        private BonfireButton btnMakeTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private CustomSwitch switchPrivate;
        private System.Windows.Forms.NumericUpDown difficultyLvl;
        private System.Windows.Forms.Label label9;
        private BonfireButton btnReset;
        private BonfireButton btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvFoundQ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private CustomSwitch switchAllTags;
        private System.Windows.Forms.TextBox txtAddTags;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.TextBox txtAddQ;
        private NotificationBox ntfAdd;
        private CustomSwitch switchCorrectAnswer;
        private BonfireButton btnAddAnswer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.ListView listAnswers;
        private System.Windows.Forms.TabPage finaltest;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTipUser;
        private System.Windows.Forms.DataGridView dgvMyTest;
        private System.Windows.Forms.Label label16;
    }
}