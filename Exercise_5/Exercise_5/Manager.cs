using Exercise_5.Vehicles;

namespace Exercise_5
{
    public class Manager
    {
        UI uI;
        GarageHandler garageHandler;
        public Manager()
        {
            uI = new UI();
            garageHandler = new GarageHandler();
        }
        public void Start()
        {
            int userChoice;
            do
            {
                uI.PrintStartMenu();
                userChoice = uI.GetUserChoice();
                UserMenuOption(userChoice);
            } while (userChoice != 0);

        }
        public void UserMenuOption(int userChoice)
        {
            switch (userChoice)
            {
                case 1:
                    int parkingSlots;
                    uI.PrintMessage("How many parking slots should your garage have?");
                    do
                    {
                        parkingSlots = uI.GetUserChoice("Please enter a value bigger then 0");
                        if (parkingSlots <= 0)
                            uI.PrintMessage("Please enter a value bigger then 0");
                    } while (parkingSlots <= 0);
                    garageHandler.Run(parkingSlots);
                    break;
                case 2:
                    VehicleChoice();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                case -1:
                    uI.PrintMessage("Please enter a valid option!");
                    break;
                default:
                    uI.PrintMessage("Please enter a valid option!");
                    break;
            }
        }
        public Vehicle VehicleChoice()
        {
            uI.PrintVehicleMenu();
            int vehicleType = uI.GetUserChoice("Please enter a valid value");
            uI.PrintMessage("RegNumber:");
            string regNumber = uI.GetUserInputString();
            uI.PrintMessage("Color:");
            string color = uI.GetUserInputString();
            uI.PrintMessage("Number of wheels:");
            int numberOfWheels = uI.GetUserChoice("Please enter a value bigger then 0");
            Vehicle vehicle = new Vehicle(regNumber, color, numberOfWheels);
            switch (vehicleType)
            {
                case 1:
                    uI.PrintMessage("Which type of fuel do you use?(Gasoline/Diesel)");
                    string fuelType = uI.GetUserInputString();
                    vehicle = new Car(regNumber, color, numberOfWheels, fuelType);
                    break;
                case 2:
                    uI.PrintMessage("How big cylinder volume do you have?");
                    int cylinderVolume = uI.GetUserChoice();
                    vehicle = new Motorcycle(regNumber, color, numberOfWheels, cylinderVolume);
                    break;
                default:
                    break;
            }
            return vehicle;
        }
    }
}
