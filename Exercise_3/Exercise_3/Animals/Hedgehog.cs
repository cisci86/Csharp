using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Hedgehog : Animal
    {
        public Hedgehog(string name, double weight, int age) : base(name, weight, age)
        {
        }
        public string FavouritFoods { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("shheeeww");
        }
    }
}
