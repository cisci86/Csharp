using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5.Vehicles
{
    internal class Bus : Vehicle
    {
        public Bus(string regNumber, Color color, int numberOfWheels, int numberOfSeats) : base(regNumber, color, numberOfWheels)
        {
            NumberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" Number Of Seats: {NumberOfSeats}";
        }
    }
}
