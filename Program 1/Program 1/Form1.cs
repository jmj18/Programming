//Jordan Johnson
//Program 1
//Due:2/16/15
//CIS:199-01
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class program1 : Form
    {
        public program1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double squareFtPerGallon=325; // Constant declared of 325 sqft per gallon of paint. 
            const int laborPerGallon=8; // Constant declared of 8 hours of labor per gallon of paint.
            const double laborPerHour = 10.50; // Constant declared of $10.50 per hour for labor.

            double squareFtWallSpace; //Variable declared to hold the sqft of wall space.
            double coatsOfPaint; // Variable declared to hold number of coast of paint desired. 
            double totalSqFtPainted; // Variable declared to hold the total sqft painted.
           
            // Parsed squareFtTextbox and desiredCoatsTextbox
            // Variable totalSqFtPainted to equal sqft wall space times coats of paint.
            // Displayed to totalSqFtOutputLabel.
            squareFtWallSpace = int.Parse(squareFeetTextbox.Text);
            coatsOfPaint = int.Parse(desiredCoatsTextbox.Text);
            totalSqFtPainted = squareFtWallSpace * coatsOfPaint;
            totalSqFtOutputLabel.Text = totalSqFtPainted.ToString("n1");
            
            double gallonOfPaintRequired; //Variable declared to hold the gallons of paint required.

            // Variable gallonOfPaintRequired to equal total SqFt Painted divided by Sqft per gallon.
            // Display to gallonsRequiredOutputLabel
            gallonOfPaintRequired = Math.Ceiling(totalSqFtPainted / squareFtPerGallon);
            gallonsRequiredOutputLabel.Text = gallonOfPaintRequired.ToString("n0");

            double hoursOfLaborRequired;//Variable declared to hold the hours of labor required. 
           
            // Variable hoursOfLaborRequired to equal total SqFt Painted divided by Sqft per gallon times labor per gallon.
            //Displayed to hoursRequiredOutputLabel.
            hoursOfLaborRequired = ((totalSqFtPainted / squareFtPerGallon)*laborPerGallon);
            hourRequiredOutputLabel.Text = hoursOfLaborRequired.ToString("n1");

            double pricePerGallonOfPaint;//Variable declared to hold price per gallon of paint. 
            double totalCostOfPaint; // Variable to hold the total cost of paint.
           
            //Parsed pricePerGallonTextbox to double.
            //Variable totalCostOfPaint equal to gallons of paint required times price per gallon of paint .
            //display to costOfPaintOutputLabel.
            pricePerGallonOfPaint = double.Parse(pricePerGallonTextbox.Text);
            totalCostOfPaint = gallonOfPaintRequired * pricePerGallonOfPaint;
            costOfPaintOutputLabel.Text = totalCostOfPaint.ToString("c");

            double totalCostOfLabor; //Variable declared to hold total cost of labor.
           
            //Variable totalCostOfLabor to equal hours of labor required times the labor per hour.
            //Display to costOfLaborOutputLabel.
            totalCostOfLabor = hoursOfLaborRequired * laborPerHour;
            costOfLaborOutputLabel.Text = totalCostOfLabor.ToString("c");

            double totalCostofJob; // Variable declared to hold the total cost of the job. 
            
            //Variable totalCostofJob to equal total cost of paint plus total cost of labor.
            //Display to totalCostOutputLabel.
            totalCostofJob = totalCostOfPaint + totalCostOfLabor;
            totalCostOutputLabel.Text = totalCostofJob.ToString("c");






       
        }
    }
}
