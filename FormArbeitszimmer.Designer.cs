namespace WindowsFormsAppZeitgeist
{
    partial class FormArbeitszimmer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArbeitszimmer));
            this.pictureBoxArbeitszimmer = new System.Windows.Forms.PictureBox();
            this.labelComm = new System.Windows.Forms.Label();
            this.panelZimmerKarten = new System.Windows.Forms.Panel();
            this.pictureBoxCard0 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCard1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCard2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCard3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCard4 = new System.Windows.Forms.PictureBox();
            this.buttonZurueck = new System.Windows.Forms.Button();
            this.buttonWeiter = new System.Windows.Forms.Button();
            this.buttonUebertragen = new System.Windows.Forms.Button();
            this.buttonFertig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArbeitszimmer)).BeginInit();
            this.panelZimmerKarten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxArbeitszimmer
            // 
            this.pictureBoxArbeitszimmer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArbeitszimmer.Image")));
            this.pictureBoxArbeitszimmer.Location = new System.Drawing.Point(237, 60);
            this.pictureBoxArbeitszimmer.Name = "pictureBoxArbeitszimmer";
            this.pictureBoxArbeitszimmer.Size = new System.Drawing.Size(810, 297);
            this.pictureBoxArbeitszimmer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArbeitszimmer.TabIndex = 2;
            this.pictureBoxArbeitszimmer.TabStop = false;
            // 
            // labelComm
            // 
            this.labelComm.AutoSize = true;
            this.labelComm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComm.Location = new System.Drawing.Point(563, 9);
            this.labelComm.Name = "labelComm";
            this.labelComm.Size = new System.Drawing.Size(190, 38);
            this.labelComm.TabIndex = 3;
            this.labelComm.Text = "Du bist im Arbeitszimmer! \r\nWas möchtest du tun?";
            // 
            // panelZimmerKarten
            // 
            this.panelZimmerKarten.Controls.Add(this.pictureBoxCard0);
            this.panelZimmerKarten.Controls.Add(this.pictureBoxCard1);
            this.panelZimmerKarten.Controls.Add(this.pictureBoxCard2);
            this.panelZimmerKarten.Controls.Add(this.pictureBoxCard3);
            this.panelZimmerKarten.Controls.Add(this.pictureBoxCard4);
            this.panelZimmerKarten.Location = new System.Drawing.Point(12, 383);
            this.panelZimmerKarten.Name = "panelZimmerKarten";
            this.panelZimmerKarten.Size = new System.Drawing.Size(1189, 354);
            this.panelZimmerKarten.TabIndex = 4;
            // 
            // pictureBoxCard0
            // 
            this.pictureBoxCard0.Location = new System.Drawing.Point(13, 11);
            this.pictureBoxCard0.Name = "pictureBoxCard0";
            this.pictureBoxCard0.Size = new System.Drawing.Size(217, 332);
            this.pictureBoxCard0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCard0.TabIndex = 1;
            this.pictureBoxCard0.TabStop = false;
            this.pictureBoxCard0.Click += new System.EventHandler(this.ZiKartenClick);
            // 
            // pictureBoxCard1
            // 
            this.pictureBoxCard1.Location = new System.Drawing.Point(236, 11);
            this.pictureBoxCard1.Name = "pictureBoxCard1";
            this.pictureBoxCard1.Size = new System.Drawing.Size(217, 332);
            this.pictureBoxCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCard1.TabIndex = 1;
            this.pictureBoxCard1.TabStop = false;
            this.pictureBoxCard1.Click += new System.EventHandler(this.ZiKartenClick);
            // 
            // pictureBoxCard2
            // 
            this.pictureBoxCard2.Location = new System.Drawing.Point(459, 11);
            this.pictureBoxCard2.Name = "pictureBoxCard2";
            this.pictureBoxCard2.Size = new System.Drawing.Size(217, 332);
            this.pictureBoxCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCard2.TabIndex = 1;
            this.pictureBoxCard2.TabStop = false;
            this.pictureBoxCard2.Click += new System.EventHandler(this.ZiKartenClick);
            // 
            // pictureBoxCard3
            // 
            this.pictureBoxCard3.Location = new System.Drawing.Point(682, 11);
            this.pictureBoxCard3.Name = "pictureBoxCard3";
            this.pictureBoxCard3.Size = new System.Drawing.Size(217, 332);
            this.pictureBoxCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCard3.TabIndex = 1;
            this.pictureBoxCard3.TabStop = false;
            this.pictureBoxCard3.Click += new System.EventHandler(this.ZiKartenClick);
            // 
            // pictureBoxCard4
            // 
            this.pictureBoxCard4.Location = new System.Drawing.Point(905, 11);
            this.pictureBoxCard4.Name = "pictureBoxCard4";
            this.pictureBoxCard4.Size = new System.Drawing.Size(217, 332);
            this.pictureBoxCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCard4.TabIndex = 1;
            this.pictureBoxCard4.TabStop = false;
            this.pictureBoxCard4.Click += new System.EventHandler(this.ZiKartenClick);
            // 
            // buttonZurueck
            // 
            this.buttonZurueck.Enabled = false;
            this.buttonZurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZurueck.Location = new System.Drawing.Point(1208, 406);
            this.buttonZurueck.Name = "buttonZurueck";
            this.buttonZurueck.Size = new System.Drawing.Size(35, 23);
            this.buttonZurueck.TabIndex = 5;
            this.buttonZurueck.Text = "<--";
            this.buttonZurueck.UseVisualStyleBackColor = true;
            this.buttonZurueck.Click += new System.EventHandler(this.buttonZurueck_Click);
            // 
            // buttonWeiter
            // 
            this.buttonWeiter.Enabled = false;
            this.buttonWeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeiter.Location = new System.Drawing.Point(1249, 406);
            this.buttonWeiter.Name = "buttonWeiter";
            this.buttonWeiter.Size = new System.Drawing.Size(35, 23);
            this.buttonWeiter.TabIndex = 5;
            this.buttonWeiter.Text = "-->";
            this.buttonWeiter.UseVisualStyleBackColor = true;
            this.buttonWeiter.Click += new System.EventHandler(this.buttonWeiter_Click);
            // 
            // buttonUebertragen
            // 
            this.buttonUebertragen.Enabled = false;
            this.buttonUebertragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUebertragen.Location = new System.Drawing.Point(1208, 456);
            this.buttonUebertragen.Name = "buttonUebertragen";
            this.buttonUebertragen.Size = new System.Drawing.Size(99, 31);
            this.buttonUebertragen.TabIndex = 5;
            this.buttonUebertragen.Text = "Übertragen";
            this.buttonUebertragen.UseVisualStyleBackColor = true;
            this.buttonUebertragen.Click += new System.EventHandler(this.buttonUebertragen_Click);
            // 
            // buttonFertig
            // 
            this.buttonFertig.Enabled = false;
            this.buttonFertig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFertig.Location = new System.Drawing.Point(1208, 566);
            this.buttonFertig.Name = "buttonFertig";
            this.buttonFertig.Size = new System.Drawing.Size(99, 31);
            this.buttonFertig.TabIndex = 5;
            this.buttonFertig.Text = "Fertig";
            this.buttonFertig.UseVisualStyleBackColor = true;
            this.buttonFertig.Click += new System.EventHandler(this.buttonFertig_Click);
            // 
            // FormArbeitszimmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 741);
            this.Controls.Add(this.buttonWeiter);
            this.Controls.Add(this.buttonFertig);
            this.Controls.Add(this.buttonUebertragen);
            this.Controls.Add(this.buttonZurueck);
            this.Controls.Add(this.panelZimmerKarten);
            this.Controls.Add(this.labelComm);
            this.Controls.Add(this.pictureBoxArbeitszimmer);
            this.Location = new System.Drawing.Point(580, 0);
            this.Name = "FormArbeitszimmer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormArbeitszimmer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArbeitszimmer)).EndInit();
            this.panelZimmerKarten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxArbeitszimmer;
        private System.Windows.Forms.Label labelComm;
        private System.Windows.Forms.Panel panelZimmerKarten;
        private System.Windows.Forms.PictureBox pictureBoxCard4;
        private System.Windows.Forms.PictureBox pictureBoxCard3;
        private System.Windows.Forms.PictureBox pictureBoxCard2;
        private System.Windows.Forms.PictureBox pictureBoxCard1;
        private System.Windows.Forms.PictureBox pictureBoxCard0;
        private System.Windows.Forms.Button buttonZurueck;
        private System.Windows.Forms.Button buttonWeiter;
        private System.Windows.Forms.Button buttonUebertragen;
        private System.Windows.Forms.Button buttonFertig;
    }
}