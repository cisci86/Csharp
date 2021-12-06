using System;
using System.Collections.Generic;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            do
            {
                Console.Clear();// To get a clean console and reduce the "messyness"
                Console.WriteLine(""); //Empty Lines to create space
                Console.WriteLine("");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("{0, 25}", "WELCOME TO THE MAIN MENU");
                Console.WriteLine("{0, 25}", "Enter a number to navigate the menu!");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("");
                Console.WriteLine("Cinema Visit: {0, 15}", '1');
                Console.WriteLine("Repeat ten times: {0, 11}", '2');
                Console.WriteLine("Get the third word: {0, 9}", '3');
                Console.WriteLine("Exit: {0, 23}", '0');
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("Make your choice: ");
                userChoice = GetInputInt();

                switch (userChoice)
                {
                    case 1:
                        CinemaMeny();
                        break;
                    case 2:
                        RepeatTenTimes();
                        break;
                    case 3:
                        TheThirdWord();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("That is not a valid option, please try again!");
                        break;
                }
            } while (userChoice != 0);

        }
        private static void CinemaMeny()
        {
            Console.Clear();
            Console.WriteLine(""); //Empty Lines to create space
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("{0, 25}", "WELCOME TO THE CINEMA");
            Console.WriteLine("{0, 25}", "Enter a number to navigate the menu!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");
            Console.WriteLine("How wold you like to pay?");
            Console.WriteLine("Separately: {0, 17}", '1');
            Console.WriteLine("As a group: {0, 17}", '2');
            Console.WriteLine("Exit: {0, 23}", '0');
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Make your choice: ");

            int userchoice = GetInputInt();
            switch (userchoice)
            {
                case 1:
                    Console.Write("\nPlease enter the age of the visitor: ");
                    VisitorPrice(GetInputInt(), 1);

                    break;
                case 2:
                    CalculationPriceBigParty();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("That is not a valid option, please try again!");
                    break;
            }
        }

        private static int VisitorPrice(int visitorAge, int userchoice = 0)
        {
            int price;

            if (visitorAge < 5)
            {
                if (userchoice == 1)
                    Console.WriteLine("\n\tYou can watch the movie for free!");
                price = 0;
            }
            else if (visitorAge < 20)
            {
                if (userchoice == 1)
                    Console.WriteLine("\n\tYouth price: 80kr");
                price = 80;
            }
            else if (visitorAge > 64 && visitorAge <= 100)
            {
                if (userchoice == 1)
                    Console.WriteLine("\n\tSenior price: 90kr");
                price = 90;
            }
            else if (visitorAge > 100)
            {
                if (userchoice == 1)
                    Console.WriteLine("\n\tYou can watch the movie for free!");
                price = 0;
            }
            else
            {
                if (userchoice == 1)
                    Console.WriteLine("\n\tStandard price: 120kr");
                price = 120;
            }
            if(userchoice == 1)
            {
                //To prevent the main menu to show before the user is ready for it.
                Console.WriteLine("\nPress Enter to exit");
                Console.ReadLine();
            }
            return price;

        }

        private static void CalculationPriceBigParty()
        {
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\t Welcome!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nThis program will calculate the total cost for your movie tickets");

            Console.Write("\nHow many are you? ");
            int partySize = GetInputInt();
            int[] visitorAge = new int[partySize];
            Console.WriteLine("\nPlease enter the age for all the visitors\n");
            for (int i = 0; i < visitorAge.Length; i++)
            {
                Console.Write($"{i + 1} visitors age: ");
                visitorAge[i] = GetInputInt();
            }
            int totalPrice = 0;
            foreach (var age in visitorAge)
            {
                totalPrice += VisitorPrice(age);
            }
            Console.WriteLine($"\nYou are {partySize} visitors");
            Console.WriteLine($"\nThe total price for all the visitors are: {totalPrice}kr");

            Console.WriteLine("\nPress Enter to exit");
            Console.ReadLine();

        }
        private static void RepeatTenTimes()
        {
            Console.Clear();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\tREPEAT TEN TIMES");
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nThis program will repeat your given word ten times on the screen");

            Console.WriteLine("\nPlease enter the word you like to repeat:");
            string theWord = GetStringInput();

            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i}.{theWord}, ");
            }
            Console.WriteLine("\nPress Enter to exit");
            Console.ReadLine();

        }
        private static void TheThirdWord()
        {
            Console.Clear();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\t\tTHE THIRD WORD");
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nThis program helps you get the third word in your sentence");
            bool isThreeWords = false;
            List<string> sentenceSplitList = new List<string>();
            
            do
            {
                Console.WriteLine("Please enter an at least three word long sentence");
                string sentence = GetStringInput();
                string[] sentenceSplit = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (sentenceSplit.Length < 3)
                {
                    isThreeWords = false;
                }
                else
                {
                    isThreeWords = true;
                    for (int i = 0; i < sentenceSplit.Length; i++)
                    {
                        sentenceSplitList.Add(sentenceSplit[i]);
                    }
                }
            } while (!isThreeWords);

            Console.WriteLine($"\nThe third word is: {sentenceSplitList[2]}");

            Console.WriteLine("\nPress Enter to exit");
            Console.ReadLine();

        }
        private static int GetInputInt()
        {
            int intInput;
            bool inputIsInt = false;
            do
            {
                inputIsInt = ValidateInt(Console.ReadLine(), out intInput);
            } while (!inputIsInt);
            return intInput;
        }
        private static bool ValidateInt(string input, out int outPut)
        {
            bool inputIsInt = false;
            inputIsInt = int.TryParse(input, out outPut);
            if (!inputIsInt || string.IsNullOrWhiteSpace(input))
            {
                Console.Write("\nThat is not a number please try again: ");

                return inputIsInt = false;
            }
            else if (outPut < 0)
            {
                Console.WriteLine("\nPlease enter an none negative number! Try again");
                return inputIsInt = false;
            }
            else
                return inputIsInt = true;
        }
        private static string GetStringInput()
        {
            bool isStringNotNullEmptyOrWhiteSpace = false;
            string stringInput;
            do
            {
                isStringNotNullEmptyOrWhiteSpace = ValidateString(Console.ReadLine(), out stringInput);
            } while (!isStringNotNullEmptyOrWhiteSpace);
            return stringInput;
        }
        private static bool ValidateString(string input, out string outPut)
        {
            outPut = input;
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("\nPlease enter a word or a string");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
//Jag tyckte denna övning var bra och rolig att göra.