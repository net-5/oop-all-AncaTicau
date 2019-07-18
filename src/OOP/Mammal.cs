using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, int maximumSpeed) : base(name, maximumSpeed)
        {
            AnimalAttributes.AddRange(new List<AnimalAttribute>{AnimalAttribute.GivesBirth, AnimalAttribute.IsWarmBlooded, AnimalAttribute.RegulatesBodyTemperature});
        }
    }
}
