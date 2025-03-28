﻿using ASM.Components;
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
        private int selectedIndex;
        private readonly CustomerController controller;
        private Validator validator;

        public CustomersView() {
            InitializeComponent();
            controller = new CustomerController();
            Init();
        }

        private void Init() {
            selectedIndex = -1;
            validator = new Validator();
        }

        private void OnLoad(object sender, EventArgs e) {
            validator.Register(txtName, ValidationType.NOT_EMPTY);
            validator.Register(cmbType, ValidationType.SELECTED);
            validator.Register(txtPeople, ValidationType.NOT_EMPTY, ValidationType.NUMERIC);
            validator.Register(txtLast, ValidationType.NOT_EMPTY, ValidationType.NUMERIC);
            validator.Register(txtCurrent, ValidationType.NOT_EMPTY, ValidationType.NUMERIC);

            RefreshView();
        }

        private void RefreshView() {
            dgvCustomers.Columns.Clear();
            dgvCustomers.DataSource = controller.GetCustomers();
            dgvCustomers.Columns[2].Visible = false;
            cmbType.Tag = Utils.EnumToString<CustomerType>();

            Localizer.ApplyLocalization(cmbType);
            Localizer.ApplyLocalization(dgvCustomers);
            ClearSelection();
        }

        private void Add(object sender, EventArgs e) {
            if (validator.ValidateAll()) {
                var customer = new CustomerModel(
                    controller.GetCustomers().Count + 1,
                    txtName.Texts,
                    (CustomerType)Enum.Parse(typeof(CustomerType), cmbType.SelectedItem.ToString()),
                    int.Parse(txtPeople.Texts),
                    int.Parse(txtLast.Texts),
                    int.Parse(txtCurrent.Texts)
                );

                controller.AddCustomer(customer);
                Toast.ShowToast($"{Localizer.GetResource(ResourceConstants.SUCCESS_ADD)}!", ToastType.SUCCESS);
            }
        }

        private void Edit(object sender, EventArgs e) {
            if (selectedIndex == -1) {
                Toast.ShowToast($"{Localizer.GetResource(ResourceConstants.WARNING_UPDATE_SELECT)}!", ToastType.WARNING);
                return;
            }

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
                Toast.ShowToast($"{Localizer.GetResource(ResourceConstants.SUCCESS_UPDATE)}!", ToastType.SUCCESS);
                RefreshView();
            }
        }

        private void New(object sender, EventArgs e) {
            ResetForm();
        }

        private void Remove(object sender, EventArgs e) {
            if (selectedIndex == -1) {
                Toast.ShowToast($"{Localizer.GetResource(ResourceConstants.WARNING_DELETE_SELECT)}!", ToastType.WARNING);
                return;
            }

            controller.DeleteCustomer(selectedIndex);
            Toast.ShowToast($"{Localizer.GetResource(ResourceConstants.SUCCESS_DELETE)}!", ToastType.SUCCESS);
        }

        private void ResetForm() {
            txtName.Texts = "";
            cmbType.SelectedIndex = 0;
            txtPeople.Texts = "1";
            txtLast.Texts = "";
            txtCurrent.Texts = "";

            dgvCustomers.ClearSelection();
            selectedIndex = -1;
        }

        private void ClearSelection() {
            BeginInvoke((Action)(() => {
                dgvCustomers.ClearSelection();
                selectedIndex = -1;
                isLoaded = true;
            }));

            ResetForm();
        }

        private void CmbType_SelectedIndexChanged(object sender, EventArgs e) {
            if (!isLoaded) {
                isLoaded = true;
                return;
            }

            txtPeople.Enabled = cmbType.SelectedIndex == 0;
            txtPeople.Texts = cmbType.SelectedIndex == 0 ? txtPeople.Texts : "1";
        }

        private void DgvCustomers_SelectionChanged(object sender, EventArgs e) {
            if (!isLoaded || dgvCustomers.SelectedRows.Count == 0) {
                return;
            }

            selectedIndex = dgvCustomers.SelectedRows[0].Index;

            if (selectedIndex >= 0 && selectedIndex < dgvCustomers.Rows.Count) {
                txtName.Texts = dgvCustomers.Rows[selectedIndex].Cells[1].Value.ToString();
                cmbType.SelectedIndex = Convert.ToInt32(dgvCustomers.Rows[selectedIndex].Cells[2].Value);
                txtPeople.Texts = dgvCustomers.Rows[selectedIndex].Cells[4].Value.ToString();
                txtLast.Texts = dgvCustomers.Rows[selectedIndex].Cells[5].Value.ToString();
                txtCurrent.Texts = dgvCustomers.Rows[selectedIndex].Cells[6].Value.ToString();
            }
        }

        private void TxtSearch_BaseTextChanged(object sender, EventArgs e) {
            dgvCustomers.DataSource = controller.SearchCustomers(txtSearch.Texts.Trim());

            ClearSelection();
        }

        private void GenerateInvoice(object sender, EventArgs e) {
            if (selectedIndex == -1 || dgvCustomers.SelectedRows.Count == 0) {
                Toast.ShowToast($"{Localizer.GetResource(ResourceConstants.WARNING_INVOICE_SELECT)}!", ToastType.WARNING);
                return;
            }

            CustomerModel customer = controller.GetCustomers()[selectedIndex];
            InvoiceService.GenerateInvoice(customer);
        }
    }
}
