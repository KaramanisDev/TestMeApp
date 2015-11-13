namespace TestME
{
    partial class frmEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.customForm1 = new CustomForm();
            this.dgvEditAnswers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new BonfireButton();
            this.txtAddQ = new System.Windows.Forms.TextBox();
            this.txtAddTags = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.switchPrivate = new CustomSwitch();
            this.difficultyLvl = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMin = new CustomButton();
            this.btnClose = new CustomButton();
            this.customForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditAnswers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyLvl)).BeginInit();
            this.SuspendLayout();
            // 
            // customForm1
            // 
            this.customForm1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customForm1.BorderSize = 10;
            this.customForm1.Controls.Add(this.dgvEditAnswers);
            this.customForm1.Controls.Add(this.label2);
            this.customForm1.Controls.Add(this.btnSaveChanges);
            this.customForm1.Controls.Add(this.txtAddQ);
            this.customForm1.Controls.Add(this.txtAddTags);
            this.customForm1.Controls.Add(this.label12);
            this.customForm1.Controls.Add(this.label11);
            this.customForm1.Controls.Add(this.label8);
            this.customForm1.Controls.Add(this.switchPrivate);
            this.customForm1.Controls.Add(this.difficultyLvl);
            this.customForm1.Controls.Add(this.label9);
            this.customForm1.Controls.Add(this.label10);
            this.customForm1.Controls.Add(this.btnMin);
            this.customForm1.Controls.Add(this.btnClose);
            this.customForm1.Darker = false;
            this.customForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customForm1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customForm1.InsideBorderSize = 3;
            this.customForm1.Location = new System.Drawing.Point(0, 0);
            this.customForm1.MinimumSize = new System.Drawing.Size(305, 150);
            this.customForm1.Name = "customForm1";
            this.customForm1.Padding = new System.Windows.Forms.Padding(13, 38, 13, 13);
            this.customForm1.Sizable = false;
            this.customForm1.Size = new System.Drawing.Size(664, 372);
            this.customForm1.TabIndex = 0;
            this.customForm1.Text = "TestME";
            this.customForm1.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.customForm1.TitleColor = System.Drawing.Color.WhiteSmoke;
            this.customForm1.TitleFont = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customForm1.TitleYOffset = 0;
            this.customForm1.TopSize = 35;
            this.customForm1.TopSpace = 0;
            // 
            // dgvEditAnswers
            // 
            this.dgvEditAnswers.BackgroundColor = System.Drawing.Color.White;
            this.dgvEditAnswers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditAnswers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditAnswers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEditAnswers.Location = new System.Drawing.Point(46, 193);
            this.dgvEditAnswers.Name = "dgvEditAnswers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditAnswers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEditAnswers.Size = new System.Drawing.Size(358, 150);
            this.dgvEditAnswers.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(291, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Edit Content";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.Teal;
            this.btnSaveChanges.ButtonStyle = BonfireButton.Style.Custom;
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveChanges.Image = global::TestME.Properties.Resources.save_as_24;
            this.btnSaveChanges.Location = new System.Drawing.Point(467, 289);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.RoundedCorners = true;
            this.btnSaveChanges.Size = new System.Drawing.Size(123, 35);
            this.btnSaveChanges.TabIndex = 45;
            this.btnSaveChanges.Text = "Save Changes";
            // 
            // txtAddQ
            // 
            this.txtAddQ.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQ.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddQ.Location = new System.Drawing.Point(46, 101);
            this.txtAddQ.Multiline = true;
            this.txtAddQ.Name = "txtAddQ";
            this.txtAddQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddQ.Size = new System.Drawing.Size(358, 61);
            this.txtAddQ.TabIndex = 43;
            // 
            // txtAddTags
            // 
            this.txtAddTags.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTags.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddTags.Location = new System.Drawing.Point(422, 101);
            this.txtAddTags.Multiline = true;
            this.txtAddTags.Name = "txtAddTags";
            this.txtAddTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddTags.Size = new System.Drawing.Size(200, 61);
            this.txtAddTags.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(44, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 18);
            this.label12.TabIndex = 41;
            this.label12.Text = "Question:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(48, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "Answers:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(463, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Private:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // switchPrivate
            // 
            this.switchPrivate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.switchPrivate.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.switchPrivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.switchPrivate.isOn = false;
            this.switchPrivate.Location = new System.Drawing.Point(518, 234);
            this.switchPrivate.MinimumSize = new System.Drawing.Size(20, 20);
            this.switchPrivate.Name = "switchPrivate";
            this.switchPrivate.Size = new System.Drawing.Size(50, 20);
            this.switchPrivate.TabIndex = 38;
            // 
            // difficultyLvl
            // 
            this.difficultyLvl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.difficultyLvl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLvl.ForeColor = System.Drawing.Color.DimGray;
            this.difficultyLvl.Location = new System.Drawing.Point(568, 193);
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
            this.difficultyLvl.TabIndex = 37;
            this.difficultyLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label9.Location = new System.Drawing.Point(466, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 36;
            this.label9.Text = "Difficulty Level:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(423, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 35;
            this.label10.Text = "Tags:";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.btnMin.DrawSeparator = false;
            this.btnMin.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMin.Location = new System.Drawing.Point(586, 4);
            this.btnMin.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnMin.Name = "btnMin";
            this.btnMin.OverlayCol = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMin.Size = new System.Drawing.Size(30, 26);
            this.btnMin.TabIndex = 34;
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
            this.btnClose.Location = new System.Drawing.Point(622, 4);
            this.btnClose.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.OverlayCol = System.Drawing.Color.Maroon;
            this.btnClose.Size = new System.Drawing.Size(30, 26);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 372);
            this.Controls.Add(this.customForm1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(305, 150);
            this.Name = "frmEdit";
            this.Text = "TestMe";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.customForm1.ResumeLayout(false);
            this.customForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditAnswers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyLvl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomForm customForm1;
        private BonfireButton btnSaveChanges;
        private System.Windows.Forms.TextBox txtAddQ;
        private System.Windows.Forms.TextBox txtAddTags;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private CustomSwitch switchPrivate;
        private System.Windows.Forms.NumericUpDown difficultyLvl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private CustomButton btnMin;
        private CustomButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEditAnswers;
    }
}