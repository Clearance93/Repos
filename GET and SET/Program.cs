using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GET_and_SET
{
    class Program
    {
        static void Main(string[] args)
        {
            Squire[] squires = new Squire[10];
            for (int i = 0; i < 10; i++)
            {
                squires[i] = new Squire(i + 1);
                Console.WriteLine("{0}, {1}", squires[i].Side,squires[i].Area);
            }
            Console.ReadLine();
        }
    }
}
