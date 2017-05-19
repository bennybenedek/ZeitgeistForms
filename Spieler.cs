using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppZeitgeist
{
    [Serializable]
    public class Spieler
    {
        public string Name { get; set; }
        public int Punkte { get; set; }
        public int Gold { get; set; }
        public int AnzahlAktionen { get; set; }

        public static int MaxHandkarten { get; set; } = 7;
        public static int MaxDiener { get; set; } = 4;
        public static bool CanSelect { get; set; }

        public List<Karte> HandKarten { get; set; }
        public List<Karte> ArbeitszimmerKarten { get; set; }
        public List<Karte> AktuelleAuswahl { get; set; }
        public List<Karte> AktuelleAuswahl2 { get; set; }
        public List<Karte> DienerPlaettchen { get; set; }
        public List<Idee> Erfindungen { get; set; }

        public Spieler()
        {
            HandKarten = new List<Karte>();
            ArbeitszimmerKarten = new List<Karte>();
            AktuelleAuswahl = new List<Karte>();
            AktuelleAuswahl2 = new List<Karte>();
            DienerPlaettchen = new List<Karte>();
            Erfindungen = new List<Idee>();

            Punkte = 0;
            Gold = 3;
            AnzahlAktionen = 1;
        }
        public void PunkteZaehlen()
        {
        }
        public void StartIdeeZiehen(List<Karte> HandKarten, List<Karte> IdeeNachziehstapel)
        {
            foreach (Karte k in IdeeNachziehstapel)
            {
                Idee i = (Idee)k.RefElement;
                if (i.Ebene == 1)
                {
                    HandKarten.Add(k);
                    IdeeNachziehstapel.Remove(k);
                    return;
                }
            }
        }
        public void ZimmerPunkteZaehlen()
        {

        }
        public void ActionPerformed()
        {
            AnzahlAktionen--;
        }
        public bool GenugGold(int gold)
        {
            if (this.Gold >= gold)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ZuvieleKarten(int anzahl)
        {
            if (HandKarten.Count() + anzahl > MaxHandkarten)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PlatzImFoyer()
        {
            if (DienerPlaettchen.Count() < MaxDiener)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
