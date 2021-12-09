using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Dog : Animal
    {
        public Dog(string name, double weight, int age, string race) : base(name, weight, age)
        {
            Race = race;
        }
        public string Race { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Woff");
        }
        public override string Stats()
        {
            return base.Stats() + $", Race:{Race}";
        }
        public string ReturnString() => "This is a dog!";
       
    }
}
