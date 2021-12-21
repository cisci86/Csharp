namespace Exercise_5
{
    public class Vehicle
    {
        public Vehicle(string regNumber, string color, int numberOfWheels)
        {
            RegNumber = regNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }
        public string RegNumber { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }

    }
}
