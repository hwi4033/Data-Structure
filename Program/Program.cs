namespace Program
{
    public class AdjacencyList<T>
    {
        private class Node
        {
            private T data;
            private Node next;

            public Node(T data, Node link = null)
            {
                this.data = data;
                next = link;
            }
        }

        private int size;       // 정점의 개수
        private int arraySize;

        private T[] vertex;     // 정점의 집합
        private Node[] list;    // 인접 리스트
        
        public AdjacencyList()
        {
            size = 0;
            arraySize = 10;

            vertex = new T[arraySize];
            list = new Node[arraySize];
        }

        public void Insert(T data)
        {
            if (size >= arraySize)
            {
                Console.WriteLine("Adjacency is Full");
                return;
            }

            vertex[size++] = data;
        }

        public void Connect(int i, int j)
        {
            if (size <= 0)
            {
                Console.WriteLine("Adjacency is Empty");
            }

            if (i > size || j > size)
            {
                Console.WriteLine("Out of Range");
            }

            list[i]
        }

        public void Show()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(vertex[i] + " ");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 인접 리스트
            // 그래프의 각 정점에 인접한 정점들을 연결 리스트로 표현하는 방법이다.

            // 장점
            // 그래프의 모든 간선의 수를 O(V + E)로 표현할 수 있다.

            // 단점
            // 두 정점을 연결하는 간선을 조회하거나 정점의 차수를 알기 위해서
            // 정점의 인접 리스트를 모두 탐색해야 하므로, 정점의 차수만큼의 시간이 필요하다.

            AdjacencyList<char> adjacencyList = new AdjacencyList<char>();

            adjacencyList.Insert('A');
            adjacencyList.Insert('B');
            adjacencyList.Insert('C');
            adjacencyList.Insert('D');

            adjacencyList.Show();
            #endregion
        }
    }
}