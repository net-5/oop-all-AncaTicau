using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Pig : Mammal
    {
        public Pig(string name) : base(name)
        {
            MovementTypes.Add(MovementType.Walk);
        }
    }
}
