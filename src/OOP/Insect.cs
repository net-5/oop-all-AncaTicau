﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Insect : Animal
    {
        public Insect(string name) : base(name)
        {
            AnimalAttributes.AddRange(new List<AnimalAttribute> { AnimalAttribute.LaysEggs, AnimalAttribute.IsWarmBlooded, AnimalAttribute.RegulatesBodyTemperature });
        }
    }
}
