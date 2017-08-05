using CactooSharp.Texts;
using System.Globalization;

namespace CactooSharp.Extensions
{
    public static class UpperTextExtensions
    {
        public static Text UpperText(this Text text) => new UpperText(text);
        public static Text UpperText(this Text text, CultureInfo cultureInfo) => new UpperText(text, cultureInfo);

    }
}
