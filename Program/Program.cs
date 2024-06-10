using System.Net.Http.Headers;
using System.Xml.Linq;

namespace Program
{
    public class SingleLinkedList<T>
    {
        private class Node
        {
            public T data;
            public Node next;
        }

        private Node head;
        private int size;

        public SingleLinkedList()
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
            if (head == null)
            {
                head = new Node();
                head.data = data;
                head.next = null;
            }
            else
            {
                Node newNode = new Node();
                newNode.data = data;
                newNode.next = head;
                head = newNode;
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
            SingleLinkedList<int> singlelinkedlist = new SingleLinkedList<int>();
            singlelinkedlist.PushFront(30);
            singlelinkedlist.PushFront(20);
            singlelinkedlist.PushFront(10);

            singlelinkedlist.Show();
            Console.WriteLine("size : " + singlelinkedlist.Size);
        }
    }
}