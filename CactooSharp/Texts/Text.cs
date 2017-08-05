namespace CactooSharp.Texts
{
    public abstract class Text : Scalar<string>
    {
        public abstract string Value();

        public override string ToString() => Value();
    }
}