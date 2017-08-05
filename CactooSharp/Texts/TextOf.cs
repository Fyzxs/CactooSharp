namespace CactooSharp.Texts
{
    public class TextOf : Text
    {
        private readonly string _value;

        public TextOf(string value) => _value = value;

        public string Value() => _value;
    }
}