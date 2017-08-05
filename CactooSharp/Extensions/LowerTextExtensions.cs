using System.Globalization;
using CactooSharp.Texts;

namespace CactooSharp.Extensions {
    public static class LowerTextExtensions {
        public static Text LowerText(this Text text) => new LowerText(text);
        public static Text LowerText(this Text text, CultureInfo cultureInfo) => new LowerText(text, cultureInfo);
    }
}