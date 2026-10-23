namespace homework_4_Protorype.Interfaces
{
    public interface IMyCloneable<out T>
    {
        T Clone();
    }
}
