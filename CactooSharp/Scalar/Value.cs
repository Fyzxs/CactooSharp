namespace CactooSharp.Scalar
{
    public class Value<T> : Scalar<T>
    {
        private readonly T _origin;

        public Value(T origin) => _origin = origin;

        public T AsValue() => _origin;
    }
}