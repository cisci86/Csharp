﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class SearchParams
    {
        public Enum? VehicleType { get; set; } 
        public Color? Color { get; set; }
        public int? NumberOfWheels { get; set; }
    }
    public enum VehicleType
    {
        Car,
        Motorcycle,
        Bus,
        Boat,
        Airplane
    }
}
