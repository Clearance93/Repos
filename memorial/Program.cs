using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num1;

            Console.Write("Enter your number: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your operator: ");
            string opp = Console.ReadLine();

            Console.Write("Enter another number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if(opp == "+")
            {
                Console.WriteLine(num + num1);
            }
            else if(opp == "/")
            {
                Console.WriteLine(num / num1);
            }
            else if(opp == "-")
            {
                Console.WriteLine(num - num1);
            }
            else if(opp == "*")
            {
                Console.WriteLine(num * num1);
            }
            else
            {
                Console.WriteLine("Incorrect syntex");
            }
            Console.ReadKey();
        }
    }
}
