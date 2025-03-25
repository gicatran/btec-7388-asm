using System.Windows.Forms;

namespace ASM.Models {
    internal class PageModel {
        public string Key { get; set; }
        public UserControl Control { get; set; }

        public PageModel(string key, UserControl control) {
            Key = key;
            Control = control;
        }
    }
}
