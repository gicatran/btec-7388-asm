using ASM.Lib;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ASM.Components {
    internal class Divider : UserControl {
        private int thickness;
        private Color lineColor;
        private Orientation orientation;

        [Category("Custom Divider Properties")]
        public int Thickness {
            get => thickness;
            set {
                thickness = Math.Max(1, value);
                Invalidate();
            }
        }

        [Category("Custom Divider Properties")]
        public Color LineColor {
            get => lineColor;
            set {
                lineColor = value;
                Invalidate();
            }
        }

        [Category("Custom Divider Properties")]
        public Orientation DividerOrientation {
            get => orientation;
            set {
                orientation = value;
                Invalidate();
            }
        }

        public Divider() {
            Init();
        }

        private void Init() {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Thickness = 2;
            LineColor = ColorConstants.BORDER;
            DividerOrientation = Orientation.Horizontal;
            Height = 2;
            Width = 100;
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            using (Pen pen = new Pen(lineColor, thickness)) {
                if (orientation == Orientation.Horizontal) {
                    int y = Height / 2;
                    e.Graphics.DrawLine(pen, 0, y, Width, y);
                } else {
                    int x = Width / 2;
                    e.Graphics.DrawLine(pen, x, 0, x, Height);
                }
            }
        }
    }
}
