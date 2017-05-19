namespace WindowsFormsAppZeitgeist
{
    partial class FormHaendler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHaendler));
            this.labelComm = new System.Windows.Forms.Label();
            this.pictureBoxHaendler = new System.Windows.Forms.PictureBox();
            this.buttonKaufen = new System.Windows.Forms.Button();
            this.buttonTauschen = new System.Windows.Forms.Button();
            this.buttonVerkaufen = new System.Windows.Forms.Button();
            this.buttonZufaellig = new System.Windows.Forms.Button();
            this.buttonBestimmt = new System.Windows.Forms.Button();
            this.labelComm2 = new System.Windows.Forms.Label();
            this.buttonFertig = new System.Windows.Forms.Button();
            this.tableLayoutPanelKomponenten = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHaendler)).BeginInit();
            this.SuspendLayout();
            // 
            // labelComm
            // 
            this.labelComm.AutoSize = true;
            this.labelComm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComm.Location = new System.Drawing.Point(298, 40);
            this.labelComm.Name = "labelComm";
            this.labelComm.Size = new System.Drawing.Size(162, 38);
            this.labelComm.TabIndex = 0;
            this.labelComm.Text = "Du bist beim Händler! \r\nWas möchtest du tun?";
            // 
            // pictureBoxHaendler
            // 
            this.pictureBoxHaendler.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHaendler.Image")));
            this.pictureBoxHaendler.Location = new System.Drawing.Point(11, 101);
            this.pictureBoxHaendler.Name = "pictureBoxHaendler";
            this.pictureBoxHaendler.Size = new System.Drawing.Size(810, 297);
            this.pictureBoxHaendler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHaendler.TabIndex = 1;
            this.pictureBoxHaendler.TabStop = false;
            // 
            // buttonKaufen
            // 
            this.buttonKaufen.Location = new System.Drawing.Point(11, 431);
            this.buttonKaufen.Name = "buttonKaufen";
            this.buttonKaufen.Size = new System.Drawing.Size(75, 23);
            this.buttonKaufen.TabIndex = 2;
            this.buttonKaufen.Text = "Kaufen";
            this.buttonKaufen.UseVisualStyleBackColor = true;
            this.buttonKaufen.Click += new System.EventHandler(this.buttonKaufen_Click);
            // 
            // buttonTauschen
            // 
            this.buttonTauschen.Location = new System.Drawing.Point(11, 474);
            this.buttonTauschen.Name = "buttonTauschen";
            this.buttonTauschen.Size = new System.Drawing.Size(75, 23);
            this.buttonTauschen.TabIndex = 2;
            this.buttonTauschen.Text = "Tauschen";
            this.buttonTauschen.UseVisualStyleBackColor = true;
            this.buttonTauschen.Click += new System.EventHandler(this.buttonTauschen_Click);
            // 
            // buttonVerkaufen
            // 
            this.buttonVerkaufen.Location = new System.Drawing.Point(11, 515);
            this.buttonVerkaufen.Name = "buttonVerkaufen";
            this.buttonVerkaufen.Size = new System.Drawing.Size(75, 23);
            this.buttonVerkaufen.TabIndex = 2;
            this.buttonVerkaufen.Text = "Verkaufen";
            this.buttonVerkaufen.UseVisualStyleBackColor = true;
            this.buttonVerkaufen.Click += new System.EventHandler(this.buttonVerkaufen_Click);
            // 
            // buttonZufaellig
            // 
            this.buttonZufaellig.Location = new System.Drawing.Point(109, 404);
            this.buttonZufaellig.Name = "buttonZufaellig";
            this.buttonZufaellig.Size = new System.Drawing.Size(197, 23);
            this.buttonZufaellig.TabIndex = 2;
            this.buttonZufaellig.Text = "2 zufällige Komponenten ziehen";
            this.buttonZufaellig.UseVisualStyleBackColor = true;
            this.buttonZufaellig.Visible = false;
            this.buttonZufaellig.Click += new System.EventHandler(this.buttonZufaellig_Click);
            // 
            // buttonBestimmt
            // 
            this.buttonBestimmt.Location = new System.Drawing.Point(109, 453);
            this.buttonBestimmt.Name = "buttonBestimmt";
            this.buttonBestimmt.Size = new System.Drawing.Size(252, 23);
            this.buttonBestimmt.TabIndex = 2;
            this.buttonBestimmt.Text = "für 2 Gold eine Komponente deiner Wahl kaufen";
            this.buttonBestimmt.UseVisualStyleBackColor = true;
            this.buttonBestimmt.Visible = false;
            this.buttonBestimmt.Click += new System.EventHandler(this.buttonBestimmt_Click);
            // 
            // labelComm2
            // 
            this.labelComm2.AutoSize = true;
            this.labelComm2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComm2.Location = new System.Drawing.Point(12, 563);
            this.labelComm2.Name = "labelComm2";
            this.labelComm2.Size = new System.Drawing.Size(275, 19);
            this.labelComm2.TabIndex = 0;
            this.labelComm2.Text = "Bitte auswählen und auf fertig drücken";
            this.labelComm2.Visible = false;
            // 
            // buttonFertig
            // 
            this.buttonFertig.Location = new System.Drawing.Point(469, 455);
            this.buttonFertig.Name = "buttonFertig";
            this.buttonFertig.Size = new System.Drawing.Size(75, 23);
            this.buttonFertig.TabIndex = 2;
            this.buttonFertig.Text = "Fertig!";
            this.buttonFertig.UseVisualStyleBackColor = true;
            this.buttonFertig.Visible = false;
            this.buttonFertig.Click += new System.EventHandler(this.buttonFertig_Click);
            // 
            // tableLayoutPanelKomponenten
            // 
            this.tableLayoutPanelKomponenten.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelKomponenten.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelKomponenten.ColumnCount = 3;
            this.tableLayoutPanelKomponenten.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelKomponenten.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelKomponenten.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelKomponenten.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelKomponenten.ForeColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelKomponenten.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelKomponenten.Location = new System.Drawing.Point(376, 484);
            this.tableLayoutPanelKomponenten.Name = "tableLayoutPanelKomponenten";
            this.tableLayoutPanelKomponenten.RowCount = 2;
            this.tableLayoutPanelKomponenten.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelKomponenten.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelKomponenten.Size = new System.Drawing.Size(263, 176);
            this.tableLayoutPanelKomponenten.TabIndex = 3;
            this.tableLayoutPanelKomponenten.Visible = false;
            // 
            // FormHaendler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 669);
            this.Controls.Add(this.tableLayoutPanelKomponenten);
            this.Controls.Add(this.buttonFertig);
            this.Controls.Add(this.buttonVerkaufen);
            this.Controls.Add(this.buttonTauschen);
            this.Controls.Add(this.buttonBestimmt);
            this.Controls.Add(this.buttonZufaellig);
            this.Controls.Add(this.buttonKaufen);
            this.Controls.Add(this.pictureBoxHaendler);
            this.Controls.Add(this.labelComm2);
            this.Controls.Add(this.labelComm);
            this.Location = new System.Drawing.Point(540, 0);
            this.Name = "FormHaendler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormHaendler";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHaendler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComm;
        private System.Windows.Forms.PictureBox pictureBoxHaendler;
        private System.Windows.Forms.Button buttonKaufen;
        private System.Windows.Forms.Button buttonTauschen;
        private System.Windows.Forms.Button buttonVerkaufen;
        private System.Windows.Forms.Button buttonZufaellig;
        private System.Windows.Forms.Button buttonBestimmt;
        private System.Windows.Forms.Label labelComm2;
        private System.Windows.Forms.Button buttonFertig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKomponenten;
    }
}