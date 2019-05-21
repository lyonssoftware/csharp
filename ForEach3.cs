using System;
using System.Windows.Forms;

namespace WindowsApplication1
{
    // create a form
    public partial class Form1 : Form
    {
        // create form 
        public Form1()
        {
            // intialize
            // the component
            InitializeComponent();
        }
p
        private void button1_Click(object sender, EventArgs e)
        {
        // array of days
            string[] days = { "Sunday", "Monday", "TuesDay", "Wednesday", "Thursday", "Friday", "Saturday" };
            // iterate and probt 
            foreach (string day in days)
            {
            // print message 
                MessageBox.Show("The day is : " + day);
            }
        }
    } // end of the program
}
