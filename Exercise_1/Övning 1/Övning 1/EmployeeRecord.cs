//Övning 1 - Cecilia Sjögren.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class EmployeeRecord
        //Class to manage the employee recordes.
    {
        private List<Employee> employeeList = new List<Employee>(); //List that holdes the emplyees
        //Adds a new employee to the list.
        public void AddEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }
        //Lets other classes get the list.
        public List<Employee> GetList()
        {
            return employeeList;
        }
    }
}
