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
    public partial class Prog2Form : Form
    {
        private UserParcelView userParcelView;  //The UserPacelView Instance Variable.

        //Pre-Condition: none.
        //Post-Condition: The Prog2Forms GUI is prepared and test data is added to
        //                the addresses and parcel lists.
        public Prog2Form()
        {
            InitializeComponent();

            userParcelView = new UserParcelView();  //initializes the UserParcelView instance

            //addresses test data
            userParcelView.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            userParcelView.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            userParcelView.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            userParcelView.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            userParcelView.AddAddress("Nicholas Goodridge", "1234 1st Street", "Apt #207",
                "Louisville", "KY", 12345);

            //parcels test data
            userParcelView.AddLetter(userParcelView.AddressAt(1), userParcelView.AddressAt(2), 1.00M);
            userParcelView.AddLetter(userParcelView.AddressAt(0), userParcelView.AddressAt(3), 0.65M);
            userParcelView.AddLetter(userParcelView.AddressAt(4), userParcelView.AddressAt(1), 2.35M);
        }

        //Pre-Condition:The "About" menu item is clicked
        //Post-Condition: The About dialog form is displayed
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About(); //A new instance of the aboutForm is created

            aboutForm.ShowDialog(); //aboutForm is displayed as a dialog box
        }

        //Pre-Condition:The "Exit" menu item is clicked
        //Post-Condition: The Prog2Form is closed
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Pre-Condition:The "Address" menu item is clicked
        //Post-Condition: The Address form is displayed as a dialog box
        //                and if the OK button was clicked,the contents
        //                are used to create a new address and added to addresses
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(); //The Address form instnace is created 
            DialogResult result;  //variable to hold the result of the dialog
            result = addressForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                userParcelView.AddAddress(addressForm.NameBox, addressForm.AddressBox1, addressForm.AddressBox2,
                    addressForm.CityBox, addressForm.StateCombo, int.Parse(addressForm.ZipBox));
            }

        }

        //Pre-Condition:The "Letter" menu item is clicked
        //Post-Condition: The LetterForm is displayed as a dialoge and if the 
        //                result is OK a letter is added to parcels
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LetterForm letterForm = new LetterForm(userParcelView.addresses); //instance of the letter form is created
            DialogResult result;  //varibale to hold the result of the dialog
            result =letterForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                    userParcelView.AddLetter(userParcelView.addresses[letterForm.OriginCombo], userParcelView.addresses[letterForm.DestCombo], int.Parse(letterForm.CostBox));
            }
        }

        //Pre-Condition:The "List Addresses" menu item is clicked
        //Post-Condition: The contents of the addresses list is printed to the textbox
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox1.Clear(); //clears the text box before adding new data
            textBox1.Text = string.Join($"{Environment.NewLine}------------------------------------{Environment.NewLine}", userParcelView.addresses);
        }

        //Pre-Condition:The "List Parcels" menu item is clicked
        //Post-Condition: The contents of the parcels list is printed to the textbox
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); //clears the textbox before adding more data
            textBox1.Text = string.Join($"{Environment.NewLine}------------------------------------{Environment.NewLine}", userParcelView.parcels);
        }
    }
}
