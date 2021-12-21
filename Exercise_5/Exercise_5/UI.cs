using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    public class UI
    {
        public void PrintStartMenu()
        {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\tWELCOME TO YOUR GARGE");
                Console.WriteLine("Use the menu to navigate");
                Console.WriteLine("* 1: Create a new Garage");
                Console.WriteLine("* 0: Exit the program\n");
                Console.WriteLine("Enter your choice:");
        }
        public int GetUserChoice(string message = "Please enter a valid value!")
        {
            int userChoice;
            do
            {
                userChoice = Utility.VerifyIntInput(Console.ReadLine()!);
                if(userChoice < 0)
                    Console.WriteLine(message);

            } while (userChoice < 0);
            return userChoice;
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
