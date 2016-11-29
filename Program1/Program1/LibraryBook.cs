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
    class LibraryBook : LibraryItem
    {
        private String _author;//Author for the book 

        public LibraryBook(String theTitle, String theAuthor, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber)
            : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
        {
            Author = theAuthor;
        }

        public String Author
        {
            get
                //Precondition:None
                //Postcondition:Author has been returned 
            {
                return _author;
            }
            set
                //Precondition:None 
                //Postcondition:Author has been set to specified value
            {
                _author = value;
            }
        }

        const double lateFee = .25; //Variable to hold late fee 
        
            public override decimal CalcLateFee(int DaysLate)
        {
            return (decimal)(DaysLate * lateFee); 
            
        }

            public override string ToString()
            {
                return string.Format("Author: {0}{6}", Author, base.ToString(), "Title:{1}{6}", Title, "Publisher:{2}{6}", Publisher,
                    "LoanPeriod:{3,6}", LoanPeriod, "Copyright:{4}{6}", CopyrightYear, "CallNumber:{5}{6}", CallNumber);
               
            }
}



  

    }

