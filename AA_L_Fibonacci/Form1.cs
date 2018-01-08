using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AA_L_Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ExecutionTimeLog = "";
      
        private void btnFirst_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            rtbResult.Text = RecursiveFibonacci((int)nupNumber.Value).ToString();
            watch.Stop();
            ExecutionTimeLog += "First impl. exec. in milliseconds: " + watch.ElapsedMilliseconds.ToString() + "\n";
            ExecutionTimeLog += "First impl. exec. in tics: " + watch.ElapsedTicks.ToString() + "\n\n";
            rtbExecution.Text = ExecutionTimeLog;
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            rtbResult.Text = TableFibonacci((int)nupNumber.Value).ToString();
            watch.Stop();
            ExecutionTimeLog += "Second impl. exec. in milliseconds: " + watch.ElapsedMilliseconds.ToString() + "\n";
            ExecutionTimeLog += "Second impl. exec. in tics: " + watch.ElapsedTicks.ToString() + "\n\n";
            rtbExecution.Text = ExecutionTimeLog;
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            rtbResult.Text = ThirdImplementation((int)nupNumber.Value).ToString();
            watch.Stop();
            ExecutionTimeLog += "Third impl. exec. in milliseconds: " + watch.ElapsedMilliseconds.ToString() + "\n";
            ExecutionTimeLog += "Third impl. exec. in tics: " + watch.ElapsedTicks.ToString() + "\n\n";
            rtbExecution.Text = ExecutionTimeLog;
        }

        private Int64 RecursiveFibonacci(int k)
        {
            if (k == 1)
                return 1;
            if (k <= 0)
                return 0;
            return RecursiveFibonacci(k - 1) + RecursiveFibonacci(k - 2);
        }

        Int64[] table = new Int64[100];
        private Int64 TableFibonacci(int k)
        {
            if (table[k] == 0)
            {
                if (k < 2)
                    table[k] = k;
                else
                    table[k] = TableFibonacci(k - 1) + TableFibonacci(k - 2);
            }
            return table[k];
        }

        private Int64 ThirdImplementation(int k)
        {
            Int64 a = 0, b = 1;
            for (int i = 0; i < k; i++)
            {
                Int64 c = a + b;
                a = b;
                b = c;
            }
            return a;
        }

        private void rtbExecution_TextChanged(object sender, EventArgs e)
        {
            rtbExecution.SelectionStart = rtbExecution.Text.Length;
            rtbExecution.ScrollToCaret();
        }
    }
}
