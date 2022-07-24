using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades_12
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMarks learner_one = new MathMarks("Kyle Smith", 98);
            Console.WriteLine("{0} got {1}%", learner_one.Names, learner_one.Marks);
            MathMarks learner_two = new MathMarks("Eugene James", 77);
            Console.WriteLine("{0} got {1}%", learner_two.Names, learner_two.Marks);



            Console.ReadKey();
        }
    }
}
