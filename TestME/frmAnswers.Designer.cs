namespace TestME
{
    partial class frmAnswers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnswers));
            this.frmskin = new CustomForm();
            this.dgvAnswerList = new System.Windows.Forms.DataGridView();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblDifficultylvl = new System.Windows.Forms.Label();
            this.txtAddQ = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMin = new CustomButton();
            this.btnClose = new CustomButton();
            this.frmskin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswerList)).BeginInit();
            this.SuspendLayout();
            // 
            // frmskin
            // 
            this.frmskin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.frmskin.BorderSize = 10;
            this.frmskin.Controls.Add(this.dgvAnswerList);
            this.frmskin.Controls.Add(this.lblDifficultylvl);
            this.frmskin.Controls.Add(this.txtAddQ);
            this.frmskin.Controls.Add(this.label12);
            this.frmskin.Controls.Add(this.label11);
            this.frmskin.Controls.Add(this.label9);
            this.frmskin.Controls.Add(this.btnMin);
            this.frmskin.Controls.Add(this.btnClose);
            this.frmskin.Darker = false;
            this.frmskin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmskin.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.frmskin.InsideBorderSize = 3;
            this.frmskin.Location = new System.Drawing.Point(0, 0);
            this.frmskin.MinimumSize = new System.Drawing.Size(305, 150);
            this.frmskin.Name = "frmskin";
            this.frmskin.Padding = new System.Windows.Forms.Padding(13, 38, 13, 13);
            this.frmskin.Sizable = false;
            this.frmskin.Size = new System.Drawing.Size(571, 365);
            this.frmskin.TabIndex = 0;
            this.frmskin.Text = "TestME";
            this.frmskin.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.frmskin.TitleColor = System.Drawing.Color.WhiteSmoke;
            this.frmskin.TitleFont = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmskin.TitleYOffset = 0;
            this.frmskin.TopSize = 35;
            this.frmskin.TopSpace = 0;
            // 
            // dgvAnswerList
            // 
            this.dgvAnswerList.AllowUserToAddRows = false;
            this.dgvAnswerList.AllowUserToDeleteRows = false;
            this.dgvAnswerList.AllowUserToResizeColumns = false;
            this.dgvAnswerList.AllowUserToResizeRows = false;
            this.dgvAnswerList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAnswerList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAnswerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnswerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnswerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnswerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.answer,
            this.Correct});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnswerList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAnswerList.Location = new System.Drawing.Point(87, 186);
            this.dgvAnswerList.MultiSelect = false;
            this.dgvAnswerList.Name = "dgvAnswerList";
            this.dgvAnswerList.ReadOnly = true;
            this.dgvAnswerList.RowHeadersVisible = false;
            this.dgvAnswerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAnswerList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAnswerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnswerList.ShowCellErrors = false;
            this.dgvAnswerList.ShowCellToolTips = false;
            this.dgvAnswerList.ShowEditingIcon = false;
            this.dgvAnswerList.ShowRowErrors = false;
            this.dgvAnswerList.Size = new System.Drawing.Size(400, 150);
            this.dgvAnswerList.TabIndex = 49;
            // 
            // answer
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.answer.DefaultCellStyle = dataGridViewCellStyle2;
            this.answer.HeaderText = "Answer";
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.answer.Width = 320;
            // 
            // Correct
            // 
            this.Correct.HeaderText = "Correct";
            this.Correct.Name = "Correct";
            this.Correct.ReadOnly = true;
            this.Correct.Width = 80;
            // 
            // lblDifficultylvl
            // 
            this.lblDifficultylvl.AutoSize = true;
            this.lblDifficultylvl.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDifficultylvl.ForeColor = System.Drawing.Color.DimGray;
            this.lblDifficultylvl.Location = new System.Drawing.Point(446, 140);
            this.lblDifficultylvl.Name = "lblDifficultylvl";
            this.lblDifficultylvl.Size = new System.Drawing.Size(18, 20);
            this.lblDifficultylvl.TabIndex = 34;
            this.lblDifficultylvl.Text = "1";
            // 
            // txtAddQ
            // 
            this.txtAddQ.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQ.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddQ.Location = new System.Drawing.Point(87, 77);
            this.txtAddQ.Multiline = true;
            this.txtAddQ.Name = "txtAddQ";
            this.txtAddQ.ReadOnly = true;
            this.txtAddQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddQ.Size = new System.Drawing.Size(399, 61);
            this.txtAddQ.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(84, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Question:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(84, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "Answers:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(349, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Difficulty Level:";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.btnMin.DrawSeparator = false;
            this.btnMin.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMin.Location = new System.Drawing.Point(496, 4);
            this.btnMin.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnMin.Name = "btnMin";
            this.btnMin.OverlayCol = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMin.Size = new System.Drawing.Size(30, 26);
            this.btnMin.TabIndex = 5;
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
            this.btnClose.Location = new System.Drawing.Point(532, 4);
            this.btnClose.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.OverlayCol = System.Drawing.Color.Maroon;
            this.btnClose.Size = new System.Drawing.Size(30, 26);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 365);
            this.Controls.Add(this.frmskin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(305, 150);
            this.Name = "frmAnswers";
            this.Text = "TestMe";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmAnswers_Load);
            this.frmskin.ResumeLayout(false);
            this.frmskin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomForm frmskin;
        private CustomButton btnMin;
        private CustomButton btnClose;
        private System.Windows.Forms.Label lblDifficultylvl;
        private System.Windows.Forms.TextBox txtAddQ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvAnswerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Correct;
    }
}