using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqyire_and_Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            squireMethod(num);
            cubeMethod(num);
            Console.ReadLine();
        }
        public static void squireMethod( int num)
        {
            int squire = num * num;
            Console.WriteLine("{0}^2 = {1}", num, squire);
        }

        public static void cubeMethod(int num)
        {
            int cube = num * num * num;
            Console.WriteLine("{0}^3 = {1}", num, cube);
        }
    }
}
