namespace ASM.Views {
    partial class CustomersView {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.people = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblPeople = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new ASM.Components.CustomTextBox();
            this.divider = new ASM.Components.Divider();
            this.txtPeople = new ASM.Components.CustomTextBox();
            this.btnEdit = new ASM.Components.CustomButton();
            this.txtCurrent = new ASM.Components.CustomTextBox();
            this.txtLast = new ASM.Components.CustomTextBox();
            this.txtName = new ASM.Components.CustomTextBox();
            this.cmbType = new ASM.Components.CustomComboBox();
            this.btnAdd = new ASM.Components.CustomButton();
            this.btnNew = new ASM.Components.CustomButton();
            this.btnInvoice = new ASM.Components.CustomButton();
            this.btnRemove = new ASM.Components.CustomButton();
            this.pnlLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLayout
            // 
            this.pnlLayout.AutoSize = true;
            this.pnlLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLayout.ColumnCount = 3;
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlLayout.Controls.Add(this.txtSearch, 0, 0);
            this.pnlLayout.Controls.Add(this.dgvCustomers, 2, 1);
            this.pnlLayout.Controls.Add(this.divider, 1, 1);
            this.pnlLayout.Controls.Add(this.pnlForm, 0, 1);
            this.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayout.Location = new System.Drawing.Point(15, 15);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.RowCount = 2;
            this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlLayout.Size = new System.Drawing.Size(1033, 599);
            this.pnlLayout.TabIndex = 0;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.type,
            this.people,
            this.last,
            this.current,
            this.consumption});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvCustomers.Location = new System.Drawing.Point(434, 45);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.ReadOnly = true;
            this.dgvCustomers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(596, 551);
            this.dgvCustomers.TabIndex = 1;
            this.dgvCustomers.Tag = "id,name,type,type,people,last,current,consumption";
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.DgvCustomers_SelectionChanged);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 47;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 69;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.type.DataPropertyName = "Type";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 61;
            // 
            // people
            // 
            this.people.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.people.DataPropertyName = "NumberOfPeople";
            this.people.HeaderText = "People";
            this.people.Name = "people";
            this.people.ReadOnly = true;
            this.people.Width = 73;
            // 
            // last
            // 
            this.last.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last.DataPropertyName = "LastWaterReading";
            this.last.HeaderText = "Last";
            this.last.Name = "last";
            this.last.ReadOnly = true;
            // 
            // current
            // 
            this.current.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.current.DataPropertyName = "CurrentWaterReading";
            this.current.HeaderText = "Current";
            this.current.Name = "current";
            this.current.ReadOnly = true;
            // 
            // consumption
            // 
            this.consumption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.consumption.DataPropertyName = "AmountOfConsumption";
            this.consumption.HeaderText = "Consumption";
            this.consumption.Name = "consumption";
            this.consumption.ReadOnly = true;
            // 
            // pnlForm
            // 
            this.pnlForm.AutoSize = true;
            this.pnlForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlForm.ColumnCount = 4;
            this.pnlForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlForm.Controls.Add(this.txtPeople, 0, 6);
            this.pnlForm.Controls.Add(this.lblPeople, 0, 5);
            this.pnlForm.Controls.Add(this.btnEdit, 1, 11);
            this.pnlForm.Controls.Add(this.txtCurrent, 0, 10);
            this.pnlForm.Controls.Add(this.txtLast, 0, 8);
            this.pnlForm.Controls.Add(this.lblCurrent, 0, 9);
            this.pnlForm.Controls.Add(this.lblLast, 0, 7);
            this.pnlForm.Controls.Add(this.lblType, 0, 3);
            this.pnlForm.Controls.Add(this.lblName, 0, 1);
            this.pnlForm.Controls.Add(this.txtName, 0, 2);
            this.pnlForm.Controls.Add(this.cmbType, 0, 4);
            this.pnlForm.Controls.Add(this.lblTitle, 0, 0);
            this.pnlForm.Controls.Add(this.btnAdd, 0, 11);
            this.pnlForm.Controls.Add(this.btnNew, 2, 11);
            this.pnlForm.Controls.Add(this.btnInvoice, 0, 12);
            this.pnlForm.Controls.Add(this.btnRemove, 3, 11);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 42);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.RowCount = 13;
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14285F));
            this.pnlForm.Size = new System.Drawing.Size(401, 557);
            this.pnlForm.TabIndex = 3;
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = true;
            this.pnlForm.SetColumnSpan(this.lblPeople, 4);
            this.lblPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPeople.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPeople.Location = new System.Drawing.Point(3, 202);
            this.lblPeople.Margin = new System.Windows.Forms.Padding(3);
            this.lblPeople.Name = "lblPeople";
            this.lblPeople.Size = new System.Drawing.Size(395, 19);
            this.lblPeople.TabIndex = 14;
            this.lblPeople.Tag = "people";
            this.lblPeople.Text = "People";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.pnlForm.SetColumnSpan(this.lblCurrent, 4);
            this.lblCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCurrent.Location = new System.Drawing.Point(3, 330);
            this.lblCurrent.Margin = new System.Windows.Forms.Padding(3);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(395, 19);
            this.lblCurrent.TabIndex = 3;
            this.lblCurrent.Tag = "current";
            this.lblCurrent.Text = "Current";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.pnlForm.SetColumnSpan(this.lblLast, 4);
            this.lblLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLast.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLast.Location = new System.Drawing.Point(3, 263);
            this.lblLast.Margin = new System.Windows.Forms.Padding(3);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(395, 19);
            this.lblLast.TabIndex = 2;
            this.lblLast.Tag = "last";
            this.lblLast.Text = "Last";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.pnlForm.SetColumnSpan(this.lblType, 4);
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblType.Location = new System.Drawing.Point(3, 141);
            this.lblType.Margin = new System.Windows.Forms.Padding(3);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(395, 19);
            this.lblType.TabIndex = 1;
            this.lblType.Tag = "type";
            this.lblType.Text = "Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.pnlForm.SetColumnSpan(this.lblName, 4);
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.Location = new System.Drawing.Point(3, 74);
            this.lblName.Margin = new System.Windows.Forms.Padding(3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(395, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Tag = "name";
            this.lblName.Text = "Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.pnlForm.SetColumnSpan(this.lblTitle, 4);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(395, 65);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Tag = "customer-form";
            this.lblTitle.Text = "Customer Form";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderSize = 2;
            this.pnlLayout.SetColumnSpan(this.txtSearch, 3);
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Icon = global::ASM.Properties.Resources.search_black;
            this.txtSearch.Location = new System.Drawing.Point(4, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MultiLine = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Search by name";
            this.txtSearch.ShowPlaceholder = true;
            this.txtSearch.Size = new System.Drawing.Size(1025, 34);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Tag = "search-by-name";
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch.BaseTextChanged += new System.EventHandler(this.TxtSearch_BaseTextChanged);
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.Transparent;
            this.divider.DividerOrientation = System.Windows.Forms.Orientation.Vertical;
            this.divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divider.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.divider.Location = new System.Drawing.Point(406, 47);
            this.divider.Margin = new System.Windows.Forms.Padding(5);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(20, 547);
            this.divider.TabIndex = 2;
            this.divider.Thickness = 2;
            // 
            // txtPeople
            // 
            this.txtPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtPeople.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPeople.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.txtPeople.BorderRadius = 10;
            this.txtPeople.BorderSize = 2;
            this.pnlForm.SetColumnSpan(this.txtPeople, 4);
            this.txtPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPeople.Enabled = false;
            this.txtPeople.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPeople.ForeColor = System.Drawing.Color.Black;
            this.txtPeople.Icon = null;
            this.txtPeople.Location = new System.Drawing.Point(4, 225);
            this.txtPeople.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.txtPeople.MultiLine = false;
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPeople.PasswordChar = false;
            this.txtPeople.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPeople.PlaceholderText = "People";
            this.txtPeople.ShowPlaceholder = false;
            this.txtPeople.Size = new System.Drawing.Size(393, 34);
            this.txtPeople.TabIndex = 15;
            this.txtPeople.Tag = "people";
            this.txtPeople.Texts = "";
            this.txtPeople.UnderlinedStyle = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::ASM.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(110, 404);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 48);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Tag = "";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.Edit);
            // 
            // txtCurrent
            // 
            this.txtCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtCurrent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtCurrent.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.txtCurrent.BorderRadius = 10;
            this.txtCurrent.BorderSize = 2;
            this.pnlForm.SetColumnSpan(this.txtCurrent, 4);
            this.txtCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCurrent.ForeColor = System.Drawing.Color.Black;
            this.txtCurrent.Icon = null;
            this.txtCurrent.Location = new System.Drawing.Point(4, 356);
            this.txtCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrent.MultiLine = false;
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCurrent.PasswordChar = false;
            this.txtCurrent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCurrent.PlaceholderText = "Current";
            this.txtCurrent.ShowPlaceholder = false;
            this.txtCurrent.Size = new System.Drawing.Size(393, 34);
            this.txtCurrent.TabIndex = 6;
            this.txtCurrent.Tag = "current";
            this.txtCurrent.Texts = "";
            this.txtCurrent.UnderlinedStyle = false;
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtLast.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtLast.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.txtLast.BorderRadius = 10;
            this.txtLast.BorderSize = 2;
            this.pnlForm.SetColumnSpan(this.txtLast, 4);
            this.txtLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLast.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLast.ForeColor = System.Drawing.Color.Black;
            this.txtLast.Icon = null;
            this.txtLast.Location = new System.Drawing.Point(4, 289);
            this.txtLast.Margin = new System.Windows.Forms.Padding(4);
            this.txtLast.MultiLine = false;
            this.txtLast.Name = "txtLast";
            this.txtLast.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLast.PasswordChar = false;
            this.txtLast.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLast.PlaceholderText = "Last";
            this.txtLast.ShowPlaceholder = false;
            this.txtLast.Size = new System.Drawing.Size(393, 34);
            this.txtLast.TabIndex = 5;
            this.txtLast.Tag = "last";
            this.txtLast.Texts = "";
            this.txtLast.UnderlinedStyle = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.txtName.BorderRadius = 10;
            this.txtName.BorderSize = 2;
            this.pnlForm.SetColumnSpan(this.txtName, 4);
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Icon = null;
            this.txtName.Location = new System.Drawing.Point(4, 100);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MultiLine = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "Name";
            this.txtName.ShowPlaceholder = false;
            this.txtName.Size = new System.Drawing.Size(393, 34);
            this.txtName.TabIndex = 4;
            this.txtName.Tag = "name";
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // cmbType
            // 
            this.cmbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cmbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cmbType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cmbType.BorderSize = 2;
            this.pnlForm.SetColumnSpan(this.cmbType, 4);
            this.cmbType.DataSource = null;
            this.cmbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.ForeColor = System.Drawing.Color.Black;
            this.cmbType.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.cmbType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cmbType.ListForeColor = System.Drawing.Color.Black;
            this.cmbType.Location = new System.Drawing.Point(6, 166);
            this.cmbType.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cmbType.Name = "cmbType";
            this.cmbType.Padding = new System.Windows.Forms.Padding(2);
            this.cmbType.SelectedIndex = -1;
            this.cmbType.SelectedItem = null;
            this.cmbType.Size = new System.Drawing.Size(389, 30);
            this.cmbType.TabIndex = 7;
            this.cmbType.Texts = "";
            this.cmbType.OnSelectedIndexChanged += new System.EventHandler(this.CmbType_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::ASM.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(10, 404);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 48);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Tag = "";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Add);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnNew.BorderRadius = 10;
            this.btnNew.BorderSize = 0;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::ASM.Properties.Resources._new;
            this.btnNew.Location = new System.Drawing.Point(210, 404);
            this.btnNew.Margin = new System.Windows.Forms.Padding(10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 48);
            this.btnNew.TabIndex = 11;
            this.btnNew.Tag = "";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.New);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnInvoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnInvoice.BorderRadius = 10;
            this.btnInvoice.BorderSize = 0;
            this.pnlForm.SetColumnSpan(this.btnInvoice, 4);
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnInvoice.Location = new System.Drawing.Point(10, 472);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(10, 10, 10, 40);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(381, 45);
            this.btnInvoice.TabIndex = 16;
            this.btnInvoice.Tag = "generate-invoice";
            this.btnInvoice.Text = "Generate Invoice";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.GenerateInvoice);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnRemove.BorderRadius = 10;
            this.btnRemove.BorderSize = 0;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = global::ASM.Properties.Resources.remove;
            this.btnRemove.Location = new System.Drawing.Point(310, 404);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(10);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 48);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Tag = "";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.Remove);
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CustomersView";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(1063, 629);
            this.Load += new System.EventHandler(this.OnLoad);
            this.pnlLayout.ResumeLayout(false);
            this.pnlLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlLayout;
        private Components.CustomTextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private Components.Divider divider;
        private System.Windows.Forms.TableLayoutPanel pnlForm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblCurrent;
        private Components.CustomTextBox txtName;
        private Components.CustomTextBox txtLast;
        private Components.CustomTextBox txtCurrent;
        private Components.CustomComboBox cmbType;
        private System.Windows.Forms.Label lblTitle;
        private Components.CustomButton btnAdd;
        private Components.CustomButton btnEdit;
        private Components.CustomButton btnNew;
        private Components.CustomButton btnRemove;
        private Components.CustomTextBox txtPeople;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn people;
        private System.Windows.Forms.DataGridViewTextBoxColumn last;
        private System.Windows.Forms.DataGridViewTextBoxColumn current;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumption;
        private Components.CustomButton btnInvoice;
    }
}
