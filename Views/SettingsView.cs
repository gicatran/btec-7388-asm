using ASM.Lib;
using ASM.Lib.Constants;
using System;
using System.Windows.Forms;

namespace ASM.Views {
    public partial class SettingsView : UserControl {
        bool isLoaded;

        public SettingsView() {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e) {
            cmbLanguage.Tag = Utils.EnumToString<Language>();

            Localizer.ApplyLocalization(cmbLanguage);
            cmbLanguage.SelectedIndex = (int)Localizer.GetLanguage();
        }

        private void CmbLanguage_SelectedIndexChanged(object sender, EventArgs e) {
            if (!isLoaded) {
                isLoaded = true;
                return;
            }

            if (cmbLanguage.SelectedIndex == -1) {
                return;
            }

            Language selectedLanguage = (Language)cmbLanguage.SelectedIndex;

            if (selectedLanguage != Localizer.GetLanguage()) {
                cmbLanguage.OnSelectedIndexChanged -= CmbLanguage_SelectedIndexChanged;
                Localizer.Load(selectedLanguage);
                cmbLanguage.SelectedIndex = (int)Localizer.GetLanguage();
                cmbLanguage.OnSelectedIndexChanged += CmbLanguage_SelectedIndexChanged;
            }
        }
    }
}
