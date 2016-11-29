// Program 3 
// CIS 200-01/02
// Spring 2016
// Due: 3/10/2016
// By: Jordan Johnson

//Edit book form that allow you to select the book which you would like to edit 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class EditBook : Form
    {
        private List<LibraryItem> items; //List of Items 

        public EditBook(List<LibraryItem> itemList)
        {
            // Precondition: None 
            // Postcondition: items is set to items list 
            InitializeComponent();
            
            items = itemList;
        }
       
        internal int ItemIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected item combo box has been returned
            get
            {
                return editBookComboBox.SelectedIndex;
            }
        }

        private void EditBook_Load(object sender, EventArgs e)
        {
            
            List<LibraryItem> bookList; //List of Items 
            List<int> bookListIndices;
            bookList=new List<LibraryItem>();
            bookListIndices= new List<int>();
            
            for (int i = 0; i < items.Count(); ++i)
                if (items[i] is LibraryBook)// Is a Library Book 
                {
                    bookList.Add(items[i]); //Add to list 
                    bookListIndices.Add(i);
                }
                //Displays Items in combobox
                foreach (LibraryItem item in bookList)
                editBookComboBox.Items.Add(item.Title + ", " + item.CallNumber); 

        }
        // Precondition:  User clicked on okButton
        // Postcondition: User clicks OK to close form.
        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Causes form to close and return OK result
        }
    }
}
