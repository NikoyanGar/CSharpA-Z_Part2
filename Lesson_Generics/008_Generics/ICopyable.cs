namespace _008_Generics
{
    public interface ICopyable<out T>
    {
        T Copy();
    }
}
