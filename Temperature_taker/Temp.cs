using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_taker
{
    class Temp
    {
        private string name;
        private string surname;
        private double temperature;

        public void Take()
        {
            Console.Write("Enter your Name: ");
            name = Console.ReadLine(); Console.WriteLine();
            Console.Write("Enter your Surname: ");
            surname = Console.ReadLine(); Console.WriteLine();
            Console.Write("Enter your Temperature: ");
            temperature = double.Parse(Console.ReadLine()); Console.WriteLine("__________________________________________________________________");

            if(temperature <= 34.9 && temperature >= 30)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("{0} {1} your temperature is {2}, means that you are too cold. Get a cup of tea and come back after.",name,surname,temperature);
            }
            else if(temperature >= 35 && temperature <= 37)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} {1} your temperature is {2}. You may go in",name,surname,temperature);
            }
            else if(temperature >= 37.1 && temperature <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} {1} your temperature is {2}. You are too hot, please do take some few minutes to cool down and come back",name,surname,temperature);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("{0} {1} your temperature is {2}. You are too hot, you need medical attention",name,surname,temperature);
            }
        }
    }
}
