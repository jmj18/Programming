// Program 3 
// CIS 200-01/02
// Spring 2016
// Due: 3/10/2016
// By: Jordan Johnson
// Using Part 2 By: Andrew Wright

// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Patron and
// Book items, an Item menu with Check Out and Return items, and a
// Report menu with Patron List, Item List, and Checked Out Items items.
// Extra Credit - Check Out and Return only show relevant items
// Allows you to save and open a library 
// Allows you to edit current patrons and books in the library 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace LibraryItems
{
    
    public partial class Prog2Form : Form
    {

        private Library lib; // The library
        // object for deserializing RecordSerializable in binary format
        private BinaryFormatter formatter = new BinaryFormatter();
        private FileStream output;
        private StreamReader fileReader;

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test items and patrons
        //                are added to the library
        public Prog2Form()
        {
            InitializeComponent();

            lib = new Library(); // Create the library

           
        }
        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Program 2{0}By: Andrew L. Wright{0}" +
                "CIS 200-01/02{0}Spring 2016", System.Environment.NewLine), "About Program 2");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Report, Patron List menu item activated
        // Postcondition: The list of patrons is displayed in the reportTxt
        //                text box
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryPatron> patrons; // List of patrons

            patrons = lib.GetPatronsList();

            result.Append(String.Format("Patron List - {0} patrons", lib.GetPatronCount()));
            result.Append(System.Environment.NewLine); // Remember, \n doesn't always work in GUIs
            result.Append(System.Environment.NewLine);

            foreach (LibraryPatron p in patrons)
            {
                result.Append(p.ToString());
                result.Append(System.Environment.NewLine);
                result.Append(System.Environment.NewLine);
            }

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Item List menu item activated
        // Postcondition: The list of items is displayed in the reportTxt
        //                text box
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String

            List<LibraryItem> items;     // List of library items

            items = lib.GetItemsList();
            result.Append(String.Format("Item List - {0} items", lib.GetItemCount()));
            result.Append(System.Environment.NewLine); // Remember, \n doesn't always work in GUIs
            result.Append(System.Environment.NewLine);

            foreach (LibraryItem item in items)
            {
                result.Append(item.ToString());
                result.Append(System.Environment.NewLine);
                result.Append(System.Environment.NewLine);
            }

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Checked Out Items menu item activated
        // Postcondition: The list of checked out items is displayed in the
        //                reportTxt text box
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String

            List<LibraryItem> items;     // List of library items

            items = lib.GetItemsList();

            // LINQ: selects checked out items
            var checkedOutItems =
                from item in items
                where item.IsCheckedOut()
                select item;

            result.Append(String.Format("Checked Out Items - {0} items", checkedOutItems.Count()));
            result.Append(System.Environment.NewLine); // Remember, \n doesn't always work in GUIs
            result.Append(System.Environment.NewLine);

            foreach (LibraryItem item in checkedOutItems)
            {
                result.Append(item.ToString());
                result.Append(System.Environment.NewLine);
                result.Append(System.Environment.NewLine);
            }

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Insert, Patron menu item activated
        // Postcondition: The Patron dialog box is displayed. If data entered
        //                are OK, a LibraryPatron is created and added to the library
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); // The patron dialog box form

            DialogResult result = patronForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                // Use form's properties to get patron info to send to library
                lib.AddPatron(patronForm.PatronName, patronForm.PatronID);
            }

            patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Insert, Book menu item activated
        // Postcondition: The Book dialog box is displayed. If data entered
        //                are OK, a LibraryBook is created and added to the library
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(); // The book dialog box form

            DialogResult result = bookForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // Use form's properties to get book info to send to library
                    lib.AddLibraryBook(bookForm.ItemTitle, bookForm.ItemPublisher, int.Parse(bookForm.ItemCopyrightYear),
                        int.Parse(bookForm.ItemLoanPeriod), bookForm.ItemCallNumber, bookForm.BookAuthor);
                }

                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Item, Check Out menu item activated
        // Postcondition: The Checkout dialog box is displayed. If data entered
        //                are OK, an item is checked out from the library by a patron
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Extra Credit - Only display items that aren't already checked out

            List<LibraryItem> notCheckedOutList; // List of items not checked out
            List<int> notCheckedOutIndices;      // List of index values of items not checked out
            List<LibraryItem> items;             // List of library items
            List<LibraryPatron> patrons;         // List of patrons

            items = lib.GetItemsList();
            patrons = lib.GetPatronsList();

            items = lib.GetItemsList();
            patrons = lib.GetPatronsList();
            notCheckedOutList = new List<LibraryItem>();
            notCheckedOutIndices = new List<int>();

            for (int i = 0; i < items.Count(); ++i)
                if (!items[i].IsCheckedOut()) // Not checked out
                {
                    notCheckedOutList.Add(items[i]);
                    notCheckedOutIndices.Add(i);
                }

            if ((notCheckedOutList.Count() == 0) || (patrons.Count() == 0)) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(notCheckedOutList, patrons); // The check out dialog box form

                DialogResult result = checkoutForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items

                        itemIndex = notCheckedOutIndices[checkoutForm.ItemIndex]; // Look up index from full list
                        lib.CheckOut(itemIndex, checkoutForm.PatronIndex);
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Check Out Index!", "Check Out Error");
                    }
                }

                checkoutForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Item, Return menu item activated
        // Postcondition: The Return dialog box is displayed. If data entered
        //                are OK, an item is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Extra Credit - Only display items that are already checked out

            List<LibraryItem> checkedOutList; // List of items checked out
            List<int> checkedOutIndices;      // List of index values of items checked out
            List<LibraryItem> items;          // List of library items
            List<LibraryPatron> patrons;      // List of patrons

            items = lib.GetItemsList();
            patrons = lib.GetPatronsList();
            checkedOutList = new List<LibraryItem>();
            checkedOutIndices = new List<int>();
            
            for (int i = 0; i < items.Count(); ++i)
                if (items[i].IsCheckedOut()) // Checked out
                {
                    checkedOutList.Add(items[i]);
                    checkedOutIndices.Add(i);
                }

            if ((checkedOutList.Count() == 0)) // Must have checked out items
                MessageBox.Show("Must have checked out items to return!", "Return Error");
            else
            {
                ReturnForm returnForm = new ReturnForm(checkedOutList); // The return dialog box form

                DialogResult result = returnForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items

                        itemIndex = checkedOutIndices[returnForm.ItemIndex]; // Look up index from full list
                        lib.ReturnToShelf(itemIndex);
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Return Index!", "Return Error");
                    }
                }
                returnForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  File, Open Library menu item activated
        // Postcondition: The Open File dialog box is displayed. If File selected
        //                is OK, file will open.
        private void openLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create and show dialog box enabling user to open file
            DialogResult result; // result of OpenFileDialog
            string filename; // name of file containing data

            //Precondition:User clicks open Library 
            //Postcondition:User selects a file 
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                filename = fileChooser.FileName;// get specified name
            }
            // show error if user specified invalid file
            if (filename == string.Empty)
                MessageBox.Show("Invalid File Name");

            else
            {
                try
                {
                    // create FileStream to obtain read access to file
                    FileStream input = new FileStream(filename, FileMode.Append, FileAccess.Read);

                    fileReader = new StreamReader(input);
                }
                catch (IOException)
                {
                    MessageBox.Show("Error reading from file",
                       "File Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }







        // Precondition:  File, Save Library menu item activated
        // Postcondition: The Save File dialog box is displayed. Path is selected 
        //                and library object is saved to a file. 
        private void saveLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;// create and show dialog box enabling user to save file
            string filename;// name of file to save data

            

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;// let user create file

                // retrieve the result of the dialog box
                result = fileChooser.ShowDialog();
                filename = fileChooser.FileName;
            }
            // ensure that user clicked "OK"
            if (result == DialogResult.OK)
            {
                // show error if user specified invalid file
                if (filename == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // save file via FileStream if user specified valid file
                    try
                    {
                        // open file with write access
                        output = new FileStream(filename, FileMode.Append, FileAccess.Write);
                        //lib selected to be serialized 
                        formatter.Serialize(output, lib);  
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error Opening File", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                
            }
            
                   

        }

        // Precondition:  Edit, Patron menu item activated
        // Postcondition: The edit patron dialog box is displayed.  
        //                and a patron can be selected from the combobox 
        private void patronToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            List<LibraryPatron> patrons;//List of Patrons 

            patrons = lib.GetPatronsList();

            
          //Opens editPatron dialog box
            EditPatron editPatron = new EditPatron(patrons);

            DialogResult result = editPatron.ShowDialog();

            int PatronIndex;
            PatronIndex=editPatron.PatronIndex;//Get the index of the editpatron combobox

            //Precondition:User selects a patron 
            //Postcondition: Patron infomration is set to patron form textboxes 
            if (result == DialogResult.OK)
            {
                LibraryPatron patron = lib._patrons[PatronIndex]; //sets patron to patron index 

                PatronForm patronForm = new PatronForm(); // Opens the patron dialog box form

                patronForm.PatronName = patron.PatronName;//Sets textboxs to have information from selected patron 
                patronForm.PatronID = patron.PatronID;

                
                DialogResult result2 = patronForm.ShowDialog();

                //Precondition:User clicks ok on patron form 
                //Postcondition:Populates list with new patron information
                if (result2 == DialogResult.OK)
                {
                    patron.PatronName = patronForm.PatronName;//Sets list to equal new edited patron
                    patron.PatronID = patronForm.PatronID;
                }
            }

        }

        // Precondition:  Edit, book menu item activated
        // Postcondition: The edit book dialog box is displayed.  
        //                and a book can be selected from the combobox
        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items; //List of Library Items 
           
           items=lib.GetItemsList();
           


            EditBook editBook = new EditBook(items);//opens edit book dialogbox

            DialogResult result = editBook.ShowDialog();
            
            int bookIndex;
            bookIndex=editBook.ItemIndex;//sets bookindex to book index from combobox

            //Precondition:User clicks ok on Book Form
            //Postcondition: Populates list with new book information 
            if (result == DialogResult.OK)
            {
                LibraryBook book = (LibraryBook)lib._items[bookIndex];

                BookForm bookform = new BookForm();//book form dialog box is opened 

                //Sets textboxs to have information from selected book 
                bookform.ItemTitle = book.Title;
                bookform.ItemPublisher = book.Publisher;
                bookform.ItemCopyrightYear = book.CopyrightYear.ToString();
                bookform.ItemLoanPeriod = book.LoanPeriod.ToString();
                bookform.ItemCallNumber = book.CallNumber;
                bookform.BookAuthor = book.Author;
                
                DialogResult result2 = bookform.ShowDialog();

                //Precondition:User selects a book 
                //Postcondition: book information is set to book form textboxes
                if (result2 == DialogResult.OK)
                {
                    book.Title = bookform.ItemTitle;
                    book.Publisher = bookform.ItemPublisher;
                    book.CopyrightYear = int.Parse(bookform.ItemCopyrightYear);
                    book.LoanPeriod = int.Parse(bookform.ItemLoanPeriod);
                    book.CallNumber = bookform.ItemCallNumber;
                    book.Author = bookform.BookAuthor;
                }

                    

            }
            

        }
    }
}

