namespace Class9th__File_Input___Output_
{
    internal class Program
    {
        static void LoadText(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);

            while (streamReader.Peek() >= 0)
            {
                Console.WriteLine(streamReader.ReadLine());
            }

            streamReader.Close();
        }

        static void Main(string[] args)
        {
            // File : 파일에 대한 생성, 복사, 이동 및 열기를 위한 클래스
            // FileInfo : 파일에 대한 생성, 복사, 이동 및 열기에 대한 속성
            // FileStream : 파일에 대한 스트림을 제공하여 동기 및 비동기 읽기/쓰기를 지원

            // FileStream fileStream = File.Create("data.txt");

            // fileStream.Close();

            // StreamReader : 문자열에서 읽어오는 TextReader 구현합니다.
            // StreamWriter : TextWriter를 구현하여 특정 인코딩을 스트림에 문자로 저장합니다.

            // StreamWriter streamWriter = new StreamWriter("data.txt");

            // streamWriter.WriteLine("HP 100");
            // streamWriter.WriteLine("Level 10");
            // streamWriter.WriteLine("Name Warrior");

            // streamWriter.Close();

            // StreamReader streamReader = new StreamReader("aaa.txt");
            // 
            // while (streamReader.Peek() >= 0)
            // {
            //     Console.WriteLine(streamReader.ReadLine());
            // }
            // 
            // streamReader.Close();

            LoadText("a.txt");
        }
    }
}