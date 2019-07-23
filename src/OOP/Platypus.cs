using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Platypus : Mammal, IWalk, ISwim
    {
        private int _maximumSpeedWalk;
        private int _maximumSpeedSwim;
        public Platypus(string name, int maximumSpeedWalk, int maximumSpeedSwim) : base(name)
        {
            this._maximumSpeedWalk = maximumSpeedWalk;
            this._maximumSpeedSwim = maximumSpeedSwim;
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
