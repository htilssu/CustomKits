using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomKits.Graphics
{
    internal class Graphic
    {

        /// <summary>
        /// Return the Path with border radius
        /// </summary>
        /// <param name="rect"></param>
        /// <param name="BorderRadius"></param>
        /// <returns></returns>
        public static GraphicsPath GetPath(RectangleF rect, float BorderRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(rect.Width - BorderRadius, rect.Y, BorderRadius, BorderRadius, 270, 90);
            path.AddArc(rect.Width - BorderRadius, rect.Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            path.AddArc(rect.X, rect.Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
