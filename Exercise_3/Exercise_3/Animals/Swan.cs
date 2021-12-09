using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Animals
{
    internal class Swan : Bird
    {
        public Swan(string name, double weight, int age, double wingSpan, string beakColor) : base(name, weight, age, wingSpan)
        {
            BeakColor = beakColor;
        }
        public string BeakColor { get; set; }
        public override string Stats()
        {
            return base.Stats() + $", Beak Color: {BeakColor}";
        }
    }
}
