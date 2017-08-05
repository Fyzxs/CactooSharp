using CactooSharp.Booleans;
using System.Globalization;

namespace CactooSharp.Texts
{
    public class ToUpper : Text
    {
        private readonly Text _value;
        private readonly CultureInfo _cultureInfo;

        public ToUpper(string value) : this(new TextOf(value)) { }

        public ToUpper(Text value) : this(value, new CultureInfo("en-US")) { }

        public ToUpper(Text value, CultureInfo cultureInfo)
        {
            _value = value;
            _cultureInfo = cultureInfo;
        }

        public string Value() => new IsNull<string>(_value) ? "NULL" : _value.Value().ToUpper(_cultureInfo);
    }
}