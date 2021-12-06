//Övning 1 - Cecilia Sjögren
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class ShowList
    {
        //Function to present the EmployeeList at the console.
        public void ShowEmployeeList(EmployeeRecord record)
        {
            foreach (Employee employee in record.GetList())
            {
                Console.WriteLine($"Employee Name: {employee.Name} Salary: {employee.Salary}");
            }
        }
    }
}
