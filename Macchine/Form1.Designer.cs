namespace Macchine
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Strada = new System.Windows.Forms.PictureBox();
            this.MacchinaRossa = new System.Windows.Forms.PictureBox();
            this.MacchinaNera = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Strada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MacchinaRossa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MacchinaNera)).BeginInit();
            this.SuspendLayout();
            // 
            // Strada
            // 
            this.Strada.Image = ((System.Drawing.Image)(resources.GetObject("Strada.Image")));
            this.Strada.Location = new System.Drawing.Point(12, 86);
            this.Strada.Name = "Strada";
            this.Strada.Size = new System.Drawing.Size(417, 274);
            this.Strada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Strada.TabIndex = 0;
            this.Strada.TabStop = false;
            // 
            // MacchinaRossa
            // 
            this.MacchinaRossa.Image = ((System.Drawing.Image)(resources.GetObject("MacchinaRossa.Image")));
            this.MacchinaRossa.Location = new System.Drawing.Point(12, 135);
            this.MacchinaRossa.Name = "MacchinaRossa";
            this.MacchinaRossa.Size = new System.Drawing.Size(91, 47);
            this.MacchinaRossa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MacchinaRossa.TabIndex = 1;
            this.MacchinaRossa.TabStop = false;
            // 
            // MacchinaNera
            // 
            this.MacchinaNera.Image = ((System.Drawing.Image)(resources.GetObject("MacchinaNera.Image")));
            this.MacchinaNera.Location = new System.Drawing.Point(12, 262);
            this.MacchinaNera.Name = "MacchinaNera";
            this.MacchinaNera.Size = new System.Drawing.Size(91, 47);
            this.MacchinaNera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MacchinaNera.TabIndex = 2;
            this.MacchinaNera.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(47, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(315, 36);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 504);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.MacchinaNera);
            this.Controls.Add(this.MacchinaRossa);
            this.Controls.Add(this.Strada);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Strada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MacchinaRossa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MacchinaNera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Strada;
        private System.Windows.Forms.PictureBox MacchinaRossa;
        private System.Windows.Forms.PictureBox MacchinaNera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

