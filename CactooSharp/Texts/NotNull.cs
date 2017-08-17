using System;

namespace CactooSharp.Texts
{
    //Understands checking a text for nulls
    public class NotNull : Text
    {
        private readonly Text _origin;

        public NotNull(Text origin) => _origin = origin;

        public string AsString()
        {
            if (_origin == null) throw new Exception("NULL instead of a valid text");
            if (_origin.AsString() == null) throw new Exception("NULL instead of a valid result string");
            return _origin.AsString();
        }
    }
}
