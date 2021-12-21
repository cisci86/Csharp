using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
