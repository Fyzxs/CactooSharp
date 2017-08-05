using CactooSharp.Texts;

namespace CactooSharp.Extensions
{
    public static class StringExtensions
    {
        public static Text ToText(this string value) => new TextOf(value);
        public static Text LowerText(this string value) => value.ToText().LowerText();
        public static Text UpperText(this string value) => value.ToText().UpperText();
    }
}