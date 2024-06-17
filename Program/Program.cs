namespace Program
{
    public class CircleQueue<T>
    {
        private int count;
        private int arraySize;
        private T[] array;
        private int front;
        private int rear;
        private T error;

        public CircleQueue()
        {
            count = 0;
            arraySize = 5;
            front = arraySize - 1;
            rear = arraySize - 1;
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
            if ()
            {
                Console.WriteLine("Circle Queue is Full");
            }
            else
            {
                array[rear++] = data;
                if (rear == arraySize) rear = 0;
                count++;
            }
        }

        public T Dequeue()
        {
            if (rear == front)
            {
                Console.WriteLine("Circle Queue is Empty");
                return error;
            }
            else
            {
                T data = array[front];
                array[front++] = default;
                if (front == arraySize) front = 0;
                count--;
                return data;
            }
        }

        public T Peek()
        {
            if (front == rear)
            {
                Console.WriteLine("Circle Queue is Empty");
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
            CircleQueue<int> circlequeue = new CircleQueue<int>();

            circlequeue.Enqueue(10);
            circlequeue.Enqueue(20);
            circlequeue.Enqueue(30);


            Console.WriteLine("front : " + circlequeue.Front);
            Console.WriteLine("rear : " + circlequeue.Rear);
            Console.WriteLine("count : " + circlequeue.Count());
            Console.WriteLine("Peek : " + circlequeue.Peek());
        }
    }
}