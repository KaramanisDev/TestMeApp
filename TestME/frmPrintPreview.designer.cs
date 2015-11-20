using CoolPrintPreview;

namespace TestME
{
    partial class frmPrintPreview
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintPreview));
            this.frmSkin = new CustomForm();
            this.btnMax = new CustomButton();
            this.btnMin = new CustomButton();
            this.btnClose = new CustomButton();
            this.preview = new CoolPrintPreview.CoolPrintPreviewControl();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnPageSetup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoom = new System.Windows.Forms.ToolStripSplitButton();
            this.itemActualSize = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFullPage = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPageWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTwoPages = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.item500 = new System.Windows.Forms.ToolStripMenuItem();
            this.item200 = new System.Windows.Forms.ToolStripMenuItem();
            this.item150 = new System.Windows.Forms.ToolStripMenuItem();
            this.item100 = new System.Windows.Forms.ToolStripMenuItem();
            this.item75 = new System.Windows.Forms.ToolStripMenuItem();
            this.item50 = new System.Windows.Forms.ToolStripMenuItem();
            this.item25 = new System.Windows.Forms.ToolStripMenuItem();
            this.item10 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPrev = new System.Windows.Forms.ToolStripButton();
            this.txtStartPage = new System.Windows.Forms.ToolStripTextBox();
            this.lblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this._separator = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.frmSkin.SuspendLayout();
            this._toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmSkin
            // 
            this.frmSkin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.frmSkin.BorderSize = 10;
            this.frmSkin.Controls.Add(this.btnMax);
            this.frmSkin.Controls.Add(this.btnMin);
            this.frmSkin.Controls.Add(this.btnClose);
            this.frmSkin.Controls.Add(this.preview);
            this.frmSkin.Controls.Add(this._toolStrip);
            this.frmSkin.Darker = false;
            this.frmSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSkin.InsideBorderSize = 3;
            this.frmSkin.Location = new System.Drawing.Point(0, 0);
            this.frmSkin.MinimumSize = new System.Drawing.Size(305, 150);
            this.frmSkin.Name = "frmSkin";
            this.frmSkin.Padding = new System.Windows.Forms.Padding(13, 38, 13, 13);
            this.frmSkin.Sizable = true;
            this.frmSkin.Size = new System.Drawing.Size(572, 438);
            this.frmSkin.TabIndex = 2;
            this.frmSkin.Text = "TestME : Print Preview";
            this.frmSkin.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.frmSkin.TitleColor = System.Drawing.Color.WhiteSmoke;
            this.frmSkin.TitleFont = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmSkin.TitleYOffset = 0;
            this.frmSkin.TopSize = 35;
            this.frmSkin.TopSpace = 0;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.btnMax.DrawSeparator = false;
            this.btnMax.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMax.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMax.Location = new System.Drawing.Point(496, 5);
            this.btnMax.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnMax.Name = "btnMax";
            this.btnMax.OverlayCol = System.Drawing.Color.DarkGreen;
            this.btnMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMax.Size = new System.Drawing.Size(30, 26);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "1";
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.btnMin.DrawSeparator = false;
            this.btnMin.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMin.Location = new System.Drawing.Point(460, 5);
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
            this.btnClose.Location = new System.Drawing.Point(532, 5);
            this.btnClose.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.OverlayCol = System.Drawing.Color.Maroon;
            this.btnClose.Size = new System.Drawing.Size(30, 26);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // preview
            // 
            this.preview.AutoScroll = true;
            this.preview.BackColor = System.Drawing.Color.Gainsboro;
            this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview.Document = null;
            this.preview.Location = new System.Drawing.Point(13, 63);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(546, 362);
            this.preview.TabIndex = 3;
            this.preview.StartPageChanged += new System.EventHandler(this.preview_StartPageChanged_1);
            this.preview.PageCountChanged += new System.EventHandler(this.preview_PageCountChanged_1);
            // 
            // _toolStrip
            // 
            this._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnPrint,
            this.btnPageSetup,
            this.toolStripSeparator2,
            this.btnZoom,
            this.btnFirst,
            this.btnPrev,
            this.txtStartPage,
            this.lblPageCount,
            this.btnNext,
            this.btnLast,
            this._separator,
            this.btnCancel});
            this._toolStrip.Location = new System.Drawing.Point(13, 38);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(546, 25);
            this._toolStrip.Stretch = true;
            this._toolStrip.TabIndex = 2;
            this._toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "        ";
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 22);
            this.btnPrint.Text = "Print Document";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPageSetup.Image = ((System.Drawing.Image)(resources.GetObject("btnPageSetup.Image")));
            this.btnPageSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(23, 22);
            this.btnPageSetup.Text = "Page Setup";
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnZoom
            // 
            this.btnZoom.AutoToolTip = false;
            this.btnZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemActualSize,
            this.itemFullPage,
            this.itemPageWidth,
            this.itemTwoPages,
            this.toolStripMenuItem1,
            this.item500,
            this.item200,
            this.item150,
            this.item100,
            this.item75,
            this.item50,
            this.item25,
            this.item10});
            this.btnZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom.Image")));
            this.btnZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(71, 22);
            this.btnZoom.Text = "&Zoom";
            this.btnZoom.ButtonClick += new System.EventHandler(this.btnZoom_ButtonClick);
            this.btnZoom.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnZoom_DropDownItemClicked);
            // 
            // itemActualSize
            // 
            this.itemActualSize.Image = ((System.Drawing.Image)(resources.GetObject("itemActualSize.Image")));
            this.itemActualSize.Name = "itemActualSize";
            this.itemActualSize.Size = new System.Drawing.Size(135, 22);
            this.itemActualSize.Text = "Actual Size";
            // 
            // itemFullPage
            // 
            this.itemFullPage.Image = ((System.Drawing.Image)(resources.GetObject("itemFullPage.Image")));
            this.itemFullPage.Name = "itemFullPage";
            this.itemFullPage.Size = new System.Drawing.Size(135, 22);
            this.itemFullPage.Text = "Full Page";
            // 
            // itemPageWidth
            // 
            this.itemPageWidth.Image = ((System.Drawing.Image)(resources.GetObject("itemPageWidth.Image")));
            this.itemPageWidth.Name = "itemPageWidth";
            this.itemPageWidth.Size = new System.Drawing.Size(135, 22);
            this.itemPageWidth.Text = "Page Width";
            // 
            // itemTwoPages
            // 
            this.itemTwoPages.Image = ((System.Drawing.Image)(resources.GetObject("itemTwoPages.Image")));
            this.itemTwoPages.Name = "itemTwoPages";
            this.itemTwoPages.Size = new System.Drawing.Size(135, 22);
            this.itemTwoPages.Text = "Two Pages";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // item500
            // 
            this.item500.Name = "item500";
            this.item500.Size = new System.Drawing.Size(135, 22);
            this.item500.Text = "500%";
            // 
            // item200
            // 
            this.item200.Name = "item200";
            this.item200.Size = new System.Drawing.Size(135, 22);
            this.item200.Text = "200%";
            // 
            // item150
            // 
            this.item150.Name = "item150";
            this.item150.Size = new System.Drawing.Size(135, 22);
            this.item150.Text = "150%";
            // 
            // item100
            // 
            this.item100.Name = "item100";
            this.item100.Size = new System.Drawing.Size(135, 22);
            this.item100.Text = "100%";
            // 
            // item75
            // 
            this.item75.Name = "item75";
            this.item75.Size = new System.Drawing.Size(135, 22);
            this.item75.Text = "75%";
            // 
            // item50
            // 
            this.item50.Name = "item50";
            this.item50.Size = new System.Drawing.Size(135, 22);
            this.item50.Text = "50%";
            // 
            // item25
            // 
            this.item25.Name = "item25";
            this.item25.Size = new System.Drawing.Size(135, 22);
            this.item25.Text = "25%";
            // 
            // item10
            // 
            this.item10.Name = "item10";
            this.item10.Size = new System.Drawing.Size(135, 22);
            this.item10.Text = "10%";
            // 
            // btnFirst
            // 
            this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Red;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(23, 22);
            this.btnFirst.Text = "First Page";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageTransparentColor = System.Drawing.Color.Red;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(23, 22);
            this.btnPrev.Text = "Previous Page";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtStartPage
            // 
            this.txtStartPage.AutoSize = false;
            this.txtStartPage.Name = "txtStartPage";
            this.txtStartPage.Size = new System.Drawing.Size(32, 23);
            this.txtStartPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartPage.Enter += new System.EventHandler(this.txtStartPage_Enter);
            this.txtStartPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartPage_KeyPress);
            this.txtStartPage.Validating += new System.ComponentModel.CancelEventHandler(this.txtStartPage_Validating);
            // 
            // lblPageCount
            // 
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(10, 22);
            this.lblPageCount.Text = " ";
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Red;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 22);
            this.btnNext.Text = "Next Page";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Red;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(23, 22);
            this.btnLast.Text = "Last Page";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // _separator
            // 
            this._separator.Name = "_separator";
            this._separator.Size = new System.Drawing.Size(6, 25);
            this._separator.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoToolTip = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 22);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(572, 438);
            this.Controls.Add(this.frmSkin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(305, 150);
            this.Name = "frmPrintPreview";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Preview";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.frmSkin.ResumeLayout(false);
            this.frmSkin.PerformLayout();
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomForm frmSkin;
        private CoolPrintPreviewControl preview;
        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnPageSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton btnZoom;
        private System.Windows.Forms.ToolStripMenuItem itemActualSize;
        private System.Windows.Forms.ToolStripMenuItem itemFullPage;
        private System.Windows.Forms.ToolStripMenuItem itemPageWidth;
        private System.Windows.Forms.ToolStripMenuItem itemTwoPages;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem item500;
        private System.Windows.Forms.ToolStripMenuItem item200;
        private System.Windows.Forms.ToolStripMenuItem item150;
        private System.Windows.Forms.ToolStripMenuItem item100;
        private System.Windows.Forms.ToolStripMenuItem item75;
        private System.Windows.Forms.ToolStripMenuItem item50;
        private System.Windows.Forms.ToolStripMenuItem item25;
        private System.Windows.Forms.ToolStripMenuItem item10;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPrev;
        private System.Windows.Forms.ToolStripTextBox txtStartPage;
        private System.Windows.Forms.ToolStripLabel lblPageCount;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator _separator;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private CustomButton btnMin;
        private CustomButton btnClose;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private CustomButton btnMax;
    }
}