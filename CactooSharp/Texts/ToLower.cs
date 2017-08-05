using CactooSharp.Booleans;
using System.Globalization;

namespace CactooSharp.Texts
{
    public class ToLower : Text
    {
        private readonly Text _value;
        private readonly CultureInfo _cultureInfo;

        public ToLower(string value) : this(new TextOf(value)) { }

        public ToLower(Text value) : this(value, new CultureInfo("en-US")) { }

        public ToLower(Text value, CultureInfo cultureInfo)
        {
            _value = value;
            _cultureInfo = cultureInfo;
        }

        public string Value() => new IsNull<string>(_value) ? "null" : _value.Value().ToLower(_cultureInfo);
    }
}