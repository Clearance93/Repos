using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Marks
    {
        private string name;
        private string subject;
        private int final_marks;

        //public Marks(string name, string subject, int final_mark)
        //{
        //    this.name = name;
        //    this.subject = subject;
        //    final_marks = final_mark;
        //}

        public void PassMarks()
        {
            Console.Write("Enter Learners Full Names: ");
            name = Console.ReadLine(); Console.WriteLine();
            Console.Write("Enter the subject: ");
            subject = Console.ReadLine(); Console.WriteLine();
            Console.Write("Enter the final marks of the student: ");
            final_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("_______________________________________________________________________________________________________________________________________");
            Console.WriteLine();

        }
        public void Results()
        {

            if (final_marks >= 70)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} has passed {1} with distinction", name, subject);
            }
            else if (final_marks >= 50 && final_marks <= 69)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} has passed {1} without distinction", name, subject);
            }
            else if (final_marks >= 40 && final_marks <= 49)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("{0} has not passed {1}. However, he quilify for rewrite");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} failed {1} and doesn't quilify for rewrite",name,subject);
            }

        }
    }
}
