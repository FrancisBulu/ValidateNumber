using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number pls...");
            string input = Console.ReadLine();
            IsNumber(input);
            Console.WriteLine("Enter second number pls...");
            string inputSendNumber = Console.ReadLine();
            IsNumber(inputSendNumber);
        }
        static bool IsNumber(string value) // string omdat de console.Readline is altijd string
        {
            int number;
            if (int.TryParse(value, out number))
            {
                Console.WriteLine("Valid number");
                return true;
                
            }
            else
            {
                Console.WriteLine("Not a valid number");
                return false;
            }
        }
    }
}
