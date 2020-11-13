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

namespace Macchine
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            PictureBox Macchina = (PictureBox)e.Argument;

            //Macchina.Location = new Point(0, 0);
            while (Macchina.Location.X < Strada.Width - Macchina.Width + Strada.Location.X)
            {
                if (!bgw.CancellationPending)
                {
                    //Thread.Sleep(50);
                    Thread.Sleep(rnd.Next(0, 101));
                    //int n = 3;
                    int n = rnd.Next(0, 5);
                    bgw.ReportProgress(n, Macchina);
                }
            }
            //if (Macchina.Name == "MacchinaRossa" && !bgw.CancellationPending)
            //{
            //    e.Result = Macchina.Name;
            //    backgroundWorker2.CancelAsync();
            //}
            //else if (Macchina.Name == "MacchinaNera" && !bgw.CancellationPending)
            //{
            //    e.Result = Macchina.Name;
            //    backgroundWorker1.CancelAsync();
            //}
            if (!bgw.CancellationPending)
                e.Result = Macchina.Name;
            backgroundWorker1.CancelAsync();
            backgroundWorker2.CancelAsync();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PictureBox Macchina = (PictureBox)e.UserState;
            int x = Macchina.Location.X + e.ProgressPercentage;
            Macchina.Location = new Point(x, Macchina.Location.Y);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var Macchina = e.Result as string;
            MessageBox.Show("Vincitrice: " + Macchina);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RipristinaPosizioni();
            backgroundWorker1.RunWorkerAsync(MacchinaRossa);
            backgroundWorker2.RunWorkerAsync(MacchinaNera);
        }

        private void RipristinaPosizioni()
        { 
            MacchinaRossa.Location = new Point(Strada.Location.X, MacchinaRossa.Location.Y);
            MacchinaNera.Location = new Point(Strada.Location.X, MacchinaNera.Location.Y);           
        }
    }
}
