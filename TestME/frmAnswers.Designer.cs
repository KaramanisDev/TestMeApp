﻿namespace TestME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnswers));
            this.frmskin = new CustomForm();
            this.btnMin = new CustomButton();
            this.btnClose = new CustomButton();
            this.listAnswers = new System.Windows.Forms.ListView();
            this.txtAddQ = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDifficultylvl = new System.Windows.Forms.Label();
            this.frmskin.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmskin
            // 
            this.frmskin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.frmskin.BorderSize = 10;
            this.frmskin.Controls.Add(this.lblDifficultylvl);
            this.frmskin.Controls.Add(this.listAnswers);
            this.frmskin.Controls.Add(this.txtAddQ);
            this.frmskin.Controls.Add(this.label12);
            this.frmskin.Controls.Add(this.label11);
            this.frmskin.Controls.Add(this.label9);
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
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.btnMin.DrawSeparator = false;
            this.btnMin.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMin.Location = new System.Drawing.Point(494, 4);
            this.btnMin.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnMin.Name = "btnMin";
            this.btnMin.OverlayCol = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMin.Size = new System.Drawing.Size(30, 26);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.btnClose.DrawSeparator = false;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(530, 4);
            this.btnClose.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.OverlayCol = System.Drawing.Color.Maroon;
            this.btnClose.Size = new System.Drawing.Size(30, 26);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            // 
            // listAnswers
            // 
            this.listAnswers.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAnswers.ForeColor = System.Drawing.Color.DimGray;
            this.listAnswers.Location = new System.Drawing.Point(87, 190);
            this.listAnswers.Name = "listAnswers";
            this.listAnswers.Size = new System.Drawing.Size(399, 127);
            this.listAnswers.TabIndex = 33;
            this.listAnswers.UseCompatibleStateImageBehavior = false;
            // 
            // txtAddQ
            // 
            this.txtAddQ.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQ.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddQ.Location = new System.Drawing.Point(87, 77);
            this.txtAddQ.Multiline = true;
            this.txtAddQ.Name = "txtAddQ";
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
            // lblDifficultylvl
            // 
            this.lblDifficultylvl.AutoSize = true;
            this.lblDifficultylvl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficultylvl.ForeColor = System.Drawing.Color.DimGray;
            this.lblDifficultylvl.Location = new System.Drawing.Point(446, 141);
            this.lblDifficultylvl.Name = "lblDifficultylvl";
            this.lblDifficultylvl.Size = new System.Drawing.Size(16, 18);
            this.lblDifficultylvl.TabIndex = 34;
            this.lblDifficultylvl.Text = "1";
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
            this.Text = "frmAnswers";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frmAnswers_Load);
            this.frmskin.ResumeLayout(false);
            this.frmskin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomForm frmskin;
        private CustomButton btnMin;
        private CustomButton btnClose;
        private System.Windows.Forms.Label lblDifficultylvl;
        private System.Windows.Forms.ListView listAnswers;
        private System.Windows.Forms.TextBox txtAddQ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}