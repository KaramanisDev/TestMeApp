using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace TestME
{
    public static class PrintTest
    {
        private static PrintDocument _document;
        private static List<Question> _test;
        private static string title;
        private static string date;
        private static bool solved;

        //PrintPage Globals
        private static int iq, ia;
        private static bool flagBreak;
        private static bool typedQ;
        private static int noPage;


        public static void Initialize()
        {
            _document = new PrintDocument();
            _document.PrintPage += new PrintPageEventHandler(printPage);
            _document.BeginPrint += new PrintEventHandler(endPrint);
            _document.EndPrint += new PrintEventHandler(endPrint);
            _document.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
            foreach (PaperSize ps in _document.PrinterSettings.PaperSizes)
            {
                if (ps.PaperName == "A4")
                {
                    _document.DefaultPageSettings.PaperSize = ps;
                    break;
                }
            }
        }

        public static PrintDocument Document
        {
            get { return _document; }
        }

        public static void SetTest(string titles, string dates, List<Question> questions, bool ok)
        {
            title = titles;
            date = dates;
            _test = questions;
            solved = ok;
        }
        public static Margins Margins
        {
            set { _document.DefaultPageSettings.Margins = value; }
        }

        private static void printPage(object sender, PrintPageEventArgs e)
        {
            Graphics G = e.Graphics;

            float right = e.PageSettings.Margins.Right;
            float left = e.PageSettings.Margins.Left;
            float top = e.PageSettings.Margins.Top;
            float bottom = e.PageSettings.Margins.Bottom;
            float width = e.PageSettings.Bounds.Width;
            float height = e.PageSettings.Bounds.Height;
            G.FillRectangle(Brushes.White, 0, 0, width, height);

            float y = top;
            float x = left;
            Font titleFont = new Font("Calibri", 14F, FontStyle.Bold);
            Font fontQ = new Font("Calibri", 12F);
            Font fontA = new Font("Calibri", 11F);
            Font fontW = new Font("Calibri", 100F);

            flagBreak = false;
            var img = new Bitmap(1, 1);
            Graphics E = Graphics.FromImage(img);

            if (noPage == 1)
            {
                //draw these only in first page
                G.DrawStringML(title, titleFont, Brushes.Black, x, ref y, width - right);
                y += (titleFont.GetHeight(G) + 20);
                G.DrawString("Date: " + date, fontQ, Brushes.Black, width - right - 150, y);
                G.DrawString("First Name: ___________________", fontQ, Brushes.Black, x, y);
                y += fontQ.GetHeight(G) + 5;
                G.DrawString("Last Name:  ___________________", fontQ, Brushes.Black, x, y);
                y += fontQ.GetHeight(G) + 5;
                G.DrawString("Class: ________", fontQ, Brushes.Black, x, y);
                y += fontQ.GetHeight(G) + 5;
                G.DrawString("Points:________", fontQ, Brushes.Black, x, y);
                y += fontQ.GetHeight(G) + 35;
                G.DrawStringML("Choose the correct answer. There might be more than one correct answers.", fontQ, Brushes.Black, x, ref y, width - right);
                y += fontQ.GetHeight(G) + 20;
            }

            while (iq < _test.Count && flagBreak == false)
            {
                //Define the question
                string question = (iq + 1) + ". " + _test[iq].question;
                float tempY = y;
                E.DrawStringML(question, fontQ, Brushes.Black, x, ref tempY, width - right);

                if (tempY > height - bottom)
                {
                    flagBreak = true;
                    break;
                }
                else
                {
                    if (!typedQ)
                    {
                        //Draw the question
                        G.DrawStringML(question, fontQ, Brushes.Black, x, ref y, width - right);
                        typedQ = true;
                    }
                    while (ia < _test[iq].anwsers.Count && flagBreak == false)
                    {
                        //Define the answer
                        string answer = _test[iq].anwsers[ia].text;
                        tempY = y;
                        E.DrawStringML(answer, fontQ, Brushes.Black, x, ref tempY, width - right);

                        if (tempY > height - bottom)
                        {
                            flagBreak = true;
                            break;
                        }
                        else
                        {
                            y += 8;
                            //Draw the answer
                            G.DrawRectangle(new Pen(Color.Black), x+15, y, 20, 20);
                            if (solved && _test[iq].anwsers[ia].correct)
                            {
                                G.FillRectangle(Brushes.Black, x+15, y, 20, 20);
                            }
                            G.DrawStringML(answer, fontA, Brushes.Black, x + 45, ref y, width - right);
                            ia++;
                        }
                    }
                    if (ia == _test[iq].anwsers.Count)
                    {
                        ia = 0;
                    }
                    if (!flagBreak)
                    {
                        y += 30;
                        iq++;
                        typedQ = false;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            string watermark = "TestME";

            // Get the size of watermark
            SizeF size = G.MeasureString(watermark, fontW);

            // Define a rotation transformation at the center of the page
            G.TranslateTransform(width / 2, height / 2);
            G.RotateTransform((float)(-Math.Atan(height / width) * 180 / Math.PI));
            G.TranslateTransform(-width / 2, -height / 2);

            // Create a string format
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Near;
            Brush brush = new SolidBrush(Color.FromArgb(60, 128, 125, 123));

            // Draw the watermark
            G.DrawString(watermark, fontW, brush,
              new PointF((width - size.Width) / 2, (height - size.Height) / 2),
              format);

            noPage++;
            e.HasMorePages = flagBreak;

        }

        private static void beginPrint(object sender, PrintEventArgs e)
        {
            iq = 0;
            ia = 0;
            flagBreak = false;
            typedQ = false;
            noPage = 1;
        }

        private static void endPrint(object sender, PrintEventArgs e)
        {
            iq = 0;
            ia = 0;
            flagBreak = false;
            typedQ = false;
            noPage = 1;
        }

        private static void DrawStringML(this Graphics G, string Text, Font font, Brush brush, float x, ref float y, float mX)
        {
            string[] words = Text.Split(' ');
            float tempX = x;
            float totalSpace = mX - x;
            SizeF measureWord = new SizeF(0, font.GetHeight());
            float tempWordWidth = 0;
            foreach (string word in words)
            {
                //measure word width (based in font size)
                tempWordWidth = G.MeasureString(word + " ", font).Width;
                measureWord.Width += tempWordWidth;
                //check if the word fits in free line space
                //if not then change line
                if (measureWord.Width > totalSpace)
                {
                    y += font.GetHeight();
                    tempX = x;
                    measureWord.Width = tempWordWidth;
                }
                G.DrawString(word + " ", font, brush, tempX, y);
                tempX += tempWordWidth;
            }
            y += font.GetHeight();
        }
    }
}
