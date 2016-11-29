// Program 3 
// CIS 200-01/02
// Spring 2016
// Due: 3/10/2016
// By: Jordan Johnson

//Edit patron form that allow you to select the patron which you would like to edit 
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
    public partial class EditPatron : Form
    {
        private List<LibraryPatron> patrons; // List of patrons

        public EditPatron(List<LibraryPatron> patronList)
        {
            InitializeComponent();
            // Precondition: None 
            // Postcondition: patrons is set to patrons list 

            patrons = patronList;


        }

        private void EditPatron_Load(object sender, EventArgs e)
        {
            //Displays patrons to combobox 
            foreach (LibraryPatron patron in patrons)
            editPatronComboBox.Items.Add(patron.PatronName + ", " + patron.PatronID);

            
        }

        internal int PatronIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected patron combo box has been returned
            get
            {
                return editPatronComboBox.SelectedIndex;
            }
        }

        // Precondition:  User clicked on okButton
        // Postcondition: User clicks OK to close form.
        private void editPatronButton_Click(object sender, EventArgs e)
        {
             this.DialogResult = DialogResult.OK; // Causes form to close and return OK result
        }

    }
}
