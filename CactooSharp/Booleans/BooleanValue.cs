namespace CactooSharp.Booleans
{
    //Understands object based boolean-ness
    public class BooleanValue
    {
        private readonly string _value;

        public BooleanValue(string value) => _value = value;

        public static implicit operator bool(BooleanValue booleanValue) => bool.TryParse(booleanValue._value, out bool value) && value;
    }
}