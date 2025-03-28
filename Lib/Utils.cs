using ASM.Constants;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ASM.Lib {
    internal static class Utils {
        public static Font Load(float size, int style = 0) {
            using (Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(ResourceConstants.FONT_PATH)) {
                if (fontStream == null) {
                    throw new FileNotFoundException($"Font resource '{ResourceConstants.FONT_PATH}' not found.");
                }

                byte[] fontData = new byte[fontStream.Length];
                fontStream.Read(fontData, 0, fontData.Length);

                BaseFont baseFont = BaseFont.CreateFont(
                    ResourceConstants.FONT_PATH,
                    BaseFont.IDENTITY_H,
                    BaseFont.EMBEDDED,
                    true,
                    fontData,
                    null
                );

                return new Font(baseFont, size, style);
            }
        }

        public static string PrefixAndFormat(int number) {
            return number.ToString("N0", new System.Globalization.CultureInfo("vi-VN"));
        }

        public static string EnumToString<T>() where T : Enum {
            return string.Join(",", Enum.GetValues(typeof(T))
                                        .Cast<T>()
                                        .Select(value => value.ToString().ToLower()));
        }
    }
}
