﻿using Exercise_5.Vehicles;

namespace Exercise_5
{
    public class Manager
    {
        IUI uI;
        IGarageHandler garageHandler;
        bool garageCreated = false;
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
                    if (garageCreated == true)
                        garageCreated = CreateNewGarage();
                    if (!garageCreated)
                    {
                        Console.Clear();
                        CreateGarge();
                        garageCreated = true;
                    }
                    break;
                case 2:
                    if (garageCreated == false)
                    {
                        uI.PrintMessage("You need to create a garage before you continue!");
                        Exit();
                        break;
                    }
                    garageHandler.GetDummieData();
                    break;
                case 3:
                    Console.Clear();
                    if (garageCreated == false)
                    {
                        uI.PrintMessage("You need to create a garage before you continue!");
                        Exit();
                        break;
                    }
                    ParkVehicle();
                    break;
                case 4:
                    Console.Clear();
                    if (garageCreated == false)
                    {
                        uI.PrintMessage("You need to create a garage before you continue!");
                        Exit();
                        break;
                    }
                    CollectVehicel();
                    break;
                case 5:
                    Console.Clear();
                    if (garageCreated == false)
                    {
                        uI.PrintMessage("You need to create a garage before you continue!");
                        Exit();
                        break;
                    }
                    ShowAllParkedVehicles();
                    break;
                case 6:
                    Console.Clear();
                    if (garageCreated == false)
                    {
                        uI.PrintMessage("You need to create a garage before you continue!");
                        Exit();
                        break;
                    }
                    ShowVehicleByType();
                    break;
                case 7:
                    Console.Clear();
                    if (garageCreated == false)
                    {
                        uI.PrintMessage("You need to create a garage before you continue!");
                        Exit();
                        break;
                    }
                    SearchVehicleByLicensePlate();
                    break;
                case 8:
                    Console.Clear();
                    if (garageCreated == false)
                    {
                        uI.PrintMessage("You need to create a garage before you continue!");
                        Exit();
                        break;
                    }
                    SearchVehicle();
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
        public void CreateGarge()
        {
            int parkingSlots;
            uI.PrintMessage("How many parking slots should your garage have?");
            do
            {
                parkingSlots = uI.GetUserChoice("Please enter a value bigger then 0");
                if (parkingSlots <= 0)
                    uI.PrintMessage("Please enter a value bigger then 0");
            } while (parkingSlots <= 0);
            garageHandler.Run(parkingSlots);
        }
        public bool CreateNewGarage()
        {
            bool newGarage = true;
            uI.PrintNewGarageMenu();
            int userChoice = uI.GetUserChoice("Please enter a value bigger then 0");
            if (userChoice == 1)
                newGarage = false;
            return newGarage;
        }
        public void ParkVehicle()
        {
            if (garageHandler.IsFull())
            {
                uI.PrintMessage("Sorry the garage is full");
                Exit();
                return;
            }
            if (garageHandler.ParkVehicle(VehicleChoice()))
                uI.PrintMessage("Your vehicle is now parked");
            else
                uI.PrintMessage("The garage is full");
        }

