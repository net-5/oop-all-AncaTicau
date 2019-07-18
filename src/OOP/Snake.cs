using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Snake : Reptile
    {
        public Snake(string name) : base(name)
        {
            MovementTypes.Add(MovementType.Crawl);
        }
    }
}
