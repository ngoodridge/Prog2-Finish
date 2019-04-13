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

    public partial class LetterForm : Form
    {
        const int MINCOMBOSELECTION = -1; //constant used for validation in the combo boxes

        //Pre-Condition: none
        //Post-Condition: The LetterForm GUI is prepared
        public LetterForm(List<Address> addresses)
        {
            InitializeComponent();

            foreach(Address a in addresses)
            {
                originCombo.Items.Add(a.Name);
                destCombo.Items.Add(a.Name);
            }
        }

        internal int OriginCombo
        {
            get { return originCombo.SelectedIndex; }

            set { originCombo.SelectedIndex = value; }
        }

        internal int DestCombo
        {
            get { return destCombo.SelectedIndex; }

            set { destCombo.SelectedIndex = value; }
        }

        //Pre-Condition: none
        //Post-Condition: The Value of the costBox is stored in the property
        internal string CostBox
        {
            get { return costBox.Text; }
            set { costBox.Text = value; }
        }

        //Pre-Condition: none
        //Post-Condition: The Value of the originCombo is not empty or the same as the desstCombo
        private void Origin_Validating(object sender, CancelEventArgs e)
        {

            if (originCombo.SelectedIndex == MINCOMBOSELECTION)
            {
                e.Cancel = true; // Stops focus changing process

                errorProvider1.SetError(originCombo, "Please select an Origin Address");
            }
            else
            {
                if (originCombo.SelectedIndex == destCombo.SelectedIndex)
                {
                    e.Cancel = true; // Stops focus changing process

                    errorProvider1.SetError(originCombo, "Origin and Destination Addresses cannot be the same");
                }
            }

        }

        //Pre-Condition: the OriginCombo has been validated
        //Post-condition: Any errors that may have been produced are cleared
        private void Origin_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(originCombo, ""); // Clears error message
        }

        //Pre-Condition: none
        //Post-Condition: The Value of the destCombo is not empty or the same as the originCombo
        private void Dest_Validating(object sender, CancelEventArgs e)
        {
            if (destCombo.SelectedIndex == MINCOMBOSELECTION)
            {
                e.Cancel = true; // Stops focus changing process

                errorProvider2.SetError(destCombo, "Please select an Destination Address");
            }
            else
            {
                if (originCombo.SelectedIndex == destCombo.SelectedIndex)
                {
                    e.Cancel = true; // Stops focus changing process

                    errorProvider2.SetError(destCombo, "Origin and Destination Addresses cannot be the same");
                }
            }
        }

        //Pre-Condition: the DestCombo has been validated
        //Post-condition: Any errors that may have been produced are cleared
        private void Dest_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(destCombo, ""); // Clears error message
        }

        //Pre-Condition: none
        //Post-Condition: A costBox contains a valid cost
        private void Cost_Validating(object sender, CancelEventArgs e)
        {
            int cost;
            const int MIN_COST = 0;

            if (String.IsNullOrWhiteSpace(costBox.Text))
            {
                e.Cancel = true; // Stops focus changing process

                errorProvider3.SetError(costBox, "Please enter a valid cost");
            }

            if (!int.TryParse(costBox.Text, out cost))
            {
                e.Cancel = true; // Stops focus changing process

                errorProvider3.SetError(costBox, "Please enter a valid cost");
            } 

            if (cost < MIN_COST)
            {
                e.Cancel = true; // Stops focus changing process

                errorProvider3.SetError(costBox, "Please enter a non-negative cost");
            }

        }

        //Pre-Condition: the costBox has been validated
        //Post-condition: Any errors that may have been produced are cleared
        private void Cost_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(costBox, ""); // Clears error message
        }

        //Pre-Condition: The OK button was clicked
        //Post-condition: The dialog form returns a dialog result of OK
        private void LetterOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        //Pre-Condition: The Cancel button was clicked
        //Post-condition: The dialog form returns a dialog result of Cancel
        private void LetterCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
