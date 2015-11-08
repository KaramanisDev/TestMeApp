using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;
using Utilitys;

#region "Base Classes"
public class ThemedControl : Control
{
    public DrawUtils D = new DrawUtils();
    public MouseState State = MouseState.None;
    public Palette Pal;
    protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
    {
    }
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        State = MouseState.Over;
        Invalidate();
    }
    protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
    {
        base.OnMouseDown(e);
        State = MouseState.Down;
        Invalidate();
    }
    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        State = MouseState.None;
        Invalidate();
    }
    protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
    {
        base.OnMouseUp(e);
        State = MouseState.Over;
        Invalidate();
    }
    protected override void OnTextChanged(System.EventArgs e)
    {
        base.OnTextChanged(e);
        Invalidate();
    }
    public ThemedControl() : base()
    {
        MinimumSize = new Size(20, 20);
        ForeColor = Color.FromArgb(146, 149, 152);
        Font = new Font("Segoe UI", 10f);
        DoubleBuffered = true;
        Pal = new Palette();
        Pal.ColHighest = Color.FromArgb(100, 110, 120);
        Pal.ColHigh = Color.FromArgb(65, 70, 75);
        Pal.ColMed = Color.FromArgb(40, 42, 45);
        Pal.ColDim = Color.FromArgb(30, 32, 35);
        Pal.ColDark = Color.FromArgb(15, 17, 19);
        BackColor = Pal.ColDim;
    }
}
public class ThemedContainer : ContainerControl
{
    public DrawUtils D = new DrawUtils();
    [Category("Theme Settings")]
    public bool Sizable { get; set; }

    protected bool Drag = true;
    public MouseState State = MouseState.None;
    protected bool TopCap = false;
    protected bool SizeCap = false;
    public Palette Pal;
    protected Point MouseP = new Point(0, 0);
    protected int TopGrip;
    protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
    {
    }
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        State = MouseState.Over;
        if (Drag & new Rectangle(Width - 15, Height - 15, 15, 15).Contains(MouseP))
        {
            Cursor = Cursors.SizeNWSE;
        }

        Invalidate();
    }
    protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
    {
        base.OnMouseDown(e);
        State = MouseState.Down;
        if (e.Button == System.Windows.Forms.MouseButtons.Left)
        {
            if (new Rectangle(0, 0, Width, TopGrip).Contains(e.Location))
            {
                TopCap = true;
                MouseP = e.Location;
            }
            else if (Drag & new Rectangle(Width - 10, Height - 10, 10, 10).Contains(e.Location))
            {
                SizeCap = true;
                MouseP = e.Location;
            }
            if (Sizable & new Rectangle(Width - 10, Height - 10, 10, 10).Contains(e.Location))
            {
                Cursor = Cursors.SizeNWSE;
            }
        }
    }
    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        State = MouseState.None;
        Invalidate();
    }
    protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
    {
        base.OnMouseUp(e);
        State = MouseState.Over;
        TopCap = false;
        if (Drag)
        {
            SizeCap = false;
        }

    }
    protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
    {
        System.ComponentModel.TypeConverter converter =
        System.ComponentModel.TypeDescriptor.GetConverter(typeof(Point));
        base.OnMouseMove(e);

        if (TopCap)
        {
            Parent.Location = MousePosition - new Size(MouseP);
        }
        if (Sizable & Drag & SizeCap)
        {
            MouseP = e.Location;
            Parent.Size = new Size(MouseP);
            Invalidate();
        }
        if (Sizable & new Rectangle(Width - 10, Height - 10, 10, 10).Contains(e.Location))
        {
            Cursor = Cursors.SizeNWSE;
        }
        else
        {
            Cursor = Cursors.Arrow;
        }

    }
    protected override void OnTextChanged(System.EventArgs e)
    {
        base.OnTextChanged(e);
        Invalidate();
    }
    public ThemedContainer() : base()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        DoubleBuffered = true;
        MinimumSize = new Size(20, 20);
        //ForeColor = Color.FromArgb(146, 149, 152);
        //Font = new Font("Trebuchet MS", 10f);
        DoubleBuffered = true;
        Pal = new Palette();
        Pal.ColHighest = Color.FromArgb(100, 110, 120);
        Pal.ColHigh = Color.FromArgb(65, 70, 75);
        Pal.ColMed = Color.FromArgb(40, 42, 45);
        Pal.ColDim = Color.FromArgb(30, 32, 35);
        Pal.ColDark = Color.FromArgb(5, 8, 10);
        BackColor = Pal.ColDim;
    }
}
#endregion

