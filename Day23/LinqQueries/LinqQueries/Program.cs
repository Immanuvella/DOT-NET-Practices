using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinqQueries
{
    public class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
};

            IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
       };


            //Multiple Select and where Operator
            //var studentNames = studentList.Where(s => s.Age > 18)
            //                   .Select(s => s)
            //                   .Where(st => st.StandardID > 0)
            //                   .Select(s => s.StudentName);
            //foreach (var name in studentNames)
            //{
            //    Console.WriteLine(name);
            //}


            //LINQ Query returns Collection of Anonymous Objects
            //var teenStudent= from s in studentList
            //                 where s.Age>12 && s.Age<20
            //                 select new { StudentName = s.StudentName };
            //teenStudent.ToList().ForEach(s => Console.WriteLine(s.StudentName));

            //LINQ GroupBy Query - C#
            //var studentsGroupByStandard = from s in studentList
            //                              group s by s.StandardID into sg
            //                              orderby sg.Key
            //                              select new { sg.Key, sg };


            //foreach (var group in studentsGroupByStandard)
            //{
            //    Console.WriteLine("StandardID {0}:", group.Key);

            //    group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
            //}

            //To remove a student who doesn't have a StandardID, use a where operator before the group operator:
            //var studentGroupbyId = from s in studentList
            //                       where s.StandardID > 0
            //                       group s by s.StandardID into sg
            //                       orderby sg.Key
            //                       orderby sg.Key
            //                       select new { sg.Key, sg };
            //foreach (var group in studentGroupbyId)
            //{
            //    Console.WriteLine("StandardID {0}:", group.Key);

            //    group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName));
            //}

            //Left outer join
            //Use left outer join to display students under each standard. Display the standard name even if there is no student assigned to that standard.

            //var studentsGroup = from stad in standardList
            //                    join s in studentList
            //                    on stad.StandardID equals s.StandardID
            //                        into sg
            //                    select new
            //                    {
            //                        StandardName = stad.StandardName,
            //                        Students = sg
            //                    };

            //foreach (var group in studentsGroup)
            //{
            //    Console.WriteLine(group.StandardName);

            //    group.Students.ToList().ForEach(st => Console.WriteLine(st.StudentName));
            //}
            //In the following example of group by query, we sort the group and select only StudentName:
            //var studentsWithStandard = from stad in standardList
            //                           join s in studentList
            //                           on stad.StandardID equals s.StandardID
            //                           into sg
            //                           from std_grp in sg
            //                           orderby stad.StandardName, std_grp.StudentName
            //                           select new
            //                           {
            //                               StudentName = std_grp.StudentName,
            //                               StandardName = stad.StandardName
            //                           };


            //foreach (var group in studentsWithStandard)
            //{
            //    Console.WriteLine("{0} is in {1}", group.StudentName, group.StandardName);
            //}
    //The following query returns list of students by ascending order of StandardID and Age.
            var sortedStudents = from s in studentList
                                 orderby s.StandardID, s.Age
                                 select new
                                 {
                                     StudentName = s.StudentName,
                                     Age = s.Age,
                                     StandardID = s.StandardID
                                 };

            sortedStudents.ToList().ForEach(s => Console.WriteLine("Student Name: {0}, Age: {1}, StandardID: {2}", s.StudentName, s.Age, s.StandardID));
        }
    }
}
