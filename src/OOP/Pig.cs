using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Pig : Mammal, IWalk
    {
        private int _maximumSpeedWalk;

        public Pig(string name, int maximumSpeedWalk) : base(name)
        {
            this._maximumSpeedWalk = maximumSpeedWalk;
        }

        public void Walk()
        {
            Console.WriteLine($"The animal {GetNameAndCategory()} walks with the maximum speed of {_maximumSpeedWalk}km/h.");
        }
    }
}
