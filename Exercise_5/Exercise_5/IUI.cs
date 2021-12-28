namespace Exercise_5
{
    public interface IUI
    {
        int GetUserChoice(string message = "Please enter a valid value!");
        string GetUserInputString();
        void PrintMessage(string message);
        void PrintNewGarageMenu();
        void PrintStartMenu();
        void PrintVehicleMenu();
        void PrintVehicleType();
        void Search();
        void ShowColors();
    }
}