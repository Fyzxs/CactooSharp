using CactooSharp.Booleans;
using System.Globalization;

namespace CactooSharp.Texts
{
    //Understands lower casing on demand
    public class LowerText : Text
    {
        private readonly Text _value;
        private readonly CultureInfo _cultureInfo;

        public LowerText(Text value) : this(value, new CultureInfo("en-US")) { }

        public LowerText(Text value, CultureInfo cultureInfo)
        {
            _value = value;
            _cultureInfo = cultureInfo;
        }

        public override string Value() => new IsNull<string>(_value) ? "null" : _value.Value().ToLower(_cultureInfo);

    }
}