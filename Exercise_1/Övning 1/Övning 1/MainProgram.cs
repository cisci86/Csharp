//Övning 1 Cecilia Sjögren.
using System;

namespace Exercise1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Start();//Starts the menu
            Console.WriteLine("Press Enter to Exit the program");
            Console.ReadLine();            
        }
    }
}
