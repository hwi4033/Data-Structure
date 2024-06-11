namespace Class1th__Single_Linked_List_
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

        public void PushBack(T data)
        {
            if (head == null)
            {
                head = new Node();
                head.data = data;
                head.next = null;
            }
            else
            {
                Node currentNode = head;

                if (currentNode.next == null)
                {
                    Node newNode = new Node();

                    newNode.data = data;
                    currentNode.next = newNode;
                }
                else
                {
                    while (currentNode.next != null)
                    {
                        currentNode = currentNode.next;
                    }

                    Node newNode = new Node();
                    newNode.data = data;
                    currentNode.next = newNode;
                }
            }

            size++;
        }

        public void Show()
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);

                currentNode = currentNode.next;
            }
        }

        public void RemoveFront()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                head = head.next;

                size--;
            }
        }

        public void RemoveBack()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                if (size == 1)
                {
                    head = null;
                }
                else
                {
                    Node currentNode = head;
                    Node previousNode = currentNode;

                    while (currentNode.next != null)
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.next;
                    }

                    previousNode.next = currentNode.next;
                }

                size--;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // SingleLinkedList<int> singlelinkedlist = new SingleLinkedList<int>();
            // singlelinkedlist.PushFront(10);
            // singlelinkedlist.PushBack(20);
            // singlelinkedlist.RemoveBack();
            // 
            // Console.WriteLine("size : " + singlelinkedlist.Size);
            // singlelinkedlist.Show();
        }
    }
}