using System.Drawing.Drawing2D;

namespace CustomKits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Painting(object sender, PaintEventArgs e)
        {
            RectangleF rect = new Rectangle(30, 30, 300, 300);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(30, 30, 70, 70, 180, 90);
                path.AddArc(rect.Right - 70, rect.Y, 70, 70, 270, 90);
                path.AddArc(rect.Right - 70, rect.Bottom - 70, 70, 70, 0, 90);
                path.AddArc(rect.X, rect.Bottom - 70, 70, 70, 90, 90);
                path.CloseFigure();
                using (Pen pen = new Pen(Color.Red, 5))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                    e.Graphics.DrawPath(pen, path);
                    e.Graphics.FillPath(new SolidBrush(Color.Yellow), path);

                }
            }
        }
    }
}