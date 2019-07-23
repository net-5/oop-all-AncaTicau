using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Bee : Animal, IFly
    {
        private int _maximumSpeedFly;

        public Bee(string name, int maximumSpeedFly) : base(name)
        {
            _maximumSpeedFly = maximumSpeedFly;
        }
        public void Fly()
        {
            Console.WriteLine($"The animal {GetNameAndCategory()} flies with the maximum speed of {_maximumSpeedFly}km/h.");
        }
    }
}
