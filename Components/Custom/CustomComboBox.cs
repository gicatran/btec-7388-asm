using ASM.Lib;
using ASM.Lib.Constants;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ASM.Components {
    [DefaultEvent("OnSelectedIndexChanged")]
    public partial class CustomComboBox : UserControl {
        private Color backColor = ColorConstants.BACKGROUND;
        private Color iconColor = ColorConstants.PRIMARY;
        private Color listBackColor = ColorConstants.SECONDARY;
        private Color listForeColor = Color.Black;
        private Color borderColor = ColorConstants.BORDER;
        private int borderSize = 1;

        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        [Category("Custom ComboBox Properties")]
        public new Color BackColor {
            get => backColor;
            set {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        [Category("Custom ComboBox Properties")]
        public Color IconColor {
            get => iconColor;
            set {
                iconColor = value;
                btnIcon.Invalidate();
            }
        }

        [Category("Custom ComboBox Properties")]
        public Color ListBackColor {
            get => listBackColor;
            set {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }

        [Category("Custom ComboBox Properties")]
        public Color ListForeColor {
            get => listForeColor;
            set {
                listForeColor = value;
                cmbList.ForeColor = listForeColor;
            }
        }

        [Category("Custom ComboBox Properties")]
        public Color BorderColor {
            get => borderColor;
            set {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }

        [Category("Custom ComboBox Properties")]
        public int BorderSize {
            get => borderSize;
            set {
                borderSize = value;
                Padding = new Padding(borderSize);
            }
        }

        [Category("Custom ComboBox Properties")]
        public override Color ForeColor {
            get => base.ForeColor;
            set {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        [Category("Custom ComboBox Properties")]
        public override Font Font {
            get => base.Font;
            set {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;
            }
        }

        [Category("Custom ComboBox Properties")]
        public string Texts {
            get => lblText.Text;
            set => lblText.Text = value;
        }

        [Category("Custom ComboBox Properties")]
        public ComboBoxStyle DropDownStyle {
            get => cmbList.DropDownStyle;
            set {
                cmbList.DropDownStyle = value;
            }
        }

        [Category("Custom ComboBox Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items {
            get => cmbList.Items;
        }

        [Category("Custom ComboBox Properties")]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        [AttributeProvider(typeof(IListSource))]
        public object DataSource {
            get => cmbList.DataSource;
            set => cmbList.DataSource = value;
        }

        [Category("Custom ComboBox Properties")]
        [DefaultValue(AutoCompleteMode.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode {
            get => cmbList.AutoCompleteMode;
            set => cmbList.AutoCompleteMode = value;
        }

        [Category("Custom ComboBox Properties")]
        [DefaultValue(AutoCompleteSource.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource {
            get => cmbList.AutoCompleteSource;
            set => cmbList.AutoCompleteSource = value;
        }

        [Category("Custom ComboBox Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteStringCollection AutoCompleteCustomSource {
            get => cmbList.AutoCompleteCustomSource;
            set => cmbList.AutoCompleteCustomSource = value;
        }

        [Category("Custom ComboBox Properties")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex {
            get => cmbList.SelectedIndex;
            set => cmbList.SelectedIndex = value;
        }

        [Category("Custom ComboBox Properties")]
        [Browsable(false)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem {
            get => cmbList.SelectedItem;
            set => cmbList.SelectedItem = value;
        }

        public event EventHandler OnSelectedIndexChanged;

        public CustomComboBox() {
            InitializeComponent();
            Init();
        }

        private void Init() {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            SuspendLayout();

            cmbList.BackColor = listBackColor;
            cmbList.Font = FontConstants.SMALL;
            cmbList.ForeColor = listForeColor;
            cmbList.Dock = DockStyle.Fill;
            cmbList.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cmbList.TextChanged += ComboBox_TextChanged;

            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(25, 25);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += Icon_Click;
            btnIcon.Paint += Icon_Paint;

            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(3, 0, 0, 0);
            lblText.Font = FontConstants.SMALL;
            lblText.Click += Surface_Click;
            lblText.MouseEnter += Surface_MouseEnter;
            lblText.MouseLeave += Surface_MouseLeave;

            Controls.Add(lblText);
            Controls.Add(btnIcon);
            Controls.Add(cmbList);
            Size = new Size(200, 25);
            ForeColor = Color.Black;
            Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            ResumeLayout();

            AdjustComboBoxDimensions();
        }

        private void AdjustComboBoxDimensions() {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point() {
                X = Width - Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        private void Surface_Click(object sender, EventArgs e) {
            OnClick(e);
            cmbList.Select();

            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList) {
                cmbList.DroppedDown = true;
            }
        }

        private void Icon_Paint(object sender, PaintEventArgs e) {
            const int iconWidth = 14;
            const int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2)) {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void Icon_Click(object sender, EventArgs e) {
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            lblText.Text = cmbList.Text;
            OnSelectedIndexChanged?.Invoke(sender, e);
        }

        private void ComboBox_TextChanged(object sender, EventArgs e) {
            lblText.Text = cmbList.Text;
        }

        private void Surface_MouseLeave(object sender, EventArgs e) {
            OnMouseEnter(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e) {
            OnMouseLeave(e);
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }
    }
}
