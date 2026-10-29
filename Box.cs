namespace ConsoleApp1
{
    public class Box<T> : IContainer<T>
    {
        private T item;

        public Box(T item)
        {
            this.item = item;
        }

        public T GetItem()
        {
            return item;
        }
    }
}
