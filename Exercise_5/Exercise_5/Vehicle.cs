namespace Exercise_5
{
    public class Vehicle
    {
        public Vehicle(string regNumber, Color color, int numberOfWheels)
        {
            RegNumber = regNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
        }
        public string RegNumber { get; set; }
        public Color Color { get; set; }
        public int NumberOfWheels { get; set; }

        public override string ToString()
        {
            return $"Vehicle Type: {this.GetType().Name}, License plate: {RegNumber}, Color: {Color}, Number Of Wheels: {NumberOfWheels}";
        }

    }
}
