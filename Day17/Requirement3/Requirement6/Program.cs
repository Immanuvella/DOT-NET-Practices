using Requirement3;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Requirement6
{
    public class Program
    {
        static void Main(string[] args)
        {

            List <Songs> songs=new List<Songs> ();
            int n;
            Console.WriteLine("Enter number of songs :");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Details :");
            for (int i=0;i<n;i++)
            {
                string[] str = Console.ReadLine().Split(',');
                Songs song = new Songs(str[0], str[1], str[2], double.Parse(str[3]), int.Parse(str[4]), DateTime.Parse(str[5]));
                songs.Add(song);
            }         
            Dictionary<string, int> typeCount = Songs.CalculateTypeCount(songs);
           
            Console.WriteLine("Song Type", "\tCount");
            //foreach (KeyValuePair<string, int> pair in typeCount.OrderBy(x => x.Key))
            //{
                
            //        Console.WriteLine(pair.Key, pair.Value);
               
            //}
            
            string StateofMind = Songs.PredictState(typeCount);
            Console.WriteLine("The user is feeling "+StateofMind);

        }

        }
}

