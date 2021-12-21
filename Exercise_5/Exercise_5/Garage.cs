using System.Collections;

namespace Exercise_5
{
    internal class Garage<T> : IEnumerable<T>
    {
        public Garage(int capacity)
        {
            garageInventory = new T[capacity];
        }
        private T[] garageInventory;
        public void AddVehicle(T item)
        {
            garageInventory[0] = item;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in garageInventory)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
