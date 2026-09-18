using System;
using System.Collections.Generic;
using System.Text;

namespace Project3._1
{
    internal class P2
    {
        static void Main()
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            int sum = 0;

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            double average = (double)sum / n;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);

            Console.WriteLine("=========================");
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment no.: 24SOECE11008");
        }
    }
}
