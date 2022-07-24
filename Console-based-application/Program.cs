using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_based_application
{
    class Program
    {
        static void Main(string[] args)
        {
            double pay_rate;

            do
            {
                Console.WriteLine("Please enter your valid pay rate");
                pay_rate = double.Parse(Console.ReadLine());

            } while (pay_rate < 5.65 || pay_rate > 49.99);

            Console.WriteLine("Your valid pay rate is {0}", pay_rate);
            Console.ReadLine();
            
        }
    }
}
