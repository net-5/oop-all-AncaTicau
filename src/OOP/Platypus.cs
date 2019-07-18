using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Platypus : Mammal
    {
        public Platypus(string name) : base(name)
        {
            MovementTypes.AddRange(new List<MovementType> { MovementType.Walk, MovementType.Swim });
        }
    }
}
