/*Project 2 - ATM
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This customer class looks for a record matching the
* entered account number, then extracts the records
* pertaining to the current customer. It also updates
* attributes of customer
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Classes
{
    public class Customer
    {
        string customer;
        string customerAccountNumber;
        string customerName;
        decimal customerCheckingBalance;
        decimal customerSavingsBalance;
        int customerPin;

        public Boolean customerMatch(string accountNum, string record)
        {
            //takes away commas and dollar signs contained in the files
            record = record.Replace(",", "");
            record = record.Replace("$", "");

            //splits the records by the marker * and creates a string array
            string[]  separatedRecords = record.Split('*');

            //if the account number matches the first field, then we
            //need the rest of the information from that record
            //obtains the account number, name, pin, savings and checking balances
            if (separatedRecords[0].Trim().Equals(accountNum))
            {
                customerAccountNumber = accountNum;
                customerName = separatedRecords[1].Trim();
                customerPin = Convert.ToInt32(separatedRecords[2]);
                customerSavingsBalance = Convert.ToDecimal(separatedRecords[3]);
                customerCheckingBalance = Convert.ToDecimal(separatedRecords[4]);
                return true;
            }
            else
            {
                return false;
            }
        }
        // returns the customerName
        public string getCustomerName()
        {
            return customerName;
        }
        // returns the customerPin
        public int getCustomerPin()
        {
            return customerPin;
        }
        // returns customerSavingBalance
        public decimal getSavingsBalance()
        {
            return customerSavingsBalance;
        }
        // returns customerCheckingBalance;
        public decimal getCheckingBalance()
        {
            return customerCheckingBalance;
        }
        // Updates account balances 
        public void updateAccounts(decimal savingsBalance, decimal checkingBalance)
        {
            customerCheckingBalance = checkingBalance;
            customerSavingsBalance = savingsBalance;
        }
        // generates new customer record, ready to write to a file
        public string generateRecord()
        {
            customer = customerAccountNumber + " * " + customerName + " * " + customerPin + " * " + customerSavingsBalance.ToString("C") + " * " + customerCheckingBalance.ToString("C");
            return customer;
        }
    }
}

