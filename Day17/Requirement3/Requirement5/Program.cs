using Requirement3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Songs s = new Songs();
            List<Songs> songs = SongRepo.GetSongs();
            SortedDictionary<string, int> typeCount = Songs.CalculateTypeCount(songs);
           
            Console.WriteLine();
        }

        }
    }

