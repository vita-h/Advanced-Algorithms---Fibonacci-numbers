namespace AA_L_Fibonacci
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnThird = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.nupNumber = new System.Windows.Forms.NumericUpDown();
            this.lblFib = new System.Windows.Forms.Label();
            this.rtbExecution = new System.Windows.Forms.RichTextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.lblExec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(255, 30);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(221, 34);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "Implementation with Recursion";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSecond
            // 
            this.btnSecond.Location = new System.Drawing.Point(255, 74);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(221, 34);
            this.btnSecond.TabIndex = 1;
            this.btnSecond.Text = "Implementation using a Table";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnThird
            // 
            this.btnThird.Location = new System.Drawing.Point(255, 118);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(221, 34);
            this.btnThird.TabIndex = 2;
            this.btnThird.Text = "Third Implementation";
            this.btnThird.UseVisualStyleBackColor = true;
            this.btnThird.Click += new System.EventHandler(this.btnThird_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(32, 32);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(62, 17);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Number:";
            // 
            // nupNumber
            // 
            this.nupNumber.Location = new System.Drawing.Point(100, 32);
            this.nupNumber.Maximum = new decimal(new int[] {
            93,
            0,
            0,
            0});
            this.nupNumber.Name = "nupNumber";
            this.nupNumber.Size = new System.Drawing.Size(120, 22);
            this.nupNumber.TabIndex = 4;
            // 
            // lblFib
            // 
            this.lblFib.AutoSize = true;
            this.lblFib.Location = new System.Drawing.Point(32, 166);
            this.lblFib.Name = "lblFib";
            this.lblFib.Size = new System.Drawing.Size(76, 17);
            this.lblFib.TabIndex = 5;
            this.lblFib.Text = "Fibonacci: ";
            // 
            // rtbExecution
            // 
            this.rtbExecution.Location = new System.Drawing.Point(10, 297);
            this.rtbExecution.Name = "rtbExecution";
            this.rtbExecution.Size = new System.Drawing.Size(487, 252);
            this.rtbExecution.TabIndex = 7;
            this.rtbExecution.Text = "";
            this.rtbExecution.TextChanged += new System.EventHandler(this.rtbExecution_TextChanged);
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(12, 186);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(487, 59);
            this.rtbResult.TabIndex = 8;
            this.rtbResult.Text = "";
            // 
            // lblExec
            // 
            this.lblExec.AutoSize = true;
            this.lblExec.Location = new System.Drawing.Point(32, 277);
            this.lblExec.Name = "lblExec";
            this.lblExec.Size = new System.Drawing.Size(101, 17);
            this.lblExec.TabIndex = 9;
            this.lblExec.Text = "Execution Log:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 558);
            this.Controls.Add(this.lblExec);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.rtbExecution);
            this.Controls.Add(this.lblFib);
            this.Controls.Add(this.nupNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnThird);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnFirst);
            this.Name = "Form1";
            this.Text = "Fibonacci ";
            ((System.ComponentModel.ISupportInitialize)(this.nupNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.NumericUpDown nupNumber;
        private System.Windows.Forms.Label lblFib;
        private System.Windows.Forms.RichTextBox rtbExecution;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label lblExec;
    }
}

