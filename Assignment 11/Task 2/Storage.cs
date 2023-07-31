using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Storage<T>
    {
        private T[] array;
        private int count;
        private int arrayChunk = 10;

        public Storage()
        {
            array = new T[arrayChunk];
            count = 0;
        }

        public void Add(T item)
        {
            if(count >= array.Length)
                Array.Resize(ref array, count + arrayChunk);
            array[count] = item;
            count++;
        }
        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    count--;
                    break;
                }
            }
        }
        public void Update(T item, T newItem)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    array[i] = newItem;
                    break;
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(array[i] + "");
            }
            Console.WriteLine();
        }
    }
}
