using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Controls
{
    public class CircularPictureBox : PictureBox
    {
        private Image _originalImage;
        private int _borderSize = 5;
        private Color _borderColor = Color.White;
        private Color _borderColor2 = Color.FromArgb(30, 136, 229);
        private bool _gradientBorder = true;

        public CircularPictureBox()
        {
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Size = new Size(180, 180);
            this.BackColor = Color.Transparent;
        }

        [System.ComponentModel.Category("Appearance")]
        [System.ComponentModel.Description("Kích thước viền")]
        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Appearance")]
        [System.ComponentModel.Description("Màu viền 1")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Appearance")]
        [System.ComponentModel.Description("Màu viền 2 (cho gradient)")]
        public Color BorderColor2
        {
            get { return _borderColor2; }
            set
            {
                _borderColor2 = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Category("Appearance")]
        [System.ComponentModel.Description("Sử dụng viền gradient")]
        public bool GradientBorder
        {
            get { return _gradientBorder; }
            set
            {
                _gradientBorder = value;
                this.Invalidate();
            }
        }

        public new Image Image
        {
            get { return base.Image; }
            set
            {
                _originalImage = value;
                base.Image = value != null ? CropToCircle(value) : null;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = this.Height; // Đảm bảo luôn là hình vuông
            if (_originalImage != null)
            {
                base.Image = CropToCircle(_originalImage);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Vẽ với chất lượng cao
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pe.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pe.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            pe.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // Vẽ viền
            if (_borderSize > 0)
            {
                Rectangle rectBorder = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

                using (GraphicsPath pathBorder = new GraphicsPath())
                {
                    pathBorder.AddEllipse(rectBorder);

                    if (_gradientBorder && _borderColor != _borderColor2)
                    {
                        using (LinearGradientBrush penBorder = new LinearGradientBrush(
                            rectBorder, _borderColor, _borderColor2, 45F))
                        {
                            using (Pen pen = new Pen(penBorder, _borderSize))
                            {
                                pen.Alignment = PenAlignment.Inset;
                                pe.Graphics.DrawPath(pen, pathBorder);
                            }
                        }
                    }
                    else
                    {
                        using (Pen penBorder = new Pen(_borderColor, _borderSize))
                        {
                            penBorder.Alignment = PenAlignment.Inset;
                            pe.Graphics.DrawPath(penBorder, pathBorder);
                        }
                    }
                }
            }

            // Vẽ ảnh
            if (this.Image != null)
            {
                Rectangle rectImage = new Rectangle(
                    _borderSize,
                    _borderSize,
                    this.Width - (_borderSize * 2) - 1,
                    this.Height - (_borderSize * 2) - 1
                );

                using (GraphicsPath pathImage = new GraphicsPath())
                {
                    pathImage.AddEllipse(rectImage);
                    pe.Graphics.SetClip(pathImage);
                    pe.Graphics.DrawImage(this.Image, rectImage);
                }
            }
        }

        private Image CropToCircle(Image srcImage)
        {
            if (srcImage == null) return null;

            // Tạo bitmap vuông
            int size = Math.Min(this.Width - _borderSize * 2, this.Height - _borderSize * 2);
            Bitmap dstImage = new Bitmap(size, size);

            using (Graphics g = Graphics.FromImage(dstImage))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // Tính toán vùng crop để giữ tỷ lệ (center crop)
                float srcRatio = (float)srcImage.Width / srcImage.Height;
                Rectangle srcRect;

                if (srcRatio > 1) // Ảnh ngang
                {
                    int newWidth = (int)(srcImage.Height * 1);
                    int x = (srcImage.Width - newWidth) / 2;
                    srcRect = new Rectangle(x, 0, newWidth, srcImage.Height);
                }
                else // Ảnh dọc hoặc vuông
                {
                    int newHeight = (int)(srcImage.Width * 1);
                    int y = (srcImage.Height - newHeight) / 2;
                    srcRect = new Rectangle(0, y, srcImage.Width, newHeight);
                }

                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddEllipse(0, 0, size, size);
                    g.SetClip(gp);
                    g.DrawImage(srcImage, new Rectangle(0, 0, size, size), srcRect, GraphicsUnit.Pixel);
                }
            }

            return dstImage;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Region = new Region(GetRoundedPath(this.ClientRectangle, 0));
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            return path;
        }
    }
}
