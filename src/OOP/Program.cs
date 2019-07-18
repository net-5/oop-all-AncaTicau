using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace OOP
{

    class Program
    {
        static void Main(string[] args)
        {
            var pig1 = new Pig("Mitica", 20);
            pig1.Move(MovementType.Fly);
            pig1.Move(MovementType.Walk);
            pig1.ShowAnimalAttributes();

            Console.WriteLine("Next animal...");
            Ostrich ostrich1 = new Ostrich("Oli", 40);
            ostrich1.ShowMovementTypes();
            ostrich1.Move(MovementType.Fly);
            ostrich1.Move(MovementType.Walk);

            Console.WriteLine("Next animal...");
            Snake snake1 = new Snake("Anaconda", 15);
            snake1.Move(MovementType.Fly);
            snake1.Move(MovementType.Crawl);

            Console.WriteLine("Next animal...");
            Bee bee1 = new Bee("Buzzy", 13);
            bee1.Move(MovementType.Crawl);
            bee1.Move(MovementType.Fly);

            Console.WriteLine("Next animal...");
            Platypus platypus1 = new Platypus("John", 33);
            platypus1.Move(MovementType.Walk);
            platypus1.Move(MovementType.Crawl);
            platypus1.Move(MovementType.Swim);

            Console.WriteLine("Next animal...");
            WildDuck wildDuck1 = new WildDuck("Birdy", 40);
            wildDuck1.Move(MovementType.Crawl);
            wildDuck1.Move(MovementType.Fly);
            wildDuck1.ShowMovementTypes();
        }
    }
}
