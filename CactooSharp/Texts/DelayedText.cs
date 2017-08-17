using System;

namespace CactooSharp.Texts {
    public class DelayedText : Text
    {
        private readonly Func<string> _func;

        public DelayedText(Func<string> func) => _func = func;

        public string AsString() => _func.Invoke();
    }
}