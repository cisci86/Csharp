//Övning 1 - Cecilia Sjögren
using System;


namespace Exercise1
{
    class Menu
    {
        public void Start()
        {
            EmployeeRecord employeeRecord = new EmployeeRecord();
            int choice = -1;

            while (choice != 0) //As long as the user don't choose to exit the application should run.
            {
                WriteMenuText(); //Shows the menu
                choice = int.Parse(Console.ReadLine()); //Takes the users choice to the switch statement

                switch (choice)
                {
                    case 1: //Whole number for add choice
                        NewEmployee newEmployee = new NewEmployee();
                        newEmployee.Start(employeeRecord);
                        break;
                    case 2:
                        ShowList showList = new ShowList();
                        showList.ShowEmployeeList(employeeRecord);
                        break;
                    case 0:
                        break;

                    default:
                        Console.WriteLine("That is not a valid option, please try again!");
                        break;
                }
            }
        }
        private void WriteMenuText() //Presents the menu choices to the user 
        {
            Console.WriteLine(""); //Emty Line to create space
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("{0, 25}", "MAIN MENU");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Add new employee: {0, 7}", '1');
            Console.WriteLine("Show employee List: {0, 5}", '2');
            Console.WriteLine("Exit: {0, 19}", '0');
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Make your choice: ");
        }
    }
}
