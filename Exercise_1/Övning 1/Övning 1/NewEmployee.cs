using System;

namespace Exercise1
{
    class NewEmployee
    {
        Employee employee;
        public void Start(EmployeeRecord record)
        {
            GetNameInput();
            GetSalaryInput();
            record.AddEmployee(employee);
        }
        private void GetNameInput()
        {
            employee = new Employee();
            Console.WriteLine("Add a new employee to the record:");
            Console.Write("Employee Name: ");
            employee.Name = Console.ReadLine();
        }
        private void GetSalaryInput()
        {
            Console.Write("Employee Salary: ");
            int salaryInput;
            bool salaryInputIsInt = int.TryParse(Console.ReadLine(), out salaryInput);
            if (salaryInputIsInt)
            {
                employee.Salary = salaryInput;

            }
            else
            {
                Console.WriteLine("Please enter an Whole number!");
                GetSalaryInput();
            }
        }

    }
}
