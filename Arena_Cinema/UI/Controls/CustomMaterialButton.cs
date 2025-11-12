using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Controls
{
    public class CustomMaterialButton : ReaLTaiizor.Controls.MaterialButton
    {
        public Color CustomBackColor { get; set; } = Color.Red;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // 🧩 Nếu đang ở Design mode → chỉ vẽ nền cơ bản thôi
            if (DesignMode)
            {
                using (SolidBrush brush = new SolidBrush(Color.LightGray))
                {
                    pevent.Graphics.FillRectangle(brush, this.ClientRectangle);
                }

                TextRenderer.DrawText(
                    pevent.Graphics,
                    this.Text,
                    this.Font,
                    this.ClientRectangle,
                    Color.Black,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
                return;
            }

            // 🟢 Khi chạy thật (runtime)
            base.OnPaint(pevent);

            // Vẽ đè màu nền
            using (SolidBrush brush = new SolidBrush(CustomBackColor))
            {
                pevent.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Vẽ lại icon (nếu có)
            if (this.Icon != null)
            {
                int iconSize = 20;
                int x = 8;
                int y = (this.Height - iconSize) / 2;
                pevent.Graphics.DrawImage(this.Icon, new Rectangle(x, y, iconSize, iconSize));
            }

            // Vẽ lại text
            Rectangle textRect = new Rectangle(35, 0, this.Width - 40, this.Height);
            TextRenderer.DrawText(
                pevent.Graphics,
                this.Text,
                this.Font,
                textRect,
                this.ForeColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );
        }
    }
}
