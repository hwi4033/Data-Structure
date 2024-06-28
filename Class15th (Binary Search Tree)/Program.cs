namespace Class15th__Binary_Search_Tree_
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

        public void Remove(int data)
        {
            Node currentNode = root;
            Node parentNode = null;

            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
            }
            else
            {
                while (currentNode.data != data)
                {
                    parentNode = currentNode;

                    if (currentNode.data > data)
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }

                    if (currentNode == null)
                    {
                        Console.WriteLine("Data not found is the Binary Search Tree");
                        return;
                    }
                }
            }

            if (currentNode.left == null && currentNode.right == null)
            {
                if (parentNode != null)
                {
                    if (parentNode.left == currentNode)
                    {
                        parentNode.left = null;
                    }
                    else
                    {
                        parentNode.right = null;
                    }
                }
                else
                {
                    root = null;
                }
            }
            else if (currentNode.left == null || currentNode.right == null)
            {
                Node childNode = null;

                if (currentNode.left != null)
                {
                    childNode = currentNode.left;
                }
                else
                {
                    childNode = currentNode.right;
                }

                if (parentNode != null)
                {
                    if (parentNode.left == currentNode)
                    {
                        parentNode.left = childNode;
                    }
                    else
                    {
                        parentNode.right = childNode;
                    }
                }
            }
            else
            {
                if (root.data > data)
                {
                    Node findNode = currentNode.left;
                    Node traceNode = findNode;

                    while (findNode.right != null)
                    {
                        traceNode = findNode;
                        findNode = findNode.right;
                    }

                    currentNode.data = findNode.data;

                    traceNode.right = findNode.left;
                }
                else
                {
                    Node findNode = currentNode.right;
                    Node traceNode = findNode;

                    while (findNode.left != null)
                    {
                        traceNode = findNode;
                        findNode = findNode.left;
                    }

                    currentNode.data = findNode.data;

                    traceNode.left = findNode.right;
                }
            }
        }

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
            binarysearchtree.Insert(5);
            binarysearchtree.Insert(15);
            binarysearchtree.Insert(14);
            binarysearchtree.Insert(22);
            binarysearchtree.Insert(21);

            //Console.WriteLine("Find : " + binarysearchtree.Find(8));
            binarysearchtree.Remove(15);

            binarysearchtree.Inorder(binarysearchtree.root);
        }
    }
}