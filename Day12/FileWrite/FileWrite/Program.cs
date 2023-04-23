using System;
using System.IO;
using System.Text;

namespace FileWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the File Path
            string FilePath = @"D:\MyFile.txt";
            FileStream fileStream = new FileStream(FilePath, FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("C# Is an Object Oriented Programming Language");
            fileStream.Write(bdata, 0, bdata.Length);
            fileStream.Close();
            Console.WriteLine("Successfully saved file with data : C# Is an Object Oriented Programming Language");
            Console.ReadKey();
        }
    }
}