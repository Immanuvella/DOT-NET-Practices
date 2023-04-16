using System;
using System.CodeDom;

namespace EmployeeDetails
{
    
    public class Employee
    {
        public int Id;
        public string Name;
        public string Desg;

        public Employee()
        {

        }
        public void Employee1(int id,string name,string desg)
        {
            this.Id = id;
            this.Name = name;
            this.Desg = desg;
        }

        public  void Search(int id)
        {
            if(id==Id)
            {
                Console.WriteLine("Employee Details ......");
                
            }
            else
            {
                Console.WriteLine("Invalid Employee Id");
            }

        }
        public void Display()
        {
            Console.WriteLine("Employee Id :" + Id);
            Console.WriteLine("Employee Name :" +Name);
            Console.WriteLine("Employee Designation :" +Desg);
        }
    }
}