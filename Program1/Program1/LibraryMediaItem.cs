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
    public abstract class LibraryMediaItem : LibraryItem
    {
        private double _duration;//Duration of the music 
        protected enum MediaType {DVD,BluRay,VHS,CD,SACD,VINYL}//Enum for the type of media 
        public LibraryMediaItem(String theTitle,String thePublisher, int theCopyrightYear, int theLoanPeriod,
            String theCallNumber, double theDuration)
            : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
        {
            Duration = theDuration;
        }

        public double Duration
        {
            get
                //Precondition:None 
                //Postcondition: Duration is returned 
            {
                return _duration;
            }
            set
            {
                //Precondition:Value must be greater than 0
                //Postcondition: Duration has been set to specified value 
                if (value >= 0)
                    _duration = value;
                else
                    throw new ArgumentOutOfRangeException("Duration", value, "Must be greater than 0");
            }
        }

        public abstract MediaType Medium
        {
            //Preconditon:None
            //Postcondition:None
            get;
            set;
        }

         public override string ToString()
            {
                return string.Format("Duration:{0}{7}", Duration,"Medium:{1}{7}",Medium, base.ToString(), "Title:{2}{7}", Title, "Publisher:{3}{7}", Publisher,
                    "LoanPeriod:{4,7}", LoanPeriod, "Copyright:{5}{7}", CopyrightYear, "CallNumber:{6}{7}", CallNumber);

            }



        


    }
}
