using System;

namespace Lab_3_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
          // This program provides the remainder of a division operation
           Console.WriteLine("Welcome");
            Console.WriteLine("This program finds the remainder");
            Console.Write("Enter the Numerator: ");
            int numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter the Denominator: ");
            int denominator = int.Parse(Console.ReadLine());
            int whatIsLeft = numerator % denominator;
            Console.WriteLine($"The remainder is {whatIsLeft}\nThank you!");
        }
    }
}
