using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorkerSimple
{
    public partial class Form1 : Form
    {
        TimeSpan timeelasped;

        public Form1()
        {
            // can report progress
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;

            //do work event
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;

            //progress updated event
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;

            //progress completed
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
        }



        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Background worker completed");// show messagebox when done          
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //update progress bar with the % completed so far
            progressBar1.Value = e.ProgressPercentage;

            // update timer label with custom string format                             
            lbl_Timer.Text = string.Format("{0:mm\\:ss}", timeelasped);

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime begin = DateTime.Now;

            int noSeconds = 70;

            DateTime endTime = begin.AddSeconds(noSeconds); // set to noSeconds from now

            float percentComplete;

            while (DateTime.Now < endTime) // while time now is less than the end time
            {
                Thread.Sleep(1000); // sleep for 1 sec to simulate some work

                timeelasped = DateTime.Now - begin; // find out how long we've been going for

                // convert it to %   
                percentComplete = ((float)timeelasped.TotalSeconds / (float)noSeconds) * 100;

                //The ReportProgress() method raises the ProgressChanged event
                //In its simplest form, the ReportProgress() method accepts one int parameter which 
                //     can have values between 0 and 100 and represents the % completed by the 
                //     background worker so far 
                // The % completed (specified as parameter in the ReportProgress() method)
                //     is returned as the ProgressPercentage property of the 
                //     ProgressChangedEventArgs.
                backgroundWorker1.ReportProgress((int)(Math.Round(percentComplete)));

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //starts the background operation
            backgroundWorker1.RunWorkerAsync();

            btnStart.Enabled = false;
        }
    }
}
