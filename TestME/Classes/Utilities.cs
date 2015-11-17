using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Drawing.BarCodes;
using PdfSharp.Fonts;
using PdfSharp.Forms;
using System.Diagnostics;
using PdfSharp.Pdf.AcroForms;

namespace TestME
{
    public static class Utilities
    {
        public static void txtBoxReplaceNewLine(TextBox txtb)
        {
            int cpos = txtb.SelectionStart;
            txtb.Text = txtb.Text.Replace(Environment.NewLine, "");
            txtb.SelectionStart = cpos;
        }

        public static void txtBoxReplaceSpaceNewLine(TextBox txtb)
        {
            int cpos = txtb.SelectionStart;
            txtb.Text = txtb.Text.Replace(Environment.NewLine, "");
            txtb.Text = txtb.Text.Replace(" ", "");
            txtb.SelectionStart = cpos;
        }

        public static void rightClickSelect(DataGridView dgv, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.ColumnIndex >=0 && e.RowIndex >=0)
            {
                dgv.CurrentCell = dgv[e.ColumnIndex, e.RowIndex];
            }
        }

        public static void notifyThem(NotificationBox ntfbox,string msg,NotificationBox.Type ntype)
        {
            InvokeMe(ntfbox, () =>
            { 
                ntfbox.Text = msg;
                ntfbox.NotificationType = ntype;
                ntfbox.Visible = true;
                ntfbox.Show();
                switch (ntype)
                {
                    case NotificationBox.Type.Success:
                        ntfbox.Image = TestME.Properties.Resources.tick;
                        break;
                    case NotificationBox.Type.Error:
                        ntfbox.Image = TestME.Properties.Resources.error;
                        break;
                    case NotificationBox.Type.Warning:
                        ntfbox.Image = TestME.Properties.Resources.warning;
                        break;
                    case NotificationBox.Type.Notice:
                        ntfbox.Image = TestME.Properties.Resources.notice;
                        break;
                    case NotificationBox.Type.Other:
                        ntfbox.Image = TestME.Properties.Resources.star;
                        break;
                }
            });
        }

        public static Thread runInThread(Action func)
        {
            return new Thread(new ThreadStart(func));
        }

       public static void saveSettings(string filename, params string[] details)
        {
            if (!Directory.Exists(Globals.FilesPath + "\\TestME"))
            {
                Directory.CreateDirectory(Globals.FilesPath + "\\TestME");
            }
            // Write the string array to a new file named "StoredSettings.txt". If file exists overwrite data.
            using (StreamWriter outputFile = new StreamWriter(Globals.FilesPath + "\\TestME\\" + filename,false))
            {
                foreach (string line in details)
                    outputFile.WriteLine(line);
            }
        }

        public static string[] loadSettings(string filename, int size)
        {
            string[] details = new string[size];
            // Open the text file using a stream reader.
            if (File.Exists(Globals.FilesPath +"\\TestME\\" + filename))
            {
                using (StreamReader file = new StreamReader(Globals.FilesPath + "\\TestME\\" + filename))
                {
                        // Read the stream to a string.
                        for (int i=0; i<details.Length; i++)
                        {
                            details[i]=file.ReadLine();
                        }
                    
                }
            }
            return details;
        }

        public static DB AsyncDB(bool DebugMe = false)
        {
            DB tempDB = new DB(Globals.ConnectionStr());
            tempDB.Debug = DebugMe;
            return tempDB;
        }

        public static void InvokeMe(this Control ctrl, MethodInvoker mInvoke)
        {
            ctrl.Invoke((MethodInvoker)(mInvoke));
        }

        public static Control FindControl(Form form, string name)
        {
            foreach (Control control in form.Controls)
            {
                Control result = FindControl(form, control, name);
                if (result != null)
                    return result;
            }

            return null;
        }

        private static Control FindControl(Form form, Control control, string name)
        {
            if (control.Name == name)
            {
                return control;
            }

            foreach (Control subControl in control.Controls)
            {
                Control result = FindControl(form, subControl, name);
                if (result != null)
                    return result;
            }

            return null;
        }

        public static void printPDF(string title, string date, List<Question> quests, bool anwsered)
        {



            
            PdfDocument document = new PdfDocument();
            document.Info.Author = "Rolf Baxter";
            document.Info.Keywords = "PdfSharp, Examples, C#";

            PdfPage page = document.AddPage();
            page.Size = PageSize.A4;

            // Obtain an XGraphics object to render to
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            double fontHeight = 22;
            double fontHeightdate = 15;
            double fontHeightquest = 13;
            double fontHeightanswer = 11;

            //create checkbox
            double ipsos = 145;
            double platos = 35;

            XFont fonttitle = new XFont("Tahoma", fontHeight, XFontStyle.BoldItalic);
            XFont fontdate = new XFont("Tahoma", fontHeightdate, XFontStyle.Regular);
            XFont fontquest = new XFont("Tahoma", fontHeightquest, XFontStyle.Bold);
            XFont fontanswer = new XFont("Tahoma", fontHeightanswer, XFontStyle.Regular);

            // Get the centre of the page
            double y = page.Height -820;
            int lineCount = 0;
            double linePadding = 10;

            // Create a rectangle to draw the text in and draw in it
            XRect rect = new XRect(0, y, page.Width, fontHeight); y += 35;

            //gfx.DrawString(title, font, XBrushes.Black, rect, XStringFormats.Center);
            gfx.DrawString(title, fonttitle, XBrushes.Black, rect, XStringFormats.Center);
            rect = new XRect(35, y, page.Width, fontHeight);
            y += 60;
            gfx.DrawString(date, fontdate, XBrushes.Black, rect, XStringFormat.TopLeft);


            for (int i = 0; i < quests.Count; i++)
            {
                rect = new XRect(35, y, page.Width, fontHeight);
                y += 25;
                gfx.DrawString((i+1)+". "+quests[i].question, fontquest, XBrushes.Black, rect, XStringFormats.TopLeft);
                
                for (int j = 0; j < quests[i].anwsers.Count; j++)
                {
                    rect = new XRect(35, y, page.Width, fontHeight);
                    y += 25;
                    XPen pen = new XPen(XColors.Black, 1.5);
                    gfx.DrawRectangle(pen, platos, ipsos, 10, 10);
                    ipsos += 25;
                    gfx.DrawString("     "+quests[i].anwsers[j].text, fontanswer, XBrushes.Black, rect, XStringFormats.TopLeft);
                    //sografise koutaki
                    if (anwsered == true && quests[i].anwsers[j].correct == true)
                    {
                        
                    }
                    
                }
                ipsos += 24;
            }

            rect = new XRect(25, y, page.Width, fontHeight);
            y += 40;
            gfx.DrawString("Erotisi 1", fontquest, XBrushes.Black, rect, XStringFormats.TopLeft);


            // Save and show the document
            document.Save("TestDocument.pdf");
            Process.Start("TestDocument.pdf");


        }
    } //end of class Utilities
}
