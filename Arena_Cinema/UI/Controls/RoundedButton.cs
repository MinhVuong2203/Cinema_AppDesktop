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
    public class RoundedButton : Button
    {
        // Thuộc tính tùy chỉnh
        public int BorderRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.DodgerBlue;
        public float BorderThickness { get; set; } = 2f;

        public Color NormalBackColor { get; set; } = Color.DodgerBlue;
        public Color HoverBackColor { get; set; } = Color.RoyalBlue;
        public Color ClickBackColor { get; set; } = Color.MidnightBlue;

        private bool isHovering = false;
        private bool isClicking = false;

        public RoundedButton()
        {
            this.BackColor = NormalBackColor;
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Cursor = Cursors.Hand;

            // Đăng ký sự kiện hover & click
            this.MouseEnter += (s, e) => { isHovering = true; this.Invalidate(); };
            this.MouseLeave += (s, e) => { isHovering = false; isClicking = false; this.Invalidate(); };
            this.MouseDown += (s, e) => { isClicking = true; this.Invalidate(); };
            this.MouseUp += (s, e) => { isClicking = false; this.Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
            {
                // Chọn màu theo trạng thái
                Color backColor = NormalBackColor;
                if (isClicking)
                    backColor = ClickBackColor;
                else if (isHovering)
                    backColor = HoverBackColor;

                // Vẽ nền
                using (SolidBrush brush = new SolidBrush(backColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Vẽ border
                using (Pen pen = new Pen(BorderColor, BorderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                // Vẽ text căn giữa
                TextRenderer.DrawText(
                    e.Graphics,
                    this.Text,
                    this.Font,
                    rect,
                    this.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                // Bo góc thật sự
                this.Region = new Region(path);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
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
