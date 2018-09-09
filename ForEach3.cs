using System;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        // array of dates // string 
            string[] days = { "Sunday", "Monday", "TuesDay", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (string day in days)
            {
            // print day 
                MessageBox.Show("The day is : " + day);
            }
        }
        // end of program
        // 
    }
}

