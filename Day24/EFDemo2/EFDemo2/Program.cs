using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EMP_DBEntities1 e = new EMP_DBEntities1();
            //foreach (var item in e.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}
            ////insert
            //using (var context = new EMP_DBEntities1())
            //{
            //    var emp = new Employee()
            //    {
            //        EmpId = 208,
            //        Name = "Kumar",
            //        Desg = "HR",

            //    };
            //    context.Employees.Add(emp);
            //    context.SaveChanges();


            //}

            ////update

            //using (var context = new EMP_DBEntities1())
            //{
            //    var std = context.Employees.First<Employee>();
            //    std.Name = "Immanuvella";
            //    context.SaveChanges();
            //}
            ////delete
            //using (var context = new EMP_DBEntities1())
            //{
            //    var std = context.Employees.First<Employee>();
            //    context.Employees.Remove(std);

            //    context.SaveChanges();
            //}
            //fetch data


            using (var ctx = new EMP_DBEntities1())
            {
                string name = "Kiran";
                var student = ctx.Employees
                              .Where(s => s.Name == name)
                              .FirstOrDefault<Employee>();
                student.Name = "Immanuvella";
                  ctx.SaveChanges();
            }


        }
    }
}
