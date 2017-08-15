using System;

namespace CactooSharp.Scalar
{
    public class NotNull<T> : Scalar<T> where T : class
    {
        private readonly Scalar<T> _origin;

        public NotNull(T origin) : this(new Value<T>(origin))
        {
        }
        public NotNull(Scalar<T> origin) => _origin = origin;


        public T AsValue()
        {
            if (_origin == null) throw new Exception("NULL instead of valid scalar");
            if (_origin.AsValue() == null) throw new Exception("NULL instead of valid value");

            return _origin.AsValue();
        }
    }
}
