using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_taker
{
    class Program
    {
        static void Main(string[] args)
        {
            Temp temp = new Temp();
            temp.Take();
            Console.ReadKey();
        }
    }
}
