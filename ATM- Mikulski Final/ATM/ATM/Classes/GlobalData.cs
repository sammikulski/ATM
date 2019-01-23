/*Project 2 - ATM
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This GlobalData class instantiates objects that can
*be accessed throughout the entire program.
* 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATM.Classes;

namespace ATM
{
    public class GlobalData
    {
     
        //       Static methods of a class may be called without instantiating the class
        //              They called from the class itself
        //       Static objects or variables may be accessed without creating an instance of the class
        //              that contains them
        //       When you declare a class as static, all its members are automatically static

        private static string currentFilePath = "CurrentATMBankFile.txt";
        private static string updatedFilePath = "UpdatedATMBankFile.txt";

        // Application classes
        public static ATMBank ATMBank = new ATMBank();
        public static Customer customer = new Customer();

        // Creating instances of all the forms ...
        public static Form TransactionCompleteForm = new Forms.frmTransactionComplete();
        public static Form TransactionEntryForm = new Forms.frmTransaction();

        // For communication between forms ...
        public static string FormsCode = "";

    } // end Global Data Class

} // end namespace
