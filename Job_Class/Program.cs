using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Job j1 = new Job("Wash windows", 5, 20);
            Console.WriteLine("{0}, {1},{2}, {3}", j1.JobDesc,j1.TimeToComplete,j1.HourlyRate,j1.TotalRate);
            Job j2 = new Job("Car wash", 7, 30);
            Console.WriteLine("{0}, {1},{2}, {3}", j2.JobDesc, j2.TimeToComplete, j2.HourlyRate, j2.TotalRate);
            //Console.WriteLine(j2.TotalRate);

            Job j3 = j1 + j2;
            Console.WriteLine("{0}, {1},{2}, {3}", j3.JobDesc, j3.TimeToComplete, j3.HourlyRate, j3.TotalRate);


            Console.ReadLine();
        }
    }
}
