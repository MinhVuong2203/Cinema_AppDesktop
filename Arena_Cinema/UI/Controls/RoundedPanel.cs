using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UI.Controls
{
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 30;
        public Color BorderColor { get; set; } = Color.LightGray;
        public float BorderThickness { get; set; } = 3f;

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath path = GetRoundedRectangle(rect, BorderRadius))
            {
                // Clip để ảnh + nền nằm trong vùng bo góc
                e.Graphics.SetClip(path);

                // Vẽ ảnh nền (nếu có)
                if (this.BackgroundImage != null)
                {
                    int panelW = this.Width;
                    int panelH = this.Height;
                    int imgW = this.BackgroundImage.Width;
                    int imgH = this.BackgroundImage.Height;

                    float scale = Math.Max((float)panelW / imgW, (float)panelH / imgH);
                    int drawW = (int)(imgW * scale);
                    int drawH = (int)(imgH * scale);
                    int x = (panelW - drawW) / 2;
                    int y = (panelH - drawH) / 2;

                    e.Graphics.DrawImage(this.BackgroundImage, new Rectangle(x, y, drawW, drawH));
                }
                else
                {
                    // Nếu không có ảnh thì tô màu nền
                    using (SolidBrush brush = new SolidBrush(this.BackColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                }

                e.Graphics.ResetClip();

                // Vẽ border
                using (Pen pen = new Pen(BorderColor, BorderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                // Gán vùng thật sự (click cũng bo góc)
                this.Region = new Region(path);
            }
        }


        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

    }
}
