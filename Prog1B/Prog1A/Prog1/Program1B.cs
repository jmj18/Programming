// Program 1B
// CIS 200-01/02
// Due: 2/24/2016
// By: Jordan Johnson 

// File: Program1B.cs
// This file creates a test program described in assignment 1B made from Dr.Wright solution to 1A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested using LINQ, demonstrating polymorphism
    public static void Main(string[] args)
    {
        const int DAYSLATE = 14; // Number of days late to test each object's CalcLateFee method

        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

        int p; // Patron index

        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));
        items.Add(new LibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
            "AB73 ZF", "IP Thief"));
        items.Add(new LibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG));
        items.Add(new LibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2011, 10,
            "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G));
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2011, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
        items.Add(new LibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12));
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2011, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryJournal("Journal of VB Goodness", "UofL Journals", 2007, 14,
            "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams"));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
            "MA53 9A", 16, 7));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
            "MA53 9B", 17, 8));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
            "MA53 9C", 18, 9));
        items.Add(new LibraryMagazine("VB Magazine", "UofL Mags", 2011, 14,
            "MA21 5V", 1, 1));

        // Add patrons
        patrons.Add(new LibraryPatron("Ima Reader", "12345"));
        patrons.Add(new LibraryPatron("Jane Doe", "11223"));
        patrons.Add(new LibraryPatron("John Smith", "54321"));
        patrons.Add(new LibraryPatron("James T. Kirk", "98765"));
        patrons.Add(new LibraryPatron("Jean-Luc Picard", "33456"));

        Console.WriteLine("List of items at start:\n");
        foreach (LibraryItem item in items)
            Console.WriteLine("{0}\n", item);
        Pause();

        // Check out some items
        items[0].CheckOut(patrons[0]);
        items[2].CheckOut(patrons[2]);
        items[5].CheckOut(patrons[1]);
        items[1].CheckOut(patrons[4]);
        items[3].CheckOut(patrons[3]);
        
        //Displays list of items after some where checked out 
        Console.WriteLine("List of items after checking some out:\n");
        foreach (LibraryItem item in items)
            Console.WriteLine("{0}\n", item);
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        Pause();
        

        // Holds results of LINQ to select items that are checked out 
        Console.WriteLine("List of items that are checked out:");
        var sortByCheckedOut =
            from i in items
            where i.IsCheckedOut() == true
            select i;

        foreach (var element in sortByCheckedOut)
            Console.WriteLine("{0}\n",element);

        
        Console.WriteLine("\nCount:{0}",items.Count);
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        Pause();

        // Holds results of LINQ to select items that are checked out that are MediaItems 
        Console.WriteLine("List of Media items that are checked out:");
        var sortByMediaItems =
           from i in sortByCheckedOut
           let mediaType = i as LibraryMediaItem
           select mediaType;

        foreach (var element in sortByMediaItems)
            Console.WriteLine("{0}\n", element);
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        Pause();

        // Holds results of LINQ to select magazines with unique titles 
        Console.WriteLine("List of unique Magazines:");
        var sortByMagTitle =
            from i in items
            let mediaType = i as LibraryMagazine
            orderby i.Title
            select mediaType;

        foreach (var element in sortByMagTitle)
            Console.WriteLine("{0}\n", element);
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        Pause();


        Console.WriteLine("Calculated late fees after {0} days late:\n", DAYSLATE);
        Console.WriteLine("{0,42} {1,11} {2,8}", "Title", "Call Number", "Late Fee");
        Console.WriteLine("------------------------------------------ ----------- --------");

        // Caluclate and display late fees for each item
        foreach (LibraryItem item in items)
            Console.WriteLine("{0,42} {1,11} {2,8:C}", item.Title, item.CallNumber,
                item.CalcLateFee(DAYSLATE));
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        Pause();

        // Return each item that is checked out
        foreach (LibraryItem item in items)
        {
            if (item.IsCheckedOut())
                item.ReturnToShelf();
        }

        Console.WriteLine("After returning all items:\n");
        foreach (LibraryItem item in items)
            Console.WriteLine("{0}\n", item);
        Console.WriteLine("\nCount:{0}", items.Count);
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        Pause();

        const int addLoan = 7; //Variable to hold days to add to loan period

        // Holds results of LINQ to select loan period and loan period plus 7 days  
        var sortLoanPeriod =
            from i in items
            let newLoan = i.LoanPeriod + addLoan
            orderby i.LoanPeriod, newLoan
            select new { i.LoanPeriod, newLoan };


        Console.WriteLine("D) LoanPeriod and newLoan by newLoan\n");
        Console.WriteLine("LoanPeriod        New Loan Period"); // Column Headers
        Console.WriteLine("-------------------- ---------");
        
        foreach (var i in sortLoanPeriod)
            Console.WriteLine("{0,-20} {1,9}", i.LoanPeriod, i.newLoan);
        Console.WriteLine();
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        Pause();

        Console.WriteLine("List of items at the end:\n");
        foreach (LibraryItem item in items)
            Console.WriteLine("{0}\n", item);
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        Pause();


    }

    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();

        Console.Clear(); // Clear screen
    }
}