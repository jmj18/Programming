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
    class LibraryJournal : LibraryPeriodical
    {
        private String _discipline; //Discipline of the journal 
        private String _editor; //Editor of the journal 

        public LibraryJournal(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod,
            String theCallNumber, int theVolume, int theNumber, String theDiscipline, String theEditor)
            : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theVolume, theNumber)
        {
            Discipline = theDiscipline;
            Editor = theEditor;
        }

        public String Discipline
        {
            get
                //Precondition:None
                //Postcondition:Discipline is returned 
            {
                return _discipline;
            }
            set
                //Precondition:None 
                //Postcondition: Discipline is set to specified value 
            {
                _discipline = value;
            }
        }

        public String Editor
        {
            get
                //Precondition:None
                //Postcondition: Editor is returned 
            {
                return _editor;
            }
            set
                //Precondition:None 
                //Postcondition: Editor is set to specified value 
            {
                _editor = value;
            }
        }

        const double Latefee4 = .75;//Variable to hold late fee for journal 
        const double maxDays = 26;//Variable to hold days until fee limit is reached 
        const decimal maxFee = 20;//Variable to hole late fee limit for journals 
        
        public override decimal CalcLateFee(int DaysLate)
        {
            if (DaysLate <= maxDays)
                return (decimal)(DaysLate * Latefee4);
            else
                return maxFee;
        }

        public override string ToString()
        {
            return string.Format("Discipline:{0}{2}", Discipline, "Editior:{0}{2}", Editor, base.ToString());
        }

        

    }
}
