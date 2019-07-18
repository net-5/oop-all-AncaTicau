using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace OOP
{
    public enum MovementType
    {
        Fly,
        Walk,
        Crawl,
        Swim
    }

    public enum AnimalAttribute
    {
        HasFeathers,
        RegulatesBodyTemperature,
        GivesBirth,
        LaysEggs,
        IsColdBlooded,
        IsWarmBlooded,
    }

    public abstract class Animal : IMove
    {
        protected readonly List<MovementType> MovementTypes = new List<MovementType>();
        protected readonly List<AnimalAttribute> AnimalAttributes = new List<AnimalAttribute>();

        protected Animal(string name)
        {
            this.Name = name;
        }

        public string Name { get; }


        public void ShowMovementTypes()
        {
            string result = $"The animal {GetNameAndCategory()} has the folowing movement types : ";

            var index = 0;

            foreach (var movementType in MovementTypes)
            {
                if (index > 0)
                {
                    result += ", ";
                }

                result += movementType;

                index++;
            }

            Console.WriteLine(result + ".");
        }

        public void ShowAnimalAttributes()
        {
            string result = $"The animal {GetNameAndCategory()} has the folowing  attributes : ";

            var index = 0;

            foreach (var animalAttribute in AnimalAttributes)
            {
                if (index > 0)
                {
                    result += ", ";
                }

                result += animalAttribute;

                index++;
            }

            Console.WriteLine(result + ".");
        }

        public void ShowMaximumSpeed()
        {
            if (MovementTypes.Contains(MovementType.Walk))
            {
                Console.WriteLine($"The animal can {MovementType.Walk} with the maximum speed of 20km/h. ");
            }
            else if (MovementTypes.Contains(MovementType.Crawl))
            {
                Console.WriteLine($"The animal can {MovementType.Crawl} with the maximum speed of 5km/h. ");
            }
            else if (MovementTypes.Contains(MovementType.Fly))
            {
                Console.WriteLine($"The animal can {MovementType.Fly} with the maximum speed of 200km/h. ");
            }
            else if (MovementTypes.Contains(MovementType.Swim))
            {
                Console.WriteLine($"The animal can {MovementType.Swim} with the maximum speed of 10km/h. ");
            }
        }

        private string GetNameAndCategory()
        {
            return $"{this.GetType().Name} ({this.GetType().BaseType.Name})";
        }

        public void Move(MovementType movementType)
        {
            if (MovementTypes.Contains(movementType))
            {
                Console.WriteLine($"The animal {this.GetType().Name} '{Name}' can {movementType}. ");
                return;
            }

            Console.WriteLine($"The animal {this.GetType().Name} '{Name}'cannot {movementType}.");
        }
    }
}
