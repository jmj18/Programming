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
   public abstract class LibraryPeriodical : LibraryItem
    {
       private int _volume;//The volume of the periodical
       private int _number;//The number of the periodical

       public LibraryPeriodical(String theTitle, String thePublisher, int theCopyrightYear, int theLoanPeriod,
            String theCallNumber, int theVolume, int theNumber)
           : base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
       {
           Volume = theVolume;
           Number = theNumber;
       }

       public int Volume
       {
           get
               //Precondition:None
               //Postcondition: Volume is returned 
           {
               return _volume;
           }
           set
               //Preconditon:Volume must be greater or equal to 0
               //Postcondition:Volume is set to specified value 
           {
               if (value >= 0)
                   _volume = value;
               else
                   throw new ArgumentOutOfRangeException("Volume", value, "Volume must be non-negitive");
           }
       }



       public int Number
       {
           get
               //Precondition:None
               //Postcondition: Number is returned 
           {
               return _number;
           }
           set
               //Precondition:Number must be greater or equal to 0
               //Postcondition:Number is set to specified value 
           {
               if (value >= 0)
                   _number = value;
               else
                   throw new ArgumentOutOfRangeException("Number", value, "Number must be non-negitive");
           }
       }

       public override string ToString()
       {
           return string.Format("Volume:{0}{7}", Volume, "Number:{1}{7}", Number, base.ToString());
       }


       





    }
}
