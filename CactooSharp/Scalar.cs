namespace CactooSharp
{
    //Understands getting a value from an object
    public interface Scalar<out T>
    {
        T AsValue();
    }
}