using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REgistration
{
    class Registration
    {
        private string name;
        private string surname;
        private int age;
        private string gender;
        private string grade;

        public void Learner_reg()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your First Name: ");
            name = Console.ReadLine();
            Console.Write("Enter your Last Name: ");
            surname = Console.ReadLine();
            Console.Write("Enter your Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter your Gender: ");
            gender = Console.ReadLine();

            if(gender != "Male" && gender != "male" && gender != "Female" && gender != "female")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PLEASE ENTER THE CORRECT GENDER!");
                Console.Write("Enter your Gender: ");
                gender = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write("Register your Grade: ");
            grade = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------------");


            if(grade == "Grade 8" || grade == "grade 8")
            {
                if(age >= 10 && age <= 14)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{name} {surname} We welcome you in our grade 8 class");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if(age >= 15)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} {1} you are too old to be registred in this class. Sorry!",name,surname);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You're too young to be in this class, relevent documentations are needed for you to be approved and as prove that you really have the ligitimare rights to be accepted in this class.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            if(grade == "grade 9" || grade == "Grade 9")
            {
                if(age >= 11 && age <= 16)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{name} {surname} we welcome you in our grade 9 class");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} {1} You are too old to be in this class",name,surname);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            if(grade == "Grade 10" || grade == "grade 10")
            {
                if(age >= 12 && age <= 17)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{name} {surname}, We welcome you in our grade 10 class");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} {1}, you are too old be accepted in this class. Sorry!",name,surname);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            if(grade == "grade 11" || grade == "Grade 11")
            {
                if(age >= 13 && age <= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{name} {surname}, Congratulations to make it to grade 10 Class");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} {1}, you are too old you be accepted in this class. Sorry!",name,surname);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            if(grade == "Grade 12" || grade == "grade 12" || grade == "Matric" || grade == "matric")
            {
                if(age >= 14 && age <= 19)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{name} {surname}, We would like you Congratulate all the new learners who made it thus far to be in this grade. You are our this year grade 12 learners and we hope for a 100% pass rate from all of you. Hard work and determination is expected from all of you. Once again. Congratulations");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} {1}. You're too old to be taken for this class. Try ABET for your matric grades. Sorry!",name,surname);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
