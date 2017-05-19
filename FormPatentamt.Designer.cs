namespace WindowsFormsAppZeitgeist
{
    partial class FormPatentamt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatentamt));
            this.pictureBoxPatentamt = new System.Windows.Forms.PictureBox();
            this.labelComm = new System.Windows.Forms.Label();
            this.buttonPatentieren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPatentamt)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPatentamt
            // 
            this.pictureBoxPatentamt.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPatentamt.Image")));
            this.pictureBoxPatentamt.Location = new System.Drawing.Point(11, 101);
            this.pictureBoxPatentamt.Name = "pictureBoxPatentamt";
            this.pictureBoxPatentamt.Size = new System.Drawing.Size(810, 297);
            this.pictureBoxPatentamt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPatentamt.TabIndex = 2;
            this.pictureBoxPatentamt.TabStop = false;
            // 
            // labelComm
            // 
            this.labelComm.AutoSize = true;
            this.labelComm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComm.Location = new System.Drawing.Point(204, 22);
            this.labelComm.Name = "labelComm";
            this.labelComm.Size = new System.Drawing.Size(412, 76);
            this.labelComm.TabIndex = 3;
            this.labelComm.Text = "Du bist beim Patentamt! \r\nBitte markiere die Idee, die du patentieren lassen möch" +
    "test\r\nund klicke anschließend auf \'Patentieren\'.\r\n\r\n";
            // 
            // buttonPatentieren
            // 
            this.buttonPatentieren.Location = new System.Drawing.Point(363, 430);
            this.buttonPatentieren.Name = "buttonPatentieren";
            this.buttonPatentieren.Size = new System.Drawing.Size(117, 30);
            this.buttonPatentieren.TabIndex = 4;
            this.buttonPatentieren.Text = "Patentieren";
            this.buttonPatentieren.UseVisualStyleBackColor = true;
            this.buttonPatentieren.Click += new System.EventHandler(this.buttonPatentieren_Click);
            // 
            // FormPatentamt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 492);
            this.Controls.Add(this.buttonPatentieren);
            this.Controls.Add(this.labelComm);
            this.Controls.Add(this.pictureBoxPatentamt);
            this.Location = new System.Drawing.Point(540, 100);
            this.Name = "FormPatentamt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormPatentamt";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPatentamt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPatentamt;
        private System.Windows.Forms.Label labelComm;
        private System.Windows.Forms.Button buttonPatentieren;
    }
}