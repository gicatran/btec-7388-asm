using ASM.Views;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ASM.Lib.Constants {
    internal enum CustomerType {
        Household,
        Administrative,
        Production,
        Business
    }

    internal enum CacheGroup {
        Localization,
        Pages,
    }

    internal enum Language {
        En,
        Vi,
    }

    internal enum ValidationType {
        NotEmpty,
        Numeric,
        Selected,
    }

    internal enum ToastType {
        Success,
        Error,
        Warning,
    }

    internal static class AppConstants {
        public const int SIDEBAR_COLLAPSED_WIDTH = 60;
        public const int SIDEBAR_WIDTH = 200;

        public static readonly Dictionary<string, UserControl> SIDEBAR_LINKS = new Dictionary<string, UserControl> {
            { "customers", new CustomersView() },
            { "settings", new SettingsView() },
        };

        public static readonly ArrayList PRICE_TABLE = new ArrayList()
        {
            new double[] { 5973, 7052, 8699, 15929 },
            9955,
            11615,
            22068
        };

        public const float FEE = 1.1f;
        public const float VAT = 1.1f;
    }
}
