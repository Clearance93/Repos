using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexPayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxpayers[] payers = new Taxpayers[10];
            for (int i = 0; i < payers.Length; i++)
            {
                payers[i] = new Taxpayers();
                Console.WriteLine("Enter payer #{0} SSN", i + 1);
                payers[i].SocialSecurityNumber = Console.ReadLine();
                Console.WriteLine("Enter payer #{0} yearly income", i + 1);
                payers[i].YearlyGrossIncome = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < payers.Length; i++)
            {
                Console.WriteLine("Tax Payer #{0} = {1}, Income = {2}, Tax Owed = {3}",i +1,payers[i].SocialSecurityNumber,payers[i].YearlyGrossIncome,payers[i].Taxoawed);

            }
            Console.ReadKey();

        }
    }
}
