using CactooSharp.Booleans;
using System.Globalization;

namespace CactooSharp.Texts
{
    public class UpperText : Text
    {
        private readonly Text _value;
        private readonly CultureInfo _cultureInfo;

        public UpperText(Text value) : this(value, new CultureInfo("en-US")) { }

        public UpperText(Text value, CultureInfo cultureInfo)
        {
            _value = value;
            _cultureInfo = cultureInfo;
        }

        public override string Value() => new IsNull<string>(_value) ? "NULL" : _value.Value().ToUpper(_cultureInfo);
    }
}