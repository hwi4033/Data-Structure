using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Program
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
            Node currentNode = head.next;
            Node newNode = new Node();

            if (head == null)
            {
                head = newNode;
                newNode.next = head;

                newNode.data = data;
            }
            else
            {
                head.next = newNode;
                newNode.next = currentNode;

                newNode.data = data;
            }
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

        public void Show()
        {
            Node currentNode = head.next;

            do
            {
                Console.WriteLine(currentNode.data);

                currentNode = currentNode.next;
            } while (currentNode != head.next);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CircleLinkedList<int> circleLinkedList = new CircleLinkedList<int>();

            circleLinkedList.PushBack(10);
            circleLinkedList.PushBack(20);
            circleLinkedList.PushBack(30);

            Console.WriteLine("size : " + circleLinkedList.Size);
            circleLinkedList.Show();
        }
    }
}