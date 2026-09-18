using System;
using System.Collections.Generic;
using System.Text;

namespace Project3._1
{
    internal class P1
    {
        static void Main()
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year.");
            }

            Console.WriteLine("=========================");
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment no.: 24SOECE11008");
        }
    }
}
