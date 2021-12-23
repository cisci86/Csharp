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
                    if (garageHandler.IsFull())
                    {
                        uI.PrintMessage("Sorry the garage is full");
                        break;
                    }
                    if (garageHandler.ParkVehicle(VehicleChoice()))
                        uI.PrintMessage("Your vehicle is now parked");
                    else
                        uI.PrintMessage("The garage is full");
                    break;
                case 3:
                    ShowAllParkedVehicles();
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
            if (vehicleType == 0)
                return null!;

            uI.PrintMessage("RegNumber (ABC123):");
            bool regNumcorrect = false;
            string regNumber;
            do
            {
                regNumber = uI.GetUserInputString().ToUpper();
                regNumcorrect = CheckRegNumber(regNumber);
            } while (!regNumcorrect);

            uI.PrintMessage("Color:");
            string color = uI.GetUserInputString();

            uI.PrintMessage("Number of wheels:");
            int numberOfWheels = uI.GetUserChoice("Please enter a number bigger then 0");

            Vehicle vehicle = new(regNumber, color, numberOfWheels);

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
                case 3:
                    uI.PrintMessage("How many seats does the bus have?");
                    int numerOfSeats = uI.GetUserChoice();
                    vehicle = new Bus(regNumber, color, numberOfWheels, numerOfSeats);
                    break;
                case 4:
                    uI.PrintMessage("How long is your boat?");
                    int lenght = uI.GetUserChoice();
                    vehicle = new Boat(regNumber, color, numberOfWheels, lenght);
                    break;
                case 5:
                    uI.PrintMessage("How many engines does you plane have?");
                    int numberOfEngins = uI.GetUserChoice();
                    vehicle = new Airplane(regNumber, color, numberOfWheels, numberOfEngins);
                    break;
                default:
                    break;
            }
            return vehicle;
        }
        public bool CheckRegNumber(string regNumber)
        {
            bool regNumCorrect = false;
            if (Utility.ChechRegNumber(regNumber))
                regNumCorrect = true;
            else
                uI.PrintMessage("Please enter a correct Registration Number!");
            if (garageHandler.UniqueRegNumber(regNumber))
                regNumCorrect = true;
            else
            {
                regNumCorrect = false;
                uI.PrintMessage("A vehicle with that RegNumber is already parked, Please enter an other RegNumber");
            }
            return regNumCorrect;
        }
        public void ShowAllParkedVehicles()
        {
           Vehicle[] vehicles = garageHandler.ShowParkedVehicles();
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    uI.PrintMessage("Empty");
                    continue;
                }
                uI.PrintMessage($"{i}. {vehicles[i].ToString()}");
            }
        }
    }
}
