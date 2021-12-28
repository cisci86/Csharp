using Exercise_5.Vehicles;
using Newtonsoft.Json;

namespace Exercise_5
{
    internal class GarageHandler
    {
        private Garage<Vehicle> garage;
        int garageSize = 0;
        internal bool Run(int garageCapacity)
        {
            garage = new Garage<Vehicle>(garageCapacity);
            garageSize = garageCapacity;
            return true;
        }
        internal bool IsFull()
        {
            return garage.IsFull();
        }
        public bool IsEmpty()
        {
            return garage.IsEmpty();
        }
        //public void Serilize()
        //{
        //    JsonSerializer jsonSerializer = new JsonSerializer();
        //    var jsonSerializerSettings = new JsonSerializerSettings()
        //    {
        //        TypeNameHandling = TypeNameHandling.All
        //    };

        //    StreamWriter sw = new StreamWriter("..\\RecipeBook.txt");
        //    foreach (Vehicle vehicle in garage.GetArray())
        //    {
        //        string serializedRecipe = JsonConvert.SerializeObject(vehicle, jsonSerializerSettings);
        //        sw.WriteLine(serializedRecipe);
        //    }
        //    sw.Close();
        //}
        public void GetDummieData()
        {
            StreamReader sr = new StreamReader("..\\DummieData.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                Vehicle vehicle = JsonConvert.DeserializeObject<Vehicle>(line, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });
                garage.AddVehicle(vehicle);
                line = sr.ReadLine();
            }
            sr.Close();

        }
        internal bool ParkVehicle(Vehicle vehicle)
        {
            return garage.AddVehicle(vehicle);
        }
        public bool UniqueRegNumber(string regNumber)
        {
            Vehicle[] vehicelArray = garage.GetArray();
            bool unique = false;
            for (int i = 0; i < vehicelArray.Length; i++)
            {
                if (vehicelArray[i] == null)
                    unique = true;
                else if (regNumber != vehicelArray[i].RegNumber)
                    unique = true;
                else
                {
                    unique = false;
                    break;
                }

            }
            return unique;
        }
        public Vehicle[] ShowParkedVehicles()
        {
            return garage.GetArray();
        }
        public string RemoveVehicle(string RegNum)
        {
            Vehicle[] vehicles = garage.GetArray();
            string message = "";
            int index = -1;
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                    continue;
                if (vehicles[i].RegNumber == RegNum)
                    index = i;
            }
            if (index != -1)
            {
                garage.RemoveVehicle(index);
                message = $"The vehicle with license plate: {RegNum} has been collected";
            }
            else
                message = $"There are no vehicle with that the license plate : {RegNum}";
            return message;
        }
        public List<Vehicle> Search(SearchParams searchParams)
        {
            Vehicle[] vehicle = garage.GetArray();
            IEnumerable<Vehicle> searchResult = vehicle;
            if (searchParams.VehicleType != null)
            {
                switch (searchParams.VehicleType)
                {
                    case VehicleType.Airplane:
                       searchResult = searchResult.OfType<Airplane>();
                        break;
                    case VehicleType.Boat:
                       searchResult = searchResult.OfType<Boat>();
                        break;
                    case VehicleType.Bus:
                        searchResult = searchResult.OfType<Bus>();
                        break;
                    case VehicleType.Car:
                        searchResult = searchResult.OfType<Car>();
                        break;
                    case VehicleType.Motorcycle:
                        searchResult = searchResult.OfType<Motorcycle>();
                        break;
                    default:
                        break;
                }
            }
            if (searchParams.NumberOfWheels != null)
                searchResult = searchResult.Where(v => v != null && v.NumberOfWheels == searchParams.NumberOfWheels);
            if (searchParams.Color != null)
                searchResult = searchResult.Where(v => v != null && v.Color == searchParams.Color);
            return searchResult.ToList();
        }
    }
}
