namespace CactooSharp.Booleans
{
    public class BooleanValue
    {
        private readonly string _value;

        public BooleanValue(string value) => _value = value;

        public static implicit operator bool(BooleanValue booleanValue) => bool.TryParse(booleanValue._value, out bool value) && value;
    }
}