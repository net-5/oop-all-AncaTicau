using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Snake : Reptile
    {
        public Snake(string name, int maximumSpeed) : base(name, maximumSpeed)
        {
            MovementTypes.Add(MovementType.Crawl);
        }
    }
}
