// C# example of for loop 
// inport
using System;
using System.Windows.Forms;

// create namespace
namespace WindowsApplication1
{
    // create a form
    public partial class Form1 : Form
    {
        // create the form object
        public Form1()
        {
            // initialize the component
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // intialize an array of type string for the days in the week 
            string[] days = { "Sunday", "Monday", "TuesDay", "Wednesday", "Thursday", "Friday", "Saturday" };
            // intialize an array 
            string[] days = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            // iterate and probt 
            foreach (string day in days)
            {
            // print message 
                MessageBox.Show("The day is : " + day);
            }
        }
    } // end of the program
}
