﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3.Animals
{
    internal class Flamingo : Bird
    {
        public Flamingo(string name, double weight, int age, double wingSpan, double amountShrimpEaten) : base(name, weight, age, wingSpan)
        {
            AmountShrimpEaten = amountShrimpEaten;
        }
        public double AmountShrimpEaten { get; set; }
        public override string Stats()
        {
            return base.Stats() + $", Amount Shrimps Eaten: {AmountShrimpEaten}kg";
        }
    }
}
