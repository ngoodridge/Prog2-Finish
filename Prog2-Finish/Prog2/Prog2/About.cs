//Program 2
//CIS 200-01
//Fall 2018
//Due: 10/24/2018
//By: D7184

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class About : Form
    {
        //Pre-Condition: none
        //Post-Condition: The AboutForm GUI is prepared
        public About()
        {
            InitializeComponent();
        }

        //Pre-Condition: The OK button is clicked
        //Post-Condition: The AboutForm is closed
        private void button1_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
