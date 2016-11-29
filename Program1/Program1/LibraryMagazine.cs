//Jordan Johnson
//CIS 200
//Due: 2/17/2016
//Program 1A: Creates a simple class hierarchy for the library classes 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class LibraryMagazine: LibraryPeriodical
    {
        public LibraryMagazine(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod,
            String theCallNumber, int theVolume, int theNumber)
            : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theVolume, theNumber)
        { }

         const double Latefee5 = .25;//Varibale to hold late fee for magazines 
         const double maxDays = 80;//Variable to hold days until fee limit is reached 
         const decimal maxFee = 20;//Variable to hold late fee limit for magazines 
         
        public override decimal CalcLateFee(int DaysLate)
         {
             if (DaysLate <= maxDays)
                 return (decimal)(DaysLate * Latefee5);
             else
                 return maxFee;
         }

        public override string ToString()
        {
            return string.Format(base.ToString());
        }
    }
}
