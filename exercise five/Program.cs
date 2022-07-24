using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_five
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your hourly pay rate:");
            double rate = double.Parse(Console.ReadLine());

            if(rate >= 7.5 && rate <= 49.00)
            {
                Console.WriteLine("${0} it's an okay rate", rate);
            }
            else
            {
                Console.WriteLine("${0} is invalid rate", rate);
            }
            Console.ReadLine();
        }
    }
}
