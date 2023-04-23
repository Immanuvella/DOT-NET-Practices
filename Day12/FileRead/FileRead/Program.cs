using System;
using System.IO;
namespace FileRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"D:\MyFile.txt";
            string data;
            FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fileStream))
            {
                data = streamReader.ReadToEnd();
            }
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}