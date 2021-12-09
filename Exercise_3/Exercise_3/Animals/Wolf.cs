using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Wolf : Animal
    {
        public Wolf(string name, double weight, int age) : base(name, weight, age)
        {
        }
        public int PackSize { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Aoooowwwwww");
        }
        public override string Stats()
        {
            return base.Stats() + $", Pack size: {PackSize}";
        }
    }
}
