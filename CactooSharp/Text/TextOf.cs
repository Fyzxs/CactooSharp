using CactooSharp.Scalar;

namespace CactooSharp.Text
{
    public class TextOf : Scalar<string>
    {
        private readonly Scalar<string> _origin;

        public TextOf(string origin) : this(new Value<string>(origin)) { }
        public TextOf(Scalar<string> origin) => _origin = origin;

        public string AsValue() => _origin.AsValue();
    }
}