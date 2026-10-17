
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedTextBox : UserControl
{
    private readonly TextBox textBox = new TextBox();
    private int borderRadius = 12;

    [DefaultValue(12)]
    public int BorderRadius
    {
        get => borderRadius;
        set
        {
            borderRadius = Math.Max(1, value);
            UpdateRoundedRegion();
            Invalidate();
        }
    }

    [DefaultValue(typeof(Color), "LightGray")]
    public Color BorderColor { get; set; } = Color.LightGray;

    [DefaultValue(typeof(Color), "White")]
    public Color TextBoxBackColor
    {
        get => textBox.BackColor;
        set
        {
            textBox.BackColor = value;
            BackColor = value;
            Invalidate();
        }
    }

    public override string Text
    {
        get => textBox.Text;
        set => textBox.Text = value;
    }

    // Clear the text inside the rounded textbox
    public void Clear()
    {
        textBox.Clear();
    }

    public bool UseSystemPasswordChar
    {
        get => textBox.UseSystemPasswordChar;
        set => textBox.UseSystemPasswordChar = value;
    }

    public int MaxLength
    {
        get => textBox.MaxLength;
        set => textBox.MaxLength = value;
    }

    public HorizontalAlignment TextAlign
    {
        get => textBox.TextAlign;
        set => textBox.TextAlign = value;
    }

    public RoundedTextBox()
    {
        SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw,
            true);

        Size = new Size(250, 38);
        MinimumSize = new Size(80, 32);
        BackColor = Color.White;
        Padding = new Padding(10, 9, 10, 5);

        textBox.BorderStyle = BorderStyle.None;
        textBox.Font = new Font("Segoe UI", 10F);
        textBox.Dock = DockStyle.Fill;
        textBox.BackColor = BackColor;

        Controls.Add(textBox);

        Resize += (s, e) => UpdateRoundedRegion();
        ParentChanged += (s, e) => UpdateRoundedRegion();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = CreateRoundedPath(
            0, 0, Width - 1, Height - 1, BorderRadius))
        using (Pen pen = new Pen(BorderColor, 1.2F))
        {
            e.Graphics.DrawPath(pen, path);
        }
    }

    private GraphicsPath CreateRoundedPath(
        int x, int y, int width, int height, int radius)
    {
        GraphicsPath path = new GraphicsPath();

        if (width <= 0 || height <= 0)
            return path;

        int diameter = Math.Min(
            Math.Min(radius * 2, width),
            height);

        path.AddArc(x, y, diameter, diameter, 180, 90);
        path.AddArc(
            x + width - diameter, y,
            diameter, diameter, 270, 90);
        path.AddArc(
            x + width - diameter,
            y + height - diameter,
            diameter, diameter, 0, 90);
        path.AddArc(
            x, y + height - diameter,
            diameter, diameter, 90, 90);

        path.CloseFigure();
        return path;
    }

    private void UpdateRoundedRegion()
    {
        if (Width <= 0 || Height <= 0)
            return;

        using (GraphicsPath path = CreateRoundedPath(
            0, 0, Width, Height, BorderRadius))
        {
            Region = new Region(path);
        }

        Invalidate();
    }
}
