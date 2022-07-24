using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_deleivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] code = { 1200, 1640, 1632, 1459, 4588, 4152, 1414, 7544, 7845, 1322 };
            string[] company = { "Mambisa", "PMG", "Dawn Park", "Volso", "Brynsten", "Boksburg", "Dynamic", "PBSA", "BPSA", "Multimedia" };
            Console.WriteLine("Enter the code of the delivery");
            int delivery = int.Parse(Console.ReadLine());
            bool answer = false;
            string comp = "";

            for (int i = 0; i < code.Length; i++)
            {
                if (delivery == code[i])
                {
                    answer = true;
                    comp = company[i];
                    break;
                }

            }

            if (answer == true)
            {
                Console.WriteLine("You code delivery is to this {0}", comp);
            }
            else
            {
                Console.WriteLine("The code does not exist");
            }
            Console.ReadLine();
        }
    }
}
