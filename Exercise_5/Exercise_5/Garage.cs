﻿using System.Collections;

namespace Exercise_5
{
    public class Garage<T> : IEnumerable<T>, IGarage<T> where T : Vehicle
    {
        public Garage(int capacity)
        {
            garageInventory = new T[capacity];
        }
        private T[] garageInventory;
        public bool AddVehicle(T item)
        {
            bool addedToSlot = false;
            for (int i = 0; i < garageInventory.Length; i++)
            {
                if (garageInventory[i] == null)
                {
                    garageInventory[i] = item;
                    addedToSlot = true;
                    break;
                }
            }
            return addedToSlot;
        }
        public bool IsFull()
        {
            bool isFull = true;
            for (int i = 0; i < garageInventory.Length; i++)
            {
                if (garageInventory[i] == null)
                {
                    isFull = false;
                }
            }
            return isFull;
        }
        public bool IsEmpty()
        {
            bool isEmpty = true;
            for (int i = 0; i < garageInventory.Length; i++)
            {
                if (garageInventory[i] != null)
                    isEmpty = false;
            }
            return isEmpty;
        }
        public T[] GetArray()
        {
            return garageInventory.ToArray();
        }
        public void RemoveVehicle(int indexToRemove)
        {
            garageInventory[indexToRemove] = null!;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in garageInventory)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
