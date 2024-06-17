namespace Class5th__Linear_Queue_
{
    public class LinearQueue<T>
    {
        private int count;
        private int front;
        private int rear;
        private int arraySize;
        private T[] array;
        private T error;

        public LinearQueue()
        {
            count = 0;
            front = 0;
            rear = 0;
            arraySize = 5;
            array = new T[arraySize];
        }

        public int Front
        {
            get { return front; }
        }

        public int Rear
        {
            get { return rear; }
        }

        public int Count()
        {
            return count;
        }

        public void Enqueue(T data)
        {
            if (rear < arraySize)
            {
                count++;
                array[rear++] = data;
            }
            else
            {
                Console.WriteLine("Linear Queue is Full");
            }
        }

        public T Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Linear Queue is Empty");
                return error;
            }
            else
            {
                T data = array[front];

                array[front++] = default;
                count--;

                return data;
            }
        }

        public T Peek()
        {
            if (front == rear)
            {
                Console.WriteLine("Linear Queue is Empty");
                return error;
            }
            else
            {
                return array[front];
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LinearQueue<int> linearQueue = new LinearQueue<int>();

            linearQueue.Enqueue(10);
            linearQueue.Enqueue(20);
            linearQueue.Enqueue(30);
            linearQueue.Enqueue(40);
            linearQueue.Enqueue(99);
            Console.WriteLine("Dequeue : " + linearQueue.Dequeue());
            Console.WriteLine("Dequeue : " + linearQueue.Dequeue());
            Console.WriteLine("Dequeue : " + linearQueue.Dequeue());

            Console.WriteLine("count : " + linearQueue.Count());
            Console.WriteLine("front : " + linearQueue.Front);
            Console.WriteLine("rear : " + linearQueue.Rear);
            Console.WriteLine("Peek : " + linearQueue.Peek());
        }
    }
}