using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sample program to understand the concept of struct
namespace StructSample
{
    struct Book//created a structure called Book
    {
        public int id;
        public string title;
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[10];
            Console.WriteLine(  "Enter the number of Books :");
            int n=int.Parse(Console.ReadLine());
            for (int i=0;i<n;i++)
            {
                Console.WriteLine(  "Enter Book Id :");
                books[i].id = int.Parse(Console.ReadLine());
                Console.WriteLine(  "Enter Book name :");
                books[i].title = Console.ReadLine();

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine( "Id = {0}, Book Name = {1}", books[i].id, books[i].title);
            }
            Console.ReadKey();
        }
    }
}
