using System;

namespace Practice_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Stuff S1 = new Stuff();
            S1.first_name = "Clearance";

            Console.WriteLine("{0} is the first stuff member", S1.first_name);
            Console.ReadLine();

        }
    }
}
