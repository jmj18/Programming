//Jordan Johnson
//CIS200-01
//Due 2/3/16
// Program 0
// Starting Point

// File: Program.cs
// This file creates a simple test application class that creates
// an array of LibraryBook objects and tests them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main(string[] args)
    {
        List<LibraryBook> book = new List<LibraryBook>();

        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            2010, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2000, "AG773 ZF"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1985, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            -1, "ZZ24 4F");    // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2001, "AE842 7A"); // 5th test book

        List<LibraryPatron> patron = new List<LibraryPatron>();//List of three Library Patron objects 

        LibraryPatron patron1 = new LibraryPatron("Bob", "123");
        LibraryPatron patron2 = new LibraryPatron("Sally", "456");
        LibraryPatron patron3 = new LibraryPatron("Brad", "789");
        
       
        LibraryBook[] theBooks = { book1, book2, book3, book4, book5 }; // Test array of books

        Console.WriteLine("Original list of books");
        PrintBooks(theBooks);

        // Make changes
        book1.CheckOut(patron1);//Book checked out by patron1
        book2.Publisher = "Borrowed Books";
        book3.CheckOut(patron2); //Book checked out by patron2
        book4.CallNumber = "AB123 4A";
        book5.CheckOut(patron3); //Book checked out by patron3

        Console.WriteLine("After changes");
        PrintBooks(theBooks);

        // Return all the books
        for (int i = 0; i < theBooks.Length; ++i)
            theBooks[i].ReturnToShelf();

        Console.WriteLine("After returning the books");
        PrintBooks(theBooks);
    }

    // Precondition:  None
    // Postcondition: The books have been printed to the console
    public static void PrintBooks(LibraryBook[] books)
    {
        foreach (LibraryBook b in books)
        {
            Console.WriteLine(b);
            Console.WriteLine();
        }
    }
}
