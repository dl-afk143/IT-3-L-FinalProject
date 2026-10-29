
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public class RoundedButton : Button
    {
        private int borderRadius = 12;
        private Color borderColor = Color.Transparent;
        private int borderSize = 0;

        [DefaultValue(12)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = Math.Max(1, value);
                UpdateRegion();
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

        [DefaultValue(0)]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = Math.Max(0, value);
                Invalidate();
            }
        }

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.FromArgb(11, 55, 100);
            ForeColor = Color.White;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = false;

            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            if (Width <= 0 || Height <= 0)
                return;

            using (GraphicsPath path = GetPath(
                new Rectangle(0, 0, Width, Height), borderRadius))
            {
                Region oldRegion = Region;
                Region = new Region(path);
                if (oldRegion != null)
                    oldRegion.Dispose();
            }
        }

        private GraphicsPath GetPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int d = Math.Min(radius * 2,
                Math.Min(rect.Width, rect.Height));

            if (d <= 0)
                return path;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using (GraphicsPath path = GetPath(rect, borderRadius))
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);

                if (borderSize > 0)
                {
                    using (Pen pen = new Pen(borderColor, borderSize))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }

            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                ClientRectangle,
                Enabled ? ForeColor : SystemColors.GrayText,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.SingleLine);
        }
    }
}
