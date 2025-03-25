using ASM.Lib;
using ASM.Lib.Constants;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ASM.Components {
    internal class CustomButton : Button {
        [Category("Custom Button Properties")]
        public int BorderSize { get; set; }

        [Category("Custom Button Properties")]
        public int BorderRadius { get; set; }

        [Category("Custom Button Properties")]
        public Color BorderColor { get; set; }

        public CustomButton() {
            Init();
        }

        private void Init() {
            BorderSize = 0;
            BorderRadius = 20;
            BorderColor = ColorConstants.BORDER;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = ColorConstants.PRIMARY;
            ForeColor = Color.White;
            Font = FontConstants.MEDIUM;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius) {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pEvent) {
            base.OnPaint(pEvent);
            pEvent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pEvent.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pEvent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            RectangleF rectSurface = new RectangleF(0, 0, Width, Height);
            RectangleF rectBorder = new RectangleF(1, 1, Width - 0.8F, Height - 1);

            if (BorderRadius > 0) {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius))
                using (Pen penSurface = new Pen(Parent.BackColor, 2))
                using (Pen penBorder = new Pen(BorderColor, BorderSize)) {
                    penBorder.Alignment = PenAlignment.Inset;
                    Region = new Region(pathSurface);
                    pEvent.Graphics.DrawPath(penSurface, pathSurface);

                    if (BorderSize > 0) {
                        pEvent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            } else {
                Region = new Region(rectSurface);

                if (BorderSize > 0) {
                    using (Pen penBorder = new Pen(BorderColor, BorderSize)) {
                        penBorder.Alignment = PenAlignment.Inset;
                        pEvent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += Container_BackColorChanged;
            Resize += Button_Resize;
        }

        private void Container_BackColorChanged(object sender, EventArgs e) {
            if (DesignMode) {
                Invalidate();
            }
        }

        private void Button_Resize(object sender, EventArgs e) {
            if (BorderRadius > Height) {
                BorderRadius = Height;
            }
        }

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // CustomButton
            // 
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResumeLayout(false);

        }
    }
}
