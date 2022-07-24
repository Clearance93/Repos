using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Clearance", "Tebogo", "Thango", "Sebata", " Thapelo", "Mankwana", "Thabiso", "Ofentse", "Katlego" };
            int[] grades = { 100, 95, 85, 88, 99, 100, 45, 66, 78 };
            Console.WriteLine("Enter the name of the students you are look for?");
            string studentName = Console.ReadLine();

            bool contain = false;
            int grade = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if(studentName == students[i])
                {
                    contain = true;
                    grade = grades[i];
                    break;
                }
            }

            if(contain == true)
            {
                Console.WriteLine("The student is present");
                Console.WriteLine("The students grades is {0}", grade);
            }
            else
            {
                Console.WriteLine("The student is absent");
            }
            Console.ReadLine();
        }
    }
}
