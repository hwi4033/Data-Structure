using System.Data.Common;

namespace Program
{
    public class Vector<T>
    {
        private int size;
        private int capacity;

        private T[] array;
        
        public Vector()
        {
            size = 0;
            capacity = 0;

            array = null;
        }

        public T this [int index]
        {
            get { return array[index]; }
        } 

        public int Count()
        {
            return size;
        }

        public void Reserve(int newSize)
        {
            if (capacity > newSize)
            {
                return;
            }
            else
            {
                Resize(newSize);
            }
        }

        public void Resize(int newSize)
        {
            capacity = newSize;
            T[] newArray = new T[capacity];
                          
            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }

        public void Add(T data)
        {
            if (capacity <= 0)
            {
                Resize(1);
            }
            else if (size >= capacity)
            {
                Resize(capacity * 2);
            }

            array[size++] = data;
        }

        public void RemoveAt(int index)
        {
            if (index > size)
            {
                Console.WriteLine("Error");
            }
            else
            {
                for (int i = index; i < size; i++)
                {
                    if (i == size - 1)
                    {
                        array[i] = default;
                        size--;
                        break;
                    }

                    array[i] = array[i + 1];
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vector<int> vector = new Vector<int>();

            vector.Reserve(4);
            vector.Add(10);
            vector.Add(20);
            vector.Add(30);
            vector.Add(40);
            vector.RemoveAt(3);

            for (int i = 0; i < vector.Count(); i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }
}