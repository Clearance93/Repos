using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Learner
    {
        private string names;
        private int age;
        private string gender;
        private string grade;
        private string stream;

 
        public void Input()
        {
            Console.Write("Enter your full Names: ");
             names = Console.ReadLine(); Console.WriteLine();
            Console.Write("Enter your Age: ");
            age = int.Parse(Console.ReadLine()); Console.WriteLine();
            Console.Write("Enter your Gender: ");
            gender = Console.ReadLine(); Console.WriteLine();
            Console.Write("Enter Your class Grade: ");
            grade = Console.ReadLine(); Console.WriteLine();
            Console.Write("Enter your stream Stream: ");
            stream = Console.ReadLine(); Console.WriteLine();
            Console.WriteLine("_______________________________________________________________________________________________________________________________________");
            Console.WriteLine();

        }

        public void Output()
        {
            if(age > 18 && age <= 19)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} You are old to be in this class, This is your last chance.",names);
            }
            else if(age == 18)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Congratulations, {0} You are in the right place at the right time. Well done!",names);
            }
            else if(age >= 20)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sorry! {0}, You are not accepted to be a learner in this institution",names);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} You are the most youngest learners in this class",names);
            }
            if(age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Full Name: {0}", names); Console.WriteLine("Age: {0}", age); Console.WriteLine("Gender: {0}", gender); Console.WriteLine("Grade: {0}", grade);
                Console.WriteLine("Stream: {0}", stream);
                Console.WriteLine("_______________________________________________________________________________________________________________________________________");
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}
