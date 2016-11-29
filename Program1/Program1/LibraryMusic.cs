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
    class LibraryMusic : LibraryMediaItem
    {
        private String _artist;//Artist of the music 
        private MediaType _medium;//Media type of the music 
        private int _numTracks;//Number of tracks the music has 

        public LibraryMusic(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod,
            String theCallNumber, double theDuration, String theArtist, MediaType theMedium, int theNumTracks)
            : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theDuration)
        {
            Artist = theArtist;
            Medium = theMedium;
            NumTracks = theNumTracks;
        }
        public String Artist
        {
            get
                //Precondition:None
                //Postcondition:Artist is returned 
            {
                return _artist;
            }
            set
                //Precondition:None
                //Postcondition:Artist is set to specified value
            {
                _artist = value;
            }
        }
       
        public MediaType Medium
        {

            get
                //Precondition:None
                //Medium is returned 
            {
                return _medium;
            }
            set
            //Precondition:Mediatype must be a CD,SACD or Vinyl
            //Postcondition:Medium is set to specified value 
            {
                if (value == MediaType.CD || value == MediaType.SACD || value == MediaType.VINYL)
                    _medium = value;
                else
                    throw new ArgumentOutOfRangeException("Medium", value, "Music medium must be a CD,SACDor Vinyl");
            }
        }

        public int NumTracks
        {
            get
                //Precondition:None
                //Postcondition:Numtracks is returned 
            {
                return _numTracks;
            }
            set
                //Precondition:Number of tracks must be greater than 0
                //Precondition:NumTracks is set to specified value 
            {
                if (value > 0)
                    _numTracks = value;
                else
                    throw new ArgumentOutOfRangeException("NumTracks", value, "NumTracks must be greater than 0");
            }
        }
       
        const double Latefee3=.50;//Variable to hold late fee for music 
        const double maxDays = 40;//Variable to hold days until fee limit is reached 
        const decimal maxFee = 20;// Variable to hold the late fee limit for music 
       public override decimal CalcLateFee(int DaysLate)
       {
           if (Medium == MediaType.CD || Medium == MediaType.SACD || Medium == MediaType.VINYL)
               return (decimal)(DaysLate * Latefee3);
           else if (DaysLate == maxDays)
               return maxFee;
           else
               throw new NotImplementedException();
       }

       public override string ToString()
       {
           return string.Format("Artist{0}{3}", Artist, "Medium{1}{3}", Medium, "NumTracks{2}{3}", NumTracks, base.ToString());
       }






    }
}
