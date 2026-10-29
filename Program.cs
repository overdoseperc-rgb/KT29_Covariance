using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кличку собаки: ");
            string name = Console.ReadLine() ?? "";

            var dog = new Dog { Name = name };
            var dogBox = new Box<Dog>(dog);

            IContainer<Animal> container = dogBox;
            Animal animal = container.GetItem();

            Console.WriteLine("Box<Dog> присвоен переменной IContainer<Animal>");
            Console.WriteLine($"Имя: {animal.Name}");
            Console.WriteLine($"Фактический тип: {animal.GetType().Name}");
            Console.WriteLine($"Это тот же объект: {object.ReferenceEquals(dog, animal)}");

            // Box<Animal> wrongBox = dogBox;
        }
    }
}