        public Vehicle VehicleChoice()
        {
            uI.PrintVehicleMenu();
            int vehicleType = uI.GetUserChoice("Please enter a valid value");
            if (vehicleType == 0)
                return null!;

            uI.PrintMessage("License plate (ABC123):");
            bool regNumcorrect = false;
            string regNumber;
            do
            {
                regNumber = uI.GetUserInputString().ToUpper();
                regNumcorrect = CheckRegNumberWhenParking(regNumber);
            } while (!regNumcorrect);

            uI.PrintMessage("What color do you vehicle have?");
            uI.ShowColors();
            int colorNr = -1;
            do
            {
                colorNr = uI.GetUserChoice();
                if (colorNr >= 14)
                    uI.PrintMessage("Please enter a number from the list!");
            } while (colorNr >= 14);
            Color color = (Color)colorNr - 1;


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
        public bool CheckRegNumberWhenParking(string regNumber)
        {
            bool regNumCorrect = false;
            if (Utility.ChechRegNumber(regNumber))
                regNumCorrect = true;
            else
                uI.PrintMessage("Please enter a correct License plate!");
            if (garageHandler.UniqueRegNumber(regNumber))
                regNumCorrect = true;
            else
            {
                regNumCorrect = false;
                uI.PrintMessage($"A vehicle with that License plate: {regNumber} is already parked, Please enter an other vehicle");
            }
            return regNumCorrect;
        }
        public void CollectVehicel()
        {
            uI.PrintMessage("What license plate do the vehicle that you want to collect have?");
            string regNum = Utility.VerifyStringInput(uI.GetUserInputString().ToUpper());
            do
            {
                if (!Utility.ChechRegNumber(regNum))
                    uI.PrintMessage("Please enter a correct License plate number!");
            } while (!Utility.ChechRegNumber(regNum));
            uI.PrintMessage(garageHandler.RemoveVehicle(regNum));
            Exit();
        }
        public void ShowAllParkedVehicles()
        {
            Vehicle[] vehicles = garageHandler.ShowParkedVehicles();
            uI.PrintMessage("In the garage the following vehicles are parked: ");
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    uI.PrintMessage("Empty");
                    continue;
                }
                uI.PrintMessage($"{i + 1}. {vehicles[i].ToString()}");
            }
            Exit();
        }
        public void ShowVehicleByType()
        {
            Vehicle[] vehicle = garageHandler.ShowParkedVehicles();
            var vehicleByType = vehicle
                .Where(v => v != null)
                .GroupBy(v => v.GetType());
            foreach (var group in vehicleByType)
            {
                uI.PrintMessage($"There are {group.Count()} {group.Key.Name} in the garage");
            }
            Exit();
        }
        public void SearchVehicleByLicensePlate()
        {
            if (garageHandler.IsEmpty())
            {
                uI.PrintMessage("Sorry, there are no vehicles parked in the garage!");
                return;
            }

            Vehicle[] vehicles = garageHandler.ShowParkedVehicles();

            uI.PrintMessage("What license plate do you want to search for?");
            string regNum = Utility.VerifyStringInput(uI.GetUserInputString().ToUpper());
            do
            {
                if (!Utility.ChechRegNumber(regNum))
                    uI.PrintMessage("Please enter a correct License plate number!");
            } while (!Utility.ChechRegNumber(regNum));
            var vehicleByLicensePlate = vehicles
                .Where(v => v != null && v.RegNumber == regNum);
            foreach (var v in vehicleByLicensePlate)
            {
                uI.PrintMessage($"The Vehicle with license plate : {regNum} is {v}");
            }
            Exit();
        }
        public void SearchVehicle()
        {
            SearchParams searchParams = new SearchParams();
            int userChoice = -1;
            do
            {
                uI.Search();
                userChoice = uI.GetUserChoice("Please enter a valid choice!");
                switch (userChoice)
                {
                    case 1:
                        uI.PrintMessage("Which vehicle type do you want to search for?");
                        uI.PrintVehicleType();
                        int vehicleChoice = -1;
                        do
                        {
                            vehicleChoice = uI.GetUserChoice();
                            if (vehicleChoice >= 5)
                                uI.PrintMessage("Please enter a number from the list!");
                        } while (vehicleChoice >= 5);
                        searchParams.VehicleType = (VehicleType)vehicleChoice - 1;
                        break;
                    case 2:
                        uI.PrintMessage("What color do you want to search for?");
                        uI.ShowColors();
                        int colorNr = -1;
                        do
                        {
                            colorNr = uI.GetUserChoice();
                            if (colorNr >= 14)
                                uI.PrintMessage("Please enter a number from the list!");
                        } while (colorNr >= 14);
                        searchParams.Color = (Color)colorNr - 1;
                        break;
                    case 3:
                        uI.PrintMessage("Which amount of wheels do you want to search for?");
                        searchParams.NumberOfWheels = uI.GetUserChoice();
                        break;
                    case 0:
                        break;
                    default:
                        uI.PrintMessage("Please enter a valid option!");
                        break;
                }
            } while (userChoice != 0);

            List<Vehicle> searchResult = garageHandler.Search(searchParams);
            if (searchResult.Count > 0)
            {
                foreach (var item in searchResult)
                {
                    if (item != null)
                        uI.PrintMessage(item.ToString());
                    else
                        continue;
                }
            }
            else
                uI.PrintMessage("There were no vehicle that matches your criteria");
            Exit();
        }
        public void Exit()
        {
            uI.PrintMessage("Press Enter to exit to main menu");
            Console.ReadLine();
        }
    }
}
