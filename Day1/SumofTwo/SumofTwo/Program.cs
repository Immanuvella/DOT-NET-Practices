// See https://aka.ms/new-console-template for more information
int a, b;
int sum1=0;

Console.WriteLine("Enter first Number");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number");
b = int.Parse(Console.ReadLine());
sum1 =SumOfTwo(a,b);
Console.WriteLine( "Sum of Two numbers :"+sum1);
static int SumOfTwo(int a,int b)
{
    int sum = 0;
    sum = a + b;
    return sum;
}
//Console.WriteLine("Hello, World!");
