using ConsoleApp3;
using System;

namespace ConsoleApp4
{


    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("Kit", new DateTime(2005, 8, 7));
            c.MakeNoise();
            Console.WriteLine($"Кошке по имени {c.Name} уже {c.GetAge()} лет");
            //c.HungryStatus = 150; 

            Cat ct = new Cat($"Cry", new DateTime(2006, 9, 8));
            ct.MakeNoise();
            Console.WriteLine($"Кошке по имени {ct.Name} уже {ct.GetAge()} лет");


            CatSmartHouse catSmartH = new CatSmartHouse(900);
            catSmartH.AddCat(c);
            catSmartH.AddCat(ct);
            Console.ReadLine();
        }



    }

}
