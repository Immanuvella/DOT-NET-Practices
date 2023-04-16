using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample2
{
   class Reader
    {
        public string name;
        public int m1, m2, m3;

        public void Readers(string name,int m1,int m2,int m3)
        {
            this.name = name;
           this.m1 = m1;
            this.m2 = m2;   
            this.m3 = m3;
            Console.WriteLine("Name :"+name+"\n"+"Mark 1 :"+m1+ "   "+"Mark 2 "+m2);
        }
    }
}
