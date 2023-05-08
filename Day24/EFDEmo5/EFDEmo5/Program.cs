using EFDEmo5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDEmo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Karan" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
