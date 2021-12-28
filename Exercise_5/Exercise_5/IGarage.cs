
namespace Exercise_5
{
    public interface IGarage<T> where T : Vehicle
    {
        bool AddVehicle(T item);
        T[] GetArray();
        IEnumerator<T> GetEnumerator();
        bool IsEmpty();
        bool IsFull();
        void RemoveVehicle(int indexToRemove);
    }
}