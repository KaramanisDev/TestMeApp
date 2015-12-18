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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            AutocompleteMenuNS.Colors colors1 = new AutocompleteMenuNS.Colors();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.rcmAnswer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customForm1 = new CustomForm();
            this.dgvAnswerlist = new System.Windows.Forms.DataGridView();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ntfEdit = new NotificationBox();
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
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.rcmAnswer.SuspendLayout();
            this.customForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswerlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyLvl)).BeginInit();
            this.SuspendLayout();
            // 
            // rcmAnswer
            // 
            this.rcmAnswer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.rcmAnswer.Name = "rcmAnswer";
            this.rcmAnswer.Size = new System.Drawing.Size(153, 48);
            this.rcmAnswer.Opening += new System.ComponentModel.CancelEventHandler(this.rcmAnswer_Opening);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::TestME.Properties.Resources.delete;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // customForm1
            // 
            this.customForm1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customForm1.BorderSize = 10;
            this.customForm1.Controls.Add(this.dgvAnswerlist);
            this.customForm1.Controls.Add(this.ntfEdit);
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
            this.customForm1.Size = new System.Drawing.Size(664, 389);
            this.customForm1.TabIndex = 0;
            this.customForm1.Text = "TestME";
            this.customForm1.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.customForm1.TitleColor = System.Drawing.Color.WhiteSmoke;
            this.customForm1.TitleFont = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customForm1.TitleYOffset = 0;
            this.customForm1.TopSize = 35;
            this.customForm1.TopSpace = 0;
            // 
            // dgvAnswerlist
            // 
            this.dgvAnswerlist.AllowUserToResizeColumns = false;
            this.dgvAnswerlist.AllowUserToResizeRows = false;
            this.dgvAnswerlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAnswerlist.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAnswerlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnswerlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnswerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnswerlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.answer,
            this.Correct});
            this.dgvAnswerlist.ContextMenuStrip = this.rcmAnswer;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnswerlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAnswerlist.Location = new System.Drawing.Point(30, 184);
            this.dgvAnswerlist.MultiSelect = false;
            this.dgvAnswerlist.Name = "dgvAnswerlist";
            this.dgvAnswerlist.RowHeadersVisible = false;
            this.dgvAnswerlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAnswerlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAnswerlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnswerlist.ShowCellErrors = false;
            this.dgvAnswerlist.ShowCellToolTips = false;
            this.dgvAnswerlist.ShowEditingIcon = false;
            this.dgvAnswerlist.ShowRowErrors = false;
            this.dgvAnswerlist.Size = new System.Drawing.Size(360, 174);
            this.dgvAnswerlist.TabIndex = 49;
            this.dgvAnswerlist.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvAnswerlist_CellBeginEdit);
            this.dgvAnswerlist.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvAnswerlist_EditingControlShowing);
            // 
            // answer
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.answer.DefaultCellStyle = dataGridViewCellStyle2;
            this.answer.HeaderText = "Answer";
            this.answer.Name = "answer";
            this.answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.answer.Width = 280;
            // 
            // Correct
            // 
            this.Correct.HeaderText = "Correct";
            this.Correct.Name = "Correct";
            this.Correct.Width = 80;
            // 
            // ntfEdit
            // 
            this.ntfEdit.BorderCurve = 8;
            this.ntfEdit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ntfEdit.Image = null;
            this.ntfEdit.Location = new System.Drawing.Point(403, 294);
            this.ntfEdit.MinimumSize = new System.Drawing.Size(100, 40);
            this.ntfEdit.Name = "ntfEdit";
            this.ntfEdit.NotificationType = NotificationBox.Type.Notice;
            this.ntfEdit.RoundCorners = true;
            this.ntfEdit.ShowCloseButton = true;
            this.ntfEdit.Size = new System.Drawing.Size(235, 64);
            this.ntfEdit.TabIndex = 48;
            this.ntfEdit.Text = "!";
            this.ntfEdit.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(280, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Edit Question";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnSaveChanges.ButtonStyle = BonfireButton.Style.Custom;
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveChanges.Image = global::TestME.Properties.Resources.save_as_24;
            this.btnSaveChanges.Location = new System.Drawing.Point(460, 248);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.RoundedCorners = true;
            this.btnSaveChanges.Size = new System.Drawing.Size(123, 35);
            this.btnSaveChanges.TabIndex = 45;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtAddQ
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtAddQ, null);
            this.txtAddQ.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQ.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddQ.Location = new System.Drawing.Point(30, 92);
            this.txtAddQ.Multiline = true;
            this.txtAddQ.Name = "txtAddQ";
            this.txtAddQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddQ.Size = new System.Drawing.Size(358, 61);
            this.txtAddQ.TabIndex = 43;
            this.txtAddQ.TextChanged += new System.EventHandler(this.txtAddQ_TextChanged);
            this.txtAddQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddQ_KeyPress);
            // 
            // txtAddTags
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtAddTags, this.autocompleteMenu1);
            this.txtAddTags.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTags.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddTags.Location = new System.Drawing.Point(403, 92);
            this.txtAddTags.Multiline = true;
            this.txtAddTags.Name = "txtAddTags";
            this.txtAddTags.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddTags.Size = new System.Drawing.Size(235, 61);
            this.txtAddTags.TabIndex = 42;
            this.txtAddTags.TextChanged += new System.EventHandler(this.txtAddTags_TextChanged);
            this.txtAddTags.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddTags_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(28, 74);
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
            this.label11.Location = new System.Drawing.Point(30, 167);
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
            this.label8.Location = new System.Drawing.Point(457, 214);
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
            this.switchPrivate.Location = new System.Drawing.Point(533, 212);
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
            this.difficultyLvl.Location = new System.Drawing.Point(559, 179);
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
            this.label9.Location = new System.Drawing.Point(457, 181);
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
            this.label10.Location = new System.Drawing.Point(411, 73);
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
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.AppearInterval = 100;
            colors1.BackColor = System.Drawing.Color.White;
            colors1.ForeColor = System.Drawing.Color.Black;
            colors1.HighlightingColor = System.Drawing.Color.YellowGreen;
            colors1.SelectedBackColor = System.Drawing.Color.YellowGreen;
            colors1.SelectedBackColor2 = System.Drawing.Color.White;
            colors1.SelectedForeColor = System.Drawing.Color.Black;
            this.autocompleteMenu1.Colors = colors1;
            this.autocompleteMenu1.Font = new System.Drawing.Font("Trebuchet MS", 9.5F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[0];
            this.autocompleteMenu1.LeftPadding = 0;
            this.autocompleteMenu1.MinFragmentLength = 1;
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 389);
            this.Controls.Add(this.customForm1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(305, 150);
            this.Name = "frmEdit";
            this.Text = "TestMe";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.rcmAnswer.ResumeLayout(false);
            this.customForm1.ResumeLayout(false);
            this.customForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswerlist)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip rcmAnswer;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private NotificationBox ntfEdit;
        private System.Windows.Forms.DataGridView dgvAnswerlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Correct;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
    }
}