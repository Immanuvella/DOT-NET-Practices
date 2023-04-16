using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    public class Employee
    {
        public int EmpId;
        public string Name;
        public decimal salary;


        public Employee()//unparameterized constructor 
        {

        }
        public Employee(int empId, string name, decimal salary)//parameterized constructor
        {
            EmpId = empId;
            Name = name;
            this.salary = salary;
        }       
    }
}
