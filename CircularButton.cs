using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropofchange
{
    class CircularButton: Button

    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphicPath = new GraphicsPath();
            graphicPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(graphicPath);
            base.OnPaint(pevent);
        }
    }
}
