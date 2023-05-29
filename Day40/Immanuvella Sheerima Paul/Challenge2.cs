using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
       
        int n = Convert.ToInt32(Console.ReadLine());

        string[] strings = new string[n];

        for (int i = 0; i < n; i++)
        {
           
            strings[i] = Console.ReadLine();
        }

        

        foreach (string str in strings)
        {
            string result = RemoveDuplicateWords(str);
            Console.WriteLine(result);
        }
    }

    static string RemoveDuplicateWords(string sentence)
    { 
        string pattern = @"\b(\w+)\b\s+(?=.*\b\1\b)";
        string rep = "";
        Regex regex = new Regex(pattern);
        string result = regex.Replace(sentence, rep);
        return result;
    }
}
