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
    public partial class FormFoyer : Form
    {
        private Form1 myForm;
        private Gameplay party;
        private Spieler s;

        private int anzahlSpione;
        private int anzahlBoten;
        private Diener d;
        private int anzahl;
        private Spieler anzugreifen;

        public FormFoyer(Form1 form, Gameplay party)
        {
            InitializeComponent();

            myForm = form;
            this.party = party;
            s = party.ActivePlayer;
        }

        private void buttonAnheuern_Click(object sender, EventArgs e)
        {
            if (!s.GenugGold(2))
            {
                MessageBox.Show("Du hast nicht genug Gold, um einen Diener anzuheuern.");
            }
            else if (!s.PlatzImFoyer())
            {
                MessageBox.Show("Dein Foyer kann nicht noch mehr Diener aufnehmen.");
            }
            else
            {
                panelDienerAuswahl.Visible = true;          
            }
        }

        private void buttonEinsetzen_Click(object sender, EventArgs e)
        {
            anzahlSpione = party.GameManager.CountSpecificCard(s.DienerPlaettchen, party.GameContentDb.DienerElemente[0].GlobalIndex);
            anzahlBoten = party.GameManager.CountSpecificCard(s.DienerPlaettchen, party.GameContentDb.DienerElemente[2].GlobalIndex);

            MessageBox.Show("Anzahl Spione ist:" + anzahlSpione);

            labelAuswahl.Visible = true;
            buttonConfirm.Visible = true;
            comboBoxDienerAuswahl.Visible = true;

            //Je nach Verfügbarkeit Diener im DropDown Menü anzeigen
            if (anzahlSpione > 0)
            {
                comboBoxDienerAuswahl.Items.Add(party.GameContentDb.DienerElemente[0]);
            }

            if (anzahlBoten > 0)
            {
                comboBoxDienerAuswahl.Items.Add(party.GameContentDb.DienerElemente[2]);
            }
        }

        private void Diener_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int dienerIndex = panelDienerAuswahl.Controls.GetChildIndex(p);

            party.Foyer_Anheuern(new Karte(party.GameContentDb.DienerElemente[dienerIndex]));

            myForm.RefreshPlayerInfo();
            myForm.RefreshFoyerTable(myForm.tableLayoutPanelFoyer, s);
            myForm.BlockActions();

            Close();
        }

        private void comboBoxDienerAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDienerAuswahl.SelectedItem != null)
            {
                d = (Diener)comboBoxDienerAuswahl.SelectedItem;

                comboBoxAnzahlAuswahl.Items.Clear();

                for (int i = 1; i <= party.GameManager.CountSpecificCard(s.DienerPlaettchen, d.GlobalIndex); i++)
                {
                    comboBoxAnzahlAuswahl.Items.Add(i);
                }

                comboBoxAnzahlAuswahl.Visible = true;
            }
        }

        private void comboBoxAnzahlAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            anzahl = (int)comboBoxAnzahlAuswahl.SelectedItem; 

            if (d.DienerIndex == 0)
            {
                foreach (Spieler sp in party.Players)
                {
                    if (sp != s)
                    {
                        comboBoxSpielerAuswahl.Items.Add(sp);
                    }
                }

                comboBoxSpielerAuswahl.Visible = true;
                labelAuswahl.Text = "Welchen Spieler" + Environment.NewLine + "willst du angreifen?";
            }

            else
            {
                buttonConfirm.Enabled = true;
            }
        }

        private void comboBoxSpielerAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            anzugreifen = (Spieler)comboBoxSpielerAuswahl.SelectedItem;
            buttonConfirm.Enabled = true;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //Spionangriff
            if (d.DienerIndex == party.GameContentDb.DienerElemente[0].DienerIndex)
            {
                party.Foyer_Spion(anzahl, anzugreifen);
            }
            else //Bote
            {
                party.Foyer_Bote(anzahl);
            }          
        }
    }
}
