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
    public partial class Form1 : Form
    {
        Gameplay party;
        Spieler s;
        public Form1()
        {
            InitializeComponent();

            party = new Gameplay();
            //party.GameContent.CreateGameObjects();
            party.GameContentDb.CreateGameObjects();

            Diener.setBack(Image.FromFile("Diener03_Back.png"));
        }
        private void textBoxSpieler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonHinzufuegen_Click(this, e);
            }
        }
        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            if (party.Players.Count >= 4)
            {
                labelSpieleranzahlError.Text = "Es können maximal 4 Spieler spielen. Bitte starte das Spiel.";   
            }
            else
            {
                Spieler neu = new Spieler();
                neu.Name = textBoxSpieler.Text;
                party.Players.Add(neu);
                listBoxSpieler.Items.Add(neu);
                textBoxSpieler.Clear();
                textBoxSpieler.Focus();
            }
            if ((party.Players.Count >= 2) && (buttonStart.Enabled == false))
            {
                buttonStart.Enabled = true;
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            panelStart.Visible = false;
            panelActionSelect.Visible = true;

            party.InitializeGame(
                party.GameContentDb.KomponentenVorrat,
                party.GameContentDb.IdeenVorrat,
                party.GameContentDb.DienerVorrat);

            LabelAktionAnpassen();
            RefreshBoard();
            RefreshDeckInfo();
            InitializePlayerInfo();
            InitializeFoyerTable(tableLayoutPanelFoyer);

            s = party.ActivePlayer;
            KartenEntfernen();
        }
        public void AuswahlHinzufuegen<T>() where T : GameElement
        {
            try
            {
                foreach (Control c in panelHand.Controls)
                {
                    PictureBox p = (PictureBox)c;

                    if ((p.BorderStyle == BorderStyle.Fixed3D) && (s.HandKarten[panelHand.Controls.GetChildIndex(c)].RefElement.GetType() == typeof(T)))
                    {
                        s.AktuelleAuswahl.Add(s.HandKarten[panelHand.Controls.GetChildIndex(c)]);
                        p.BorderStyle = BorderStyle.None;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void buttonHaendler_Click(object sender, EventArgs e)
        {
            new FormHaendler(this, party).Show();
        }
        private void buttonVeranda_Click(object sender, EventArgs e)
        {
            if (party.Veranda_VerfuegbarkeitPruefen() >= 2)
            {
                if (s.ZuvieleKarten(2))
                {
                    MessageBox.Show("Du hast zuviele Karten auf der Hand, um zwei Ideen zu ziehen.");
                }
                else
                {
                    party.Veranda(2);
                    buttonKartenAnzeigen_Click(this, e);
                    RefreshDeckInfo();
                    BlockActions();
                }
            }
            else if (party.Veranda_VerfuegbarkeitPruefen() == 1)
            {
                if (s.ZuvieleKarten(1))
                {
                    MessageBox.Show("Du hast zuviele Karten auf der Hand, um eine Idee zu ziehen.");
                }
                else
                {
                    party.Veranda(1);

                    MessageBox.Show("Du hast nur eine Idee erhalten, da nicht mehr Ideen verfügbar waren.");
                    buttonKartenAnzeigen_Click(this, e);
                    RefreshDeckInfo();
                    BlockActions();
                }
            }
            else
            {
                MessageBox.Show("Es gibt keine Ideen mehr zu ziehen.");
            }         
        }
        private void buttonFoyer_Click(object sender, EventArgs e)
        {
            new FormFoyer(this, party).Show();
        }
        private void buttonArbeitszimmer_Click(object sender, EventArgs e)
        {
            new FormArbeitszimmer(this, party, true).Show();
        }
        private void buttonPatentamt_Click(object sender, EventArgs e)
        {
            new FormPatentamt(this, party).Show();
        }
        private void InitializePlayerInfo()
        {
            for (int i = 0; i < party.Players.Count; i++)
            {
                GroupBox g = (GroupBox)panelPlayerInfo.Controls[i];
                Spieler s = party.Players[i];
                TableLayoutPanel t = (TableLayoutPanel)g.Controls[1];

                g.Visible = true;
                ((Label)g.Controls[2]).Text = "Karten im Arbeitszimmer: " + s.ArbeitszimmerKarten.Count;
                ((Label)g.Controls[3]).Text = "Gold: " + s.Gold;
                ((Label)g.Controls[3]).Text = "Gold: " + s.Gold;
                ((Label)g.Controls[4]).Text = "Punkte: " + s.Punkte;
                ((Label)g.Controls[5]).Text = s.Name;

                InitializeFoyerTable(t);
            }
        }
        private void InitializeFoyerTable(TableLayoutPanel t)
        {          
            int cellIndex = 0;

            for (int z = 0; z < 2; z++)
            {
                for (int s = 0; s < 2; s++)
                {
                    PictureBox p = new PictureBox();
                    p.Image = null;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.Visible = false;
                    p.Dock = DockStyle.Fill;
                    t.Controls.Add(p, z, s);
                    t.Controls.SetChildIndex(p, cellIndex);
                    cellIndex++;                  
                }
            }
        }
        public void RefreshPlayerInfo()
        {
            GroupBox g = (GroupBox)panelPlayerInfo.Controls[party.Players.IndexOf(s)];
            TableLayoutPanel t = (TableLayoutPanel)g.Controls[1];

            ((Label)g.Controls[2]).Text = "Karten im Arbeitszimmer: " + s.ArbeitszimmerKarten.Count;
            ((Label)g.Controls[3]).Text = "Gold: " + s.Gold;
            ((Label)g.Controls[3]).Text = "Gold: " + s.Gold;
            ((Label)g.Controls[4]).Text = "Punkte: " + s.Punkte;

            RefreshFoyerTable(t, s);
        }
        public void RefreshAllPlayerInfo()
        {
            foreach (Spieler sp in party.Players)
            {
                GroupBox g = (GroupBox)panelPlayerInfo.Controls[party.Players.IndexOf(sp)];
                TableLayoutPanel t = (TableLayoutPanel)g.Controls[1];

                ((Label)g.Controls[2]).Text = "Karten im Arbeitszimmer: " + sp.ArbeitszimmerKarten.Count;
                ((Label)g.Controls[3]).Text = "Gold: " + sp.Gold;
                ((Label)g.Controls[3]).Text = "Gold: " + sp.Gold;
                ((Label)g.Controls[4]).Text = "Punkte: " + sp.Punkte;

                RefreshFoyerTable(t, sp);
            }
        }
        public void RefreshDeckInfo()
        {
            labelIdCount.Text = "Karten im Ideen-Nachziehstapel: " +party.IdeenNachziehDeck.Count().ToString();
            labelKpCount.Text = "Karten im Komponenten-Nachziehstapel: " + party.KomponentenNachziehDeck.Count().ToString();
        }
        public void RefreshBoard()
        {
            //Die Informationen des Spielfeldes aktualisieren
            
            for (int i = 0; i < 15; i++)
            {
                Label l = (Label)panelBoard.Controls[i];
                Label l2 = (Label)panelBoard.Controls[i+15];
                Idee id = party.GameContentDb.IdeenElemente[i];
                l.Visible = true;

                if (id.Erfunden)
                {
                    l.Text = "Patentwert: " + id.Patentwert + Environment.NewLine +
                       "Erfinder: " + id.Erfinder.Name;
                    l2.ForeColor = Color.Green;
                }
                else
                {
                    l.Text = "Patentwert: " + id.Patentwert + Environment.NewLine +
                      "Noch nicht erfunden.";
                }
            }
        }
        public void RefreshFoyerTable(TableLayoutPanel t, Spieler sp)
        {          
            int cellIndex = 0;

            for (int z = 0; z < 2; z++)
            {
                for (int s = 0; s < 2; s++)
                {
                    PictureBox p = (PictureBox)t.Controls[cellIndex];
                    p.Image = null;            

                    if (cellIndex < sp.DienerPlaettchen.Count())
                    {
                        Karte k = sp.DienerPlaettchen[cellIndex];

                        if (t == tableLayoutPanelFoyer)
                        {
                            p.Image = k.RefElement.Front;                   
                        }
                        else
                        {
                            p.Image = Diener.Back;
                        }

                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        p.Visible = true;
                        p.Dock = DockStyle.Fill;
                        t.Controls.Add(p, z, s);
                        t.Controls.SetChildIndex(p, cellIndex);
                        cellIndex++;
                    }
                }
            }
        }
        public void BlockActions()
        {
            if (party.ActivePlayer.AnzahlAktionen == 0)
            {
                buttonArbeitszimmer.Enabled = false;
                buttonHaendler.Enabled = false;
                buttonVeranda.Enabled = false;
                buttonPatentamt.Enabled = false;
                buttonFoyer.Enabled = false;

                labelAktionWaehlen.Text = party.ActivePlayer.Name + ", du hast keine Aktionen mehr frei.";
            }
        }
        public void buttonKartenAnzeigen_Click(object sender, EventArgs e)
        {
            //die Karten des aktiven Spielers sollen angezeigt werden
            //dazu sollen in die bis zu 7 angelegten Pictureboxen die Karten geladen werden
            //und die Positionen angepasst werden (je nach Kartentyp)

            panelHand.Visible = true;
            List<Karte> hand = s.HandKarten;
            int cardCount = 0;
            int nextX = 0;
            int x = 5;
            int y = 0;
            int width;
            int height;

            foreach (Karte k in hand)
            {
                PictureBox p = (PictureBox)panelHand.Controls[cardCount];
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
                cardCount++;
            }

            //Foyer anzeigen
            labelFoyer.Visible = true;
            tableLayoutPanelFoyer.Visible = true;
            RefreshFoyerTable(tableLayoutPanelFoyer, s);
        }
        private void buttonArbeitszimmerAnzeigen_Click(object sender, EventArgs e)
        {
            new FormArbeitszimmer(this, party, false).Show();
        }
        private void buttonFertig_Click(object sender, EventArgs e)
        {
            //Bilder aus Pictureboxen entfernen und Panels unsichtbar machen
            KartenEntfernen();

            //Nächster Spieler wird aktiver Spieler und erhält eine Aktion
            int activeIndex = party.Players.IndexOf(party.ActivePlayer) + 1;

            if (activeIndex > party.Players.Count-1)
            {
                activeIndex = 0;
            }
            party.ActivePlayer = party.Players[activeIndex];
            party.ActivePlayer.AnzahlAktionen = 1;
            s = party.ActivePlayer;
            LabelAktionAnpassen();

            //Foyer unsichtbar machen bzw. clearen
            labelFoyer.Visible = false;
            tableLayoutPanelFoyer.Visible = false;
            FoyerEntfernen();

            //Aktionen verfügbar machen
            buttonArbeitszimmer.Enabled = true;
            buttonHaendler.Enabled = true;
            buttonVeranda.Enabled = true;
            buttonPatentamt.Enabled = true;
            buttonFoyer.Enabled = true;
        }
        public void KartenEntfernen()
        {
            foreach (Control c in panelHand.Controls)
            {
                PictureBox p = (PictureBox)c;
                p.Image = null;
                p.Visible = false;
                p.BorderStyle = BorderStyle.None;
            }
            panelHand.Visible = false;
        }
        public void FoyerEntfernen()
        {
            int cellIndex = 0;

            for (int z = 0; z < 2; z++)
            {
                for (int s = 0; s < 2; s++)
                {
                    PictureBox p = (PictureBox)tableLayoutPanelFoyer.Controls[cellIndex];

                    p.Image = null;
                    p.Visible = false;

                    cellIndex++;
                }
            }
        }
        private void LabelAktionAnpassen()
        {
            labelAktionWaehlen.Text = party.ActivePlayer.Name + ", bitte wähle eine Aktion.";
        }
        private void KartenClick(object sender, MouseEventArgs e)
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
