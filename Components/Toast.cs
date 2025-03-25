using ASM.Lib;
using ASM.Lib.Constants;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace ASM.Components {
    internal partial class Toast : Form {
        private int margin;
        private int duration;
        private float opacityIncrement;
        private int borderRadius;
        private int borderSize;
        private Color borderColor;
        private bool fadingIn;
        private bool holding;

        public Toast(string message, Color backColor, int durationMs = 3000) {
            InitializeComponent();
            Init(message, backColor, durationMs);
        }

        private void Init(string message, Color backColor, int durationMs = 3000) {
            fadingIn = true;
            borderRadius = 15;
            borderSize = 2;
            borderColor = ColorConstants.BORDER;
            margin = 20;
            opacityIncrement = 0.05f;
            duration = durationMs;

            BackColor = backColor;
            lblMessage.Text = message;

            Form mainForm = Application.OpenForms.Cast<Form>().FirstOrDefault();

            int x = mainForm.Location.X + mainForm.Width - Width - margin;
            int y = mainForm.Location.Y + mainForm.Height - Height - margin;

            Location = new Point(x, y);

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            if (fadingIn) {
                Opacity = Math.Min(Opacity + opacityIncrement, 1);

                if (Opacity >= 1) {
                    fadingIn = false;
                    holding = true;
                    timer.Interval = duration;
                }
            } else if (holding) {
                holding = false;
                timer.Interval = 10;
            } else {
                Opacity = Math.Max(Opacity - opacityIncrement, 0);

                if (Opacity <= 0) {
                    timer.Stop();
                    Close();
                }
            }
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
            pEvent.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            pEvent.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pEvent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            RectangleF rectSurface = new RectangleF(0, 0, Width, Height);
            RectangleF rectBorder = new RectangleF(1, 1, Width - 2, Height - 2);

            if (borderRadius > 0) {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius))
                using (Pen penBorder = new Pen(borderColor, borderSize)) {
                    penBorder.Alignment = PenAlignment.Inset;
                    Region = new Region(pathSurface);
                    pEvent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }

        public static void ShowToast(string message, ToastType type, int durationMs = 3000) {
            Color backColor;

            switch (type) {
                case ToastType.SUCCESS:
                    backColor = ColorConstants.SUCCESS;
                    break;
                case ToastType.ERROR:
                    backColor = ColorConstants.ERROR;
                    break;
                case ToastType.WARNING:
                    backColor = ColorConstants.WARNING;
                    break;
                default:
                    backColor = ColorConstants.PRIMARY;
                    break;
            }

            Toast toast = new Toast(message, backColor, durationMs);
            toast.Show();
        }
    }
}
