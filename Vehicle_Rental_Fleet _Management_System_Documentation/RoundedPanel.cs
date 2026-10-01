using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    [ToolboxItem(true)]
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 20;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(
                Width - BorderRadius,
                0,
                BorderRadius,
                BorderRadius,
                270,
                90
            );
            path.AddArc(
                Width - BorderRadius,
                Height - BorderRadius,
                BorderRadius,
                BorderRadius,
                0,
                90
            );
            path.AddArc(
                0,
                Height - BorderRadius,
                BorderRadius,
                BorderRadius,
                90,
                90
            );

            path.CloseFigure();

            Region = new Region(path);
        }
    }
}