using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number:");

            int number = int.Parse(Console.ReadLine());
          
            int original = number;
            int reversed = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }

            if (original == reversed)
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }
            Console.WriteLine($"Reversed number: {reversed}");
            Console.ReadLine();
        }
    }
}
