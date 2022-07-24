using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conole_based_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            multiplicationTable(number);
            Console.ReadLine();
            Console.ReadLine();
        }
        public static void multiplicationTable(int number)
        {
            for (int i = 2; i <= 10; i++)
            {
                int answer = number * i;
                Console.WriteLine("{0} * {1} = {2}",i,number,answer);

            }       
        }
    }
}
