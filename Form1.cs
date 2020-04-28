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
* Date: 11/9/18
* Purpose: In Chapter 10, Answer Questions #5 and #6, Assignment #2 for Week 2 to create
* an application that displays bag items, their prices, the quantity ordered,
* the shipping charge and the total, as well as a submit and clear button.
*/
namespace BagOrderForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Purchase items button that will display the bag and price items, quantity and shipping charge.
                string bagItem = "";
                if (listBox1.SelectedIndex != -1)
                {
                    bagItem += 50;
                    bagItem = listBox1.SelectedItem.ToString();
                }
                if (listBox1.SelectedIndex != -1)
                {
                    bagItem += 45;
                    bagItem = listBox1.SelectedItem.ToString();
                }
                if (listBox1.SelectedIndex != -1)
                {
                    bagItem += 40;
                    bagItem = listBox1.SelectedItem.ToString();
                }
                if (listBox1.SelectedIndex != -1)
                {
                    bagItem += 25;
                    bagItem = listBox1.SelectedItem.ToString();
                }
                if (listBox1.SelectedIndex != -1)
                {
                    bagItem += 80;
                    bagItem = listBox1.SelectedItem.ToString();
                }
                if (listBox1.SelectedIndex != -1)
                {
                    bagItem += 20;
                    bagItem = listBox1.SelectedItem.ToString();
                }


                string quantity = listBox1.Text;
                comboBox1.Items.Add(quantity);

                if (comboBox1.SelectedIndex != -1)
                {
                    quantity = comboBox1.SelectedItem.ToString();
                }

                int percentage = 0;
                if (this.radioButton1.Checked)
                {
                    percentage += 10;
                }
                if (this.radioButton2.Checked)
                {
                    percentage += 7;
                }
                if (this.radioButton3.Checked)
                {
                    percentage += 5;
                }

            //int firstCost = (Convert.ToInt16(bagItem) * (Convert.ToInt16(quantity)));
            //int totalCost = firstCost / percentage;

            MessageBox.Show("ITEMS PURCHASED!" + "\n" +
                "Bag Item and Price: " + bagItem + "\n" +
                "Item quantity: " + quantity + "\n" +
                String.Format("Shipping charge: {0}%", percentage) + "\n" +
                "Total cost: ${0}"); //+ Convert.ToInt16(totalCost));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear(); //clear selected item in listbox
            comboBox1.SelectedIndex = -1; //clear selected item and not all items in combobox
            radioButton1.Checked = false; //clear items check in radiobuttons
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
    }
}
