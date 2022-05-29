using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        int numberUnicode = 100;// The value should be 65353 but it takes ages to break the 
                                // code. So we changed it to 100 to try and reduce the time 


        public Form1()
        {
            InitializeComponent();

            codeBreaker.ProgressChanged += CodeBreaker_ProgressChanged;
            codeBreaker.RunWorkerCompleted += CodeBreaker_RunWorkerCompleted;

            codeBreaker.WorkerSupportsCancellation = true;
            codeBreaker.WorkerReportsProgress = true;
        }

        private void CodeBreaker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // check for error
            if (e.Error != null)
            {
                MessageBox.Show("Error");
            }

            // check if cancel happened
            else if (e.Cancelled)
            {
                MessageBox.Show("Background worker Calncelled ... cancelled....");
                // show messagebox when the background worker was cancelled 
            }
            // use e.Result coming from the DoWork event handler
            else
            {
                // retrieve the result (or value) passed from the DoWork event handler
                string brokenCode = (string)e.Result;

                // display the results
                txLetter1.Text = brokenCode[0].ToString();
                txLetter2.Text = brokenCode[1].ToString();
                txLetter3.Text = brokenCode[2].ToString();
                txLetter4.Text = brokenCode[3].ToString();

                MessageBox.Show("Background worker completed");// show messagebox when done  
            }
        }

        private void CodeBreaker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //update progress bar with the % completed so far
            progressBar1.Value = e.ProgressPercentage;


        }

        private void codeBreaker_DoWork(object sender, DoWorkEventArgs e)
        {
            //will hold the code after it was broken
            string theBrokenCode = "";

            string breakingInProgress = "";
            string hashedBreakingInProgress;

            // get the HashedCode passed as parameter to the Background Worker
            string HashedCode = (string)e.Argument;  //cast it to a string

            // try to break the HashedCode
            for (int i = 0; i < numberUnicode; i++)
                for (int j = 0; j < numberUnicode; j++)
                    for (int k = 0; k < numberUnicode; k++)
                        for (int l = 0; l < numberUnicode; l++)
                        {

                            // code which runs when the background worker is cancelled
                            if (codeBreaker.CancellationPending == true)
                            {
                                e.Cancel = true;
                                return;
                            }

                            // brute force attack – generate one by one all the possible 
                            // combinations of 4 letters
                            breakingInProgress = ((char)i).ToString() + ((char)j).ToString() + ((char)k).ToString() + ((char)l).ToString();

                            // brute force attack – hash the 4 letter generated above
                            hashedBreakingInProgress = Sha256Hash(breakingInProgress);


                            // compare the HashedCode with the hash generated in the attempt to // break the code
                            if (String.Compare(hashedBreakingInProgress, HashedCode) == 0)
                            {
                                // if they match, we broke the code!  Save the 4 letter generated
                                // “guess” in another variable
                                theBrokenCode = breakingInProgress;

                                // PLACE CODE IN HERE TO REPORT THAT THE PROGRESS IS 100%

                                string guess;

                                guess = theBrokenCode;
                                break;
                            }

                            // PLACE CODE IN HERE TO REPORT ON PROGRESS
                        }

            // transport a result out of the DoWork event handler and make it available to   
            // the likes of RunWorkerCompleted event handler (where we can use the value)
            e.Result = theBrokenCode;

        }

        //the Hashing algorithm
        static string Sha256Hash(string unHashedData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Compute the Hash - returns an array of bytes  
                byte[] hashAsArray = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(unHashedData));

                // We have to convert the array of bytes to a string   
                StringBuilder sb = new StringBuilder();

                foreach (byte b in hashAsArray)
                    sb.Append(b.ToString("X2"));

                return sb.ToString();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // A Random number generator.
            Random rndUnicode = new Random();

            string CodeToBreak = "";
            string HashedCodeToBreak;

            for (int i = 0; i < 4; i++)
            {
                //Generate a random Unicode char for each of the 4 letters
                CodeToBreak += (char)(rndUnicode.Next(numberUnicode));
            }

            lblCodetobreak.Text += CodeToBreak;

            //hash the code using SHA 256
            HashedCodeToBreak = Sha256Hash(CodeToBreak);

            //display the hashed code in the label
            lblHashedCode.Text += HashedCodeToBreak;

            //start the backgroundWorker and pass the parameter
            codeBreaker.RunWorkerAsync(argument: HashedCodeToBreak);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Call the CancelAsync() method to cancel the background worker
            codeBreaker.CancelAsync();

        }
    }
}
