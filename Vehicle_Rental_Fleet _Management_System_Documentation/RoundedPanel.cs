using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 16;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int d = CornerRadius * 2;
            var r = new Rectangle(0, 0, Width - 1, Height - 1);

            using (var path = new GraphicsPath())
            {
                path.AddArc(r.X, r.Y, d, d, 180, 90);
                path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
                path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
                path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
                path.CloseFigure();

                Region = new Region(path);
            }
        }
    }
}