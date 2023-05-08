using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EMP_DBEntities1 e = new EMP_DBEntities1();
            foreach(var item in e.Managers)
            {
                Console.WriteLine( item.Name);
            }
        }
    }
}
