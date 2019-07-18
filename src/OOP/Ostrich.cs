using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Ostrich : Bird
    {
        public Ostrich(string name) : base(name)
        {
            MovementTypes.Add(MovementType.Walk);
        }
    }
}
