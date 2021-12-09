using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Bird : Animal
    {
        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }
        public double WingSpan { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("pipip"); ;
        }
        public override string Stats()
        {
            return base.Stats() + $", WingSpan: {WingSpan}m";
        }

    }
}
