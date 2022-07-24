using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexPayer
{
    class Taxpayers
    {
        private string socialSecurityNumber;
        private double yearlyGrossIncome;
        private double taxOwed;

        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
            set
            {
                socialSecurityNumber = value;
            }
        }

        public double YearlyGrossIncome
        {
            get
            {
                return yearlyGrossIncome;
            }
            set
            {
                yearlyGrossIncome = value;
                calcTaxOwed();
            }
        }
        public double Taxoawed
        {
            get
            {
                return taxOwed;
            }
        }
        private void calcTaxOwed()
        {
            if (yearlyGrossIncome < 30000)
            {
                taxOwed = yearlyGrossIncome * .15;
            }
            else
            {
                taxOwed = yearlyGrossIncome * .28;
            }
        }
    }
}
