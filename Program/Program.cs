namespace Program
{
    public class Heap
    {
        private int size;
        private int arraySize;
        private int [] array;
        
        public Heap()
        {
            size = 0;
            arraySize = 8;

            array = new int[arraySize];
        }

        private void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public void Insert(int data)
        {
            if (size >= arraySize - 1)
            {
                Console.WriteLine("Heap is Full");
            }
            else
            {
                array[++size] = data;

                int child = size;
                int parent = size / 2;

                while (child > 1)
                {
                    if (array[child] > array[parent])
                    {
                        Swap(ref array[child], ref array[parent]);
                    }

                    child = parent;
                    parent = child / 2;
                }
            }
        }

        public int Remove()
        {
            if (size <= 0)
            {
                Console.WriteLine("Heap is Empty");
                return -99999;
            }

            int temp = array[1];
            array[1] = array[size];
            array[size--] = 0;
            
            if (size == 1)
            {
                return temp;
            }
            
            int parent = 1;
            
            if (array[parent] < array[parent * 2])
            {
                if (array[parent] < array[parent * 2 + 1])
                {

                }
                else
                {
                    
                }
            }
            while (parent >= size - 1)
            {
                if (array[parent * 2] > array[parent * 2 + 1])
                {
                    Swap(ref array[parent], ref array[parent * 2]);

                    parent = parent * 2;
                }
                else
                {
                    Swap(ref array[parent], ref array[parent * 2 + 1]);

                    parent = parent * 2 + 1;
                }
            }

            return temp;
        }

        public void Show()
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine("[" + i + "] : " + array[i]);
            }

            Console.WriteLine("size : " + size);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new Heap();

            heap.Insert(1);
            heap.Insert(3);
            heap.Insert(5);
            heap.Insert(7);
            heap.Insert(10);
            heap.Insert(8);
            heap.Insert(9);
            //Console.WriteLine(heap.Remove());

            heap.Show();
        }
    }
}