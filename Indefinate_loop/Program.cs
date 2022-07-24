using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indefinate_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int running_number = 0;
            Console.WriteLine("Enter your number or -1 to quite");
            int number = int.Parse(Console.ReadLine());

            while(number != -1)
            {
                running_number += number;
                Console.WriteLine("Enter your number or -1 to quite");
                number = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("The total running number is {0}", running_number);
            Console.ReadLine();
        }
    }
}
