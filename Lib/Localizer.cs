using ASM.Components;
using ASM.Constants;
using ASM.Lib.Constants;
using System;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace ASM.Lib {
    internal static class Localizer {
        private static Language currentLanguage;
        private static ResourceManager resourceManager;
        private static CultureInfo culture;

        public static event Action LanguageChanged;

        public static void Init(Control mainControl) {
            LanguageChanged += () => ApplyLocalization(mainControl);
            Load(Language.VI);
        }

        public static void Load(Language language) {
            currentLanguage = language;
            culture = new CultureInfo(language.ToString());
            resourceManager = new ResourceManager(ResourceConstants.LANGUAGE_PATH, typeof(MainView).Assembly);

            LanguageChanged?.Invoke();
        }

        public static Language GetLanguage() {
            return currentLanguage;
        }

        public static void SetLanguage(Language language) {
            if (currentLanguage == language) {
                return;
            }

            Load(language);
        }

        public static void ApplyLocalization(Control control) {
            if (control.Controls.Count > 0) {
                ApplyLocalizations(control);
            }

            if (string.IsNullOrEmpty(control.Tag?.ToString())) {
                return;
            }

            string[] keys = control.Tag.ToString().Split(',');
            string[] localizedTexts = GetResources(keys);

            string[] storedTexts = CacheManager.Get<string[]>(CacheGroup.LOCALIZATION, control.Name);
            string[] currentTexts = new string[localizedTexts.Length];

            if (control is CustomTextBox customTextBox) {
                currentTexts[0] = customTextBox.PlaceholderText;
            } else if (control is DataGridView dataGridView) {
                if (dataGridView.Columns.Count != localizedTexts.Length) {
                    return;
                }

                for (int i = 0; i < dataGridView.Columns.Count; i++) {
                    currentTexts[i] = dataGridView.Columns[i].HeaderText;
                }
            } else if (control is CustomComboBox comboBox) {
                currentTexts = comboBox.Items.Cast<string>().ToArray();
            } else {
                currentTexts[0] = control.Text;
            }

            if (storedTexts?.SequenceEqual(localizedTexts) == true && currentTexts.SequenceEqual(localizedTexts)) {
                return;
            }

            if (control is CustomTextBox textBox) {
                textBox.PlaceholderText = localizedTexts[0];
            } else if (control is DataGridView dataGridView) {
                for (int i = 0; i < dataGridView.Columns.Count; i++) {
                    dataGridView.Columns[i].HeaderText = localizedTexts[i];
                }
            } else if (control is CustomComboBox comboBox) {
                comboBox.DataSource = localizedTexts;
            } else {
                control.Text = localizedTexts[0];
            }

            CacheManager.Set(CacheGroup.LOCALIZATION, control.Name, localizedTexts);
        }

        public static void ApplyLocalizations(Control parentControl) {
            foreach (Control control in parentControl.Controls) {
                ApplyLocalization(control);
            }
        }

        public static string GetResource(string resourceKey) {
            if (resourceManager == null || culture == null) {
                return $"[{resourceKey}]";
            }

            return resourceManager.GetString(resourceKey, culture);
        }

        public static string[] GetResources(string[] resources) {
            string[] results = new string[resources.Length];

            for (int i = 0; i < resources.Length; i++) {
                results[i] = GetResource(resources[i]);
            }

            return results;
        }
    }
}
