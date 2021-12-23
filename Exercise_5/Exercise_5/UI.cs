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
            Console.WriteLine("* 2: Park a new vehicle");
            Console.WriteLine("* 3: Collect a parked vehicle");
            Console.WriteLine("* 4: Show all parked vehicles");
            Console.WriteLine("* 5: Show how many of each type of vehicle is parked in the garage");
            Console.WriteLine("* 6: Search for vehicle by license plate");
            Console.WriteLine("* 0: Exit the program\n");
            Console.WriteLine("Enter your choice:");
        }
        public int GetUserChoice(string message = "Please enter a valid value!")
        {
            int userChoice;
            do
            {
                userChoice = Utility.VerifyIntInput(Console.ReadLine()!);
                if (userChoice < 0)
                    Console.WriteLine(message);

            } while (userChoice < 0);
            return userChoice;
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintVehicleMenu()
        {
            Console.WriteLine("Please add the following information about your vehicle:");
            Console.WriteLine("Which vehicle type do you have?");
            Console.WriteLine("* 1: Car");
            Console.WriteLine("* 2: Motorcycle");
            Console.WriteLine("* 3: Bus");
            Console.WriteLine("* 4: Boat");
            Console.WriteLine("* 5: Airplane");
            Console.WriteLine("* 0: Exit");
        }
        public string GetUserInputString()
        {
            string userInputString;
            do
            {
                userInputString = Utility.VerifyStringInput(Console.ReadLine());
                if (userInputString == null)
                    Console.WriteLine("Please enter a valid input!");
            } while (userInputString == null);
            return userInputString;
        }
        public void ShowColors()
        {
            int number = 1;
            foreach (var c in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine($"* {number}: {c}");
                number++;
            }
        }
    }
}
