namespace CactooSharp.Texts {
    public static class StringExtensions {
        public static Text ToText(this string value) => new TextOf(value);
        public static Text ToLower(this string value) => value.ToText().ToLower();
        public static Text ToUpper(this string value) => value.ToText().ToUpper();
    }
}