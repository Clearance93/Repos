using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(5);
            Sum(10, 5, 15);
            Sum(45, 40, 35, 30, 5);
            Sum(5, 10, 15, 20, 25, 30, 35, 40, 45, 50);
            Console.ReadLine(); 
        }
        public static void Sum(params int[] myArrays)
        {
            int sum = 0;
            for (int i = 0; i < myArrays.Length; i++)
            {
                sum += myArrays[i];
            }
            Console.WriteLine("The sum is {0}: ",sum);
        }
    }
}
