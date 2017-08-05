using System.Collections.Generic;

namespace CactooSharp.Texts
{
    //Understands joining Texts on demand
    public class JoinedText : Text
    {
        private readonly Text _delimiter;
        private readonly IEnumerable<Text> _values;

        public JoinedText(Text delimiter, IEnumerable<Text> values)
        {
            _delimiter = delimiter;
            _values = values;
        }

        public override string Value() => string.Join(_delimiter.Value(), _values);
    }
}