#region "Theme"
public class CustomForm : ThemedContainer
{
    [Category("Theme Settings")]
    public int TopSize { get; set; }
    [Category("Theme Settings")]
    public int TopSpace { get; set; }
    [Category("Theme Settings")]
    public int BorderSize { get; set; }
    [Category("Theme Settings")]
    public int InsideBorderSize { get; set; }
    [Category("Theme Settings")]
    public Font TitleFont { get; set; }
    [Category("Theme Settings")]
    public Color TitleColor { get; set; }
    [Category("Theme Settings")]
    public HorizontalAlignment TitleAlignment { get; set; }
    [Category("Theme Settings")]
    public int TitleYOffset { get; set; }
    [Category("Theme Settings")]
    public bool Darker { get; set; }

    public CustomForm() : base()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        DoubleBuffered = true;
        this.DoubleBuffered = true;
        MinimumSize = new Size(305, 150);
        Dock = DockStyle.Fill;
        TopSize = 30;
        TopSpace = 0;
        BorderSize = 6;
        InsideBorderSize = 4;
        Darker = false;
        TopGrip = TopSize + TopSpace;
        TitleFont = new Font("Calibri Light", 15.75f,FontStyle.Italic);
        TitleYOffset = 0;
        BackColor = Color.FromArgb(21, 23, 25);
        TitleColor = Color.FromArgb(160, Color.White);
        this.Padding = new Padding(BorderSize+InsideBorderSize, TopSize + TopSpace + InsideBorderSize, BorderSize + InsideBorderSize, BorderSize + InsideBorderSize);
    }
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        Graphics G = e.Graphics;
        base.OnPaint(e);
        TopGrip = TopSize + TopSpace;

        this.Padding = new Padding(BorderSize + InsideBorderSize, TopSize + TopSpace + InsideBorderSize, BorderSize + InsideBorderSize, BorderSize + InsideBorderSize);
        this.ParentForm.TransparencyKey = Color.Fuchsia;
        this.ParentForm.MinimumSize = MinimumSize;
        if (!(this.ParentForm.FormBorderStyle == FormBorderStyle.None))
        {
            this.ParentForm.FormBorderStyle = FormBorderStyle.None;
        }
        G.Clear(this.ParentForm.TransparencyKey);

        //| Drawing the main rectangle base.
        Rectangle MainRect = new Rectangle(0, TopSpace, Width - 1, Height - (1 + TopSpace));
        Rectangle MainHighlightRect = new Rectangle(1, 1 + TopSpace, Width - 3, Height - (3+ TopSpace));
        TextureBrush BGTextureBrush = new TextureBrush(D.CodeToImage(D.BGTexture), WrapMode.TileFlipXY);
        G.FillRectangle(BGTextureBrush, MainRect);
        G.DrawRectangle(new Pen(Color.FromArgb(40, Pal.ColHighest)), MainHighlightRect);
        G.DrawRectangle(Pens.Black, MainRect);

        //| Detail to the main rect's top grip
        Rectangle ShineRect = new Rectangle(0, TopSpace, Width, Height);
        //G.FillRectangle(new SolidBrush(Color.FromArgb(40, Pal.ColMed)), ShineRect);
        LinearGradientBrush SubShineLGB1 = new LinearGradientBrush(ShineRect, Color.Black, Color.Black, 0, false);
        LinearGradientBrush SubShineLGB2 = new LinearGradientBrush(ShineRect, Color.Black, Color.Black, 0, false);
        ColorBlend Blend = new ColorBlend();
        Blend.Positions = new[]{0,1 / 3f,2 / 3f,1};
        Blend.Colors = new[]{
            Color.FromArgb(50, Color.Black),
			Color.FromArgb(150, Color.Black),
			Color.FromArgb(50, Color.Black),
			Color.Transparent
        };
        SubShineLGB1.InterpolationColors = Blend;
        SubShineLGB1.RotateTransform(45);
        Blend.Colors = new[]{
            Color.FromArgb(50, Pal.ColHighest),
			Color.FromArgb(150, Pal.ColHighest),
			Color.FromArgb(50, Pal.ColHighest),
			Color.Transparent
        };
        SubShineLGB2.InterpolationColors = Blend;
        SubShineLGB2.RotateTransform(45);
        //|
        //D.FillGradientBeam(G, Color.Transparent, Color.FromArgb(80, Pal.ColHighest), ShineRect, GradientAlignment.Vertical);
        //G.DrawLine(new Pen(SubShineLGB1), new Point(1, ShineRect.Height), new Point(Width - 2, ShineRect.Height));
        //G.DrawLine(new Pen(SubShineLGB2), new Point(1, ShineRect.Height + 1), new Point(Width - 2, ShineRect.Height + 1));

        //| Goind back through and making the rect below the detail darker
        Rectangle DarkRect = new Rectangle(2, TopSpace + 2, Width - 4, Height - 4 - TopSpace);
        LinearGradientBrush DarkLGB = new LinearGradientBrush(DarkRect, Color.FromArgb(100, Color.Black), Color.FromArgb(100, Color.Black), 90);
        if (Darker) {
            G.FillRectangle(DarkLGB, DarkRect);
        }
        //Lighter
        //G.FillRectangle(new SolidBrush(Color.FromArgb(80, Pal.ColHigh)), DarkRect);

        //| The inner and slightly brigher rectangle of the form
        Rectangle InnerRect = new Rectangle(BorderSize-1, TopSpace + TopSize-1, Width - (BorderSize*2)+1, Height - BorderSize - TopSize - TopSpace+1);
        Rectangle InnerHighlightRect = new Rectangle(BorderSize + 1, TopSpace + TopSize + 1, Width - (BorderSize * 2) - 1, Height - BorderSize - TopSize - TopSpace - 1);
        Rectangle InnerHighlightRect2 = new Rectangle(BorderSize + InsideBorderSize, TopSpace + TopSize + InsideBorderSize, Width - (BorderSize * 2) - (InsideBorderSize*2), Height - BorderSize - TopSize - TopSpace - (InsideBorderSize*2));
        // G.FillRectangle(BGTextureBrush, InnerRect);
        // G.FillRectangle(new SolidBrush(Color.FromArgb(45, Pal.ColHigh)), InnerRect);
        G.FillRectangle(new SolidBrush(D.ColorFromHex("#33373B")), InnerRect);
        G.FillRectangle(new SolidBrush(BackColor), InnerHighlightRect2);
        G.DrawRectangle(new Pen(Color.FromArgb(65, Pal.ColHighest)), InnerRect);
        //G.DrawRectangle(new Pen(Color.FromArgb(40, Pal.ColHighest)), MainHighlightRect);
        //G.DrawRectangle(Pens.Black, MainRect);

        //G.FillRectangle(new SolidBrush(D.ColorFromHex("#33373B")), InnerHighlightRect);
        //G.FillRectangle(new SolidBrush(BackColor), InnerHighlightRect2);
        //G.DrawRectangle(new Pen(Color.FromArgb(80, Pal.ColHighest)), InnerHighlightRect);
        //G.DrawRectangle(Pens.Black, InnerRect);

        int textPad = 0;

        if (this.ParentForm.ShowIcon)
        {
            G.DrawIcon(this.ParentForm.Icon, new Rectangle(BorderSize-4, TopSpace + 3, TopSize - 4, TopSize - 4));
            textPad = BorderSize + TopSize - 5 + 4;
        }

        if(TitleAlignment == HorizontalAlignment.Center) {
            textPad = 0;
        }else if(TitleAlignment == HorizontalAlignment.Left && this.ParentForm.ShowIcon == false){
            textPad = BorderSize + 1;
        }
        D.DrawTextWithShadow(G, new Rectangle(textPad, TopSpace, Width, TopSize + TitleYOffset), Text, TitleFont, TitleAlignment, TitleColor, Color.Black);

        if (Sizable == true)
        {
            Rectangle SizeRect = new Rectangle(Width - BorderSize+1, Height - BorderSize+1, BorderSize-3, BorderSize-3);
            LinearGradientBrush SizeLGB = new LinearGradientBrush(DarkRect, Color.FromArgb(10, Color.LightGray), Color.FromArgb(10, Color.LightGray), 90);
            G.FillRectangle(SizeLGB, SizeRect);
            G.FillRectangle(SizeLGB, SizeRect);
        }

    }
}
public class CustomButton : ThemedControl
{
    [Category("Theme Settings")]
    public Color OverlayCol { get; set; }
    [Category("Theme Settings")]
    public bool DrawSeparator { get; set; }
    public CustomButton() : base()
    {
        Font = new Font("Segoe UI", 11f);
        ForeColor = Color.Gainsboro;
    }
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        Graphics G = e.Graphics;
        base.OnPaint(e);
        G.Clear(this.BackColor);

