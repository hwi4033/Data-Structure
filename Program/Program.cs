using System.Net.Http.Headers;
using System.Xml.Linq;

namespace Program
{
    public class DoubleLinkedList<T>
    {
        public class Node
        {
            public T data;
            public Node previous;
            public Node next;
        }

        private int size;
        private Node head;
        private Node tail;

        public DoubleLinkedList()
        {
            size = 0;
            head = null;
            tail = null;
        }

        public int Size
        {
            get { return size; }
        }

        public void PushBack(T data)
        {
            Node newNode = new Node();

            if (tail == null)
            {                
                head = newNode;
                tail = newNode;

                newNode.data = data;
                newNode.next = null;
                newNode.previous = head;
            }
            else
            {
                tail.next = newNode;
                newNode.previous = tail;

                tail = newNode;

                newNode.data = data;
                newNode.next = null;
            }

            size++;
        }

        public void Show()
        {
            Node currentNode = head;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.data);

                currentNode = currentNode.next;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            doubleLinkedList.PushBack(10);
            doubleLinkedList.PushBack(20);
            doubleLinkedList.PushBack(30);

            Console.WriteLine("size : " + doubleLinkedList.Size);
            doubleLinkedList.Show();
        }
    }
}