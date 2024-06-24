namespace Program
{
    public class Node
    {
        public int data;

        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }

    internal class Program
    {
        static Node CreateNode(int data, Node left, Node rigth)
        {
            Node newNode = new Node(data);
            newNode.left = left;
            newNode.right = rigth;

            return newNode;
        }

        static void Preorder(Node root)
        {
            // 전위 순회
            // 1. root Node를 방문한다.
            // 2. 왼쪽 자식 노드를 전위 순회한다.
            // 3. 오른쪽 자식 노드를 전위 순회한다.

            if (root != null)
            {
                Console.Write(root.data + " ");

                Preorder(root.left);

                Preorder(root.right);               
            }
        }

        static void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.left);

                Console.Write(root.data + " ");

                Inorder(root.right);
            }
        }

        static void Main(string[] args)
        {
            Node node7 = new Node(7);
            Node node6 = new Node(6);
            Node node5 = new Node(5);
            Node node4 = new Node(4);

            Node node3 = CreateNode(3, node6, node7);
            Node node2 = CreateNode(2, node4, node5);

            Node node1 = CreateNode(1, node2, node3);

            Preorder(node1);
            Inorder(node1);
        }
    }
}