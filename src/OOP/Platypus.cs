using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Platypus : Mammal
    {
        public Platypus(string name, int maximumSpeed) : base(name, maximumSpeed)
        {
            MovementTypes.AddRange(new List<MovementType> { MovementType.Walk, MovementType.Swim });
        }
    }
}
