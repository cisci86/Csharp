using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Employee
        //Class that manages the employee data.
    {
        private string name;
        private int salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
