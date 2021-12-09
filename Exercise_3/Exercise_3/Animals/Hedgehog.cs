using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Hedgehog : Animal
    {
        public Hedgehog(string name, double weight, int age, string favouritFood) : base(name, weight, age)
        {
            FavouritFoods = favouritFood;
        }
        public string FavouritFoods { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("shheeeww");
        }
        public override string Stats()
        {
            return base.Stats() + $", Favourite Food: {FavouritFoods}";
        }
    }
}
