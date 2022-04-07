using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    internal class CreatedList<T>
    {
        private T[] array = new T[0];
        private int count;
        private int capacity = 0;
        private int length = 0;


        public void Add(T element)
        {
            if (Resizable())
                if (capacity == 0)
                {
                    capacity += 2;
                }
                else
                {
                    capacity *= 2;
                }
            Array.Resize(ref array, capacity);

            array[length] = element;
            length++;

        }
        public void AddItems(params T[] elements)
        {
            foreach (var item in elements)
            {
                Add(item);
            }
        }
        private bool Resizable()
        {
            if (length == capacity)
                return true;
            return false;
        }
        public void Capacity()
        {
            Console.WriteLine(capacity);
        }
        public void Count()
        {
            count = length;
            Console.WriteLine(count);
        }

        public void Clear()
        {
            array = new T[0];
            length = 0;
            count = 0;
            capacity = 0;
        }

        public bool Exist(T element)
        {
            foreach (T item in array)
            {
                if (element.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }
        public void PrintArray()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        public void Reverse()
        {
            
                for (int i = length-1; i >= 0; i--)
                {
                Console.WriteLine(array[i]);
                }
           
        }
        public void IndexOf(T element)
        {
            for (int i = 0; i < length; i++)
            {
                if (element.Equals(array[i]))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("There is no such kind of element");
        }
        public void LastIndexOf(T element)
        {
            for (int i = length - 1; i >= 0; i--)
            {
                if (element.Equals(array[i]))
                {
                    Console.WriteLine(array[i]);
                    return;
                }
            }
            Console.WriteLine("There is no such kind of element");
        }

        public void Remove()
        {

            capacity -= 1;

        }
    }
}
