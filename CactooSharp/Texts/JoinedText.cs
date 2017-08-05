using CactooSharp.Iterable;

namespace CactooSharp.Texts
{
    public class JoinedText : Text
    {
        private readonly Text _delimiter;
        private readonly IterableOf<Text> _values;

        public JoinedText(Text delimiter, IterableOf<Text> values)
        {
            _delimiter = delimiter;
            _values = values;
        }

        public override string Value() => string.Join(_delimiter.Value(), _values);
    }
}