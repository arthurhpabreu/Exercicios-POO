namespace _2._1_Lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.powerTV = new System.Windows.Forms.Button();
            this.PowerDVD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.volumeTV = new System.Windows.Forms.TrackBar();
            this.volumeDVD = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusVolumeTV = new System.Windows.Forms.Label();
            this.statusVolumeDVD = new System.Windows.Forms.Label();
            this.aumentarCanal = new System.Windows.Forms.Button();
            this.diminuirCanal = new System.Windows.Forms.Button();
            this.statusTV = new System.Windows.Forms.Label();
            this.statusDVD = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusCanal = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.statusFilme = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inserirButton = new System.Windows.Forms.Button();
            this.statusCD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeDVD)).BeginInit();
            this.SuspendLayout();
            // 
            // powerTV
            // 
            this.powerTV.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerTV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.powerTV.Location = new System.Drawing.Point(12, 25);
            this.powerTV.Name = "powerTV";
            this.powerTV.Size = new System.Drawing.Size(259, 91);
            this.powerTV.TabIndex = 0;
            this.powerTV.Text = "POWER";
            this.powerTV.UseVisualStyleBackColor = true;
            this.powerTV.Click += new System.EventHandler(this.powerTV_Click);
            // 
            // PowerDVD
            // 
            this.PowerDVD.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerDVD.Location = new System.Drawing.Point(289, 25);
            this.PowerDVD.Name = "PowerDVD";
            this.PowerDVD.Size = new System.Drawing.Size(259, 91);
            this.PowerDVD.TabIndex = 1;
            this.PowerDVD.Text = "POWER";
            this.PowerDVD.UseVisualStyleBackColor = true;
            this.PowerDVD.Click += new System.EventHandler(this.PowerDVD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TELEVISOR:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DVD:";
            // 
            // volumeTV
            // 
            this.volumeTV.Enabled = false;
            this.volumeTV.Location = new System.Drawing.Point(12, 135);
            this.volumeTV.Maximum = 100;
            this.volumeTV.Name = "volumeTV";
            this.volumeTV.Size = new System.Drawing.Size(259, 45);
            this.volumeTV.TabIndex = 4;
            this.volumeTV.Scroll += new System.EventHandler(this.volumeTV_Scroll);
            // 
            // volumeDVD
            // 
            this.volumeDVD.Enabled = false;
            this.volumeDVD.Location = new System.Drawing.Point(289, 135);
            this.volumeDVD.Maximum = 100;
            this.volumeDVD.Name = "volumeDVD";
            this.volumeDVD.Size = new System.Drawing.Size(259, 45);
            this.volumeDVD.TabIndex = 5;
            this.volumeDVD.Scroll += new System.EventHandler(this.VolumeDVD_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "VOLUME: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "VOLUME: ";
            // 
            // statusVolumeTV
            // 
            this.statusVolumeTV.AutoSize = true;
            this.statusVolumeTV.Location = new System.Drawing.Point(179, 119);
            this.statusVolumeTV.Name = "statusVolumeTV";
            this.statusVolumeTV.Size = new System.Drawing.Size(13, 13);
            this.statusVolumeTV.TabIndex = 8;
            this.statusVolumeTV.Text = "0";
            // 
            // statusVolumeDVD
            // 
            this.statusVolumeDVD.AutoSize = true;
            this.statusVolumeDVD.Location = new System.Drawing.Point(458, 119);
            this.statusVolumeDVD.Name = "statusVolumeDVD";
            this.statusVolumeDVD.Size = new System.Drawing.Size(13, 13);
            this.statusVolumeDVD.TabIndex = 9;
            this.statusVolumeDVD.Text = "0";
            // 
            // aumentarCanal
            // 
            this.aumentarCanal.Enabled = false;
            this.aumentarCanal.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aumentarCanal.Location = new System.Drawing.Point(12, 186);
            this.aumentarCanal.Name = "aumentarCanal";
            this.aumentarCanal.Size = new System.Drawing.Size(119, 64);
            this.aumentarCanal.TabIndex = 10;
            this.aumentarCanal.Text = "+";
            this.aumentarCanal.UseVisualStyleBackColor = true;
            this.aumentarCanal.Click += new System.EventHandler(this.aumentarCanal_Click);
            // 
            // diminuirCanal
            // 
            this.diminuirCanal.Enabled = false;
            this.diminuirCanal.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diminuirCanal.Location = new System.Drawing.Point(12, 256);
            this.diminuirCanal.Name = "diminuirCanal";
            this.diminuirCanal.Size = new System.Drawing.Size(119, 64);
            this.diminuirCanal.TabIndex = 11;
            this.diminuirCanal.Text = "-";
            this.diminuirCanal.UseVisualStyleBackColor = true;
            this.diminuirCanal.Click += new System.EventHandler(this.diminuirCanal_Click);
            // 
            // statusTV
            // 
            this.statusTV.AutoSize = true;
            this.statusTV.Location = new System.Drawing.Point(179, 9);
            this.statusTV.Name = "statusTV";
            this.statusTV.Size = new System.Drawing.Size(21, 13);
            this.statusTV.TabIndex = 12;
            this.statusTV.Text = "Off";
            // 
            // statusDVD
            // 
            this.statusDVD.AutoSize = true;
            this.statusDVD.Location = new System.Drawing.Point(439, 9);
            this.statusDVD.Name = "statusDVD";
            this.statusDVD.Size = new System.Drawing.Size(21, 13);
            this.statusDVD.TabIndex = 13;
            this.statusDVD.Text = "Off";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CANAL: ";
            // 
            // statusCanal
            // 
            this.statusCanal.AutoSize = true;
            this.statusCanal.Location = new System.Drawing.Point(206, 216);
            this.statusCanal.Name = "statusCanal";
            this.statusCanal.Size = new System.Drawing.Size(13, 13);
            this.statusCanal.TabIndex = 15;
            this.statusCanal.Text = "1";
            this.statusCanal.Click += new System.EventHandler(this.canalTV_Click);
            // 
            // playButton
            // 
            this.playButton.Enabled = false;
            this.playButton.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(289, 186);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(119, 61);
            this.playButton.TabIndex = 16;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(289, 253);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(119, 64);
            this.stopButton.TabIndex = 17;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // statusFilme
            // 
            this.statusFilme.AutoSize = true;
            this.statusFilme.Location = new System.Drawing.Point(456, 283);
            this.statusFilme.Name = "statusFilme";
            this.statusFilme.Size = new System.Drawing.Size(49, 13);
            this.statusFilme.TabIndex = 18;
            this.statusFilme.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inserirButton
            // 
            this.inserirButton.Enabled = false;
            this.inserirButton.Location = new System.Drawing.Point(422, 186);
            this.inserirButton.Name = "inserirButton";
            this.inserirButton.Size = new System.Drawing.Size(126, 32);
            this.inserirButton.TabIndex = 19;
            this.inserirButton.Text = "Inserir";
            this.inserirButton.UseVisualStyleBackColor = true;
            this.inserirButton.Click += new System.EventHandler(this.inserirButton_Click);
            // 
            // statusCD
            // 
            this.statusCD.AutoSize = true;
            this.statusCD.Location = new System.Drawing.Point(439, 237);
            this.statusCD.Name = "statusCD";
            this.statusCD.Size = new System.Drawing.Size(90, 13);
            this.statusCD.TabIndex = 20;
            this.statusCD.Text = "INSIRA O DISCO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(422, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Programadores: João Gontijo, Daniel Jorge, Arthur Henrique, Robert Victor, Breno " +
    "Vieira.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusCD);
            this.Controls.Add(this.inserirButton);
            this.Controls.Add(this.statusFilme);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.statusCanal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusDVD);
            this.Controls.Add(this.statusTV);
            this.Controls.Add(this.diminuirCanal);
            this.Controls.Add(this.aumentarCanal);
            this.Controls.Add(this.statusVolumeDVD);
            this.Controls.Add(this.statusVolumeTV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.volumeDVD);
            this.Controls.Add(this.volumeTV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PowerDVD);
            this.Controls.Add(this.powerTV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CONTROLE";
            ((System.ComponentModel.ISupportInitialize)(this.volumeTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeDVD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powerTV;
        private System.Windows.Forms.Button PowerDVD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar volumeTV;
        private System.Windows.Forms.TrackBar volumeDVD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label statusVolumeTV;
        private System.Windows.Forms.Label statusVolumeDVD;
        private System.Windows.Forms.Button aumentarCanal;
        private System.Windows.Forms.Button diminuirCanal;
        private System.Windows.Forms.Label statusTV;
        private System.Windows.Forms.Label statusDVD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statusCanal;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label statusFilme;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button inserirButton;
        private System.Windows.Forms.Label statusCD;
        private System.Windows.Forms.Label label5;
    }
}

