
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedComboBox : UserControl
{
    private readonly ComboBox comboBox = new ComboBox();
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
    public Color ComboBoxBackColor
    {
        get => comboBox.BackColor;
        set
        {
            comboBox.BackColor = value;
            BackColor = value;
            Invalidate();
        }
    }

    [DefaultValue(typeof(ComboBoxStyle), "DropDownList")]
    public ComboBoxStyle DropDownStyle
    {
        get => comboBox.DropDownStyle;
        set => comboBox.DropDownStyle = value;
    }

    [DefaultValue(typeof(DrawMode), "Normal")]
    public DrawMode DrawMode
    {
        get => comboBox.DrawMode;
        set => comboBox.DrawMode = value;
    }

    public ComboBox InnerComboBox => comboBox;

    public override string Text
    {
        get => comboBox.Text;
        set => comboBox.Text = value;
    }

    public RoundedComboBox()
    {
        SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw,
            true);

        Size = new Size(250, 38);
        MinimumSize = new Size(100, 32);
        BackColor = Color.White;
        Padding = new Padding(7, 4, 7, 3);

        comboBox.Dock = DockStyle.Fill;
        comboBox.Font = new Font("Segoe UI", 10F);
        comboBox.FlatStyle = FlatStyle.Flat;
        comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox.BackColor = Color.White;
        comboBox.IntegralHeight = true;

        Controls.Add(comboBox);

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
