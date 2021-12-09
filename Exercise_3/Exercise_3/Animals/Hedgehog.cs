using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Hedgehog : Animal
    {
        public Hedgehog(string name, double weight, int age, string favoritFood) : base(name, weight, age)
        {
            FavoritFoods = favoritFood;
        }
        public string FavoritFoods { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("shheeeww");
        }
        public override string Stats()
        {
            return base.Stats() + $", Favorite Food: {FavoritFoods}";
        }
    }
}
