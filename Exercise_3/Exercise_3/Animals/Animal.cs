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
            Name = name;
            Weight = weight;
            Age = age;
        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public abstract void DoSound();
        public virtual string Stats()
        {
            return $"Name: {Name}, Weight:{Weight}kg, Age:{Age} years";
        }
    }
}
//F: Då bör vi lägga attributet i Bird klassen
//F: Då skulle man lägga det här i Animal klassen