using System;

namespace LINQDemo

{

    class Program

    {

        static void Main(string[] args)

        {

            string sentence = "Hello Dotnet";

            int wordCount = sentence.GetWordCount();

            Console.WriteLine($"Count : {wordCount}");

            Console.ReadKey();

        }

    }

    public static class ExtensionHelper

    {

        public static int GetWordCount(this string str)

        {

            if (!String.IsNullOrEmpty(str))

                return str.Split(' ').Length;

            return 0;

        }

    }

}





