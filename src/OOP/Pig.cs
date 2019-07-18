using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Pig : Mammal
    {
        public Pig(string name, int maximumSpeed) : base(name, maximumSpeed)
        {
            MovementTypes.Add(MovementType.Walk);
        }
    }
}
