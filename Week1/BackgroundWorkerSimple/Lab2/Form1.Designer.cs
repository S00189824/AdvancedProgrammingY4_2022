
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInputNo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txNumber = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbxSum = new System.Windows.Forms.ListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SumWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblInputNo
            // 
            this.lblInputNo.AutoSize = true;
            this.lblInputNo.Location = new System.Drawing.Point(82, 84);
            this.lblInputNo.Name = "lblInputNo";
            this.lblInputNo.Size = new System.Drawing.Size(103, 13);
            this.lblInputNo.TabIndex = 0;
            this.lblInputNo.Text = "Please input number";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(85, 138);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // txNumber
            // 
            this.txNumber.Location = new System.Drawing.Point(85, 200);
            this.txNumber.Name = "txNumber";
            this.txNumber.Size = new System.Drawing.Size(202, 20);
            this.txNumber.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(85, 271);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate Sums";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbxSum
            // 
            this.lbxSum.FormattingEnabled = true;
            this.lbxSum.Location = new System.Drawing.Point(530, 84);
            this.lbxSum.Name = "lbxSum";
            this.lbxSum.Size = new System.Drawing.Size(236, 290);
            this.lbxSum.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(85, 360);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lbxSum);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txNumber);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblInputNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputNo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txNumber;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lbxSum;
        private System.Windows.Forms.Label lblError;
        private System.ComponentModel.BackgroundWorker SumWorker;
    }
}

