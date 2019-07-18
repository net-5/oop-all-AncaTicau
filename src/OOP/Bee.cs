using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Bee : Animal
    {
        public Bee(string name) : base(name)
        {
            MovementTypes.Add(MovementType.Fly);
        }
    }
}
