using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Drawing.BarCodes;
using PdfSharp.Fonts;
using PdfSharp.Forms;
using System.Diagnostics;
using PdfSharp.Pdf.AcroForms;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TestME
{
    public static class SavePDF
    {
        private static PdfDocument _document;
        private static Margins _margins;
        private static List<Question> _test;
        private static string _title;
        private static string _date;
        private static bool _solved;
        private static string _savePath;

        private static void initialize()
        {
            _document = new PdfDocument();
            _margins = new Margins(50, 50, 50, 50);
        }

        public static void SetTest(string title, string date, List<Question> test, bool solved, string savePath)
        {
            _title = title;
            _date = date;
            _test = test;
            _solved = solved;
            _savePath = savePath;
        }

        public static void SaveTest()
        {

            XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

            initialize();
            PdfPage page = _document.AddPage();
            XGraphics X = XGraphics.FromPdfPage(page);
            page.Size = PageSize.A4;

            double width = page.Width;
            double height = page.Height;
            double top = _margins.Top;
            double bottom = _margins.Bottom;
            double left = _margins.Left;
            double right = _margins.Right*2;

            double y = top;
            double x = left;
            XFont titleFont = new XFont("Calibri", 14F, XFontStyle.Bold,options);
            XFont fontQ = new XFont("Calibri", 12F, XFontStyle.Regular,options);
            XFont fontA = new XFont("Calibri", 11F, XFontStyle.Regular, options);

            var img = new Bitmap(1, 1);
            XGraphics E = XGraphics.FromGraphics(Graphics.FromImage(img), new XSize());

            X.DrawStringML(_title, titleFont, XBrushes.Black, x, ref y, width - right);
            y += titleFont.GetHeight() + 20;

            X.DrawString("Date: " + _date, fontQ, Brushes.Black, width - right - 40, y);
            X.DrawString("First Name: ___________________", fontQ, Brushes.Black, x, y);
            y += fontQ.GetHeight() + 5;

            X.DrawString("Last Name:  ___________________", fontQ, Brushes.Black, x, y);
            y += fontQ.GetHeight() + 5;

            X.DrawString("Class: ________", fontQ, Brushes.Black, x, y);
            y += fontQ.GetHeight() + 5;

            X.DrawString("Points:________", fontQ, Brushes.Black, x, y);
            y += fontQ.GetHeight() + 35;

            X.DrawString("Choose the correct answer. There might be more than one correct answers.", fontQ, Brushes.Black, x, y);
            y += fontQ.GetHeight() + 20;

            for (int i = 0; i < _test.Count; i++)
            {
                string question = (i + 1) + ". " + _test[i].question;
                //Ipologismos gia allagi selidas
                double tempY = y;
                E.DrawStringML(question, fontQ, Brushes.Black, x, ref tempY, width - right);
                if (tempY > height - bottom)
                {
                    page = _document.AddPage();
                    X = XGraphics.FromPdfPage(page);
                    y = top;
                }
                //Prints Questions
                X.DrawStringML(question, fontQ, XBrushes.Black, x, ref y, width - right);
           
                for (int k = 0; k < _test[i].anwsers.Count; k++)
                {
                    string answer = _test[i].anwsers[k].text;
                    //ipologismos gia allagi selida
                    tempY = y;
                    E.DrawStringML(answer, fontQ, Brushes.Black, x, ref tempY, width - right);
                    if (tempY > height-bottom)
                    {
                        page = _document.AddPage();
                        X = XGraphics.FromPdfPage(page);
                        y = top;
                    }

                    y += 3;
                    //Edw tipwnei apantisi
                    X.DrawRectangle(new Pen(Color.Black), x + 15, y, 20, 20);
                    if (_solved && _test[i].anwsers[k].correct)
                    {
                        var cube = new Bitmap(20, 20);
                        Graphics C = Graphics.FromImage(cube);
                        C.FillRectangle(Brushes.Black, 0, 0, 20, 20);
                        X.DrawImage(cube, x+15, y,20,20);
                    }
                    y += 12;
                    X.DrawStringML(answer, fontA, Brushes.Black, x + 45, ref y, width - right);
                }
                y += 30;
            }

            _document.Save("TestDocument.pdf");
            Process.Start("TestDocument.pdf");
        }

        private static void DrawStringML(this XGraphics G, string Text, XFont font, XBrush brush, double x, ref double y, double mX)
        {
            string[] words = Text.Split(' ');
            double tempX = x;
            double totalSpace = mX - x;
            double measureWord = font.GetHeight(G);
            double tempWordWidth = 0;
            foreach (string word in words)
            {
                tempWordWidth = G.MeasureString(word, font).Width;
                measureWord += tempWordWidth;
                if (measureWord > totalSpace)
                {
                    y += font.GetHeight(G);
                    tempX = x;
                    measureWord = tempWordWidth;
                }
                G.DrawString(word, font, brush, tempX, y);
                tempX += tempWordWidth+4;
            }
            y += font.GetHeight(G);
        }
    }
}
