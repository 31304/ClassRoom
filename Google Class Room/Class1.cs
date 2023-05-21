using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Class_Room
{
    public class CircularButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.SeaGreen);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle buttonRect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                graphics.FillEllipse(brush, buttonRect);
            }

            using (Pen pen = new Pen(this.ForeColor, 2))
            {
                graphics.DrawEllipse(pen, buttonRect);
            }

            // Draw the button text
            TextRenderer.DrawText(graphics, this.Text, this.Font, buttonRect, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
    public class CustomPanel : Panel
    {
        private Color borderColor = Color.Red;

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate(); // Redraw the panel
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the custom border color
            using (Pen pen = new Pen(borderColor))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, Width - 1, Height - 1));
            }
        }
    }


}
