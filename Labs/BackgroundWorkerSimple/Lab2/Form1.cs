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

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SumWorker.DoWork += SumWorker_DoWork;

            SumWorker.RunWorkerCompleted += SumWorker_RunWorkerCompleted;

            
        }

        private void SumWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Sum Worker completed!");// show messagebox when done        
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            SumWorker.RunWorkerAsync();

            btnCalculate.Enabled = false;
        }

        private void SumWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int userSum = 0;
            string stringToDisplay;

            try
            {
                for (int i = 1; i <= int.Parse(txNumber.Text); i++)
                {
                    int ans = userSum;
                    userSum += i;

                    stringToDisplay = String.Format(" {0} + {1} = {2}", ans, i, userSum);

                    this.Invoke(new MethodInvoker(delegate
                    {
                        lbxSum.Items.Add(stringToDisplay);
                    }));

                    Thread.Sleep(1000);

                }
            }
            catch(Exception ex)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    lblError.Text = ex.Message;
                }));
            }
            
        }
    }
}
