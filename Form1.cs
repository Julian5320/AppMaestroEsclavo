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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(backgroundWorker2.IsBusy != true)
            {
                backgroundWorker2.RunWorkerAsync();
            }

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

                backgroundWorker2.CancelAsync();

        }

        private void ProgressBar1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                //backgroundWorker1.ReportProgress(i*10);
            }
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Se termino");
        }

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                if(backgroundWorker2.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                Thread.Sleep(1000);
                backgroundWorker2.ReportProgress(i * 10);
            }
        }

        private void BackgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;

        }

        private void BackgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Se termino");

        }
    }
}
