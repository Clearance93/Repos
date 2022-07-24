using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Class
{
    class Students
    {
        private string names;
        private int age;
        private string grade;
        private string gender;


        public Students(string names, int age, string grade, string gender)
        {
            this.names = names;
            this.age = age;
            this.grade = grade;
            this.gender = gender;
        }
       public void Output()
        {
            Console.WriteLine("Full Names: {0}",names); Console.WriteLine("Age: {0}",age); Console.WriteLine("Grade: {0}",grade);
            Console.WriteLine("Gender: {0}",gender);
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine();
        }
    }
}
