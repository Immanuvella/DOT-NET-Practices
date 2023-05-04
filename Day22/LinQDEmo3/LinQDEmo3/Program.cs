using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LinQDEmo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dalia", "rosd", "lilly", "daffodil" };

            var fQuery = from flower in flowers
                         let l=flower.Length
                         where l>2 & l<5
                         //where flower.StartsWith("d")||flower.Length>7
                         select flower;
            foreach (string f in fQuery)
            {
                Console.WriteLine(f);
            }
        }
    }
}
