//Program 2
//CIS 200-01
//Fall 2018
//Due: 10/24/2018
//By: D7184

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class AddressForm : Form
    {
        //Pre-Condition: none
        //Post-Condition: The AddressForm GUI is prepared
        public AddressForm()
        {
            InitializeComponent();
        }

        //Pre-Condition: none
        //Post-Condition: The Value of the nameBox is stored in the property
        internal string NameBox
        {
            get { return nameBox.Text; }
            set { nameBox.Text = value; }
        }

        //Pre-Condition: none
        //Post-Condition: The Value of addressBox1 is stored in the property
        internal string AddressBox1
        {
            get { return addressBox1.Text; }
            set { addressBox1.Text = value; }
        }

        //Pre-Condition: none
        //Post-Condition: The Value of addressBox2 is stored in the property
        internal string AddressBox2
        {
            get { return addressBox2.Text; }
            set { addressBox2.Text = value; }
        }

        //Pre-Condition: none
        //Post-Condition: The Value of the cityBox is stored in the property
        internal string CityBox
        {
            get { return cityBox.Text; }
            set { cityBox.Text = value; }
        }

        //Pre-Condition: none
        //Post-Condition: The Value of the stateCombo is stored in the property
        internal string StateCombo
        {
            get { return stateCombo.Text; }
            set { stateCombo.Text = value; }
        }

        //Pre-Condition: none
        //Post-Condition: The Value of the zipBox is stored in the property
        internal string ZipBox
        {
            get { return zipBox.Text; }
            set { stateCombo.Text = value; }
        }

        //Pre-Condition: none
        //Post-Condition: The nameBox contains a valid Name
        private void NameBox_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(nameBox.Text))
            {
                e.Cancel = true; // Stops focus changing process

                errorProvider1.SetError(nameBox, "Please enter a name");
            }
        }

        //Pre-Condition: none
        //Post-Condition: Any error that may have been produced is cleared
        private void NameBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameBox, ""); // Clears error message
        }

        //Pre-Condition: none
        //Post-Condition: The addressBox contains a valid Address
        private void AddressBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(addressBox1.Text))
            {
                e.Cancel = true; // Stops focus changing process

                errorProvider2.SetError(addressBox1, "Please enter an address");
            }
        }

        //Pre-Condition: none
        //Post-Condition: Any error that may have been produced is cleared
        private void AddressBox_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(addressBox1, ""); // Clears error message
        }

        //Pre-Condition: none
        //Post-Condition: The cityBox contains a valid City
        private void CityBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cityBox.Text))
            {
                e.Cancel = true; // Stops focus changing process

                errorProvider3.SetError(cityBox, "Please enter a city");
            }
        }

        //Pre-Condition: none
        //Post-Condition: Any error that may have been produced is cleared
        private void CityBox_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(cityBox, ""); // Clears error message
        }

        //Pre-Condition: none
        //Post-Condition: The stateCombo contains a valid State
        private void State_Validating(object sender, CancelEventArgs e)
        {
            const int MINCOMBOSELECTION = -1;
            if (stateCombo.SelectedIndex == MINCOMBOSELECTION)
            {
                e.Cancel = true; // Stops focus changing process

                errorProvider4.SetError(stateCombo, "Please select a state");
            }
        }

        //Pre-Condition: none
        //Post-Condition: Any error that may have been produced is cleared
        private void State_Validated(object sender, EventArgs e)
        {
            errorProvider4.SetError(stateCombo, ""); // Clears error message
        }

        //Pre-Condition: none
        //Post-Condition: The ZipBox contains a valid Zip Code
        private void Zip_Validating(object sender, CancelEventArgs e)
        {
            int zip;
            const int  MAX_ZIP = 99999;
            const int MIN_ZIP = 0;

            if (String.IsNullOrWhiteSpace(zipBox.Text))
            {
                e.Cancel = true; // Stops focus changing process

                errorProvider5.SetError(zipBox, "Please enter a Zip Code");
            }

            if (!int.TryParse(zipBox.Text, out zip))
            {
                e.Cancel = true; // Stops focus changing process

                errorProvider5.SetError(zipBox, "Please enter a valid Zip Code");
            }
            else
            {
                if(zip < MIN_ZIP || zip > MAX_ZIP)
                {
                    e.Cancel = true; // Stops focus changing process

                    errorProvider5.SetError(zipBox, "Please enter a valid Zip Code");
                }

            }
        }

        //Pre-Condition: none
        //Post-Condition: Any error that may have been produced is cleared
        private void Zip_Validated(object sender, EventArgs e)
        {
            errorProvider5.SetError(zipBox, ""); // Clears error message
        }

        //Pre-Condition: The OK button was clicked
        //Post-Condition: The dialog form returns a dialog result of OK
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        //Pre-Condition: The Cancel button was clicked
        //Post-Condition: The Address form is closed
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
