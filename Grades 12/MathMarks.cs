using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades_12
{
    class MathMarks
    {
        private string names;
        private double marks;

        public MathMarks(string names, double marks)
        {
            this.names = names;
            this.marks = marks;
        }

        public string Names
        {
            get
            {
                return names;
            }
            set
            {
                names = value;
            }
        }

        public double Marks
        {
            get
            {
                return marks;
            }
            set
            {
                marks = value;
            }
        }
    }
}
