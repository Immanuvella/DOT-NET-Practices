using System;
using System.IO;
namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the File Path
            string FilePath = @"D:\MyFile.txt";
            FileStream fileStream = new FileStream(FilePath, FileMode.Create);
            fileStream.Close();
            Console.Write("File has been created and the Path is D:\\MyFile.txt");
            Console.ReadKey();
        }
    }
}