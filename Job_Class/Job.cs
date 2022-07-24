using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Class
{
    class Job
    {
        private string jobDesc;
        private double timeToComplete;
        private double hourlyrate;
        private double totalRate;

        public Job(string jobDesc, double timeToComplete, double hourlyRate)
        {
            JobDesc = jobDesc;
            TimeToComplete = timeToComplete;
            HourlyRate = hourlyRate;
        }
        public string JobDesc
        {
            get
            {
                return jobDesc;
            }
            set
            {
                jobDesc = value;
            }
        }
        public double TimeToComplete
        {
            get
            {
                return timeToComplete;
            }
            set
            {
                timeToComplete = value;
                calcTotalFeee();
            }
        }
        public double HourlyRate
        {
            get
            {
                return  hourlyrate;
            }
            set
            {
                hourlyrate = value;
                calcTotalFeee();
            }
        }
        public double TotalRate
        {
            get
            {
                return totalRate;
            }
        }

        public static Job operator +(Job j1, Job j2)
        {
            string newDesc = j1.JobDesc + " and " + j2.JobDesc;
            double newTotalHours = j1.TimeToComplete + j2.TimeToComplete;
            double newHourlyRate = (j1.HourlyRate + j2.HourlyRate) / 2;

            Job addedJob = new Job(newDesc, newTotalHours, newHourlyRate);
            return addedJob;
        }


        private void calcTotalFeee()
        {
            totalRate = hourlyrate * timeToComplete;
        }
    }
}
