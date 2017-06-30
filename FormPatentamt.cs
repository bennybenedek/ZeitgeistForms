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
    public partial class FormPatentamt : Form
    {
        private Form1 myForm;
        private Gameplay party;
        private Spieler s;
        public FormPatentamt(Form1 form, Gameplay party)
        {
            InitializeComponent();

            myForm = form;
            this.party = party;
            s = party.ActivePlayer;
        }

        private void buttonPatentieren_Click(object sender, EventArgs e)
        {
            myForm.AuswahlHinzufuegen<Idee>();

            if (s.AktuelleAuswahl.Count() != 1) 
            {
                MessageBox.Show("Entscheide dich für EINE Idee.");
                s.AktuelleAuswahl.Clear();
            }

            else
            {
                Karte k = s.AktuelleAuswahl.Last();
                Idee i = (Idee)k.RefElement;

                party.Patentamt_GoldBerechnen(i);

                if (i.Erfunden)
                {
                    MessageBox.Show("Diese Idee wurde bereits patentiert.");
                }
                else if (!party.Patentamt_ErfindungPruefen(i))
                {
                    MessageBox.Show("Es wurden noch nicht alle notwendigen Ideen erfunden, um diese Idee zu patentieren.");
                }
                else if (!party.Patentamt_GoldPruefen())
                {
                    MessageBox.Show("Du hast nicht genuegend Gold, um diese Idee zu patentieren.");
                }
                else if (!party.Patentamt_KomponentenPruefen(i))
                {
                    MessageBox.Show("Du hast nicht alle nötigen Komponenten, um diese Idee zu patentieren.");
                }
                else
                {
                    party.Patentamt_IdeePatentieren(i);

                    myForm.KartenEntfernen();
                    myForm.buttonKartenAnzeigen_Click(this, e);
                    myForm.RefreshAllPlayerInfo();
                    myForm.RefreshDeckInfo();
                    myForm.RefreshBoard();
                    myForm.BlockActions();

                    Close();
                }
            }
            s.AktuelleAuswahl.Clear();
        }
    }
}
