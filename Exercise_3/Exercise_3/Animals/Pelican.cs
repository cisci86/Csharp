using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Animals
{
    internal class Pelican : Bird
    {
        public Pelican(string name, double weight, int age, double wingSpan, double beakSize) : base(name, weight, age, wingSpan)
        {
            BeakSize = beakSize;
        }
        public double BeakSize { get; set; }
        public override string Stats()
        {
            return base.Stats() + $", Beak Size: {BeakSize}cm";
        }
    }
}
