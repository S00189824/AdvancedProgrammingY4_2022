using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AdvancedProgrammingLab1
{
    public partial class Form1 : Form
    {
        string codeToBreak;

        public Form1()
        {
            InitializeComponent();

            //Set properties of the background worker are ore of interest to us
            bw_CodeBreaker.WorkerReportsProgress = true;

            //insert a new instance of a delegate which points to the method handling the DoWork event
            bw_CodeBreaker.DoWork += Bw_CodeBreaker_DoWork;
            bw_CodeBreaker.ProgressChanged += Bw_CodeBreaker_ProgressChanged;
            bw_CodeBreaker.RunWorkerCompleted += Bw_CodeBreaker_RunWorkerCompleted;
        }

        private void Bw_CodeBreaker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void Bw_CodeBreaker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void Bw_CodeBreaker_DoWork(object sender, DoWorkEventArgs e)
        {
            //place the code behind the background worker in here

            //retrieve the argument
            string cToBreak = (string)e.Argument;

            char[] solvedCode = new char[4];

            for (int i = 0; i < 65535; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (cToBreak[j] == (char)i)
                        solvedCode[j] = (char)i;
                    Thread.Sleep(1000);
                }
                    

            }

            //display

            Invoke(new MethodInvoker(delegate
            {

                textBox1.Text = solvedCode[0].ToString();
                textBox2.Text = solvedCode[1].ToString();
                textBox3.Text = solvedCode[2].ToString();
                textBox4.Text = solvedCode[3].ToString();

            }));
        }

        private void btn_Generate(object sender, EventArgs e)
        {
            //Generate a random 4 letter code from the 65535 inicode available

            Random rndUNICodeLetter = new Random();

            codeToBreak = string.Empty;

            for (int i = 0; i < 4; i++)
            {
                //Generate a random unicode
                codeToBreak += (char)(rndUNICodeLetter.Next(65535));
            }

            lbl_Code.Text = codeToBreak;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Check if a code is here to break
            //if the code is there we are going to start the background worker which performs the brute force attack

            if (codeToBreak != string.Empty)
                //start the background worker and pass the codeToBreak as argument
                bw_CodeBreaker.RunWorkerAsync(argument: codeToBreak);
            else
                MessageBox.Show("Please Generate Code First");
        }
    }
}
