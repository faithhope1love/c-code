using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Programmer: Corin
* Date: 12/8/18
* Purpose: In Chapter 15 create a web application that enables the user to enter first name,
* last name, and e-mail address. Accept those values and store them in a text box. Allow 
* the user to input the path where the file should be stored. Then display the file on
* a webpage.
*/
namespace webApp
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream myFile;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter saveFile = new StreamWriter(saveFileDialog1.FileName))
                {
                    saveFile.Write(textBox1.Text + "\n");
                    saveFile.Write(textBox2.Text + "\n");
                    saveFile.Write(textBox3.Text + "\n");

                    MessageBox.Show("Your information has been saved!");
                }

                foreach (var line in File.ReadAllLines(saveFileDialog1.FileName))
                {
                    listBox1.Items.Add(line);
                }

                if ((myFile = saveFileDialog1.OpenFile()) != null)
                {
                    myFile.Close();
                }
            }
        }
    }
}
