using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REgistration
{
    class Parents : Registration
    {
        private string names;
        private string surnames;
        private int ages;
        private string genders;
        private string married;
        private string relationship;
        private int contact;
        private int number;
        private string child_name;
        private string child_gender;

        public void Guardian()
        {

            Console.WriteLine("----------**********************************************************************------------");
            Console.WriteLine("PARENTS INFO:"); Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Parents/Guardian Name: ");
            names = Console.ReadLine();
            Console.Write("Parents/Guardian Surname: ");
            surnames = Console.ReadLine();
            Console.Write("Parents/Guardian Age: ");
            ages = int.Parse(Console.ReadLine());
            Console.Write("Parents/Guardian Gender: ");
            genders = Console.ReadLine();

            if (genders != "Male" && genders != "male" && genders != "Female" && genders != "female")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PLEASE ENTER THE CORRECT GENDER!");
                Console.Write("Enter your Gender: ");
                genders = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write("Are you married :");
            married = Console.ReadLine();

            if(married == "Y" || married == "y")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Who is your spouse name: ");
                string spouse = Console.ReadLine();
                Console.Write("Spouse age: ");
                string s_age = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write("Enter your relationship with the child: ");
            relationship = Console.ReadLine();
            Console.Write("Enter your Contact number: ");
            contact = int.Parse(Console.ReadLine());
            Console.Write("How many kids do you have in this school?: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("________________________________________________________________");

            if(number == 1)
            {
                Console.Write("Enter the name of your child: ");
                child_name = Console.ReadLine();
                Console.Write("Enter the gender of your child: ");
                child_gender = Console.ReadLine();
            }
            Console.WriteLine($"{names} {surnames} is the guardian of {child_name} {surnames} who is {child_gender}");

            if(number == 2)
            {
                for (int i = 1; i <= 2; i++)
                {
                    Console.Write("Enter the name of your #{0} child: ",i);
                    string child_name = Console.ReadLine();
                    Console.Write("Enter the grade of your child: ");
                    string child_gender = Console.ReadLine();
                }
                Console.WriteLine($"{names} {surnames} is the guardian of {child_name} {surnames} who is {child_gender}");
            }
            
            if(number == 3)
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.Write("Enter the name of your #{0} child: ", i);
                    string child_name = Console.ReadLine();
                    Console.Write("Enter the grade of your child: ");
                    string child_gender = Console.ReadLine();
                }
                Console.WriteLine($"{names} {surnames} is the guardian of {child_name} {surnames} who is {child_gender}");
            }

            if (number == 4)
            {
                for (int i = 1; i <= 4; i++)
                {
                    Console.Write("Enter the name of your #{0} child: ", i);
                    string child_name = Console.ReadLine();
                    Console.Write("Enter the grade of your child: ");
                    string child_gender = Console.ReadLine();
                }
                Console.WriteLine($"{names} {surnames} is the guardian of {child_name} {surnames} who is {child_gender}");
            }

            if (number == 5)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Enter the name of your #{0} child: ", i);
                    string child_name = Console.ReadLine();
                    Console.Write("Enter the grade of your child: ");
                    string child_gender = Console.ReadLine();
                }
                Console.WriteLine($"{names} {surnames} is the guardian of {child_name} {surnames} who is {child_gender}");
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine("Below is the information of the parent/s or Guardian");
            Console.WriteLine("************************************************************************************************");
            Console.WriteLine($"Name: {names}"); Console.WriteLine($"Surname: {surnames}"); Console.WriteLine($""); Console.WriteLine($"Age: {ages}"); Console.WriteLine($"Gender: {genders}"); Console.WriteLine($"Maried: {married}"); Console.WriteLine($"Relationship to the child: {relationship}"); Console.WriteLine($"Contact Number: {contact}"); Console.WriteLine($"Number of learners who in our school: {number}");
            Console.WriteLine("************************************************************************************************");
            
        }
    }
}
