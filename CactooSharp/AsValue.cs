namespace CactooSharp
{

    //Understands getting a value
    public interface AsValue<out T>
    {
        T Value();

    }
}