using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Pigeon : Bird, IFly, IWalk
    {
        private int _maximumSpeedWalk;

        private int _maximumSpeedFly;

        public Pigeon(string name, int maximumSpeedWalk, int maximumSpeedFly) : base(name)
        {
            this._maximumSpeedWalk = maximumSpeedWalk;
            this._maximumSpeedFly = maximumSpeedFly;
        }

        public void Fly()
        {
            Console.WriteLine($"The animal {GetNameAndCategory()} flies with the maximum speed of {_maximumSpeedFly}km/h.");
        }
        public void Walk()
        {
            Console.WriteLine($"The animal {GetNameAndCategory()} walks with the maximum speed of {_maximumSpeedWalk}km/h.");
        }

    }
}
