using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Reptile : Animal
    {
        public Reptile(string name) : base(name)
        {
            AnimalAttributes.AddRange(new List<AnimalAttribute> { AnimalAttribute.IsColdBlooded, AnimalAttribute.LaysEggs });
        }
    }
}