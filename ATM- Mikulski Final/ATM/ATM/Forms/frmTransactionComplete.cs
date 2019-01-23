/*Project 2 - ATM
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski
*This transactionComplete form allows the user to view balances
* and select another transaction if they wish. It also calls
* the remaining methods needed to update the records
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
    public partial class frmTransactionComplete : Form
    {
        public frmTransactionComplete()
        {
            InitializeComponent();
        }

        //if user clicks yes
        private void btnYesBalance_Click(object sender, EventArgs e)
        {
            lblSavingsBalance.Visible = true;
            lblCheckingBalance.Visible = true;
            lblYourBalancesAre.Visible = true;
            txtCheckingBal.Visible = true;
            txtSavingsBal.Visible = true;
            lblAnotherTransaction.Visible = true;
            btnYesAnotherTransaction.Visible = true;
            btnNoNewTransaction.Visible = true; 
            txtCheckingBal.Text = GlobalData.customer.getCheckingBalance().ToString();
            txtSavingsBal.Text = GlobalData.customer.getSavingsBalance().ToString();

            lblSeeBalancesQuestion.Enabled = false;
            btnYesBalance.Enabled = false;
            btnNoBalance.Enabled = false;
           
        }

        //if the user wants another transaction, current form closes and frmTransaction opens
        private void btnYesAnotherTransaction_Click(object sender, EventArgs e)
        {
            Form frmTransaction = new frmTransaction();
            frmTransaction.Show();
            Close();
        }

        private void btnNoBalance_Click(object sender, EventArgs e)
        {
            lblSeeBalancesQuestion.Enabled = false;
            btnYesBalance.Enabled = false;
            btnNoBalance.Enabled = false;
            lblAnotherTransaction.Visible = true;
            btnYesAnotherTransaction.Visible = true;
            btnNoNewTransaction.Visible = true;
        }

        //completion of the application
        //copy, update, and writeOut records
        private void btnNoNewTransaction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for choosing Mikulski Bank!", "Transaction Complete!");
            MessageBox.Show("Have a great day!", "Transaction Complete!");
            GlobalData.ATMBank.writeOut(GlobalData.customer.generateRecord());
            GlobalData.ATMBank.CopyRemainingRecords();
            GlobalData.ATMBank.generateUpdatedFile();
            Application.Exit();
        }

        
    }
}
