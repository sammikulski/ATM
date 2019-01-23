/*Project 2 - ATM
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski
*This transaction form allows the user to select a transaction,
* and enter a specified amount if needed. Once verified and processed,
* the transactions will occur and frmTransactionComplete will load
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

namespace ATM.Forms
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }
        //if the user hits 'no - select again' this will reset all properties of each attribute
        private void restart()
        {
            //initial color of eachh button
            btnSavingsBalance.BackColor = Color.Transparent;
            btnCheckingBalance.BackColor = Color.Transparent;
            btnCheckingDeposit.BackColor = Color.Transparent;
            btnSavingsDeposit.BackColor = Color.Transparent;
            btnSavingsWithdrawal.BackColor = Color.Transparent;
            btnCheckingWithdrawal.BackColor = Color.Transparent;
            btnTransferCheckingToSavings.BackColor = Color.Transparent;
            btnTransferSavingsToChecking.BackColor = Color.Transparent;

            //buttons should be enabled on load
            btnSavingsDeposit.Enabled = true;
            btnCheckingDeposit.Enabled = true;
            btnCheckingWithdrawal.Enabled = true;
            btnSavingsWithdrawal.Enabled = true;
            btnSavingsBalance.Enabled = true;
            btnCheckingBalance.Enabled = true;
            btnTransferCheckingToSavings.Enabled = true;
            btnTransferSavingsToChecking.Enabled = true;
            txtTransactionAmount.ResetText();

            //this portion of the form should not be visible on load
            lblSelectAmount.Visible = false;
            txtTransactionAmount.Visible = false;
            btnOkAmount.Visible = false;

            lblSelectAmount.Visible = false;
            lblYouSelected.Visible = false;
            txtConfirmAmount.Visible = false;
            lblCorrectMarked.Visible = false;

            btnYesProcess.Visible = false;
            btnNoSelectAgain.Visible = false;

        }

        decimal transactionAmount = 0;
        decimal checkingBal = GlobalData.customer.getCheckingBalance();
        decimal savingsBal = GlobalData.customer.getSavingsBalance();

        //event handler for when user clicks 'OK' button
        //this validates the amount entered and allows user to review their entered amount
        private void btnOkAmount_Click(object sender, EventArgs e)
        {
            try
            {
                transactionAmount = Convert.ToDecimal(txtTransactionAmount.Text);
                //if negative:
                if (transactionAmount < 0)
                {
                    MessageBox.Show("Please enter a value greater than 0", "Invalid Input");
                    txtTransactionAmount.ResetText();
                    txtTransactionAmount.Focus();
                    txtTransactionAmount.Select();
                }
                //if valid:
                else
                {
                    btnOkAmount.Enabled = true;
                    lblYouSelected.Visible = true;
                    txtConfirmAmount.Visible = true;
                    txtConfirmAmount.Text = transactionAmount.ToString();
                    lblCorrectMarked.Visible = true;
                    btnYesProcess.Visible = true;
                    btnNoSelectAgain.Visible = true;
                }
            }//end of try block

            //if amount not valid:
            catch
            {
                MessageBox.Show("Please enter a valid amount!", "Invalid Input");
                txtTransactionAmount.ResetText();
                txtTransactionAmount.Focus();
                txtTransactionAmount.Select();
            }//end of catch block
        }
       
        //when the user clicks a particular transaction, the program indicated
        //that the transaction is selected (colored yellow buttons)
        private void transactionEvent_Click(object sender, EventArgs e)
        {
            //once the user clicks a transaction button,
            //they should not be able to select a different one (just yet)
            btnSavingsDeposit.Enabled = false;
            btnCheckingDeposit.Enabled = false;
            btnCheckingWithdrawal.Enabled = false;
            btnSavingsWithdrawal.Enabled = false;
            btnSavingsBalance.Enabled = false;
            btnCheckingBalance.Enabled = false;
            btnTransferCheckingToSavings.Enabled = false;
            btnTransferSavingsToChecking.Enabled = false;

            //allow user to enter the amount per the transaction
            lblSelectAmount.Visible = true;
            txtTransactionAmount.Visible = true;
            btnOkAmount.Visible = true;

            //yellow color easily indicates which transaction they selected
            if (sender == btnSavingsDeposit)
            {
                btnSavingsDeposit.BackColor = Color.Yellow;
            }
            if (sender == btnCheckingDeposit)
            {
                btnCheckingDeposit.BackColor = Color.Yellow;
            }
            if (sender == btnSavingsWithdrawal)
            {
                btnSavingsWithdrawal.BackColor = Color.Yellow;
            }
            if(sender == btnCheckingWithdrawal)
            {
                btnCheckingWithdrawal.BackColor = Color.Yellow;
            }
            //for balance views, an amount is not required to be entered,
            //so that portion will not be visible and the 'Yes - Process'
            //and 'No - Select Again' buttons will be enabled right away
            if(sender == btnSavingsBalance)
            {
                btnSavingsBalance.BackColor = Color.Yellow;
                btnYesProcess.Visible = true;
                btnNoSelectAgain.Visible = true;

                lblSelectAmount.Visible = false;
                txtTransactionAmount.Visible = false;
                btnOkAmount.Visible = false;
         
                lblSelectAmount.Visible = false;
                lblYouSelected.Visible = false;
                txtConfirmAmount.Visible = false;
                lblCorrectMarked.Visible = false;

            }
            if (sender == btnCheckingBalance)
            {
                btnCheckingBalance.BackColor = Color.Yellow;
                btnYesProcess.Visible = true;
                btnNoSelectAgain.Visible = true;

                lblSelectAmount.Visible = false;
                txtTransactionAmount.Visible = false;
                btnOkAmount.Visible = false;

                lblSelectAmount.Visible = false;
                lblYouSelected.Visible = false;
                txtConfirmAmount.Visible = false;
                lblCorrectMarked.Visible = false;
            }
            if(sender == btnTransferCheckingToSavings)
            {
                btnTransferCheckingToSavings.BackColor = Color.Yellow;
            }
            if(sender == btnTransferSavingsToChecking)
            {
                btnTransferSavingsToChecking.BackColor = Color.Yellow;
            }
        }
        //event handler for when user clicks 'Yes - Process'
        //validates transaction, then updates customer object with the new information
        //Loads frmTransactionComplete after update
        private void btnYesProcess_Click(object sender, EventArgs e)
        {
            //inidcates whether or not to load frmTransactionComplete
            Boolean processed = false;

            //increment savingsBal with transactionAmount
            if (btnSavingsDeposit.BackColor == Color.Yellow)
            {
                savingsBal += transactionAmount;
                processed = true;
            }
            //increment checkingBal with transactionAmount
            if (btnCheckingDeposit.BackColor == Color.Yellow)
            {
                checkingBal += transactionAmount;
                processed = true;
            }
            //Load frmTransactionComplete so that user can view balance
            if (btnSavingsBalance.BackColor == Color.Yellow)
            {
                //MessageBox.Show("Your Savings Account Balance is : $" + savingsBal, "Savings Account Balance");
                processed = true;
            }
            //Load frmTransactionComplete so that user can view balance
            if (btnCheckingBalance.BackColor == Color.Yellow)
            {
                //MessageBox.Show("Your Checking Account Balance is : $" + checkingBal, "Checking Account Balance");
                processed = true;
            }

            if(btnCheckingWithdrawal.BackColor == Color.Yellow)
            {
                //if transactionAmount is greather than the withdrawal limit, user needs to enter a smaller amount
                if (GlobalData.ATMBank.underLimit(transactionAmount) == false)
                {
                    MessageBox.Show("Please enter a withdrawal amount less than 300", "Error");
                    transactionAmount = 0;
                    txtConfirmAmount.ResetText();
                    lblCorrectMarked.Visible = false;
                    lblYouSelected.Visible = false;
                    txtConfirmAmount.Visible = false;
                    btnYesProcess.Visible = false;
                    btnNoSelectAgain.Visible = false;
                    txtTransactionAmount.ResetText();
                    txtTransactionAmount.Focus();
                    txtTransactionAmount.Select();
                }
                //if transactionAmount is more than the current Balance, the user needs to enter a smaller amount
                else if (transactionAmount > checkingBal)
                {
                    MessageBox.Show("Insufficient Funds. Please type in a smaller amount", "Error");
                    transactionAmount = 0;
                    txtConfirmAmount.ResetText();
                    lblCorrectMarked.Visible = false;
                    lblYouSelected.Visible = false;
                    txtConfirmAmount.Visible = false;
                    btnYesProcess.Visible = false;
                    btnNoSelectAgain.Visible = false;

                    txtTransactionAmount.ResetText();
                    txtTransactionAmount.Focus();
                    txtTransactionAmount.Select();
                }
                //if transactionAmount is a valid amount, then the withdrawal transaction can be executed
                else
                {
                    checkingBal -= transactionAmount;
                    processed = true;
                }
            }
            if(btnSavingsWithdrawal.BackColor == Color.Yellow)
            {
                //if transactionAmount is greather than the withdrawal limit, user needs to enter a smaller amount
                if (GlobalData.ATMBank.underLimit(transactionAmount) == false)
                {
                    MessageBox.Show("Amount Exceeds the Daily Limit. Please enter a withdrawal amount less than 300", "Invalid Amount");
                    transactionAmount = 0;
                    txtConfirmAmount.ResetText();
                    lblCorrectMarked.Visible = false;
                    lblYouSelected.Visible = false;
                    txtConfirmAmount.Visible = false;
                    btnYesProcess.Visible = false;
                    btnNoSelectAgain.Visible = false;

                    txtTransactionAmount.ResetText();
                    txtTransactionAmount.Focus();
                    txtTransactionAmount.Select();
                }
                //if transactionAmount is more than the current Balance, the user needs to enter a smaller amount
                else if (transactionAmount > savingsBal)
                {
                    MessageBox.Show("The amount you entered exceeds the current amount in this account. Please type in a smaller amount", "Insufficient Funds");
                    transactionAmount = 0;
                    txtConfirmAmount.ResetText();
                    lblCorrectMarked.Visible = false;
                    lblYouSelected.Visible = false;
                    txtConfirmAmount.Visible = false;
                    btnYesProcess.Visible = false;
                    btnNoSelectAgain.Visible = false;

                    txtTransactionAmount.ResetText();
                    txtTransactionAmount.Focus();
                    txtTransactionAmount.Select();
                }
                //if transactionAmount is a valid amount, then the withdrawal transaction can be executed
                else
                {
                    savingsBal -= transactionAmount;
                    processed = true;
                }
            }
            if(btnTransferCheckingToSavings.BackColor == Color.Yellow)
            {
                //if transactionAmount is greather than the amount in the source account, user needs to enter a smaller amount
                if (transactionAmount > checkingBal)
                {
                    MessageBox.Show("The amount you entered exceeds the current amount in this account. Please type in a smaller amount.", "Insufficient Funds");
                    txtConfirmAmount.ResetText();
                    lblCorrectMarked.Visible = false;
                    lblYouSelected.Visible = false;
                    txtConfirmAmount.Visible = false;
                    btnYesProcess.Visible = false;
                    btnNoSelectAgain.Visible = false;

                    transactionAmount = 0;
                    txtTransactionAmount.ResetText();
                    txtTransactionAmount.Focus();
                }
                //if transactionAmount is a valid amount, then the trasnfer money transaction can be executed
                else
                {
                    checkingBal -= transactionAmount;
                    savingsBal += transactionAmount;
                    processed = true;
                }

            }
            if(btnTransferSavingsToChecking.BackColor == Color.Yellow)
            {
                //if transactionAmount is greather than the amount in the source account, user needs to enter a smaller amount
                if (transactionAmount > savingsBal)
                {
                    MessageBox.Show("The amount you entered exceeds the current amount in this account. Please type in a smaller amount.", "Insufficient Funds");
                    txtConfirmAmount.ResetText();
                    lblCorrectMarked.Visible = false;
                    lblYouSelected.Visible = false;
                    txtConfirmAmount.Visible = false;
                    btnYesProcess.Visible = false;
                    btnNoSelectAgain.Visible = false;

                    transactionAmount = 0;
                    txtTransactionAmount.ResetText();
                    txtTransactionAmount.Focus();
                }
                //if transactionAmount is a valid amount, then the trasnfer money transaction can be executed
                else
                {
                    savingsBal -= transactionAmount;
                    checkingBal += transactionAmount;
                    processed = true;
                }
            }
            //if true, then frmTransactionComplete can be loaded
            if (processed == true)
            {
                GlobalData.customer.updateAccounts(savingsBal, checkingBal);
                Form frmTransactionComplete = new frmTransactionComplete();
                frmTransactionComplete.Show();
                Close();
            }
        }

        //if user clicks 'No-Select Again,' the form will reset as if it were just loaded
        //these necessary buttons and 8 transaction buttons will be visible
        private void btnNoSelectAgain_Click(object sender, EventArgs e)
        {
            restart();
            lblSelectAmount.Visible = true;
            txtTransactionAmount.Visible = true;
            btnOkAmount.Visible = true;
        }
    }
}
