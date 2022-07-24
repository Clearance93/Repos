using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_four
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string name;
            string surname;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your surname: ");
            surname = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            num = int.Parse(Console.ReadLine());

            if(num < 18)
            {
                Console.WriteLine(name +" " + surname + " your are less than 18 years and you are not allowed to enter in this club.");
            }
            else if(num == 18)
            {
                Console.WriteLine("Congratualtion " + name + " " + surname + " you've just turned 18, Welcome on board of adulthood.");
            }
            else
            {
                Console.WriteLine(name + " " + surname + " Welcome to our club, enjoy yourself");
            }

            Console.ReadLine();
        }
    }
}
