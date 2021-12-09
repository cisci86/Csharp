using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Horse : Animal
    {
        public Horse(string name, double weight, int age) : base(name, weight, age)
        {
        }
        public double HoofSize { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Eeehhhhiii");
        }
        public override string Stats()
        {
            return base.Stats() + $", Hoff Size: {HoofSize}";
        }
    }
}
