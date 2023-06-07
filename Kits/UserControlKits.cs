using CustomKits.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomKits.Kits
{
    public partial class UserControlKits : UserControl
    {
        public UserControlKits()
        {
            InitializeComponent();
            this.BackColor = Color.BlueViolet;

        }

        float borderWidth;
        int borderRadius;
        bool fill;
        Color borderColor;
        Color hoverColor;

        [Category("Hisu")]
        public float BorderWidth
        {
            get => borderWidth; set
            {
                if (value > 0)
                {
                    borderWidth = value;
                }
                else
                {
                    BorderColor = Color.Transparent;
                }
                Invalidate();
            }
        }

        [Category("Hisu")]
        public int BorderRadius
        {
            get => borderRadius; set
            {
                if (value < this.Height)
                {
                    borderRadius = value;
                }
                else
                {
                    borderRadius = this.Height - 1;
                }
                Invalidate();

            }
        }

        [Category("Hisu")]
        public bool Fill
        {
            get => fill; set
            {
                if (!value)
                {
                    this.BackColor = Color.Empty;
                }
                fill = value;
                Invalidate();
            }
        }

        [Category("Hisu")]
        public Color BorderColor
        {
            get => borderColor; set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Hisu")]
        public Color HoverColor
        {
            get => hoverColor; set
            {
                if (value != BackColor)
                {
                    hoverColor = value;
                    Invalidate();

                }
            }
        }





        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 1, this.Height - 1);

            if (BorderRadius > 2)
            {

                using (GraphicsPath pathSurface = Graphic.GetPath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = Graphic.GetPath(rectBorder, BorderRadius - 1))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 4))
                using (Pen penBorder = new Pen(BorderColor, BorderWidth))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
                }

            }
            else
            {
                using (Pen pen = new Pen(BorderColor, BorderWidth))
                {
                    pen.Alignment = PenAlignment.Inset;
                    this.Region = new Region(rectSurface);
                    pevent.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                }

            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.SizeChanged += ButtonKits_SizeChanged;
        }

        private void ButtonKits_SizeChanged(object? sender, EventArgs e)
        {
            if (this.Height <= BorderRadius)
            {
                BorderRadius = this.Height - 1;
            }
        }


    }
}
