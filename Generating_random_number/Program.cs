using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generating_random_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);

            Console.WriteLine("Enter the next number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(randomNumber);

            if(number == randomNumber)
            {
                Console.WriteLine("You are correct! Congratulation");
            }
            else if(number < randomNumber)
            {
                Console.WriteLine("You number is too low from the number displayed! sad");
            }
            else
            {
                Console.WriteLine("Your number is too high! try to lower numbers");
            }

            Console.ReadLine();
        }
    }
}
