using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class WildDuck : Bird
    {
        public WildDuck(string name) : base(name)
        {
            MovementTypes.AddRange(new List<MovementType> { MovementType.Walk, MovementType.Swim, MovementType.Fly });
        }
    }
}
