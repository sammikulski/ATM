/*Project 2 - ATM
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This ATMBank class is used to contain data relative to
*Mikulski Bank to keep it private. It is also used to locate customer
*records and work with currentFile and updatedFile classes
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATM.Classes;

namespace ATM
{
    public class ATMBank
    {
        // Constructor for the ATM Bank Class
        public ATMBank()
        {

        }

        // Bank parameters (Named constants defined by the bank)

        // The Files the Bank Owns
        private static string currentFilePath = "CurrentATMBankFile.txt";
        private static string updatedFilePath = "UpdatedATMBankFile.txt";

        private ATM.currentFile currentFile = new ATM.currentFile(currentFilePath);
        private ATM.updatedFile updatedFile = new ATM.updatedFile(updatedFilePath);

        // Exact length of legal accounts for Bailed Out Bank
        private int hiddenAccountLength = 5;

        // Number of attempts Bailed Out Bank allows a user before terminating ATM Session
        private int hiddenTryCountMax = 3;

        // Maximum withdrawal amount bank allows per day
        private decimal hiddenWDAmount = Convert.ToDecimal(300.0);

        // returns false if parameterized amount is greater than the daily withdrawal limit
        //returns true if the amount is less than the daily withdrawal limit
        public Boolean underLimit(decimal amount)
        {
            if (amount > hiddenWDAmount)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //returns hiddenAccountLength (number of digits in an account number)
        public int AccountLength()
        {
            return hiddenAccountLength;
        }
        //returns hiddenTryCountMax (number of attempts)
        public int maxAttempts()
        {
            return hiddenTryCountMax;
        }

        // Find customer record given the entered account
        public string findCustomerRecord(string account, ref Boolean found)
        {
            string nextRecord;
            Boolean isEndOfFile = true;

            nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            found = false;
            while (!isEndOfFile)
            {
                if (GlobalData.customer.customerMatch(account, nextRecord))
                {
                    found = true;
                    return (nextRecord);
                }
                else
                {
                    updatedFile.putNextRecord(nextRecord);
                    nextRecord = currentFile.getNextRecord(ref isEndOfFile);
                } // end  if (GlobalData.customer.customerMatch(account, nextRecord))
            } //end while (!isEndOfFile)

            return (nextRecord);
        } //end findCustomerRecord


        // Writes record to the updated file
        public void writeOut(string record)
        {
            updatedFile.putNextRecord(record);
        }  // end writeOut
        public void generateUpdatedFile()
        {
            updatedFile.generateFile();
            MessageBox.Show("End of program execution." + "\n"
                + "The number of records read is: " + currentFile.getRecordsReadCount().ToString() + "\n"
                + "The number of records written is: " + updatedFile.getNumRecordsWritten().ToString());
        }

        // Copies remaining records from currentFile to updatedFile.
        public void CopyRemainingRecords()
        {
            Boolean isEndOfFile = false;
            string nextRecord;

            nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                updatedFile.putNextRecord(nextRecord);
                nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            } // end While
        } // end CopyRemaingRecords

        //rewinds file to the beginning of the file
        public void rewindFiles()
        {
            currentFile.rewindFile();
            updatedFile.rewindFile();
        }  // end rewindFiles

        //close readers and writers
        public void closeFiles()
        {
            currentFile.closeFile();
            updatedFile.closeFile();
        }  // end close files

    } // end ATMBankClass

} //end namespace ATM

