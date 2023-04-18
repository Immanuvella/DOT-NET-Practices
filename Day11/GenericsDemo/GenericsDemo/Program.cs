using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
   public class Program
    {
        static void Main(string[] args)
        {
            bool IsEqual = Calculator.AreEqual<string>("ABC", "ABC");
            if(IsEqual) {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            Console.ReadKey();
        }
    }
    public class Calculator
    {
        //public static bool AreEqual(int value1,int value2)
        //{
        //    return value1 == value2;
        //}
        //public static bool AreEqual(string value1,string value2) {
        //return value1 == value2;    
        //} 
        public static bool AreEqual(double value1,double value2) {
            return value1 == value2;
           
        }
        public static bool AreEqual<T>(T value1,T value2)//Generic method
        {
            return value1.Equals(value2);
        }
    }
}
