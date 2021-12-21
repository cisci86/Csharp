using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5.Vehicles
{
    internal class Car : Vehicle
    {
        public Car(string regNumber, string color, int numberOfWheels, string fueltype) : base(regNumber, color, numberOfWheels)
        {
            Fueltype = fueltype;
        }

        public string Fueltype { get; set; }
    }
}
