namespace CactooSharp.Texts
{
    //Understands a creating a Text
    public class TextOf : Text
    {
        private readonly string _value;

        public TextOf(string value) => _value = value;

        public override string Value() => _value;
    }
}