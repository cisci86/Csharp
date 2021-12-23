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
        public bool IsEmpty()
        {
            return garage.IsEmpty();
        }
        internal bool ParkVehicle(Vehicle vehicle)
        {
            return garage.AddVehicle(vehicle);
        }
        public bool UniqueRegNumber(string regNumber)
        {
            Vehicle[] vehicelArray = garage.GetArray();
            bool unique = false;
            for (int i = 0; i < vehicelArray.Length; i++)
            {
                if(vehicelArray[i] == null)
                    unique = true;
                else if (regNumber != vehicelArray[i].RegNumber)
                    unique = true;
                else
                {
                    unique = false;
                    break;
                }
                    
            }
            return unique;
        }
        public Vehicle[] ShowParkedVehicles()
        {
            return garage.GetArray();
        }
        public string RemoveVehicle(string RegNum)
        {
            Vehicle[] vehicles = garage.GetArray();
            string message ="";
            int index = -1;
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                    continue;
                if(vehicles[i].RegNumber == RegNum)
                    index = i;
            }
            if (index != -1)
            {
                garage.RemoveVehicle(index);
                message = $"The vehicle with license plate: {RegNum} has been collected";
            }
            else
                message = $"There are no vehicle with that the license plate : {RegNum}";
            return message;
        }
    }
}
