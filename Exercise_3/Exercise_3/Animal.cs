using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    abstract class Animal
    {
        public Animal(string name, double weight, int age)
        {

        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public abstract void DoSound();
    }
}
