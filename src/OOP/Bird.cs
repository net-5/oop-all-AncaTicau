using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Bird : Animal
    {
        public Bird(string name, int maximumSpeed) : base(name, maximumSpeed)
        {
            AnimalAttributes.AddRange(new List<AnimalAttribute> { AnimalAttribute.HasFeathers, AnimalAttribute.IsWarmBlooded, AnimalAttribute.RegulatesBodyTemperature });
        }
    }
}
