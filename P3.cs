using System;
using System.Collections.Generic;
using System.Text;

namespace Project3._1
{
    internal class P3
    {
        static void Main()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.WriteLine("Uppercase: " + sentence.ToUpper());
            Console.WriteLine("Replace Spaces: " + sentence.Replace(" ", "_"));
            Console.WriteLine("Trimmed Sentence: " + sentence.Trim());
            Console.WriteLine("Length: " + sentence.Length);

            Console.WriteLine("=========================");
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment no.: 24SOECE11008");
        }
    }
}
