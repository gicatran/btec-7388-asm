using ASM.Components;
using ASM.Constants;
using ASM.Controllers;
using ASM.Lib;
using ASM.Lib.Constants;
using ASM.Models;
using System;
using System.Windows.Forms;

namespace ASM.Views {
    internal partial class CustomersView : UserControl {
        private bool isLoaded;
        private CustomerController controller;
        private Validator validator;

        public CustomersView() {
            InitializeComponent();
            Init();
        }

        private void Init() {
            controller = new CustomerController();
            validator = new Validator();
            cmbType.Tag = Utils.EnumToString<CustomerType>();

            validator.Register(txtName, ValidationType.NotEmpty);
            validator.Register(cmbType, ValidationType.Selected);
            validator.Register(txtPeople, ValidationType.NotEmpty, ValidationType.Numeric);
            validator.Register(txtLast, ValidationType.NotEmpty, ValidationType.Numeric);
            validator.Register(txtCurrent, ValidationType.NotEmpty, ValidationType.Numeric);

            RefreshData();
        }

        private void RefreshData() {
            dgvCustomers.DataSource = controller.GetCustomers();
            dgvCustomers.Columns[2].Visible = false;

            foreach (DataGridViewColumn column in dgvCustomers.Columns) {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            dgvCustomers.ClearSelection();
        }

        private void Add(object sender, EventArgs e) {
            if (validator.ValidateAll()) {
                var customer = new CustomerModel(
                    controller.GetCustomers().Count + 1,
                    txtName.Texts,
                    (CustomerType)cmbType.SelectedIndex,
                    int.Parse(txtPeople.Texts),
                    int.Parse(txtLast.Texts),
                    int.Parse(txtCurrent.Texts)
                );

                controller.AddCustomer(customer);
                Toast.ShowToast($"{Localizer.GetResource(ResourceConstants.SUCCESS_ADD)}!", ToastType.Success);
                RefreshData();
            }
        }

        private void Edit(object sender, EventArgs e) {
            if (dgvCustomers.SelectedRows.Count <= 0) {
                Toast.ShowToast($"{Localizer.GetResource(ResourceConstants.WARNING_UPDATE_SELECT)}!", ToastType.Warning);
                return;
            }

            int selectedIndex = dgvCustomers.SelectedRows[0].Index;

            if (validator.ValidateAll()) {
                var customer = new CustomerModel(
                    selectedIndex + 1,
                    txtName.Texts,
                    (CustomerType)cmbType.SelectedIndex,
                    int.Parse(txtPeople.Texts),
                    int.Parse(txtLast.Texts),
                    int.Parse(txtCurrent.Texts)
                );

                controller.UpdateCustomer(selectedIndex, customer);
                Toast.ShowToast($"{Localizer.GetResource(ResourceConstants.SUCCESS_UPDATE)}!", ToastType.Success);
                RefreshData();
            }
        }

        private void New(object sender, EventArgs e) {
            dgvCustomers.ClearSelection();
        }

        private void Remove(object sender, EventArgs e) {
            if (dgvCustomers.SelectedRows.Count <= 0) {
                Toast.ShowToast($"{Localizer.GetResource(ResourceConstants.WARNING_DELETE_SELECT)}!", ToastType.Warning);
                return;
            }

            int selectedIndex = dgvCustomers.SelectedRows[0].Index;

            controller.DeleteCustomer(selectedIndex);
            Toast.ShowToast($"{Localizer.GetResource(ResourceConstants.SUCCESS_DELETE)}!", ToastType.Success);
            RefreshData();
        }

        private void GenerateInvoice(object sender, EventArgs e) {
            if (dgvCustomers.SelectedRows.Count <= 0) {
                Toast.ShowToast($"{Localizer.GetResource(ResourceConstants.WARNING_INVOICE_SELECT)}!", ToastType.Warning);
                return;
            }

            int selectedIndex = dgvCustomers.SelectedRows[0].Index;

            CustomerModel customer = controller.GetCustomers()[selectedIndex];
            InvoiceService.GenerateInvoice(customer);
            RefreshData();
        }

        private void CmbType_SelectedIndexChanged(object sender, EventArgs e) {
            txtPeople.Enabled = cmbType.SelectedIndex == 0;
            txtPeople.Texts = cmbType.SelectedIndex == 0 ? txtPeople.Texts : "1";
        }

        private void DgvCustomers_SelectionChanged(object sender, EventArgs e) {
            if (!isLoaded) {
                return;
            }

            if (dgvCustomers.SelectedRows.Count == 0 || dgvCustomers.Rows.Count == 0) {
                txtName.Texts = "";
                cmbType.SelectedIndex = 0;
                txtPeople.Texts = "1";
                txtLast.Texts = "";
                txtCurrent.Texts = "";
                return;
            }

            int selectedIndex = dgvCustomers.SelectedRows[0].Index;

            if (selectedIndex < 0 || selectedIndex >= dgvCustomers.Rows.Count) {
                return;
            }

            var row = dgvCustomers.Rows[selectedIndex];

            txtName.Texts = row.Cells[1].Value.ToString();
            cmbType.SelectedIndex = Convert.ToInt32((CustomerType)row.Cells[2].Value);
            txtPeople.Texts = row.Cells[4].Value.ToString();
            txtLast.Texts = row.Cells[5].Value.ToString();
            txtCurrent.Texts = row.Cells[6].Value.ToString();
        }

        private void TxtSearch_BaseTextChanged(object sender, EventArgs e) {
            dgvCustomers.DataSource = controller.SearchCustomers(txtSearch.Texts.Trim());
            dgvCustomers.ClearSelection();
        }

        private void CustomersView_Load(object sender, EventArgs e) {
            BeginInvoke((Action)(() => {
                isLoaded = true;
                dgvCustomers.ClearSelection();
            }));
        }
    }
}
