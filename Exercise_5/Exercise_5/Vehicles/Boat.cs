using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5.Vehicles
{
    internal class Boat : Vehicle
    {
        public Boat(string regNumber, string color, int numberOfWheels, int lenght) : base(regNumber, color, numberOfWheels)
        {
            Lenght = lenght;
        }

        public int Lenght { get; set; }
    }
}
