using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_and_student_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of students in your class");
            int amountOfStudents = int.Parse(Console.ReadLine());

            double avarageGrade = 0;
            double highestGrade = 0;
            string highestGradename = "";

            string[] studentsNames = new string[amountOfStudents];
            double[] grade = new double[amountOfStudents];

            for (int i = 0; i < amountOfStudents; i++)
            {
                Console.WriteLine("Enter student number{0} name", i +1);
                string name = Console.ReadLine();
                studentsNames[i] = name;
                Console.WriteLine("Enter students number{0} grade", i + 1);
                double grades = double.Parse(Console.ReadLine());
                grade[i] = grades;
                avarageGrade += grades;

                if (grades > highestGrade)
                {
                    highestGrade = grades;
                    highestGradename = name;
                }
            }
            avarageGrade /= amountOfStudents;
            Console.WriteLine("The avarage of the class is {0}", avarageGrade);
            Console.WriteLine("The highest grade of the  class is {0} and their name was {1}",highestGrade, highestGradename);
            Console.ReadLine();


        }
    }
}
