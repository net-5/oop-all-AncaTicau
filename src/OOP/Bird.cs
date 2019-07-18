using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
            AnimalAttributes.AddRange(new List<AnimalAttribute> { AnimalAttribute.HasFeathers, AnimalAttribute.IsWarmBlooded, AnimalAttribute.RegulatesBodyTemperature });
        }
    }
}
