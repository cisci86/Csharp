﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5.Vehicles
{
    internal class Airplane : Vehicle
    {
        public Airplane(string regNumber, string color, int numberOfWheels, int numberOfEngines) : base(regNumber, color, numberOfWheels)
        {
            NumberOfEngines = numberOfEngines;
        }

        public int NumberOfEngines { get; set; }
    }
}
