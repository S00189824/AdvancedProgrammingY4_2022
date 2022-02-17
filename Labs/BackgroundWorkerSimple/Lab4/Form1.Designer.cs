
namespace Lab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txLetter1 = new System.Windows.Forms.TextBox();
            this.txLetter2 = new System.Windows.Forms.TextBox();
            this.txLetter3 = new System.Windows.Forms.TextBox();
            this.txLetter4 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCodetobreak = new System.Windows.Forms.Label();
            this.lblHashedCode = new System.Windows.Forms.Label();
            this.codeBreaker = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Breaker With Hashing";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(185, 135);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(227, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate Code then Break it";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txLetter1
            // 
            this.txLetter1.Location = new System.Drawing.Point(64, 199);
            this.txLetter1.Name = "txLetter1";
            this.txLetter1.Size = new System.Drawing.Size(100, 20);
            this.txLetter1.TabIndex = 2;
            this.txLetter1.Text = "Letter 1:";
            // 
            // txLetter2
            // 
            this.txLetter2.Location = new System.Drawing.Point(64, 225);
            this.txLetter2.Name = "txLetter2";
            this.txLetter2.Size = new System.Drawing.Size(100, 20);
            this.txLetter2.TabIndex = 3;
            this.txLetter2.Text = "Letter 2:";
            // 
            // txLetter3
            // 
            this.txLetter3.Location = new System.Drawing.Point(64, 251);
            this.txLetter3.Name = "txLetter3";
            this.txLetter3.Size = new System.Drawing.Size(100, 20);
            this.txLetter3.TabIndex = 4;
            this.txLetter3.Text = "Letter 3:";
            // 
            // txLetter4
            // 
            this.txLetter4.Location = new System.Drawing.Point(64, 277);
            this.txLetter4.Name = "txLetter4";
            this.txLetter4.Size = new System.Drawing.Size(100, 20);
            this.txLetter4.TabIndex = 5;
            this.txLetter4.Text = "Letter 4:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(64, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCodetobreak
            // 
            this.lblCodetobreak.AutoSize = true;
            this.lblCodetobreak.Location = new System.Drawing.Point(510, 84);
            this.lblCodetobreak.Name = "lblCodetobreak";
            this.lblCodetobreak.Size = new System.Drawing.Size(99, 13);
            this.lblCodetobreak.TabIndex = 7;
            this.lblCodetobreak.Text = "The Code to break:";
            // 
            // lblHashedCode
            // 
            this.lblHashedCode.AutoSize = true;
            this.lblHashedCode.Location = new System.Drawing.Point(510, 145);
            this.lblHashedCode.Name = "lblHashedCode";
            this.lblHashedCode.Size = new System.Drawing.Size(96, 13);
            this.lblHashedCode.TabIndex = 8;
            this.lblHashedCode.Text = "The Hashed code:";
            // 
            // codeBreaker
            // 
            this.codeBreaker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.codeBreaker_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(281, 274);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblHashedCode);
            this.Controls.Add(this.lblCodetobreak);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txLetter4);
            this.Controls.Add(this.txLetter3);
            this.Controls.Add(this.txLetter2);
            this.Controls.Add(this.txLetter1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txLetter1;
        private System.Windows.Forms.TextBox txLetter2;
        private System.Windows.Forms.TextBox txLetter3;
        private System.Windows.Forms.TextBox txLetter4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCodetobreak;
        private System.Windows.Forms.Label lblHashedCode;
        private System.ComponentModel.BackgroundWorker codeBreaker;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

