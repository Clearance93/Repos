using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Students s1 = new Students("Clearance Morumudi", 12, "Grade 7", "Male");
            s1.Output();

            Students s2 = new Students("Tebogo Molekwa", 12, "Grade 7", "Male");
            s2.Output();

            Students s3 = new Students("Neo Mohlanga", 14, "Grade 7", "Female");
            s3.Output();

            Students s4 = new Students("Kyle Smith", 12, "Grade 7", "Male");
            s4.Output();

            Console.ReadLine();
        }
    }
}
