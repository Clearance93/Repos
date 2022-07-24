using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num1;
            string opp;

            Console.WriteLine("Please enter your first number!.. ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your operation sign! ");
            opp = Console.ReadLine();

            Console.WriteLine("Please enter your second number!.. ");
            num1 = int.Parse(Console.ReadLine());

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
                Console.WriteLine(num * num);
            }
            else
            {
                Console.WriteLine("Syntax error");
            }
            Console.ReadLine();
        }
    }
}
