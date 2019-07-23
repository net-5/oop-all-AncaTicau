using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class WildDuck : Bird, IFly, IWalk, ISwim
    {
        private int _maximumSpeedFly;
        private int _maximumSpeedWalk;
        private int _maximumSpeedSwim;

        public WildDuck(string name, int maximumSpeedFly, int maximumSpeedWalk, int maximumSpeedSwim) : base(name)
        {
            _maximumSpeedFly = maximumSpeedFly;
            _maximumSpeedWalk = maximumSpeedWalk;
            _maximumSpeedSwim = maximumSpeedSwim;
        }

        public void Fly()
        {
            Console.WriteLine($"The animal {GetNameAndCategory()} flies with the maximum speed of {_maximumSpeedFly}km/h.");
        }

        public void Walk()
        {
            Console.WriteLine($"The animal {GetNameAndCategory()} walks with the maximum speed of {_maximumSpeedWalk}km/h.");
        }

        public void Swim()
        {
            Console.WriteLine($"The animal {GetNameAndCategory()} swims with the maximum speed of {_maximumSpeedSwim}km/h.");
        }
    }
}
