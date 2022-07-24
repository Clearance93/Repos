using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_two
{
    class Program
    {
        static void Main(string[] args)
        {
            const int per_squire_foot = 10;

            Console.WriteLine("Please enter the length of your room: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of your room ");
            int width = int.Parse(Console.ReadLine());

            int area = length * width;
            int price = area * per_squire_foot;

            Console.WriteLine("The total price of your room is R"+price);

            Console.ReadLine();
        }
    }
}
