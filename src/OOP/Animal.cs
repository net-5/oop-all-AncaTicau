using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace OOP
{
    public abstract class Animal
    {
        protected Animal(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public string GetNameAndCategory()
        {
            return $"{this.GetType().Name} ({this.GetType().BaseType.Name})";
        }
    }
}
