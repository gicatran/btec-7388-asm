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
        private static string currentLanguage;
        private static ResourceManager resourceManager;
        private static CultureInfo culture;

        public static event Action LanguageChanged;

        public static void Init(Control mainControl) {
            LanguageChanged += () => ApplyLocalization(mainControl);
            Load(Language.VI);
        }

        public static void Load(Language language) {
            string strLanguage = language.ToString().ToLower();

            if (currentLanguage == strLanguage) {
                return;
            }

            currentLanguage = strLanguage;
            culture = new CultureInfo(strLanguage);
            resourceManager = new ResourceManager(ResourceConstants.LANGUAGE_PATH, typeof(MainView).Assembly);

            LanguageChanged?.Invoke();
        }

        public static void ApplyLocalizations(Control parentControl) {
            foreach (Control control in parentControl.Controls) {
                ApplyLocalization(control);
            }
        }

        public static void ApplyLocalization(Control control) {
            if (control.Controls.Count > 0) {
                ApplyLocalizations(control);
            }

            if (string.IsNullOrEmpty(control.Tag?.ToString())) {
                return;
            }

            string[] keys = control.Tag.ToString().Split(',');
            string[] localizedTexts = GetResourcesFromArray(keys);

            string[] storedTexts = CacheManager.Get<string[]>(CacheGroup.Localization, control.Name);
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
            } else {
                control.Text = localizedTexts[0];
            }

            CacheManager.Set(CacheGroup.Localization, control.Name, localizedTexts);
        }

        public static string GetResources(string resources) {
            if (resourceManager == null || culture == null) {
                return $"[{resources}]";
            }

            return resourceManager.GetString(resources, culture);
        }

        public static string[] GetResourcesFromArray(string[] resources) {
            string[] results = new string[resources.Length];

            for (int i = 0; i < resources.Length; i++) {
                results[i] = GetResources(resources[i]);
            }

            return results;
        }
    }
}
