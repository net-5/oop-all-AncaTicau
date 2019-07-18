using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Ostrich : Bird
    {
        public Ostrich(string name, int maximumSpeed) : base(name, maximumSpeed)
        {
            MovementTypes.Add(MovementType.Walk);
        }
    }
}
