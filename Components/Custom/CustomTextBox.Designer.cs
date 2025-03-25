namespace ASM.Components {
    partial class CustomTextBox {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtField = new System.Windows.Forms.TextBox();
            this.pbField = new System.Windows.Forms.PictureBox();
            this.pnlLayout = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pbField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLayout)).BeginInit();
            this.pnlLayout.Panel1.SuspendLayout();
            this.pnlLayout.Panel2.SuspendLayout();
            this.pnlLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtField
            // 
            this.txtField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtField.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtField.ForeColor = System.Drawing.Color.Black;
            this.txtField.Location = new System.Drawing.Point(0, 0);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(150, 18);
            this.txtField.TabIndex = 0;
            this.txtField.Click += new System.EventHandler(this.TextBoxClick);
            this.txtField.TextChanged += new System.EventHandler(this.TextBoxChanged);
            this.txtField.Enter += new System.EventHandler(this.TextBoxEnter);
            this.txtField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            this.txtField.Leave += new System.EventHandler(this.TextBoxLeave);
            this.txtField.MouseEnter += new System.EventHandler(this.TextBoxMouseEnter);
            this.txtField.MouseLeave += new System.EventHandler(this.TextBoxMouseLeave);
            // 
            // pbField
            // 
            this.pbField.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbField.Location = new System.Drawing.Point(0, 0);
            this.pbField.Margin = new System.Windows.Forms.Padding(0);
            this.pbField.Name = "pbField";
            this.pbField.Size = new System.Drawing.Size(25, 16);
            this.pbField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbField.TabIndex = 1;
            this.pbField.TabStop = false;
            // 
            // pnlLayout
            // 
            this.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayout.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.pnlLayout.IsSplitterFixed = true;
            this.pnlLayout.Location = new System.Drawing.Point(10, 7);
            this.pnlLayout.Name = "pnlLayout";
            // 
            // pnlLayout.Panel1
            // 
            this.pnlLayout.Panel1.Controls.Add(this.pbField);
            this.pnlLayout.Panel1MinSize = 16;
            // 
            // pnlLayout.Panel2
            // 
            this.pnlLayout.Panel2.Controls.Add(this.txtField);
            this.pnlLayout.Size = new System.Drawing.Size(180, 16);
            this.pnlLayout.SplitterDistance = 25;
            this.pnlLayout.SplitterWidth = 5;
            this.pnlLayout.TabIndex = 2;
            // 
            // CustomTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pnlLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomTextBox";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Size = new System.Drawing.Size(200, 30);
            ((System.ComponentModel.ISupportInitialize)(this.pbField)).EndInit();
            this.pnlLayout.Panel1.ResumeLayout(false);
            this.pnlLayout.Panel2.ResumeLayout(false);
            this.pnlLayout.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLayout)).EndInit();
            this.pnlLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.PictureBox pbField;
        private System.Windows.Forms.SplitContainer pnlLayout;
    }
}
