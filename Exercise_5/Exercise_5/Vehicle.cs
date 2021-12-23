namespace Exercise_5
{
    public class Vehicle
    {
        public Vehicle(string regNumber, Enum color, int numberOfWheels)
        {
            RegNumber = regNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }
        public string RegNumber { get; set; }
        public Enum Color { get; set; }
        public int NumberOfWheels { get; set; }

        public override string ToString()
        {
            return $"Vehicle Type: {this.GetType().Name}, License plate: {RegNumber}, Color: {Color}, Number Of Wheels: {NumberOfWheels}";
        }

    }
}
