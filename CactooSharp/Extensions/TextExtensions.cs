using CactooSharp.Texts;
using System.Globalization;

namespace CactooSharp.Extensions
{
    public static class TextExtensions
    {
        public static Text LowerText(this Text text) => new LowerText(text);
        public static Text LowerText(this Text text, CultureInfo cultureInfo) => new LowerText(text, cultureInfo);

        public static Text UpperText(this Text text) => new UpperText(text);
        public static Text UpperText(this Text text, CultureInfo cultureInfo) => new UpperText(text, cultureInfo);

    }
}
