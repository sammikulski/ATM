/*Project 2 - ATM
*CIS 3309 - Component-Based Software Design
*Created by Sam Mikulski, with code provided by Prof. Frank Friedman, Temple University
*This updateFile class is used to write and update
*the currentFile records in the buffer to a new updated file.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.Classes;

namespace ATM
{
    public class updatedFile
    {
        private string updatedFilePath;
        private StreamWriter outputFile;    //Reference variable of type SW
        private int numRecordsWritten;
        private List<string> recordsList = new List<string>();

        // Constructor with file path input
        // Create instance of StreamWriter class (type) and store reference
        public updatedFile(string filePath)
        {
            numRecordsWritten = 0;
            updatedFilePath = filePath;
        } // end updatedFileClass 

        // Adds record to recordsList
        public void putNextRecord(string record)
        {
            recordsList.Add(record);
        }

        //return the number of records written
        public int getNumRecordsWritten()
        {
            return numRecordsWritten;
        }

        // Writes each record in recordsList to updatedFile.
        public void generateFile()
        {
            try
            {
                if (File.Exists(updatedFilePath))
                {
                    File.Delete(updatedFilePath);
                }
                using (outputFile = new StreamWriter(updatedFilePath, true))
                {
                    foreach (string record in recordsList)
                    {
                        outputFile.WriteLine(record);
                        numRecordsWritten++;
                    }
                }
            }//end Try block
            catch (Exception ex)
            {
                MessageBox.Show("Cannot write file " + updatedFilePath + "Terminate Program." +ex,
                            "Output File Connection Error.", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//end generateFile


        //close output file
        public void closeFile()
        {
            outputFile.Close();
        }

        // Rewind the file
        public void rewindFile()
        {
            numRecordsWritten = 0;
            outputFile.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        }
    } // end updatedFile class
}
