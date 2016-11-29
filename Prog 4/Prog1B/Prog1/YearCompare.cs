// Program 4
// CIS 200-01/02
// Due: 4/11/2016
// By: Jordan Johnson

// File: YearCompare.cs
// This program displays the use of the ICompareable and IComparer interfaces and displays 
// the sorted list to a console application.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    public class YearCompare : IComparer<LibraryItem>
    {

        // Precondition:  None
        // Postcondition: Reverses natural time order, so
        //                When i1 < i2, method returns positive #
        //                When i1 == i2, method returns zero
        //                When i1 > i2, method returns negative #
        public int Compare(LibraryItem i1, LibraryItem i2)
        {
            if (i1 == null && i2 == null) // Both null?
                return 0;

            if (i1 == null) // only t1 is null?
                return -1;

            if (i2 == null) // only t2 is null?
                return 1;

            return i2.CopyrightYear.CompareTo(i1.CopyrightYear); // Reverses natural order
        }
    }
}
