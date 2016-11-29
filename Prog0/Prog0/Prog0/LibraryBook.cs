//Jordan Johnson
//CIS200-01
//Due 2/3/16
// Program 0
// Creates a has-a relationship between librarybook and libraryPatron classes. 
// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status.

//I think i correctly created the has-a Relationship between the classes 
//but i dont think i correctly displayed the results in the console 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook
{
    public const int DEFAULT_YEAR = 2015; // Default copyright year

    private String _title;      // The book's title
    private String _author;     // The book's author
    private String _publisher;  // The book's publisher
    private int _copyrightYear; // The book's year of copyright
    private String _callNumber; // The book's call number in the library
    private bool _checkedOut;   // The book's checked out status
    
    private LibraryPatron _patron;//Reference to LibraryPatron Object 
    
    // Precondition:  None
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryBook(String theTitle, String theAuthor, String thePublisher,
        int theCopyrightYear, String theCallNumber)
    {
        // Establish default first in case invalid
        CopyrightYear = DEFAULT_YEAR;

        Title = theTitle;
        Author = theAuthor;
        Publisher = thePublisher;
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

    public String Author
    {
        // Precondition:  None
        // Postcondition: The author has been returned
        get
        {
            return _author;
        }

        // Precondition:  None
        // Postcondition: The author has been set to the specified value
        set
        {
            _author = value;
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

    //Precondition:Book must me checked out 
    //Postcondition: The patron has been called from LibraryPatron when a book is checked out
    public LibraryPatron Patron
    {
        get   
        {
            if(_checkedOut==true)
            {
            return _patron;
            }
            else 
               return _patron=null;
         }
            private set
        {
            _patron = value;
        }
    }


            
    

    
    // Precondition:  None
    // Postcondition: The book is checked out and patron is selected for the book 
    public void CheckOut(LibraryPatron Patron)
    {
        _checkedOut = true;
        _patron = Patron;
        
    }

    // Precondition:  None
    // Postcondition: The book is not checked out and Patron will be set to null
    public void ReturnToShelf()
    {
        _checkedOut = false;
        _patron= null;
      
     }   
    

    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()
    {
        return _checkedOut;
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary book's data on
    //                separate lines
    public override string ToString()
    {
        return String.Format("Title: {0}{6}Author: {1}{6}Publisher: {2}{6}" +
            "Copyright: {3:D4}{6}Call Number: {4}{6}Checked Out: {5}" + "Checked out by: {6}{7}",
            Title, Author, Publisher, CopyrightYear, CallNumber, IsCheckedOut(),Patron,
            System.Environment.NewLine);
    }
}
