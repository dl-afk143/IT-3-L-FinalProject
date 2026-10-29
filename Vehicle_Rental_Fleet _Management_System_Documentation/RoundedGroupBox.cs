
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public class RoundedGroupBox : GroupBox
    {
        private int borderRadius = 15;
        private Color borderColor = Color.FromArgb(220, 228, 239);
        private int borderSize = 1;

        [DefaultValue(15)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = Math.Max(1, value);
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [DefaultValue(1)]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = Math.Max(1, value);
                Invalidate();
            }
        }

        public RoundedGroupBox()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);

            BackColor = Color.White;
            ForeColor = Color.FromArgb(24, 49, 78);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Parent != null ? Parent.BackColor : SystemColors.Control);

            int titleHeight = (int)g.MeasureString(Text, Font).Height;
            int top = titleHeight / 2 + 2;

            Rectangle rect = new Rectangle(
                1,
                top,
                Width - 3,
                Height - top - 2);

            using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
            using (Pen pen = new Pen(borderColor, borderSize))
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                g.FillPath(brush, path);
                g.DrawPath(pen, path);
            }

            SizeF textSize = g.MeasureString(Text, Font);

            RectangleF titleRect = new RectangleF(
                10,
                0,
                textSize.Width + 8,
                titleHeight + 3);

            using (SolidBrush brush = new SolidBrush(
                Parent != null ? Parent.BackColor : SystemColors.Control))
            {
                g.FillRectangle(brush, titleRect);
            }

            using (SolidBrush brush = new SolidBrush(ForeColor))
            {
                g.DrawString(Text, Font, brush, 14, 0);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int d = Math.Min(radius * 2,
                Math.Min(rect.Width, rect.Height));

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
