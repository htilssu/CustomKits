using CustomKits.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomKits.Kits
{
    public class PanelKits : Panel
    {
        float borderRadius;
        private Color borderColor;
        private float borderWidth;

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
        public Color BorderColor
        {
            get => borderColor; set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Hisu")]
        public float BorderRadius
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


        public PanelKits()
        {
            BorderRadius = 0;
            MinimumSize = new Size(200, 50);

        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1,1, this.Width - 1, this.Height - 1);

            if (BorderRadius > 2)
            {
                using (GraphicsPath pathSurface = Graphic.GetPath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = Graphic.GetPath(rectBorder, BorderRadius-1))
                using (Pen penSurface = new(this.Parent.BackColor, 5))
                using (Pen penBorder = new Pen(BorderColor, BorderWidth))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    e.Graphics.DrawPath(penSurface, pathSurface);
                    e.Graphics.DrawPath(penBorder, pathBorder);
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
