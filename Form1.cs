using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/* Programmer: Corin
  * Date: 11/27/18
 * Purpose: In Chapter 13, Answer Question #9. Write a graphical user application that accepts employee data to include
 * employee name, number, pay rate, and number of hours worked. Pay is to be computed as follows: Hours over 40 recieve time-and-a-half pay.
 * Store the employee name, number and the total amount of pay (prior to deductions) in a text file. Close the file and then, in the same application, 
 * retrieve the stored values and displau the employeee name and the formatted total pay. The application should allow the user to browse to the file location
 * for saving and retrieving the file.
 */
namespace graphicalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //required user informatiion then,
        //save all information entered into textbox and allow them to open it in a text file
        private void button1_Click(object sender, EventArgs e) 
        {
            StreamWriter txt;
            txt = new StreamWriter("employeeData.txt", true); //the name of the file the information will be saved
            txt.WriteLine();
            txt.Write("Employee name: " + textBox1.Text);
            txt.WriteLine();
            txt.Write("Employee number: " + textBox2.Text);
            txt.WriteLine();
            txt.Write("Total pay: $" + textBox5.Text);
            txt.WriteLine();
            txt.Close();
            //display message after information is saved
            MessageBox.Show("Your file has been saved in the employeeData.txt file on your computer!");
        }
        //get employee name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string employeeName = textBox1.Text;
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //int employeeNumber = Convert.ToInt16(textBox2.Text);
        }
        //get employee number and allow the box to accept numbers only
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {  
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //get pay rate and allow the box to accept numbers only
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           //int payRate = Convert.ToInt16(textBox3.Text);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //get number of hours and allow the box to accept numbers only
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //int numOfHours = Convert.ToInt16(textBox4.Text);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //multiply the pay rate and number of hours worked
        //if worked more than forty hours than multiply by 1.5
        //if worked less than forty horus then multiply the hours by the regular payrate
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Multiply();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Multiply();
        }

        public void Multiply()
        {
            int payRate;
            int numOfHours;

            bool ispayRateValid = int.TryParse(textBox3.Text, out payRate);
            bool isnumOfHoursValid = int.TryParse(textBox4.Text, out numOfHours);

            if (numOfHours > 40)
            {
                textBox5.Text = (payRate * 1.5).ToString();
            }
            else
            {
                textBox5.Text = (numOfHours * payRate).ToString();
            }
        }
    }
}
