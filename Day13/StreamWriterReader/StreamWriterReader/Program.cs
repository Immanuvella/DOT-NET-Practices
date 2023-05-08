using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterReader
{
    class WriteAndReader
    {
        static string file = @"D:\UST\day13\file.txt";
        static void Main(string[] args)
        {
            Write();
            
        }
        static void Write()
        {
            StreamWriter fileStream = new StreamWriter(file);
            fileStream.WriteLine("What is CallConvThiscall ");
        }
        static void Read()
        {
            StreamReader fileStream=new StreamReader(file);
            string s = null;
            while((s=fileStream.ReadLine()) != null) 
            {

                Console.WriteLine();
            }
        }
    }
}
