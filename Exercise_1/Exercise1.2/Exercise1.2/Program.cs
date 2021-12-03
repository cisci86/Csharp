using System;

namespace Exercise1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteMenuText();
        }
        static private void WriteMenuText() //Presents the menu choices to the user 
        {
            Console.WriteLine(""); //Emty Line to create space
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("{0, 25}", "MAIN MENU");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Add new employee: {0, 7}", '1');
            Console.WriteLine("Show employee List: {0, 5}", '2');
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Make your choice: ");
        }
    }
}
