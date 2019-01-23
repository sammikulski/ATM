/*Project 2 - ATM
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski
*This form validates the name and PIN associated with the 
*account number from frmAccountLookup
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class frmNameAndPin : Form
    {
        public frmNameAndPin()
        {
            InitializeComponent();
            //sets cursor on the txtName
            txtName.Focus();
            txtName.Select();
        }
        //tracks the number of attempts to enter name and PIN
        int attempts = 1;
        private void btnNamePinOk_Click(object sender, EventArgs e)
        {
            try
            {
                //get name and pin that customer enters
                string customer = txtName.Text;
                int pin = Convert.ToInt32(txtPin.Text);

                if (attempts < GlobalData.ATMBank.maxAttempts())
                {
                    //if name does not match the name on record
                    if (!customer.Equals(GlobalData.customer.getCustomerName()))
                    {
                        MessageBox.Show("Please enter a name. This field cannot be blank", "Error");
                        txtName.ResetText();
                        txtName.Focus();
                        txtName.Select();
                        attempts++;
                    }
                    //if pin does not match the pin on record
                    else if (!pin.Equals(GlobalData.customer.getCustomerPin()))
                    {
                        MessageBox.Show("Please enter a PIN. This field cannot be blank", "Error");
                        txtPin.ResetText();
                        txtPin.Focus();
                        txtPin.Select();
                        attempts++;
                    }
                    
                    //if both pin and the customer name entered match the records, then the user can now perform a transaction
                    else if (customer.Equals(GlobalData.customer.getCustomerName()) && pin == Convert.ToInt32(GlobalData.customer.getCustomerPin()))
                    {
                        Form frmTransactionEntry = new Forms.frmTransaction();
                        frmTransactionEntry.Show();
                        Close();
                    }

                }// end if (attempts < GlobalData.ATMBank.maxAttempts())

                //if the user has reached the maximum number of attempts, the program will shutdown
                else
                {
                    MessageBox.Show("You have reached the maximum number of attempts to enter your Account " +
                                    "Information. The program will now terminate","Account Locked");
                    Application.Exit();
                }
            }//end of try block

            //An exception will occur if the account does not exist
            //Prompts user to re enter account number, current input is reset, and cursor is placed back on txtAccountNum
            catch
            {
                MessageBox.Show("Please enter the name and PIN that match your Account.", "Invalid Name or Pin Entered");
                txtPin.ResetText();
                txtName.ResetText();
                txtName.Focus();
                txtName.Select();
            }

           
        }
    }
}



