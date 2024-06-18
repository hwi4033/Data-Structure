namespace Class6th__Circle_Queue_
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
            if (front == (rear + 1) % arraySize)
            {
                Console.WriteLine("Circle Queue is Full");
            }
            else
            {
                rear = (rear + 1) % arraySize;
                array[rear] = data;
                count++;
            }
        }

        public T Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Circle Queue is Empty");
                return error;
            }
            else
            {
                front = (front + 1) % arraySize;
                count--;
                return array[front];
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
                return array[(front + 1) % arraySize];
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
            circlequeue.Enqueue(40);

            while (circlequeue.Count() != 0)
            {
                Console.WriteLine(circlequeue.Dequeue());
            }

            Console.WriteLine("front : " + circlequeue.Front);
            Console.WriteLine("rear : " + circlequeue.Rear);
            Console.WriteLine("count : " + circlequeue.Count());
            Console.WriteLine("Peek : " + circlequeue.Peek());
        }
    }
}