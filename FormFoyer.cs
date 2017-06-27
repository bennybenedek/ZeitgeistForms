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
    }
}
