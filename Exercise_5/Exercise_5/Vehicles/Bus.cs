using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5.Vehicles
{
    internal class Bus : Vehicle
    {
        public Bus(string regNumber, string color, int numberOfWheels, int numberOfSeats) : base(regNumber, color, numberOfWheels)
        {
            NumberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats { get; set; }
    }
}
