﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Worm : Animal
    {
        public Worm(string name, double weight, int age, double length) : base(name, weight, age)
        {
            Length = length;
        }
        public double Length { get; set; }
        public override void DoSound()
        {
            Console.WriteLine(".............");
        }
        public override string Stats()
        {
            return base.Stats() + $", Length: {Length}cm";
        }
    }
}
