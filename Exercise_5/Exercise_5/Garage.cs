using System.Collections;

namespace Exercise_5
{
    internal class Garage<T> : IEnumerable<T>
    {
        public Garage(int capacity)
        {
            garageInventory = new Vehicle[capacity];
        }
        private Vehicle[] garageInventory;
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
