using System.Text;

namespace CactooSharp.Texts
{
    //Understands transforming input into strings

    public class TextOf : Text
    {
        private readonly Text _origin;

        public TextOf(byte[] origin) : this(new DelayedText(() => Encoding.ASCII.GetString(origin))) { }
        public TextOf(string origin) : this(new DelayedText(() => origin)) { }

        public TextOf(Text origin) => _origin = origin;

        public string AsString() => _origin.AsString();
    }
}