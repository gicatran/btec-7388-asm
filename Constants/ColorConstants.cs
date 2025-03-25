using System.Drawing;

namespace ASM.Lib {
    internal static class ColorConstants {
        public readonly static Color PRIMARY = Color.FromArgb(30, 58, 138);
        public readonly static Color PRIMARY_HOVER = Color.FromArgb(40, 68, 158);
        public readonly static Color PRIMARY_MOUSE_DOWN = Color.FromArgb(20, 48, 118);

        public readonly static Color SECONDARY = Color.FromArgb(100, 116, 139);
        public readonly static Color SECONDARY_HOVER = Color.FromArgb(120, 136, 159);
        public readonly static Color SECONDARY_MOUSE_DOWN = Color.FromArgb(80, 96, 119);

        public readonly static Color ACCENT = Color.FromArgb(6, 182, 212);

        public readonly static Color BACKGROUND = Color.FromArgb(248, 250, 252);

        public readonly static Color TEXT_WHITE = Color.White;
        public readonly static Color TEXT_WHITE_SECONDARY = Color.FromArgb(200, 200, 200);

        public readonly static Color TEXT_BLACK = Color.Black;
        public readonly static Color TEXT_BLACK_SECONDARY = Color.FromArgb(80, 80, 80);

        public readonly static Color ERROR = Color.FromArgb(220, 38, 38);
        public readonly static Color SUCCESS = Color.FromArgb(16, 185, 129);
        public readonly static Color WARNING = Color.FromArgb(255, 159, 67);

        public readonly static Color BORDER = Color.FromArgb(200, 200, 200);
        public readonly static Color BORDER_FOCUS = Color.FromArgb(30, 58, 138);
    }
}
