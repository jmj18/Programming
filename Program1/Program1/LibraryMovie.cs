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
    class LibraryMovie : LibraryMediaItem
    {
        private String _director;//Director of the movie
        private enum MappaRating { G, PG, PG13, R, NC17, U }//Enum for movie rating 
        private MediaType _medium;//Media type of the item
        private MappaRating _rating;//Rating of the movie 

        public LibraryMovie(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod,
            String theCallNumber, double theDuration,String theDirector, MediaType theMedium, MappaRating theRating)
            : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theDuration)
        {
            Director = theDirector;
            Medium = theMedium;
            Rating = theRating;
        }
        public String Director
        {
            get
                //Precondition:None
                //Postcondtion:Director is returned 
            {
                return _director;
            }
            set
                //Precondition:None
                //Postcondition:Director is set to specified value 
            {
                _director = value;
            }
        }

        public MediaType Medium
        {
        
            get
                //Precondition:None
                //Postcondition:Medium is returned 
            {
                return _medium;
            }
            set
                //Precondition:Mediatype must be a Bluray,DVD or VHS
                //Postcondition:Medium is set to specified value 
            {
                if (value == MediaType.BluRay || value == MediaType.DVD || value == MediaType.VHS)
                    _medium = value;
                else
                    throw new ArgumentOutOfRangeException("Medium", value, "Movie Medium must be a Bluray,DvD, or VHS");
            }
        }

        public MappaRating Rating
        {
            get
                //Precondition:None
                //Postcondition:Rating is returned 
            {
                return _rating;
            }
            set
                //Precondition:None
                //Postcondtion: Rating is set to specified value 
            {
                _rating = value;
            }
        }

        const double Latefee1 = 1.00;//variable to hold late fee for dvd and vhs
        const double Latefee2 = 1.50;//variable to hold late fee for bluray
        const double maxDays1 = 25; //variable to hold days until fee limit is reached for DVD and VHS
        const double maxDays2 = 16;//variable to hold days until fee limit is reached for Bluray
        const decimal maxFee = 25;//Variable to hold max fee limit
            public override decimal CalcLateFee(int DaysLate)
        {
            if (Medium == MediaType.DVD || Medium == MediaType.VHS)
                return (decimal)(DaysLate * Latefee1);

            else if (Medium == MediaType.BluRay)
                return (decimal)(DaysLate * Latefee2);
            else if (DaysLate == maxDays1)
                return maxFee;
            else if (DaysLate == maxDays2)
                return maxFee;
            else
                throw new NotImplementedException();
        }

          public override string ToString()
            {
                return string.Format("Director{0}{3}", Director, "Medium{1}{3}", Medium, "Rating{2}{3}",Rating, base.ToString());
          }


    }
}

