using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoSlotMachine
{
    class GradientPanel : Panel
    {
        private Color colorTop;
        private Color colorBottom;
        private float gradientAngle;
        public Color ColorTop { get => colorTop; set => colorTop = value; }
        public Color ColorBottom { get => colorBottom; set => colorBottom = value; }
        public float GradientAngle { get => gradientAngle; set => gradientAngle = value; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90);
            Graphics graphic = e.Graphics;
            graphic.FillRectangle(linearGradientBrush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
