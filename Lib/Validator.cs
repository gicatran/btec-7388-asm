using ASM.Components;
using ASM.Constants;
using ASM.Lib.Constants;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ASM.Lib {
    internal class Validator {
        private readonly Dictionary<Control, List<ValidationType>> registeredControls = new Dictionary<Control, List<ValidationType>>();

        public void Register(Control control, params ValidationType[] validationTypes) {
            if (!registeredControls.ContainsKey(control)) {
                registeredControls[control] = new List<ValidationType>();
            }

            registeredControls[control].AddRange(validationTypes);
        }

        public bool ValidateAll() {
            foreach (var entry in registeredControls) {
                Control control = entry.Key;

                foreach (ValidationType validationType in entry.Value) {
                    if (!ValidateControl(control, validationType, out string errorMessage)) {
                        Toast.ShowToast($"'{GetFieldName(control)}' {Localizer.GetResource(errorMessage)}!", ToastType.ERROR);

                        if (control is CustomTextBox textBoxError) {
                            textBoxError.BorderColor = ColorConstants.ERROR;
                        } else if (control is CustomComboBox comboBoxError) {
                            comboBoxError.BorderColor = ColorConstants.ERROR;
                        }

                        return false;
                    }
                }

                if (control is CustomTextBox textBox) {
                    textBox.BorderColor = ColorConstants.BORDER;
                } else if (control is CustomComboBox comboBox) {
                    comboBox.BorderColor = ColorConstants.BORDER;
                }
            }

            return true;
        }

        private bool ValidateControl(Control control, ValidationType validationType, out string errorMessage) {
            switch (validationType) {
                case ValidationType.NOT_EMPTY:
                    if (string.IsNullOrWhiteSpace((control as CustomTextBox)?.Texts)) {
                        errorMessage = ResourceConstants.ERROR_EMPTY;
                        return false;
                    }
                    break;
                case ValidationType.NUMERIC:
                    if (!int.TryParse((control as CustomTextBox)?.Texts, out _)) {
                        errorMessage = ResourceConstants.ERROR_NUMERIC;
                        return false;
                    }
                    break;
                case ValidationType.SELECTED:
                    if ((control as CustomComboBox)?.SelectedIndex == -1) {
                        errorMessage = ResourceConstants.ERROR_SELECT;
                        return false;
                    }
                    break;
            }

            errorMessage = "";
            return true;
        }

        private string GetFieldName(Control control) {
            return Localizer.GetResource(control.Tag.ToString());
        }
    }
}
