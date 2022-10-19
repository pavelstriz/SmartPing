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

namespace SmartPing_v1._0._0
{
    public partial class sendProgressBar : Form
    {
        public sendProgressBar()
        {
            InitializeComponent();
        }
        struct DataParemeter
        {
            public int Process;
            public int Delay;
            
        }
        private DataParemeter _inputParameter;
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = string.Format("Sending email...{0}%", e.ProgressPercentage);
            progressBar1.Update();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParemeter)e.Argument).Process;
            int delay = ((DataParemeter)e.Argument).Delay;
            int index = 1;
            try
            {
                for(int i = 0; i < process;i++)
                {
                    if(!backgroundWorker1.CancellationPending)
                    {
                        backgroundWorker1.ReportProgress(index++ * 100 / process, string.Format("Process data {0}", i));
                        Thread.Sleep(delay);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker1.CancelAsync();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Email successfully sent.","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e) // 1
        {
            if(!backgroundWorker1.IsBusy)
            {
                _inputParameter.Delay = 100;
                _inputParameter.Process = 10;
                backgroundWorker1.RunWorkerAsync(_inputParameter);
            }
        }

        private void button2_Click(object sender, EventArgs e) //2
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
    }
}
