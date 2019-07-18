using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Bee : Animal
    {
        public Bee(string name, int maximumSpeed) : base(name, maximumSpeed)
        {
            MovementTypes.Add(MovementType.Fly);
        }
    }
}
