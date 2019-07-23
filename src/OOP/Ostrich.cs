using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Ostrich : Bird, IWalk
    {
        private int _maximumSpeedWalk;

        public Ostrich(string name, int maximumSpeedWalk) : base(name)
        {
            this._maximumSpeedWalk = maximumSpeedWalk;
        }
        public void Walk()
        {
            Console.WriteLine($"The animal {GetNameAndCategory()} walks with the maximum speed of {_maximumSpeedWalk}km/h.");
        }
    }
}