        //| Drawing the main rectangle base.
        Rectangle MainRect = new Rectangle(0, 0, Width - 1, Height - 1);
        Rectangle MainHighlightRect = new Rectangle(1, 1, Width - 3, Height - 3);
        TextureBrush BGTextureBrush = new TextureBrush(D.CodeToImage(D.BGTexture), WrapMode.TileFlipXY);
        G.FillRectangle(BGTextureBrush, MainRect);

        if (OverlayCol != null)
        {
            G.FillRectangle(new SolidBrush(OverlayCol), MainRect);
        }


        //| Detail to the main rect's top & bottom gradients
        int GradientHeight = Height / 2;
        Rectangle ShineRect = new Rectangle(0, 0, Width, GradientHeight);
        Rectangle ShineRect2 = new Rectangle(0, GradientHeight, Width, GradientHeight);
        G.FillRectangle(new SolidBrush(Color.FromArgb(40, Pal.ColMed)), ShineRect);
        D.FillGradientBeam(G, Color.Transparent, Color.FromArgb(60, Pal.ColHighest), ShineRect, GradientAlignment.Vertical);
        D.FillGradientBeam(G, Color.Transparent, Color.FromArgb(30, Pal.ColHighest), ShineRect2, GradientAlignment.Vertical);
        if (DrawSeparator)
        {
            G.DrawLine(new Pen(Color.FromArgb(50, Color.Black)), new Point(1, ShineRect.Height), new Point(Width - 2, ShineRect.Height));
            G.DrawLine(new Pen(Color.FromArgb(35, Pal.ColHighest)), new Point(1, ShineRect.Height + 1), new Point(Width - 2, ShineRect.Height + 1));
            G.DrawLine(new Pen(Color.FromArgb(50, Color.Black)), new Point(1, ShineRect.Height + 2), new Point(Width - 2, ShineRect.Height + 2));
        }

