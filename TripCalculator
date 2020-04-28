using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Programmer: Corin
 * Date: 11/2/18
 * Purpose: For Assignment #1, Chapter 9 on page 590 Problem #5 create a Trip Calculator that
 * displays the trip destination, miles traveled, gallons of gas used and the total
 * miles per gallon for the trip.
 */
namespace TripCalculator
{
    public partial class TripCalc : Form
    {
        public TripCalc()
        {
            InitializeComponent();
        }

        //Enter button functions
        //Entered functions will display the total of gas and miles used for whereever you traveled to.
        private void button1_Click(object sender, EventArgs e)
        {
            Double MilesTraveled;
            Double GallonsOfGasConsumed;
            Double MPG;

            MilesTraveled = Convert.ToDouble(textBox2.Text);
            GallonsOfGasConsumed = Convert.ToDouble(textBox3.Text);
            MPG = MilesTraveled / GallonsOfGasConsumed;

            label4.Text = "Your total MPG for the trip was " + MPG.ToString() + ".";
        }
        //Clear button functions
        //Clear all entered text as well as the results
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label4.Text = "MPG: ";
        }
    }
}
