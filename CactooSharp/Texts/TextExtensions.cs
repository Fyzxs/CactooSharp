using System.Globalization;

namespace CactooSharp.Texts
{
    public static class TextExtensions
    {
        public static Text ToLower(this Text text) => new ToLower(text);
        public static Text ToLower(this Text text, CultureInfo cultureInfo) => new ToLower(text, cultureInfo);
        public static Text ToUpper(this Text text) => new ToUpper(text);
        public static Text ToUpper(this Text text, CultureInfo cultureInfo) => new ToUpper(text, cultureInfo);
    }
}
