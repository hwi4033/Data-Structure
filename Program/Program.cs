namespace Program
{
    public class BinarySearchTree
    {
        public class Node
        {
            public int data;

            public Node left;
            public Node right;
        }

        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        private Node CreateNode(int data)
        {
            Node newNode = new Node();

            newNode.data = data;

            newNode.left = null;
            newNode.right = null;

            return newNode;
        }

        public void Insert(int data)
        {
            if (root == null)
            {
                root = CreateNode(data);
                return;
            }

            Node currentNode = root;

            while (currentNode != null)
            {
                if (currentNode.data > data)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = CreateNode(data);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                else if (currentNode.data < data)
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = CreateNode(data);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
                else
                {
                    return;
                }
            }                        
        }

        //public int Remove(int data)
        //{
        //    if (root == null)
        //    {
        //        Console.WriteLine("Binary Search Tree is Empty");
        //        return -99999;
        //    }
        //
        //    int temp = 
        //
        //    Node currentNode = root;
        //
        //    if (currentNode.data == data)
        //    {
        //
        //    }
        //}

        public bool Find(int data)
        {
            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
                return false;
            }

            Node currentNode = root;

            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    return true;
                }
                else if (currentNode.data > data)
                {
                    currentNode = currentNode.left;
                }
                else
                {
                    currentNode = currentNode.right;
                }
            }

            return false;
        }

        public void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.left);

                Console.Write(root.data + " ");

                Inorder(root.right);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarysearchtree = new BinarySearchTree();

            binarysearchtree.Insert(10);
            binarysearchtree.Insert(15);
            binarysearchtree.Insert(7);
            binarysearchtree.Insert(9);
            binarysearchtree.Insert(13);
            binarysearchtree.Insert(12);
            binarysearchtree.Insert(8);

            Console.WriteLine("Find : " + binarysearchtree.Find(8));

            binarysearchtree.Inorder(binarysearchtree.root);
        }
    }
}