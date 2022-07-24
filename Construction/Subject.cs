using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Subject
    {
        private string subjects;

        public void RegSubjects()
        {
            Console.WriteLine("Subject Registration");
            Console.WriteLine();
            Console.WriteLine("---**********************---");
            Console.WriteLine();

            for (int i = 1; i <= 7; i++)
            {
                Console.Write("Register your {0} subject: ",i);
                subjects = Console.ReadLine();
                Console.WriteLine("{0} is registered as No:{1} subject ",subjects,i);
                Console.WriteLine();
            }
            Console.WriteLine("_______________________________________________________________________________________________________________________________________");
            Console.WriteLine();
        }
    }
}
