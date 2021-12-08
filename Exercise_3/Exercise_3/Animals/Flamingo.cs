using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Animals
{
    internal class Flamingo : Bird
    {
        public Flamingo(string name, double weight, int age) : base(name, weight, age)
        {
        }
        public double AmountShrimpEaten { get; set; }
    }
}
