using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("Мурзик", new DateTime(2009, 04, 29));
            c.MakeNoise();
            Console.WriteLine($"Коту {c.Name} уже {c.GetAge()} лет");
        }
    }
}
