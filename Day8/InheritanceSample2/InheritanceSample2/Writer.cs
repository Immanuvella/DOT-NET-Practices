using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample2
{
   class Writer : Reader
    {
        public void Writers()
        {
            Console.WriteLine("Name :"+base.name);
            Console.WriteLine("Mark 1 :"+base.m1);
            Console.WriteLine("Mark 2 :"+base.m2);
        }
    }
}
