using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string regNumber, Enum color, int numberOfWheels, int cylinderVolume) : base(regNumber, color, numberOfWheels)
        {
            CylinderVolume = cylinderVolume;
        }

        public int CylinderVolume { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" Cylinder Volume: {CylinderVolume}";
        }
    }
}
