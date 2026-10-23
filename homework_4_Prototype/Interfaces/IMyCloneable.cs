namespace homework_4_Prototype.Interfaces
{
    public interface IMyCloneable<out T>
    {
        T Clone();
    }
}
