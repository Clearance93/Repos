using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            Learner l1 = new Learner();
            l1.Input();
            l1.GetHashCode();
            Subject s1 = new Subject();
            s1.RegSubjects();

            Learner l2 = new Learner();
            l2.Input();
            l2.GetHashCode();
            Subject s2 = new Subject();
            s2.RegSubjects();

            Learner l3 = new Learner();
            l3.Input();
            l3.GetHashCode();
            Subject s3 = new Subject();
            s3.RegSubjects();

            Learner l4 = new Learner();
            l4.Input();
            l4.GetHashCode();
            Subject s4 = new Subject();
            s4.RegSubjects();

            Learner l5 = new Learner();
            l5.Input();
            l5.GetHashCode();
            Subject s5 = new Subject();
            s5.RegSubjects();

            Learner l6 = new Learner();
            l6.Input();
            l6.GetHashCode();
            Subject s6 = new Subject();
            s6.RegSubjects();

            l1.Output();
            l2.Output();
            l3.Output();
            l4.Output();
            l5.Output();
            l6.Output();

            Console.ReadKey();
        }
    }
}
