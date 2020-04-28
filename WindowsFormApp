using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
/*Programmer: Corin
 * Date: 12/7/18
 * Assignment: Create a Books database to include two tables Book Table and a Course Book Table.
 * The Book Table should have fields for ISBN number, title, copyright date, primary author, publisher,
 * and number of pages.
 * The Course book table should have fields for course number and ISBN.
 * Populate thte tables with books in your current collection, including books from your classes.
 * Display the course number and the ISBN and the name of the book on the same screen.*/
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private DataSet _ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            _ds = new DataSet();

            try
            {
                conn.ConnectionString =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Books.accdb;Persist Security Info = False;";

                conn.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                string query = "SELECT BookTable.ISBN, BookTable.Title, CourseBookTable.CourseNumber FROM BookTable INNER JOIN CourseBookTable ON BookTable.ISBN=CourseBookTable.ISBN;";
                command.CommandText = query;

                var oledbAdapter = new OleDbDataAdapter(command);
                oledbAdapter.Fill(_ds, "xxx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
                if (conn != null)
                    conn.Close();
            }

            dataGridView.DataSource = _ds;
            dataGridView.DataMember = "xxx";
            dataGridView.Refresh();

            //DataReader - read only, and connected always to db
            //DataSet - read/write, can be disconnected
        }
    }
}
