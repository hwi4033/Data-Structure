namespace Class8th__String_
{
    public class String
    {
        private char[] array;

        public String()
        {
            array = null;
        }

        public int Size()
        {
            return array.Length - 1;
        }

        public void Add(char[] content)
        {
            array = new char[content.Length + 1];

            for (int i = 0; i < content.Length; i++)
            {
                array[i] = content[i];
            }
        }

        public void Concat(char[] content)
        {
            char[] newArray = new char[(array.Length - 1) + content.Length + 1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = 0; i < content.Length; i++)
            {
                newArray[(array.Length - 1) + i] = content[i];
            }

            array = newArray;
        }

        public void Show()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine();
        }

        public int IndexOf(char alphabet)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == alphabet)
                {
                    return i;
                }
            }

            return -99999;
        }

        public bool Equals(char[] content)
        {
            if (array == null)
            {
                return false;
            }
            else if (array.Length - 1 != content.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] != content[i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            String name = new String();

            name.Add(new char[] { 'A', 'B', 'C', 'R' });

            name.Show();
            Console.WriteLine(name.IndexOf('R'));
            Console.WriteLine(name.Equals(new char[] { 'A', 'B', 'C', 'R' }));
            Console.WriteLine("Size : " + name.Size());
        }
    }
}