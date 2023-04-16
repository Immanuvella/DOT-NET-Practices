using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch=0;
            Employee e = new Employee();
            
            do
            {
               
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Display");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your Choice :");
                ch=int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        int id;
                        string name;
                        string des;                                              
                            Console.WriteLine("Enter Employee Id :");
                            id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Employee Name :");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter Designation");
                            des = Console.ReadLine();
                        e.Employee1(id, name, des);
                        break;

                    case 2:
                        Console.WriteLine("Enter empId :");
                        int empid=int.Parse(Console.ReadLine());
                        
                       
                           e.Search(empid);
                        e.Display();
                       
                        break;
                    case 3:
                        Console.WriteLine("-----Employeee Details-----");
                        e.Display();
                        Console.WriteLine();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
            
                }
            }
            while (ch != 0);
           
        }
       
       
    }
    
}
