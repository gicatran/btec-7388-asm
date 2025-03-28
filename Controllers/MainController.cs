using ASM.Lib;
using ASM.Lib.Constants;
using ASM.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ASM.Controllers {
    public class MainController {
        private readonly Dictionary<string, PageModel> pages;

        public MainController() {
            pages = new Dictionary<string, PageModel>();
            InitializePages();
        }

        private void InitializePages() {
            foreach (var key in AppConstants.SIDEBAR_LINKS.Keys) {
                pages[key] = new PageModel(key, AppConstants.SIDEBAR_LINKS[key]);
            }
        }

        public UserControl GetPage(string key) {
            if (pages.ContainsKey(key)) {
                if (!CacheManager.Exists(CacheGroup.PAGES, key)) {
                    CacheManager.Set(CacheGroup.PAGES, key, pages[key].Control);
                }
                return CacheManager.Get<UserControl>(CacheGroup.PAGES, key);
            }
            return null;
        }
    }
}