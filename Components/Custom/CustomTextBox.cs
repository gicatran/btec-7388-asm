using ASM.Lib;
using ASM.Lib.Constants;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ASM.Components {
    [DefaultEvent("BaseTextChanged")]
    internal partial class CustomTextBox : UserControl {
        private int borderSize;
        private int borderRadius;
        private bool underlinedStyle;
        private bool isFocused;
        private string placeholderText;
        private bool isPlaceholder;
        private bool isPasswordChar;
        private bool showPlaceholder;

        private Color borderColor;
        private Color borderFocusColor;
        private Color placeholderColor;

        public event EventHandler BaseTextChanged;

        public CustomTextBox() {
            InitializeComponent();
            Init();
        }

        private void Init() {
            Font = FontConstants.SMALL;
            borderSize = 2;
            borderRadius = 10;
            placeholderText = "";
            borderColor = ColorConstants.BORDER;
            borderFocusColor = ColorConstants.BORDER_FOCUS;
            placeholderColor = Color.DarkGray;
            showPlaceholder = true;

            txtField.TextChanged += TextBoxChanged;
        }

        [Category("Custom Text Box Properties")]
        public Color BorderColor {
            get => borderColor;
            set {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Custom Text Box Properties")]
        public int BorderSize {
            get => borderSize;
            set {
                borderSize = value;
                Invalidate();
            }
        }

        [Category("Custom Text Box Properties")]
        public bool UnderlinedStyle {
            get => underlinedStyle;
            set {
                underlinedStyle = value;
                Invalidate();
            }
        }

        [Category("Custom Text Box Properties")]
        public bool PasswordChar {
            get {
                return isPasswordChar;
            }
            set {
                isPasswordChar = value;
                txtField.UseSystemPasswordChar = value;
            }
        }

        [Category("Custom Text Box Properties")]
        public bool MultiLine {
            get {
                return txtField.Multiline;
            }
            set {
                txtField.Multiline = value;
            }
        }

        [Category("Custom Text Box Properties")]
        public override Color BackColor {
            get => base.BackColor;
            set {
                base.BackColor = value;
                txtField.BackColor = value;
                Invalidate();
            }
        }

        [Category("Custom Text Box Properties")]
        public override Color ForeColor {
            get => base.ForeColor;
            set {
                base.ForeColor = value;
                txtField.ForeColor = value;
            }
        }

        [Category("Custom Text Box Properties")]
        public override Font Font {
            get => base.Font;
            set {
                base.Font = value;
                txtField.Font = value;

                if (DesignMode) {
                    UpdateControlHeight();
                }
            }
        }

        [Category("Custom Text Box Properties")]
        public string Texts {
            get {
                return isPlaceholder ? "" : txtField.Text;
            }
            set {
                if (string.IsNullOrWhiteSpace(value)) {
                    if (showPlaceholder) {
                        SetPlaceholder();
                    } else {
                        isPlaceholder = false;
                        txtField.Text = "";
                        txtField.ForeColor = ForeColor;
                    }
                } else {
                    isPlaceholder = false;
                    txtField.Text = value;
                    txtField.ForeColor = ForeColor;

                    if (isPasswordChar) {
                        txtField.UseSystemPasswordChar = true;
                    }
                }
            }
        }

        [Category("Custom Text Box Properties")]
        public Color BorderFocusColor {
            get => borderFocusColor;
            set {
                borderFocusColor = value;
            }
        }

        [Category("Custom Text Box Properties")]
        public int BorderRadius {
            get => borderRadius;
            set {
                borderRadius = Math.Min(value, Height / 2);
                Invalidate();
            }
        }

        [Category("Custom Text Box Properties")]
        public Color PlaceholderColor {
            get => placeholderColor;
            set {
                placeholderColor = value;

                if (isPasswordChar) {
                    txtField.ForeColor = value;
                }
            }
        }

        [Category("Custom Text Box Properties")]
        public string PlaceholderText {
            get => placeholderText;
            set {
                placeholderText = value;

                txtField.Text = "";
                SetPlaceholder();
            }
        }

        [Category("Custom Text Box Properties")]
        public bool ShowPlaceholder {
            get => showPlaceholder;
            set {
                showPlaceholder = value;

                if (!showPlaceholder) {
                    RemovePlaceholder();
                } else {
                    SetPlaceholder();
                }
            }
        }

        [Category("Custom Text Box Properties")]
        public Image Icon {
            get => pbField?.Image;
            set {
                if (pbField != null) {
                    pbField.Image = value;
                    pnlLayout.Panel1Collapsed = value == null;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            if (borderRadius > 1) {
                var rectBorderSmooth = ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize)) {
                    Region = new Region(pathBorderSmooth);

                    if (borderRadius > 15) {
                        SetTextBoxRoundedRegion();
                    }

                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = PenAlignment.Center;

                    if (isFocused) {
                        penBorder.Color = borderFocusColor;
                    }

                    if (underlinedStyle) {
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graphics.SmoothingMode = SmoothingMode.None;
                        graphics.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    } else {
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            } else {
                using (Pen penBorder = new Pen(borderColor, borderSize)) {
                    Region = new Region(ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;

                    if (isFocused) {
                        penBorder.Color = borderFocusColor;
                    }

                    if (underlinedStyle) {
                        graphics.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    } else {
                        graphics.DrawRectangle(penBorder, 0, 0, Width - 0.5f, Height - 0.5f);
                    }
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

        private void UpdateControlHeight() {
            if (!txtField.Multiline) {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 4;
                txtField.Multiline = true;
                txtField.MinimumSize = new Size(0, txtHeight);
                txtField.Multiline = false;

                Height = txtField.Height + Padding.Top + Padding.Bottom;
            }
        }

        private void SetTextBoxRoundedRegion() {
            GraphicsPath pathTxt;

            if (MultiLine) {
                pathTxt = GetFigurePath(txtField.ClientRectangle, borderRadius - borderSize);
                txtField.Region = new Region(pathTxt);
            } else {
                pathTxt = GetFigurePath(txtField.ClientRectangle, borderSize * 2);
                txtField.Region = new Region(pathTxt);
            }
        }

        private void SetPlaceholder() {
            if (!showPlaceholder || string.IsNullOrWhiteSpace(placeholderText)) {
                return;
            }

            if (string.IsNullOrWhiteSpace(txtField.Text)) {
                isPlaceholder = true;
                txtField.Text = placeholderText;
                txtField.ForeColor = placeholderColor;

                if (isPasswordChar) {
                    txtField.UseSystemPasswordChar = false;
                }
            }
        }

        private void RemovePlaceholder() {
            if (isPlaceholder) {
                isPlaceholder = false;
                txtField.Text = "";
                txtField.ForeColor = ForeColor;

                if (isPasswordChar) {
                    txtField.UseSystemPasswordChar = true;
                }
            }
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);

            if (DesignMode) {
                UpdateControlHeight();
            }
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void TextBoxChanged(object sender, EventArgs e) {
            BaseTextChanged?.Invoke(this, e);
        }

        private void TextBoxClick(object sender, EventArgs e) {
            OnClick(e);
        }

        private void TextBoxMouseEnter(object sender, EventArgs e) {
            OnMouseEnter(e);
        }

        private void TextBoxMouseLeave(object sender, EventArgs e) {
            OnMouseLeave(e);
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e) {
            OnKeyPress(e);
        }

        private void TextBoxEnter(object sender, EventArgs e) {
            isFocused = true;
            Invalidate();
            RemovePlaceholder();
        }

        private void TextBoxLeave(object sender, EventArgs e) {
            isFocused = false;
            Invalidate();
            SetPlaceholder();
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            txtField.Width = Width - (borderSize * 2);
            txtField.Height = Height - (borderSize * 2);
            Invalidate();
        }
    }
}
