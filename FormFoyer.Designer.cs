namespace WindowsFormsAppZeitgeist
{
    partial class FormFoyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFoyer));
            this.pictureBoxFoyer = new System.Windows.Forms.PictureBox();
            this.labelComm = new System.Windows.Forms.Label();
            this.buttonAnheuern = new System.Windows.Forms.Button();
            this.buttonEinsetzen = new System.Windows.Forms.Button();
            this.panelDienerAuswahl = new System.Windows.Forms.Panel();
            this.pictureBoxSpion = new System.Windows.Forms.PictureBox();
            this.pictureBoxWaechter = new System.Windows.Forms.PictureBox();
            this.pictureBoxBote = new System.Windows.Forms.PictureBox();
            this.labelBote = new System.Windows.Forms.Label();
            this.labelWaechter = new System.Windows.Forms.Label();
            this.labelSpion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoyer)).BeginInit();
            this.panelDienerAuswahl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaechter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBote)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFoyer
            // 
            this.pictureBoxFoyer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoyer.Image")));
            this.pictureBoxFoyer.Location = new System.Drawing.Point(11, 101);
            this.pictureBoxFoyer.Name = "pictureBoxFoyer";
            this.pictureBoxFoyer.Size = new System.Drawing.Size(810, 297);
            this.pictureBoxFoyer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoyer.TabIndex = 3;
            this.pictureBoxFoyer.TabStop = false;
            // 
            // labelComm
            // 
            this.labelComm.AutoSize = true;
            this.labelComm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComm.Location = new System.Drawing.Point(343, 28);
            this.labelComm.Name = "labelComm";
            this.labelComm.Size = new System.Drawing.Size(162, 57);
            this.labelComm.TabIndex = 4;
            this.labelComm.Text = "Du bist im Foyer! \r\nWas möchtest du tun?\r\n\r\n";
            // 
            // buttonAnheuern
            // 
            this.buttonAnheuern.Location = new System.Drawing.Point(12, 417);
            this.buttonAnheuern.Name = "buttonAnheuern";
            this.buttonAnheuern.Size = new System.Drawing.Size(116, 23);
            this.buttonAnheuern.TabIndex = 5;
            this.buttonAnheuern.Text = "Diener anheuern";
            this.buttonAnheuern.UseVisualStyleBackColor = true;
            this.buttonAnheuern.Click += new System.EventHandler(this.buttonAnheuern_Click);
            // 
            // buttonEinsetzen
            // 
            this.buttonEinsetzen.Location = new System.Drawing.Point(12, 470);
            this.buttonEinsetzen.Name = "buttonEinsetzen";
            this.buttonEinsetzen.Size = new System.Drawing.Size(116, 23);
            this.buttonEinsetzen.TabIndex = 6;
            this.buttonEinsetzen.Text = "Diener einsetzen";
            this.buttonEinsetzen.UseVisualStyleBackColor = true;
            this.buttonEinsetzen.Click += new System.EventHandler(this.buttonEinsetzen_Click);
            // 
            // panelDienerAuswahl
            // 
            this.panelDienerAuswahl.Controls.Add(this.pictureBoxSpion);
            this.panelDienerAuswahl.Controls.Add(this.pictureBoxWaechter);
            this.panelDienerAuswahl.Controls.Add(this.pictureBoxBote);
            this.panelDienerAuswahl.Controls.Add(this.labelBote);
            this.panelDienerAuswahl.Controls.Add(this.labelWaechter);
            this.panelDienerAuswahl.Controls.Add(this.labelSpion);
            this.panelDienerAuswahl.Location = new System.Drawing.Point(213, 404);
            this.panelDienerAuswahl.Name = "panelDienerAuswahl";
            this.panelDienerAuswahl.Size = new System.Drawing.Size(320, 138);
            this.panelDienerAuswahl.TabIndex = 7;
            this.panelDienerAuswahl.Visible = false;
            // 
            // pictureBoxSpion
            // 
            this.pictureBoxSpion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSpion.Image")));
            this.pictureBoxSpion.Location = new System.Drawing.Point(9, 33);
            this.pictureBoxSpion.Name = "pictureBoxSpion";
            this.pictureBoxSpion.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxSpion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSpion.TabIndex = 0;
            this.pictureBoxSpion.TabStop = false;
            this.pictureBoxSpion.Click += new System.EventHandler(this.Diener_Click);
            // 
            // pictureBoxWaechter
            // 
            this.pictureBoxWaechter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWaechter.Image")));
            this.pictureBoxWaechter.Location = new System.Drawing.Point(110, 33);
            this.pictureBoxWaechter.Name = "pictureBoxWaechter";
            this.pictureBoxWaechter.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxWaechter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWaechter.TabIndex = 0;
            this.pictureBoxWaechter.TabStop = false;
            this.pictureBoxWaechter.Click += new System.EventHandler(this.Diener_Click);
            // 
            // pictureBoxBote
            // 
            this.pictureBoxBote.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBote.Image")));
            this.pictureBoxBote.Location = new System.Drawing.Point(211, 33);
            this.pictureBoxBote.Name = "pictureBoxBote";
            this.pictureBoxBote.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxBote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBote.TabIndex = 0;
            this.pictureBoxBote.TabStop = false;
            this.pictureBoxBote.Click += new System.EventHandler(this.Diener_Click);
            // 
            // labelBote
            // 
            this.labelBote.AutoSize = true;
            this.labelBote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBote.Location = new System.Drawing.Point(239, 9);
            this.labelBote.Name = "labelBote";
            this.labelBote.Size = new System.Drawing.Size(43, 18);
            this.labelBote.TabIndex = 1;
            this.labelBote.Text = "Bote";
            // 
            // labelWaechter
            // 
            this.labelWaechter.AutoSize = true;
            this.labelWaechter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaechter.Location = new System.Drawing.Point(123, 9);
            this.labelWaechter.Name = "labelWaechter";
            this.labelWaechter.Size = new System.Drawing.Size(71, 18);
            this.labelWaechter.TabIndex = 1;
            this.labelWaechter.Text = "Wächter";
            // 
            // labelSpion
            // 
            this.labelSpion.AutoSize = true;
            this.labelSpion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpion.Location = new System.Drawing.Point(32, 9);
            this.labelSpion.Name = "labelSpion";
            this.labelSpion.Size = new System.Drawing.Size(51, 18);
            this.labelSpion.TabIndex = 1;
            this.labelSpion.Text = "Spion";
            // 
            // FormFoyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 554);
            this.Controls.Add(this.panelDienerAuswahl);
            this.Controls.Add(this.buttonEinsetzen);
            this.Controls.Add(this.buttonAnheuern);
            this.Controls.Add(this.labelComm);
            this.Controls.Add(this.pictureBoxFoyer);
            this.Name = "FormFoyer";
            this.Text = "FormFoyer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoyer)).EndInit();
            this.panelDienerAuswahl.ResumeLayout(false);
            this.panelDienerAuswahl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWaechter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFoyer;
        private System.Windows.Forms.Label labelComm;
        private System.Windows.Forms.Button buttonAnheuern;
        private System.Windows.Forms.Button buttonEinsetzen;
        private System.Windows.Forms.Panel panelDienerAuswahl;
        private System.Windows.Forms.Label labelBote;
        private System.Windows.Forms.Label labelWaechter;
        private System.Windows.Forms.Label labelSpion;
        private System.Windows.Forms.PictureBox pictureBoxBote;
        private System.Windows.Forms.PictureBox pictureBoxWaechter;
        private System.Windows.Forms.PictureBox pictureBoxSpion;
    }
}