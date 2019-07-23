using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Snake : Reptile, ICrawl
    {
        private int _maximumSpeedCrawl;

        public Snake(string name, int maximumSpeedCrawl) : base(name)
        {
            this._maximumSpeedCrawl = maximumSpeedCrawl;
        }
        public void Crawl()
        {
            Console.WriteLine($"The animal {GetNameAndCategory()} crawls with the maximum speed of {_maximumSpeedCrawl}km/h.");
        }
    }
}
