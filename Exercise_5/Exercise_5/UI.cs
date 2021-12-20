using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    public class UI
    {
        public int Menustart()
        {
            int userChoice;
            do
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\tWELCOME TO YOUR GARGE");
                Console.WriteLine("Use the menu to navigate");
                Console.WriteLine("* 1: Create a new Garage");
                Console.WriteLine("* 0: Exit the program\n");
                Console.WriteLine("Enter your choice:");
                userChoice = Utility.VerifyIntInput(Console.ReadLine()!);
            } while (userChoice != 0);

            switch (userChoice)
            {
                case 1:
                    GarageHandler garageHandler = new GarageHandler();
                    int parkinSlots;
                    do
                    {
                        Console.WriteLine("How many parking slots should the garage have?");
                        parkinSlots = Utility.VerifyIntInput(Console.ReadLine()!);
                        if (parkinSlots < 0)
                            Console.WriteLine("Please enter a value bigger than 0");
                    } while (parkinSlots < 0);
                    garageHandler.Run(parkinSlots);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                case -1:
                    Console.WriteLine("Please enter a valid option!");
                    break;
                default:
                    Console.WriteLine("Please enter a valid option!");
                    break;
            }
        }
    }
}
