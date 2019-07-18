using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Reptile : Animal
    {
        public Reptile(string name, int maximumSpeed) : base(name, maximumSpeed)
        {
            AnimalAttributes.AddRange(new List<AnimalAttribute> { AnimalAttribute.IsColdBlooded, AnimalAttribute.LaysEggs });
        }
    }
}