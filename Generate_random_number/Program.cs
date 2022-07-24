using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_random_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            int number;
            int guesstimne = 0;

            do
            {
                Console.WriteLine("Enter your random number:");
                number = int.Parse(Console.ReadLine());
                if(number < randomNumber)
                {
                    Console.WriteLine("Your guess was too low"); ;
                }
                else if(number == randomNumber)
                {
                    Console.WriteLine("You're correct");
                }
                else
                {
                    Console.WriteLine("Your number is too high");
                }
                guesstimne++;

            } while (number != randomNumber);
            Console.WriteLine("You have guess {0} times", guesstimne);
            Console.ReadLine();
        }
    }
}
