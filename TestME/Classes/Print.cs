using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;

namespace TestME
{
    public static class PrintTest
    {
        private static PrintDocument _document;
        private static List<Question> _test;

        //PrintPage Globals
        private static int iq, ia;
        private static bool flagBreak;
        private static bool typedQ;


        public static void Initialize()
        {
            _document = new PrintDocument();
            _document.PrintPage += new PrintPageEventHandler(printPage);
            _document.BeginPrint += new PrintEventHandler(endPrint);
            _document.EndPrint += new PrintEventHandler(endPrint);
            _document.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
            foreach(PaperSize ps in _document.PrinterSettings.PaperSizes)
            {
                if(ps.PaperName == "A4")
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

        public static List<Question> SetTest
        {
            set { _test = value; }
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
            Font fontQ = new Font("Segoe UI", 12F, FontStyle.Bold);
            Font fontA = new Font("Segoe UI", 10F);

            flagBreak = false;
            var img = new Bitmap(1, 1);
            Graphics E = Graphics.FromImage(img);

            while (iq < _test.Count && flagBreak == false)
            {
                //Edw pernei to keimeno tis erwtisis
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
                        //Edw tipwnei erwtisi
                        G.DrawStringML(question, fontQ, Brushes.Black, x, ref y, width - right);
                        typedQ = true;
                    }
                    while (ia < _test[iq].anwsers.Count && flagBreak == false)
                    {
                        //Edw pernei to keimeno tis apantisis
                        string answer = (ia + 1) + ". " + _test[iq].anwsers[ia].text;
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
                            //Edw tipwnei apantisi
                            G.DrawStringML(answer, fontA, Brushes.Black, x + 30, ref y, width - right);
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

            e.HasMorePages = flagBreak;

        }

        private static void beginPrint(object sender, PrintEventArgs e)
        {
            iq = 0;
            ia = 0;
            flagBreak = false;
            typedQ = false;
        }

        private static void endPrint(object sender, PrintEventArgs e)
        {
            iq = 0;
            ia = 0;
            flagBreak = false;
            typedQ = false;
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
                tempWordWidth = G.MeasureString(word + " ", font).Width;
                measureWord.Width += tempWordWidth;
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
