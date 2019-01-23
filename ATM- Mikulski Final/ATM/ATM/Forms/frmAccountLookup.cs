/*Project 2 - ATM
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski
*This form allows the user to enter an account number (3 attempts)
*if the account number exits, it will advance to frmNameAndPin
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
using ATM.Classes;

namespace ATM.Forms
{
    public partial class frmAccountLookup : Form
    {
        int attempts = 1;
        //used to keep track of the number of attempts user took to enter a valid account number
        //when program starts, the user will be on their first attempt
        public frmAccountLookup()
        {
            InitializeComponent();
            //Cursor is placed on the text box upon startup
            txtAccountNum.Focus();
            txtAccountNum.Select();
        }
        //event handler for when user clicks 'Find Me'
        private void btnFindMe_Click(object sender, EventArgs e)
        {

            try
            {
                //if user has not yet reached the maximum number of attempts,
                //then the program will attempt to continue to look up the account
                if (attempts < GlobalData.ATMBank.maxAttempts())
                {
                    //converts the account number entered by a user to a string
                    String accountNum = Convert.ToString(txtAccountNum.Text);

                    //variable referencing the account length declared in the ATMBank class
                    int accountLength = Convert.ToInt32(GlobalData.ATMBank.AccountLength());

                    //if the account number input is blank, or has white space
                    //message box appears telling user to enter a valid account number with 5 digits
                    //current input is reset, and cursor is placed back on txtAccountNum
                    if (String.IsNullOrEmpty(txtAccountNum.Text) || (String.IsNullOrWhiteSpace(txtAccountNum.Text)))
                    {
                        MessageBox.Show("Please enter a valid Account Number. This Field cannot be blank", "No digits entered");
                        txtAccountNum.ResetText();
                        txtAccountNum.Focus();
                        txtAccountNum.Select();
                        attempts++;

                    }

                    //if the length of the account number entered matches the proper length of an account number
                   //the find customer record method in the instance of the ATM bank we are working with is caled
                    else if (accountNum.Length == accountLength)
                    {
                        bool foundRecord = false;

                        //find record given the entered account number
                        string record = GlobalData.ATMBank.findCustomerRecord(accountNum, ref foundRecord);

                        //if the account number matches a record, foundRecord is true
                        //the next form will appear
                        if (foundRecord)
                        {
                            Form nameAndPin = new frmNameAndPin();
                            nameAndPin.Show();
                            this.Hide();
                        }

                        //if a record was not found, message box is displayed telling the user that the account does not exist
                        //files are rewound, an attempt is recorded
                        //current input is reset, and cursor is placed back on txtAccountNum
                        else
                        {
                            MessageBox.Show("This Account Number Does Not Exist", "Invalid Account Number");
                            txtAccountNum.ResetText();
                            txtAccountNum.Focus();
                            txtAccountNum.Select();
                            GlobalData.ATMBank.rewindFiles();
                            attempts++;
                        }
                    }//end of else if (accountNum.Length == accountLength)

                    //if the account number entered does not match the length of a proper account number:
                    //message box will be displayed telling user to enter account number with 5 digits
                    //current input is reset, and cursor is placed back on txtAccountNum
                    else
                    {
                        MessageBox.Show("Please enter a 5-digit Account Number", "Account Number too short");
                        txtAccountNum.ResetText();
                        txtAccountNum.Focus();
                        txtAccountNum.Select();
                        attempts++;
                    }
                }//end of  if (attempts < GlobalData.ATMBank.maxAttempts() )

                //if the user has reached the maximum number of attempts, the program will shutdown
                else
                {
                    MessageBox.Show("You have reached the maximum number of attempts to enter your account number. The program will now terminate", "Account Locked");
                    Application.Exit();
                }
            }//end of try block

            //An exception will occur if the account does not exist
            //Prompts user to re enter account number, current input is reset, and cursor is placed back on txtAccountNum
            catch
            {
                MessageBox.Show("Please enter a valid 5-digit Account Number. This Field cannot be blank", "Exception Error");
                txtAccountNum.ResetText();
                txtAccountNum.Focus();
                txtAccountNum.Select();
            }//end of catch 
        }
    }
}
