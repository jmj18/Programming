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
    public abstract class LibraryItem
    {
        public const int DEFAULT_YEAR = 2015; // Default copyright year

        private String _title;          // The book's title
        private String _publisher;      // The book's publisher
        private int _copyrightYear;     // The book's year of copyright
        private int _loanPeriod;        // The loan period in days for the book
        private String _callNumber;     // The book's call number in the library
        private bool _checkedOut;       // The book's checked out status
        private LibraryPatron _patron;  // The person that has the book checked out (null otherwise)


        public LibraryItem(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod,
        String theCallNumber)
        {
            // Establish default first in case invalid
            CopyrightYear = DEFAULT_YEAR;

            Title = theTitle;
            Publisher = thePublisher;
            LoanPeriod = theLoanPeriod;
            CopyrightYear = theCopyrightYear;
            CallNumber = theCallNumber;

            ReturnToShelf(); // Make sure book is not checked out
        }
        public String Title
        {
            // Precondition:  None
            // Postcondition: The title has been returned
            get
            {
                return _title;
            }

            // Precondition:  None
            // Postcondition: The title has been set to the specified value
            set
            {
                _title = value;
            }
        }

        public String Publisher
        {
            // Precondition:  None
            // Postcondition: The publisher has been returned
            get
            {
                return _publisher;
            }

            // Precondition:  None
            // Postcondition: The publisher has been set to the specified value
            set
            {
                _publisher = value;
            }
        }

        public int LoanPeriod
        {
            // Precondition:  None
            // Postcondition: The LoanPeriod has been returned

            get
            {
                return _loanPeriod;
            }
            // Precondition:  None
            // Postcodition: The loan period has been set to specified value 
            set

            {
                _loanPeriod = value;
            }
        }

        public int CopyrightYear
        {
            // Precondition:  None
            // Postcondition: The copyright year has been returned
            get
            {
                return _copyrightYear;
            }

            // Precondition:  value >= 0
            // Postcondition: The copyright year has been set to the specified value
            set
            {
                if (value >= 0)
                    _copyrightYear = value;
            }
        }

        public String CallNumber
        {
            // Precondition:  None
            // Postcondition: The call number has been returned
            get
            {
                return _callNumber;
            }

            // Precondition:  None
            // Postcondition: The call number has been set to the specified value
            set
            {
                _callNumber = value;
            }
        }

        public LibraryPatron Patron
        {
            // Precondition:  IsCheckedOut() == true
            // Postcondition: The patron that has the book checked out is returned
            //                (otherwise null)
            get
            {
                return _patron;
            }

            // HELPER - not public
            // Precondition:  None
            // Postcondition: The associated patron value is stored
            private set
            {
                _patron = value;
            }
        }

        public void CheckOut(LibraryPatron thePatron)
        {
            _checkedOut = true;
            Patron = thePatron;
        }

        // Precondition:  None
        // Postcondition: The book is not checked out (by any patron)
        public void ReturnToShelf()
        {
            _checkedOut = false;
            Patron = null; // No longer associated with anyone
        }


        // Precondition:  None
        // Postcondition: true is returned if the book is checked out,
        //                otherwise false is returned
        public bool IsCheckedOut()
        {
            return _checkedOut;
        }

        private int ValidateDaysLate();

        public abstract decimal CalcLateFee(int DaysLate);

        public override string ToString()
        {
            String result; // Holds for formatted results as being built

            result = String.Format("Title: {0}{5}Publisher: {1}{5}Loan Period:{2}{5}" +
                "Copyright: {3}{5}Call Number: {4}{5}",
                Title, Publisher,LoanPeriod,CopyrightYear, CallNumber, System.Environment.NewLine);

            if (IsCheckedOut())
                result += String.Format("Checked Out By: {1}{0}", Patron, System.Environment.NewLine);
            else
                result += "Not Checked Out";

            return result;
        }
    }
}

