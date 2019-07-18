using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace OOP
{

    class Program
    {
        static void Main(string[] args)
        {
            var pig1 = new Pig("Mitica");
            pig1.ShowMovementTypes();
            pig1.Move(MovementType.Fly);
            pig1.Move(MovementType.Walk);
            pig1.ShowAnimalAttributes();
            pig1.ShowMaximumSpeed();

            Console.WriteLine("Next animal...");
            Ostrich ostrich1 = new Ostrich("Oli");
            ostrich1.ShowMovementTypes();
            ostrich1.Move(MovementType.Fly);
            ostrich1.Move(MovementType.Walk);
            ostrich1.ShowAnimalAttributes();
            ostrich1.ShowMaximumSpeed();

            Console.WriteLine("Next animal...");
            Snake snake1 = new Snake("Anaconda");
            snake1.ShowMovementTypes();
            snake1.Move(MovementType.Fly);
            snake1.Move(MovementType.Crawl);
            snake1.ShowAnimalAttributes();
            snake1.ShowMaximumSpeed();

            Console.WriteLine("Next animal...");
            Bee bee1 = new Bee("Buzzy");
            bee1.Move(MovementType.Crawl);
            bee1.Move(MovementType.Fly);

            Console.WriteLine("Next animal...");
            Platypus platypus1 = new Platypus("John");
            platypus1.Move(MovementType.Walk);
            platypus1.Move(MovementType.Crawl);
            platypus1.Move(MovementType.Swim);
            platypus1.ShowAnimalAttributes();
            platypus1.ShowMaximumSpeed();

            Console.WriteLine("Next animal...");
            WildDuck wildDuck1 = new WildDuck("Birdy");
            wildDuck1.Move(MovementType.Crawl);
            wildDuck1.Move(MovementType.Fly);
            wildDuck1.ShowMovementTypes();
            wildDuck1.ShowAnimalAttributes();
            wildDuck1.ShowMaximumSpeed();
        }
    }
}
