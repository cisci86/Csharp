using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5.Vehicles
{
    internal class Airplane : Vehicle
    {
        public Airplane(string regNumber, Color color, int numberOfWheels, int numberOfEngines) : base(regNumber, color, numberOfWheels)
        {
            NumberOfEngines = numberOfEngines;
        }

        public int NumberOfEngines { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" Number Of Engines: {NumberOfEngines}";
        }
    }
}
