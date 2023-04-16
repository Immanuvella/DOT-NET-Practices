// See https://aka.ms/new-console-template for more information
int age = 0;
Console.WriteLine("Enter your Age :");
age = int.Parse(Console.ReadLine());
if(age>=18)
{
    Console.WriteLine("Eligible to Vote");
}
else
{
    Console.WriteLine("Not Eligible to vote");
}
    
