using Exercise_5.Vehicles;
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
        internal bool Run(int garageCapacity)
        {
            garage = new Garage<Vehicle>(garageCapacity);
            return true;
        }
        internal bool IsFull()
        {
            return garage.IsFull();
        }
        internal bool ParkVehicle(Vehicle vehicle)
        {
            return garage.AddVehicle(vehicle);
        }
    }
}
