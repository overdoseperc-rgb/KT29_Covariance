namespace ConsoleApp1
{
    public interface IContainer<out T>
    {
        T GetItem();

        // void SetItem(T item);
    }
}
