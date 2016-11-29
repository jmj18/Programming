//Jordan Johnson
//CIS 199-01
//Program 4
//Due:4/26/15

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    public partial class Program4 : Form
    {
        //list to hold GroundPackage object 
       List<GroundPackage> packageList = new List<GroundPackage>();
        public Program4()
        {
            InitializeComponent();
        }

        const int minZip = 00000;//Minimum zip value for validation
        const int maxZip = 99999;//Maximum zip value for validation
            
            int originZip;//variable to hold originzip
            int destinationZip;//variable to hold destinationzip
            double length;//variable to hold length 
            double width;//variable to hold width 
            double height;//variable to hold height
            double weight;//variable to hold weight
            // Precondition:  User clicked on ADD button
            // Postcondition: If user's input in the six textboxes, all six are parsed and validated and added to ground package object.
        private void addButton_Click(object sender, EventArgs e)
        {
            //All six textboxes are parsed to a string 
                if (int.TryParse(originZipTextBox.Text, out originZip) && int.TryParse(destinZipTextBox.Text, out destinationZip)
                && double.TryParse(lengthTextBox.Text, out length) && double.TryParse(widthTextBox.Text, out width)
                && double.TryParse(heightTextBox.Text, out height) && double.TryParse(weightTextBox.Text, out weight))
            {
                if (originZip <= minZip && originZip > maxZip)
                {
                    MessageBox.Show("Invaild Origin Zip");
                    return;
                }
                if (destinationZip <= minZip && destinationZip > maxZip)
                {
                    MessageBox.Show("Invaid Destination Zip");
                    return;
                }
                if (length <= 0)
                {
                    MessageBox.Show("Length must be >0");
                    return;
                }
                if (width <= 0)
                {
                    MessageBox.Show("Width must be >0");
                    return;
                }
                if (height <= 0)
                {
                    MessageBox.Show("Height must be >0");
                    return;
                }
                if (weight <= 0)
                {
                    MessageBox.Show("Weight must be >0");
                    return;
                }
                //Groundpackage object created as my package with data from and six textboxes stored as its data  
               GroundPackage mypackage = new GroundPackage(originZip, destinationZip, length, width, height, weight);
                    packageList.Add(mypackage);//mypackage added to package list 

                    //Price from method calcCost stored in package listbox
                    packageListbox.Items.Add(mypackage.CalcCost().ToString("C"));
                }
            }
        // Precondition:  User clicked on Details button
        // Postcondition: Details from selected item from listbox are displayed in a messagebox
        private void detailsButton_Click(object sender, EventArgs e)
        {
          int index = packageListbox.SelectedIndex;//index set to equal selected item from listbox 
          if (index != -1)
          {
              MessageBox.Show(packageList[index].ToString());//if value is not equal to -1 display details 
          }
          else
          {
              MessageBox.Show("Please Select Package in Listbox");//otherwise display error message 
          }
        }
        // Precondition:  User clicked on From uofl button
        // Postcondition: origin zip code is changed to uofl zip code
        private void fromButton_Click(object sender, EventArgs e)
        {
            const int uofl = 40492;//Constant to hold uofl zip code

            int index = packageListbox.SelectedIndex;//if value is not equal to -1 change origin zip to uofl zip code
              if (index != -1)
              {
                  packageList[index].OriginZip = uofl;
                  packageListbox.Items[index] = packageList[index].CalcCost().ToString("c");//adjust pricing from change in zip code
              }


        }
        // Precondition:  User clicked on To uofl button
        // Postcondition: destination zip code is changed to uofl zip code
        private void toButton_Click(object sender, EventArgs e)
        {
            const int uofl = 40492;//Constant to hold uofl zip code


            int index = packageListbox.SelectedIndex;//if value is not equal to -1 change destination zip to uofl zip code
            if (index != -1)
            {
                packageList[index].DestinZip = uofl;
                packageListbox.Items[index] = packageList[index].CalcCost().ToString("c");//adjust pricing from change in zip code
            }
        }








        }
    }


