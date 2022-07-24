using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i < 51; i++)
            {
                sum += i;
            }
            Console.WriteLine("The totla sum is {0}", sum);
            Console.ReadKey();
        }
    }
}
