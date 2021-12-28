
namespace Exercise_5
{
    internal interface IGarageHandler
    {
        void GetDummieData();
        bool IsEmpty();
        bool IsFull();
        bool ParkVehicle(Vehicle vehicle);
        string RemoveVehicle(string RegNum);
        bool Run(int garageCapacity);
        List<Vehicle> Search(SearchParams searchParams);
        Vehicle[] ShowParkedVehicles();
        bool UniqueRegNumber(string regNumber);
    }
}