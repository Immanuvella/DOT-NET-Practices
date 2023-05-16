using System;
public class Exercise16
{
    public static void Main()
    {
        int n, i, j = 0;
        int[] arr1 = new int[50];

        Console.Write("\n\nFind the second largest element in an array :\n");
        Console.Write("-----------------------------------------\n");

        Console.Write("Input the size of array : ");
        n = Convert.ToInt32(Console.ReadLine());
        /* Stored values into the array*/
        Console.Write("Input {0} elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        /* find location of the largest element in the array */
        Array.Sort(arr1);
        int count = 0;
        int total = n * (n + 1 )/ 2;
        int sum = 0;
        for (i = 0; i < n; i++)
        {
            sum += arr1[i];
        }
        int miss = total - sum;

        for (i=0;i<n;i++)
        {
            if (arr1[j] == arr1[i+1])
            {
                count++;
                Console.WriteLine(arr1[j]); 
            }
        }
        
        
       


        Console.WriteLine("repeating element in array is" + arr1[j]);
        Console.Write("The smallest missing element in the array is :  {0} \n\n", miss);
    }
}
