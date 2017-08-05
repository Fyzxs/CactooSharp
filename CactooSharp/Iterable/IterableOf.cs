using System.Collections;
using System.Collections.Generic;

namespace CactooSharp.Iterable
{
    public class IterableOf<T> : IEnumerable<T>
    {
        private readonly T[] _values;

        public IterableOf(params T[] values) => _values = values;

        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)_values).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}