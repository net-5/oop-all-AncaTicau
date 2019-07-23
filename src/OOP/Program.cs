using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace OOP
{

    class Program
    {
        static void Main(string[] args)
        {
            var pig1 = new Pig("Mitica", 10);
            pig1.Walk();

            Console.WriteLine("Next animal...");
            Ostrich ostrich1 = new Ostrich("Oli", 15);
            ostrich1.Walk();
           

            Console.WriteLine("Next animal...");
            Snake snake1 = new Snake("Anaconda", 12);
            snake1.Crawl();
            

            Console.WriteLine("Next animal...");
            Bee bee1 = new Bee("Buzzy", 18);
            bee1.Fly();
           

            Console.WriteLine("Next animal...");
            Platypus platypus1 = new Platypus("John", 10, 15);
            platypus1.Swim();
            platypus1.Walk();
           
            Console.WriteLine("Next animal...");
            WildDuck wildDuck1 = new WildDuck("Birdy", 40, 8, 15);
            wildDuck1.Swim();
            wildDuck1.Fly();
            wildDuck1.Walk();
          
        }
    }
}
