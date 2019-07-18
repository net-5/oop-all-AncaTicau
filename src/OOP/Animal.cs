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

        protected Animal(string name, int maximumSpeed)
        {
            this.Name = name;
            this.MaximumSpeed = maximumSpeed;
        }

        public string Name { get; }

        /// <summary>
        /// km / h
        /// </summary>
        public int MaximumSpeed { get; }

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

        private string GetNameAndCategory()
        {
            return $"{this.GetType().Name} ({this.GetType().BaseType.Name})";
        }

        public void Move(MovementType movementType)
        {
            if (MovementTypes.Contains(movementType))
            {
                Console.WriteLine($"The animal {this.GetType().Name} '{Name}' can {movementType} with the maximum speed {MaximumSpeed}km/h. ");
                return;
            }

            Console.WriteLine($"The animal {this.GetType().Name} '{Name}'cannot {movementType}.");
        }
    }
}