        //| Goind back through and making the rect below the detail darker
        LinearGradientBrush DarkLGB = new LinearGradientBrush(MainRect, Color.FromArgb(20, Color.Black), Color.FromArgb(100, Color.Black), 90);
        G.FillRectangle(DarkLGB, MainRect);

        switch (State)
        {
            case MouseState.Over:
                G.FillRectangle(new SolidBrush(Color.FromArgb(30, Pal.ColHighest)), MainRect);
                break;
            case MouseState.Down:
                G.FillRectangle(new SolidBrush(Color.FromArgb(56, Color.Black)), MainRect);
                break;
        }

        G.DrawRectangle(new Pen(Color.FromArgb(40, Pal.ColHighest)), MainHighlightRect);
        G.DrawRectangle(Pens.Black, MainRect);
        if (!Enabled)
        {
            ForeColor = Color.FromArgb(146, 149, 152);
        }
        D.DrawTextWithShadow(G, new Rectangle(0, 0, Width, Height), Text, Font, HorizontalAlignment.Center, ForeColor, Color.Black);
    }
}
public class CustomSwitch : ThemedControl {
    public bool isOn = false;
    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        isOn = !isOn;
    }
    public CustomSwitch() : base(){
        Size = new Size(50, 20);
        BackColor = Color.WhiteSmoke;
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;
        base.OnPaint(e);
        G.Clear(this.BackColor);

        if (isOn)
        {
            //| Drawing the main rectangle base.
            Rectangle MainRect = new Rectangle(0, 2, 45, 16);
            Rectangle InnerRect = new Rectangle(3, 5, 39, 10);

            G.FillRectangle(new SolidBrush(D.ColorFromHex("#7a7474")), MainRect);
            G.FillRectangle(new SolidBrush(D.ColorFromHex("#45d138")), InnerRect);

            //Drawing the switch rectangle
            Rectangle BoxRect = new Rectangle(30, 0, 16, 20);
            G.FillRectangle(new SolidBrush(D.ColorFromHex("#000000")), BoxRect);

        }
        else
        {
            //| Drawing the main rectangle base.
            Rectangle MainRect = new Rectangle(0, 2, 45, 16);
            Rectangle InnerRect = new Rectangle(3, 5, 39, 10);

            G.FillRectangle(new SolidBrush(D.ColorFromHex("#7a7474")), MainRect);
            G.FillRectangle(new SolidBrush(D.ColorFromHex("#d4171a")), InnerRect);

            //Drawing the switch rectangle
            Rectangle BoxRect = new Rectangle(0, 0, 16, 20);
            G.FillRectangle(new SolidBrush(D.ColorFromHex("#000000")), BoxRect);

        }

    }

}

