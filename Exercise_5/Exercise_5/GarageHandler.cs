using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class GarageHandler
    {
        internal void Run(int garageCapacity)
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(garageCapacity);
        }
        
    }
}
