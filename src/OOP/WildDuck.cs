using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class WildDuck : Bird
    {
        public WildDuck(string name, int maximumSpeed) : base(name, maximumSpeed)
        {
            MovementTypes.AddRange(new List<MovementType> { MovementType.Walk, MovementType.Swim, MovementType.Fly });
        }
    }
}
