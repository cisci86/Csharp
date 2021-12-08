using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Person
    {
        public Person(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }
        private int age;
        private string fName;
        private string lName;

        public int Age
        {
            get { return age; }
            set { age = Math.Max(0, value); }
        }

        public string FName {
            get { return fName; } 
            set 
            {

                if (value.Length !<= 2 && value.Length !>= 10)
                    throw new ArgumentException($"The first name needs to be between 2 and 10 caracters long");
                else
                    fName = value;
            }
        }
        public string LName {
            get { return lName; }
            set 
            {
                if (lName.Length !<= 3 && lName.Length !>= 15)
                    throw new ArgumentException($"The first name needs to be between 3 and 15 characters long");
                else
                    lName = value;
            }
        }
        public double Height { get; set; }
        public double Weight { get; set; }

    }
}
