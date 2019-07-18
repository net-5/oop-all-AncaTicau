using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Pigeon : Bird
    {
        public Pigeon(string name) : base(name)
        {
            MovementTypes.AddRange(new List<MovementType> {MovementType.Walk, MovementType.Fly});
        }
    }
}
