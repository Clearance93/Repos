using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theeSearch = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 };
            int[] myArray = { 20, 10, 5, 70, 60, 45, 55, 16, 36 };
            Console.WriteLine("Please do enter your favorite number");
            int number = int.Parse(Console.ReadLine());

            int answer = Array.BinarySearch(theeSearch, number);
            if (answer < 0)
            {
                Console.WriteLine("The number doesn't exist");
            }
            else
            {
                Console.WriteLine("Your favorite number is is on number {0}", answer);
            }

            Array.Sort(myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Array.Reverse(myArray);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadKey();

        }
    }
}
