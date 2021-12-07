using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public string FName { get; set; }
        public string LName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        //F: Nej jag kommer åt propertyn för variablen men inte variablen direkt.
    }
}
