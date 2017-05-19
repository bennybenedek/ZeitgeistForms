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
    public partial class FormArbeitszimmer : Form
    {
        private Form1 myForm;
        private Gameplay party;
        private Spieler s;
        private bool isAction;
        private int startIndex = 0;
        private int endIndex = 5;

        public FormArbeitszimmer(Form1 form, Gameplay party, bool isAction)
        {
            InitializeComponent();

            myForm = form;
            this.party = party;
            s = party.ActivePlayer;
            this.isAction = isAction;

            if (isAction)
            {
                buttonUebertragen.Enabled = true;
                buttonFertig.Enabled = true;
            }

            ZimmerKartenEntfernen();
            ZimmerKartenAnzeigen();
        }
        private void ZimmerKartenAnzeigen()
        {
            panelZimmerKarten.Visible = true;
            List<Karte> zimmer = s.ArbeitszimmerKarten;
            int cardCount = 0;
            int controlCount = 0;
            int nextX = 0;
            int x = 5;
            int y = 0;
            int width;
            int height;

            for (cardCount = startIndex; cardCount < endIndex; cardCount++)
            {
                if (cardCount < s.ArbeitszimmerKarten.Count())
                {
                    Karte k = s.ArbeitszimmerKarten[cardCount];
                    PictureBox p = (PictureBox)panelZimmerKarten.Controls[controlCount];
                    k.ObjectControl = p;
                    Image i = k.RefElement.Front;

                    if (k.RefElement.GetType() == typeof(Idee))
                    {
                        y = 0;
                        height = 345;
                        width = 225;
                        nextX = 235;
                    }
                    else
                    {
                        y = 45;
                        height = 300;
                        width = 180;
                        nextX = 190;
                    }

                    p.Image = k.RefElement.Front;
                    p.SetBounds(x, y, width, height);
                    p.Visible = true;
                    p.Show();

                    x += nextX;
                    controlCount++;
                } 
            }

            if ((s.ArbeitszimmerKarten.Count() > 5) && (startIndex + 6 <= s.ArbeitszimmerKarten.Count()))
            {
                buttonWeiter.Enabled = true;
            }
            else
            {
                buttonWeiter.Enabled = false;
            }

            if (startIndex == 0)
            {
                buttonZurueck.Enabled = false;
            }
        }
        public void ZimmerKartenEntfernen()
        {
            foreach (Control c in panelZimmerKarten.Controls)
            {
                PictureBox p = (PictureBox)c;
                p.Image = null;
                p.Visible = false;
                p.BorderStyle = BorderStyle.None;
            }
            panelZimmerKarten.Visible = false;
        }
        public void AuswahlHinzufuegen() 
        {
            try
            {
                foreach (Control c in panelZimmerKarten.Controls)
                {
                    PictureBox p = (PictureBox)c;

                    if (p.BorderStyle == BorderStyle.Fixed3D)
                    {
                        s.AktuelleAuswahl2.Add(s.ArbeitszimmerKarten[panelZimmerKarten.Controls.GetChildIndex(c) + startIndex]);
                        p.BorderStyle = BorderStyle.None;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);             
            }
        }
        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            startIndex -= 5;
            endIndex -= 5;

            ZimmerKartenEntfernen();
            ZimmerKartenAnzeigen();   
        }
        private void buttonWeiter_Click(object sender, EventArgs e)
        {
            startIndex += 5;
            endIndex += 5;

            ZimmerKartenEntfernen();
            ZimmerKartenAnzeigen();
                                   
            buttonZurueck.Enabled = true;          
        }
        private void buttonUebertragen_Click(object sender, EventArgs e)
        {
            //Erst alle ausgewaehlten Handkarten dem Arbeitszimmer hinzufuegen, 
            //dann die ausgewählten Arbeitszimmerkarten der Hand übertragen
            //dazwischen prüfen, ob genug Platz auf der Hand, sonst nicht übertragen

            myForm.AuswahlHinzufuegen<Komponente>();
            myForm.AuswahlHinzufuegen<Idee>();
            AuswahlHinzufuegen();

            party.Arbeitszimmer_Hinzufuegen();

            if (s.ZuvieleKarten(s.AktuelleAuswahl2.Count() - s.AktuelleAuswahl.Count()))
            {
                MessageBox.Show("Du kannst nicht so viele Karten auf die Hand nehmen.");

                s.AktuelleAuswahl.Clear();
                s.AktuelleAuswahl2.Clear();
            }
            else
            {
                party.Arbeitszimmer_Entfernen();               
            }

            ZimmerKartenEntfernen();
            ZimmerKartenAnzeigen();
            myForm.KartenEntfernen();
            myForm.buttonKartenAnzeigen_Click(this, e);

            s.AktuelleAuswahl.Clear();
            s.AktuelleAuswahl2.Clear();
            
        }
        private void buttonFertig_Click(object sender, EventArgs e)
        {
            s.AnzahlAktionen--;
            myForm.RefreshPlayerInfo();
            myForm.BlockActions();

            Close();
        }

        private void ZiKartenClick(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            if (p.BorderStyle == BorderStyle.Fixed3D)
            {
                p.BorderStyle = BorderStyle.None;
            }

            else
            {
                p.BorderStyle = BorderStyle.Fixed3D;
            }
        }
    }
}