#endregion

#region "Theme Utility Stuff"
namespace Utilitys
{
    public class Palette
    {
        public Color ColHighest;
        public Color ColHigh;
        public Color ColMed;
        public Color ColDim;
        public Color ColDark;
    }
    public enum ImageMode : byte
    {
        Normal = 0,
        Scaled = 1
    }
    public enum MouseState : byte
    {
        None = 0,
        Over = 1,
        Down = 2,
        Block = 3
    }
    public enum GradientAlignment : byte
    {
        Vertical = 0,
        Horizontal = 1
    }
}
public class DrawUtils
{
   public string BGTexture = "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";
    public void FillGradientBeam(Graphics g, Color Col1, Color Col2, Rectangle rect, GradientAlignment align)
    {
        SmoothingMode stored = g.SmoothingMode;
        ColorBlend Blend = new ColorBlend();
        g.SmoothingMode = SmoothingMode.HighQuality;
        LinearGradientBrush PathGradient;
        switch (align)
        {
            case GradientAlignment.Vertical:
                PathGradient = new LinearGradientBrush(new Point(rect.X, rect.Y), new Point(rect.X + rect.Width - 1, rect.Y), Color.Black, Color.Black);
                Blend.Positions = new[] { 0, 1 / 2f, 1 };

                Blend.Colors = new[]{Col1,Col2,Col1};
                PathGradient.InterpolationColors = Blend;
                g.FillRectangle(PathGradient, rect);
                break;
            case GradientAlignment.Horizontal:
                PathGradient = new LinearGradientBrush(new Point(rect.X, rect.Y), new Point(rect.X, rect.Y + rect.Height), Color.Black, Color.Black);
                Blend.Positions = new[]{0,1 / 2f,1 };
                Blend.Colors = new[]{
                    Col1,
					Col2,
					Col1
                };
                PathGradient.InterpolationColors = Blend;
                PathGradient.RotateTransform(0);
                g.FillRectangle(PathGradient, rect);
                break;
        }
        g.SmoothingMode = stored;
    }
    public void DrawTextWithShadow(Graphics G, Rectangle ContRect, string Text, Font TFont, HorizontalAlignment TAlign, Color TColor, Color BColor)
    {
        DrawText(G, new Rectangle(ContRect.X + 1, ContRect.Y + 1, ContRect.Width, ContRect.Height), Text, TFont, TAlign, BColor);
        DrawText(G, ContRect, Text, TFont, TAlign, TColor);
    }
    public void FillDualGradPath(Graphics g, Color Col1, Color Col2, Rectangle rect, GraphicsPath gp, GradientAlignment align)
    {
        SmoothingMode stored = g.SmoothingMode;
        ColorBlend Blend = new ColorBlend();
        g.SmoothingMode = SmoothingMode.HighQuality;
        LinearGradientBrush PathGradient;
        switch (align)
        {
            case GradientAlignment.Vertical:
                PathGradient = new LinearGradientBrush(new Point(rect.X, rect.Y), new Point(rect.X + rect.Width - 1, rect.Y), Color.Black, Color.Black);
                Blend.Positions = new[]{
                    0,
					1 / 2f,
					1
                };
                Blend.Colors = new[]{
                    Col1,
					Col2,
					Col1
                };
                PathGradient.InterpolationColors = Blend;
                g.FillPath(PathGradient, gp);
                break;
            case GradientAlignment.Horizontal:
                PathGradient = new LinearGradientBrush(new Point(rect.X, rect.Y), new Point(rect.X, rect.Y + rect.Height), Color.Black, Color.Black);
                Blend.Positions = new[]{
                    0,
					1 / 2f,
					1
                };
                Blend.Colors = new[]{
                    Col1,
					Col2,
					Col1
                };
                PathGradient.InterpolationColors = Blend;
                PathGradient.RotateTransform(0);
                g.FillPath(PathGradient, gp);
                break;
        }
        g.SmoothingMode = stored;
    }
    public void DrawText(Graphics G, Rectangle ContRect, string Text, Font TFont, HorizontalAlignment TAlign, Color TColor)
    {
        if (string.IsNullOrEmpty(Text))
            return;
        Size TextSize = G.MeasureString(Text, TFont).ToSize();
        int CenteredY = ContRect.Height / 2 - TextSize.Height / 2;
        StringFormat sf;
        switch (TAlign)
        {
            case HorizontalAlignment.Left:
                sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Near;
                sf.Alignment = StringAlignment.Near;
                G.DrawString(Text, TFont, new SolidBrush(TColor), new Rectangle(ContRect.X, ContRect.Y + ContRect.Height / 2 - TextSize.Height / 2, ContRect.Width, ContRect.Height), sf);
                break;
            case HorizontalAlignment.Right:
                sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Far;
                sf.Alignment = StringAlignment.Far;
                G.DrawString(Text, TFont, new SolidBrush(TColor), new Rectangle(ContRect.X, ContRect.Y, ContRect.Width, ContRect.Height / 2 + TextSize.Height / 2), sf);
                break;
            case HorizontalAlignment.Center:
                sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
                G.DrawString(Text, TFont, new SolidBrush(TColor), ContRect, sf);
                break;
        }
    }
    public GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
    {
        GraphicsPath Path = new GraphicsPath();
        int ArcRectangleWidth = Curve * 2;
        var _with1 = Path;
        _with1.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
        _with1.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
        _with1.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
        _with1.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
        _with1.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
        return Path;
    }
    public GraphicsPath RoundedTopRect(Rectangle Rectangle, int Curve)
    {
        GraphicsPath Path = new GraphicsPath();
        int ArcRectangleWidth = Curve * 2;
        var _with2 = Path;
        _with2.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
        _with2.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
        _with2.AddLine(new Point(Rectangle.X + Rectangle.Width, Rectangle.Y + ArcRectangleWidth), new Point(Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height));
        _with2.AddLine(new Point(Rectangle.X, Rectangle.Height + Rectangle.Y), new Point(Rectangle.X, Rectangle.Y + Curve));
        return Path;
    }
    public Image CodeToImage(string Code)
    {
        return Image.FromStream(new System.IO.MemoryStream(Convert.FromBase64String(Code)));
    }
    public Color ColorFromHex(string Hex)
    {
        return Color.FromArgb(checked((int)long.Parse(string.Format("FFFFFFFFFF{0}", Hex.Substring(1)), NumberStyles.HexNumber)));
    }
}
#endregion