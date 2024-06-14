namespace Program
{
    public class Stack<T>
    { 
        private int top;
        private T error;
        private T[] array;
        private readonly int arraySize;

        public Stack()
        {
            top = -1;
            arraySize = 10;
            array = new T[arraySize];
        }

        public void Push(T data)
        {
            if (top >= arraySize - 1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                array[++top] = data;
            }
        }

        public T Pop()
        {
            if (top <= -1)
            {
                Console.WriteLine("Stack is Empty");
                return error;
            }
            else
            {
                return array[top--];
            }
        }

        public T Peek()
        {
            if (top <= -1)
            {
                Console.WriteLine("Stack is Empty");
                return error;
            }
            else
            {
                return array[top];
            }
        }

        public bool Constains(T data)
        {
            for (int i = 0; i <= top; i++)
            {
                if (array[i].ToString() == data.ToString())
                {
                    return true;
                }
            }

            return false;
        }
    }

    internal class Program
    {
        static bool CheckBracket(string content)
        {
            if (content.Length <= 0)
            {
                return false;
            }
            int temp = 0;
            Stack<char> stack = new Stack<char>();
            
            for (int i = 0; i <= content.Length / 2; i++)
            {
                stack.Push(content[i]);
            }

            for (int i = 0; i <= content.Length / 2; i++)
            {
                for (int j = content.Length / 2 + 1; j <= content.Length; j++)
                {
                    switch (stack.Peek())
                    {
                        case '{':
                            if (content[j] == '}')
                            {
                                stack.Pop();
                                break;
                            }
                            else temp = 1;
                            break;
                        case '(':
                            if (content[j] == ')')
                            {
                                stack.Pop();
                                break;
                            }
                            else temp = 1;
                            break;
                        case '[':
                            if (content[j] == ']')
                            {
                                stack.Pop();
                                break;
                            }
                            else temp = 1;
                            break;
                    }
                }
            }

            if (temp != 1) return true;
            else return false;
        }

        static void Main(string[] args)
        {
            // Stack<int> stack = new Stack<int>();
            // stack.Push(10);
            // stack.Push(20);
            // stack.Push(30);
            // stack.Push(40);
            // stack.Push(50);
            // stack.Pop();
            // 
            // Console.WriteLine("Stack의 Peek : " + stack.Peek());
            // Console.WriteLine(stack.Constains(99));
            Console.WriteLine(CheckBracket("{{{[(((}))]}}}"));
        }
    }
}