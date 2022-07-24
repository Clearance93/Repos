using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawn_mowing_Service
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your the length of your lawn:");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of your lawn:");
            int width = int.Parse(Console.ReadLine());

            int squire_feet = length * width;
            int price;

            if(squire_feet < 400)
            {
                price = 25;
            }
            else if(squire_feet >= 400 && squire_feet < 600)
            {
                price = 35;
            }
            else
            {
                price = 50;
            }

            Console.WriteLine("The weekly price is {0}", price);
            Console.WriteLine("The 20 week season price is {0}", price * 20);

            Console.ReadLine();
        }
    }
}
