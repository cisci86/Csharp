using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class UI
    {
        public void MenuStart()
        {
            do
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\tWELCOME TO YOUR GARGE");
                Console.WriteLine("Use the menu to navigate");
                Console.WriteLine("* 1: Create a new Garage");
                Console.WriteLine("* 0: Exit the program:");
            } while (userChoice != 0);
        }
    }
}
