using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Practice1List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //for(int j=0;j<5;j++)
            //{
            //    list.Add(j * 3);
            //}
            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}


            //Queue myqueue = new Queue();
            //myqueue.Enqueue("Hello");
            //myqueue.Enqueue("world");
            //Console.WriteLine(myqueue.Count);
            //Console.WriteLine(myqueue.Peek());


            Collection<int> c = new Collection<int>();
            c.Add(1);
            c.Add(2);
            c.Add(1);
            foreach(int i in c)
            {
                    Console.WriteLine(c[i].GetType());
                Console.WriteLine();


                Console.WriteLine(i);
            }
            if(c.Contains(1))
            {
                Console.WriteLine("yes");
                

            }
            
            Console.WriteLine("Count"+c.Count);
           
            int[] str = new int[c.Count];
            c.CopyTo(str, 0);
            foreach(int i in str)
            {
                Console.WriteLine(i);
            }


        }
    }
}
