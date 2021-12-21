using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class GarageHandler
    {
        private Garage<Vehicle> garage;
        internal void Run(int garageCapacity)
        {
            garage = new Garage<Vehicle>(garageCapacity);
        }
        internal void AddVehicle()
        {
            
        }
    }
}
