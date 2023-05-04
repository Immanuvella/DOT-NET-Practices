using System;

public class Program
{


    public static void Main()
    {
        Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;

        Student stud = new Student() { Age = 21 };

        Console.WriteLine(isStudentTeenAger(stud));


    }
}

public class Student
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}