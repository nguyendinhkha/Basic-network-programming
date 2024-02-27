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

namespace MultiThreading_20520562
{
    public partial class BTTL_MultiThreading_20520562 : Form
    {
        public BTTL_MultiThreading_20520562()
        {
            /* Gets or sets a value indicating whether to catch calls on the wrong thread
            that access a control's Handle property when an application is being debugged. */

            // Property value: true if calls on the wrong thread are caught; otherwise, false.
            CheckForIllegalCrossThreadCalls = false;  
            InitializeComponent();
        }

        private void Count_num1(int num)
        {
            // conduct browsing from start to finish
            for (int i = 0; i <= num; i++)
            {
                // .Invoke((MethodInvoker)delegate - 
                /* Definition: Represents a delegate that can execute any method
                in managed code that is declared void and takes no parameters. */

                // Invoke an identify method (which already appear on winform :b) on the thread of the form.
                txtboxC1.Invoke((MethodInvoker) delegate
                {
                    txtboxC1.Text = i.ToString();
                });

                // Definition: Suspends the current thread for the specified amount of time.
                Thread.Sleep(100);  /* Thread.Sleep Method */
            }

            btnThread1.Invoke((MethodInvoker) delegate
            {
                btnThread1.Enabled = default;  // returns true if the control can respond to user interaction
                // Note: The default is true 
            });
        }

        private void Count_num2(int num)
        {
            // conduct browsing from start to finish
            for (int i = 0; i <= num; i++)
            {
                // .Invoke((MethodInvoker)delegate - 
                /* Definition: Represents a delegate that can execute any method
                in managed code that is declared void and takes no parameters. */

                // Invoke an identify method (which already appear on winform :b) on the thread of the form.
                txtboxC2.Invoke((MethodInvoker) delegate 
                {
                    txtboxC2.Text = i.ToString();
                });
                Thread.Sleep(100); /* Thread.Sleep Method */
            }

            txtboxC2.Invoke((MethodInvoker) delegate 
            {
                txtboxC2.Text = num.ToString();
            });

            btnThread2.Invoke((MethodInvoker) delegate 
            {
                btnThread2.Enabled = default;
                // Note: The default is true 
            });
        }

        // btnThread1 being used to start Thread 1
        private void btnThread1_Click(object sender, EventArgs e)
        {
            // use try - catch to make sure whether user typing in is an integer or not
            try
            {
                // get value from textbox textN
                int integerN = int.Parse(textN.Text);
                if (integerN != 0) // The i= (inequality) operators check if their operands are not equal.
                {
                    btnThread1.Enabled = false; // the control can't respond to user interaction
                    // return false

                    /* Create a new thread */
                    // Create thread1
                    Thread thread1 = new Thread(() =>
                    {
                        Count_num1(integerN);
                    });

                    thread1.IsBackground = false;
                    thread1.Start();    /* Definition: Causes a thread to be scheduled for execution. */
                }
            }
            catch
            {
                const string message = "Please enter a valid integer. ";
                MessageBox.Show(message);
            }
        }

        // btnThread2 being used to start Thread 2 ( which after Thread 1 )
        private void btnThread2_Click(object sender, EventArgs e)
        {
            // use try - catch to make sure whether user typing in is an integer or not
            try
            {
                // get value from textbox textN
                int integerN = int.Parse(textN.Text);
                if (integerN != 0)  // The i= (inequality) operators check if their operands are not equal.
                {
                    btnThread2.Enabled = false; // the control can't respond to user interaction
                    // return false
                    Thread thread2 = new Thread(() =>
                    {
                        Count_num2(integerN);
                    });

                    thread2.IsBackground = false;
                    thread2.Start(); /* Definition: Causes a thread to be scheduled for execution. */
                }
            }

            catch
            {
                const string message = "Please enter a valid integer. ";
                MessageBox.Show(message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.textN.Text = this.txtboxC1.Text = this.txtboxC2.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTTL_MultiThreading_20520562_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Are you sure that you would like to close the form ?? ";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
        }
    }
}
