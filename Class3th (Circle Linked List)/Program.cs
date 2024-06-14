namespace Class3th__Circle_Linked_List_
{
    public class CircleLinkedList<T>
    {
        public class Node
        {
            public T data;
            public Node next;
        }

        private int size;
        private Node head;

        public CircleLinkedList()
        {
            size = 0;
            head = null;
        }

        public int Size
        {
            get { return size; }
        }

        public void PushFront(T data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (head == null)
            {
                head = newNode;
                newNode.next = head;
            }
            else
            {
                newNode.next = head.next;
                head.next = newNode;
            }

            size++;
        }

        public void PushBack(T data)
        {
            Node newNode = new Node();
            newNode.data = data;

            if (head == null)
            {
                head = newNode;
                newNode.next = head;
            }
            else
            {
                newNode.next = head.next;
                head.next = newNode;
                head = newNode;
            }

            size++;
        }

        public void RemoveFront()
        {
            if (head == null)
            {
                Console.WriteLine("No Data Exists");
            }
            else
            {
                if (head == head.next)
                {
                    head = null;
                }
                else
                {
                    head.next = head.next.next;
                }

                size--;
            }
        }

        public void RemoveBack()
        {
            if (head == null)
            {
                Console.WriteLine("No Data Exists");
            }
            else
            {
                if (head == head.next)
                {
                    head = null;
                }
                else
                {
                    Node currentNode = head;

                    for (int i = 0; i < size - 1; i++)
                    {
                        currentNode = currentNode.next;
                    }

                    currentNode.next = head.next;
                    head = currentNode;
                }

                size--;
            }
        }

        public void Show()
        {
            if (head != null)
            {
                Node currentNode = head.next;

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(currentNode.data);

                    currentNode = currentNode.next;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CircleLinkedList<int> circleLinkedList = new CircleLinkedList<int>();
            circleLinkedList.PushFront(30);
            circleLinkedList.PushFront(20);
            circleLinkedList.PushFront(10);

            circleLinkedList.RemoveBack();

            Console.WriteLine("size : " + circleLinkedList.Size);
            circleLinkedList.Show();
        }
    }
}