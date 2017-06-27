using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppZeitgeist
{
    public partial class FormHaendler : Form
    {
        private Form1 myForm;
        private Gameplay party;
        private List<Image> komponenten;
        private Spieler s;
        private bool changeSelected = false;

        public FormHaendler(Form1 form, Gameplay party)
        {
            InitializeComponent();

            komponenten = new List<Image>();
            komponenten.Add(Image.FromFile("Wood.jpg"));
            komponenten.Add(Image.FromFile("steel.png"));
            komponenten.Add(Image.FromFile("copper.png"));
            komponenten.Add(Image.FromFile("glass.jpg"));
            komponenten.Add(Image.FromFile("screw.jpg"));
            komponenten.Add(Image.FromFile("gear.png"));

            InitializeComponentTable();

            myForm = form;
            this.party = party;
            s = party.ActivePlayer;
        }
        private void InitializeComponentTable()
        {

            TableLayoutPanel t = tableLayoutPanelKomponenten;

            int imageIndex = 0;
            for (int z = 0; z < 3; z++)
            {
                for (int s = 0; s < 2; s++)
                {
                    PictureBox p = new PictureBox();
                    p.Image = komponenten[imageIndex];                    
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Visible = true;
                    p.Dock = DockStyle.Fill;
                    p.MouseClick += buttonComponent_Click;
                    t.Controls.Add(p, z, s);
                    t.Controls.SetChildIndex(p, imageIndex);
                    imageIndex++;
                }
            }
        }       
        private void buttonKaufen_Click(object sender, EventArgs e)
        {
            if (s.ZuvieleKarten(1))
            {
                MessageBox.Show("Du hast zuviele Karten auf der Hand, um eine Komponente zu kaufen.");
            }
            else
            {
                buttonKaufen.Enabled = false;
                buttonVerkaufen.Enabled = false;
                buttonTauschen.Enabled = false;
                buttonZufaellig.Visible = true;
                buttonBestimmt.Visible = true;
            }
        }
        private void buttonTauschen_Click(object sender, EventArgs e)
        {
            //Der Spieler soll alle Karten markieren, die er tauschen möchte
            //Bei Druck auf "fertig" werden die Karten zum Stapel "selected" hinzugefügt, und anschließend bei Gameplay 
            //in der methode "tauschen" abgelegt und durch zufällige neue (gleiche anzahl) vom komponentenstapel ersetzt

            changeSelected = true;

            buttonKaufen.Enabled = false;
            buttonVerkaufen.Enabled = false;
            buttonTauschen.Enabled = false;
            labelComm2.Text = "Bitte markiere die Komponenten, die du gegen zufällige neue" + Environment.NewLine +
                "aus dem Nachziehstapel austauschen möchtest und drücke anschließend auf fertig.";
            labelComm2.Visible = true;
            buttonFertig.Visible = true;
        }
        private void buttonVerkaufen_Click(object sender, EventArgs e)
        {
            //Der Spieler soll alle Karten markieren, die er verkaufen möchte
            //Bei Druck auf "fertig" werden die Karten zum Stapel "selected" hinzugefügt, und anschließend bei Gameplay 
            //in der methode "verkaufen" abgelegt und gold hinzugefügt

            buttonKaufen.Enabled = false;
            buttonVerkaufen.Enabled = false;
            buttonTauschen.Enabled = false;
            labelComm2.Text = "Bitte markiere die Komponenten, die du für jeweils" +Environment.NewLine +
                "1 Gold verkaufen möchtest und drücke anschließend auf fertig.";
            labelComm2.Visible = true;
            buttonFertig.Visible = true;
        }          
        private void buttonZufaellig_Click(object sender, EventArgs e)
        {
            if (s.ZuvieleKarten(2))
            {
                MessageBox.Show("Du hast zuviele Karten auf der Hand, um zwei Komponenten zu ziehen.");
            }
            else
            {
                party.Haendler_Ziehen();
                myForm.KartenEntfernen();
                myForm.buttonKartenAnzeigen_Click(this, e);
                myForm.RefreshDeckInfo();
                myForm.BlockActions();

                Close();
            }
        }
        private void buttonBestimmt_Click(object sender, EventArgs e)
        {
            if (!s.GenugGold(2))
            {
                MessageBox.Show("Du hast nicht genug Gold, um eine Komponente zu kaufen.");
            }
            else
            {
                labelComm2.Text = "Bitte wähle eine Komponente aus.";
                labelComm2.Visible = true;
                tableLayoutPanelKomponenten.Visible = true;
            }
        }
        private void buttonComponent_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int elementIndex = tableLayoutPanelKomponenten.Controls.GetChildIndex(p);

            p.BorderStyle = BorderStyle.Fixed3D;

            if (!party.Haendler_VerfuegbarkeitPruefen(elementIndex)) 
            {
                MessageBox.Show("Diese Komponente ist momentan nicht verfuegbar.");
            }
            else
            {
                party.Haendler_Kaufen(new Karte(party.GameContentDb.KomponentenElemente[elementIndex]));
                myForm.KartenEntfernen();
                myForm.buttonKartenAnzeigen_Click(this, e);
                myForm.RefreshPlayerInfo();
                myForm.RefreshDeckInfo();
                myForm.BlockActions();

                Close();
            }
        }
        private void buttonFertig_Click(object sender, EventArgs e)
        {
            myForm.AuswahlHinzufuegen<Komponente>();

            if (!changeSelected)
            {
                 party.Haendler_Verkaufen();               
            }
            else
            {
                party.Haendler_Tauschen();
            }

            myForm.KartenEntfernen();
            myForm.buttonKartenAnzeigen_Click(this, e);
            myForm.RefreshPlayerInfo();
            myForm.RefreshDeckInfo();
            myForm.BlockActions();

            Close();
        }
    }
}
