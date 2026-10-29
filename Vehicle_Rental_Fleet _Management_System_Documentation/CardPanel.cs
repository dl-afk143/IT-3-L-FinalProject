using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CardPanel : Panel
{
    public Image CarImage { get; set; }

    public CardPanel()
    {
        this.DoubleBuffered = true;
        this.ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;

        // white card background
        g.Clear(Color.White);

        // green gradient on the left part (about 40% of the width)
        int greenWidth = (int)(this.Width * 0.40);
        var greenRect = new Rectangle(0, 0, greenWidth, this.Height);
        using (var brush = new LinearGradientBrush(greenRect,
               Color.FromArgb(170, 214, 160), Color.FromArgb(0, 180, 150), 90f))
        {
            g.FillRectangle(brush, greenRect);
        }

        // car drawn last, so it crosses from green into white
        if (CarImage != null)
        {
            int carW = (int)(this.Width * 0.50);
            int carH = (int)(carW * CarImage.Height / (float)CarImage.Width);
            int x = (int)(this.Width * 0.03);
            int y = (this.Height - carH) / 2;
            g.DrawImage(CarImage, x, y, carW, carH);
        }
    }
}