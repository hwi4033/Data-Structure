using System.Data.Common;
using System.Linq.Expressions;
using System.Xml.Schema;

namespace Program
{
    public class HashTable<KEY, VALUE> 
    {
        public class Node
        {
            public KEY key;
            public VALUE value;

            public Node next;
        }

        public class Bucket
        {
            public int count;

            public Node head;
        }

        private Bucket[] bucket;
        private readonly int arraySize;

        public HashTable()
        {
            arraySize = 6;
            
            bucket = new Bucket[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                bucket[i] = new Bucket();
            }
        }

        private int HashFunction(KEY key)
        {
            return int.Parse(key.ToString()) % arraySize;
        }

        private Node CreateNode(KEY key, VALUE value)
        {
            Node newNode = new Node();

            newNode.key = key;
            newNode.value = value;

            newNode.next = null;

            return newNode;
        }

        public void Insert(KEY key, VALUE value)
        {
            // PushFront와 같은 기능을 수행한다.

            // 해쉬 함수를 통해서 값을 받는 임시 변수
            int hashIndex = HashFunction(key);

            // 새로운 노드를 생성한다.
            Node newNode = CreateNode(key, value);

            // 노드가 1개라도 존재하지 않는다면
            if (bucket[hashIndex].count <= 0)
            {
                // 1. bucket[hashIndex]의 head 포인터에 새로운 노드를 저장한다.
                bucket[hashIndex].head = newNode;
            }
            // 노드가 1개라도 존재한다면
            else
            {
                // 1. newNode의 next에 bucket[hashIndex]의 head값을 저장한다.
                newNode.next = bucket[hashIndex].head;
                
                // 2. bucket[hashIndex].head를 방금 생성한 노드의 주소를 가리키게 한다.
                bucket[hashIndex].head = newNode;
            }
            
            // bucket[hashIndex]의 count 변수의 값을 증가시킨다.
            bucket[hashIndex].count++;
        }

        public void Show()
        {
            for (int i = 0; i < arraySize; i++)
            {
                Node currentNode = bucket[i].head;

                while(currentNode != null)
                {
                    Console.WriteLine("[" + i + "] " + "KEY : " + currentNode.key + " VALUE : " + currentNode.value);
                    
                    currentNode = currentNode.next;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable<int, string> hashtable = new HashTable<int, string>();

            hashtable.Insert(0, "value1");
            hashtable.Insert(1, "value2");
            hashtable.Insert(2, "value3"); 
            hashtable.Insert(3, "value4");
            hashtable.Insert(4, "value5");
            hashtable.Insert(5, "value6");
            hashtable.Insert(6, "value1-1");
            hashtable.Insert(7, "value2-1");
            hashtable.Insert(8, "value3-1");
            hashtable.Insert(9, "value4-1");
            hashtable.Insert(10, "value5-1");

            hashtable.Show();
        }
    }
}