using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_three
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of time in minutes only: ");
            int minuites = int.Parse(Console.ReadLine());
            int hours = minuites / 60;
            int remaining_minutes = minuites % 60;

            Console.WriteLine("{0} minutes is equal to {1} hours and {2} minutes", minuites, hours, remaining_minutes);
            Console.ReadLine();
        }
    }
}
