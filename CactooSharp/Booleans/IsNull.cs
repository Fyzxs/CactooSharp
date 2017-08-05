namespace CactooSharp.Booleans
{
    public class IsNull<T> where T : class
    {
        private readonly Scalar<T> _origin;

        public IsNull(Scalar<T> scalar) => _origin = scalar;

        public static implicit operator bool(IsNull<T> isNull) => isNull._origin?.Value() == null;
    }
}