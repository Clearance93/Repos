using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REgistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Registration r1 = new Registration();
            r1.Learner_reg();
            Parents p1 = new Parents();
            p1.Guardian();
            //Registration r2 = new Registration();
            //r2.Learner_reg();
            //Parents p2 = new Parents();
            //p2.Guardian();
            //Console.ReadKey();
        }
    }
}
