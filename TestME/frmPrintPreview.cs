using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using CoolPrintPreview;

namespace TestME
{
    internal partial class frmPrintPreview : Form
    {

        PrintDocument _doc;
        public frmPrintPreview() : this(null)
        {
        }

        public frmPrintPreview(Control parentForm)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                Size = parentForm.Size;
            }
        }

        public PrintDocument Document
        {
            get { return _doc; }
            set
            {
                if (_doc != null)
                {
                    _doc.BeginPrint -= _doc_BeginPrint;
                    _doc.EndPrint -= _doc_EndPrint;
                }

                _doc = value;

                if (_doc != null)
                {
                    _doc.BeginPrint += _doc_BeginPrint;
                    _doc.EndPrint += _doc_EndPrint;
                }

                if (Visible)
                {
                    preview.Document = Document;
                }
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            preview.Document = Document;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (preview.IsRendering && !e.Cancel)
            {
                preview.Cancel();
            }
        }

        void _btnPrint_Click(object sender, EventArgs e)
        {
            using (var dlg = new PrintDialog())
            {
                // configure dialog
                dlg.AllowSomePages = true;
                dlg.AllowSelection = true;
                dlg.UseEXDialog = true;
                dlg.Document = Document;

                // show allowed page range
                var ps = dlg.PrinterSettings;
                ps.MinimumPage = ps.FromPage = 1;
                ps.MaximumPage = ps.ToPage = preview.PageCount;

                // show dialog
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    // print selected page range
                    preview.Print();
                }
            }
        }
        void _btnPageSetup_Click(object sender, EventArgs e)
        {
            using (var dlg = new PageSetupDialog())
            {
                dlg.Document = Document;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    // to show new page layout
                    preview.RefreshPreview();
                }
            }
        }


        void _btnZoom_ButtonClick(object sender, EventArgs e)
        {
            preview.ZoomMode = preview.ZoomMode == ZoomMode.ActualSize
                ? ZoomMode.FullPage
                : ZoomMode.ActualSize;
        }
        void _btnZoom_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == itemActualSize)
            {
                preview.ZoomMode = ZoomMode.ActualSize;
            }
            else if (e.ClickedItem == itemFullPage)
            {
                preview.ZoomMode = ZoomMode.FullPage;
            }
            else if (e.ClickedItem == itemPageWidth)
            {
                preview.ZoomMode = ZoomMode.PageWidth;
            }
            else if (e.ClickedItem == itemTwoPages)
            {
                preview.ZoomMode = ZoomMode.TwoPages;
            }
            if (e.ClickedItem == item10)
            {
                preview.Zoom = .1;
            }
            else if (e.ClickedItem == item100)
            {
                preview.Zoom = 1;
            }
            else if (e.ClickedItem == item150)
            {
                preview.Zoom = 1.5;
            }
            else if (e.ClickedItem == item200)
            {
                preview.Zoom = 2;
            }
            else if (e.ClickedItem == item25)
            {
                preview.Zoom = .25;
            }
            else if (e.ClickedItem == item50)
            {
                preview.Zoom = .5;
            }
            else if (e.ClickedItem == item500)
            {
                preview.Zoom = 5;
            }
            else if (e.ClickedItem == item75)
            {
                preview.Zoom = .75;
            }
        }

        void _btnFirst_Click(object sender, EventArgs e)
        {
            preview.StartPage = 0;
        }
        void _btnPrev_Click(object sender, EventArgs e)
        {
            preview.StartPage--;
        }
        void _btnNext_Click(object sender, EventArgs e)
        {
            preview.StartPage++;
        }
        void _btnLast_Click(object sender, EventArgs e)
        {
            preview.StartPage = preview.PageCount - 1;
        }
        void _txtStartPage_Enter(object sender, EventArgs e)
        {
            txtStartPage.SelectAll();
        }
        void _txtStartPage_Validating(object sender, CancelEventArgs e)
        {
            CommitPageNumber();
        }
        void _txtStartPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            var c = e.KeyChar;
            if (c == (char)13)
            {
                CommitPageNumber();
                e.Handled = true;
            }
            else if (c > ' ' && !char.IsDigit(c))
            {
                e.Handled = true;
            }
        }
        void CommitPageNumber()
        {
            int page;
            if (int.TryParse(txtStartPage.Text, out page))
            {
                preview.StartPage = page - 1;
            }
        }
        void preview_StartPageChanged(object sender, EventArgs e)
        {
            var page = preview.StartPage + 1;
            txtStartPage.Text = page.ToString();
        }
        private void preview_PageCountChanged(object sender, EventArgs e)
        {
            this.Update();
            Application.DoEvents();
            lblPageCount.Text = string.Format("of {0}", preview.PageCount);
        }

        void _btnCancel_Click(object sender, EventArgs e)
        {
            if (preview.IsRendering)
            {
                preview.Cancel();
            }
            else
            {
                Close();
            }

        }
        void _doc_BeginPrint(object sender, PrintEventArgs e)
        {
            btnCancel.Text = "&Cancel";
            btnPrint.Enabled = btnPageSetup.Enabled = false;
        }

        void _doc_EndPrint(object sender, PrintEventArgs e)
        {
            btnCancel.Text = "&Close";
            btnPrint.Enabled = btnPageSetup.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool state = false;
        int lwidth;
        int lheight;
        int ltop;
        int lleft;
        private void btnMax_Click(object sender, EventArgs e)
        {
            
            if(!state)
            {
                lwidth = Width;
                ltop = Top;
                lheight = Height;
                lleft = Left;

                btnMax.Text = "2";
                this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                this.Left = 0;
                this.Top = 0;
                state = true;
            }
            else
            {
                Width = lwidth;
                Top = ltop;
                Height = lheight;
                Left = lleft;
                state = false;
                btnMax.Text = "1";
            }
        }
    }
}
