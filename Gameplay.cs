using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppZeitgeist
{
    public class Gameplay
    {
        public List<Spieler> Players { get; set; }
        public Spieler ActivePlayer { get; set; }
        public Spieler Winner { get; set; }

        public List<Karte> KomponentenNachziehDeck { get; set; }
        public List<Karte> KomponentenAblageDeck { get; set; }
        public List<Karte> IdeenNachziehDeck { get; set; }
        public List<Karte> IdeenAblageDeck { get; set; }
        public List<Karte> DienerNachziehDeck { get; set; }
        public List<Karte> DienerAblageDeck { get; set; }

        public Random Rand { get; set; }
        public CardManager GameManager { get; set; }
        public ContentManager GameContent { get; set; }


        public Gameplay()
        {
            Players = new List<Spieler>();
            ActivePlayer = null;
            Winner = null;

            KomponentenNachziehDeck = new List<Karte>();
            KomponentenAblageDeck = new List<Karte>();
            IdeenNachziehDeck = new List<Karte>();
            IdeenAblageDeck = new List<Karte>();
            DienerNachziehDeck = new List<Karte>();

            GameManager = new CardManager();
            GameContent = new ContentManager();
            Rand = new Random();
        }
        public void InitializeGame(
               List<Karte> komponentenVorrat,
               List<Karte> ideenVorrat,
               List<Karte> dienerVorrat)
        {
            //Nachziehstapel bilden
            foreach (Karte k in komponentenVorrat)
            {
                KomponentenNachziehDeck.Add(k);
            }           

            foreach (Karte k in ideenVorrat)
            {
                IdeenNachziehDeck.Add(k);
            }

            foreach (Karte k in dienerVorrat)
            {
                DienerNachziehDeck.Add(k);
            }

            //Die Stapel mischen
            KomponentenNachziehDeck = GameManager.ShuffleDeck(KomponentenNachziehDeck);
            IdeenNachziehDeck = GameManager.ShuffleDeck(IdeenNachziehDeck);
            DienerNachziehDeck = GameManager.ShuffleDeck(DienerNachziehDeck);

            //Spieler mit Starthand versehen & diese sortieren
            foreach (Spieler s in Players)
            {
                GameManager.Deal(s.HandKarten, KomponentenNachziehDeck, 2);              
                s.StartIdeeZiehen(s.HandKarten, IdeenNachziehDeck);
                s.HandKarten = GameManager.SortCards(s.HandKarten);              
            }

            //Startspieler zufällig festlegen
            ActivePlayer = Players[Rand.Next(0,Players.Count())];        
        }
        public int Veranda_VerfuegbarkeitPruefen()
        {
            return IdeenNachziehDeck.Count();
        }
        public void Veranda(int count)
        {
            Spieler s = ActivePlayer;

            GameManager.Deal(s.HandKarten, IdeenNachziehDeck, count);           

            s.HandKarten = GameManager.SortCards(s.HandKarten);
            s.AnzahlAktionen--;
        }
        public void Haendler_Ziehen()
        {
            Spieler s = ActivePlayer;

            if (KomponentenNachziehDeck.Count() <= 1)
            {
                GameManager.RefreshDrawDeck(KomponentenNachziehDeck, KomponentenAblageDeck);
                KomponentenNachziehDeck = GameManager.ShuffleDeck(KomponentenNachziehDeck);
            }

            GameManager.Deal(s.HandKarten, KomponentenNachziehDeck, 2);          
            s.HandKarten = GameManager.SortCards(s.HandKarten);
            s.AnzahlAktionen--;
        }
        public void Haendler_Kaufen(Karte k)
        {
            Spieler s = ActivePlayer;

            if (KomponentenNachziehDeck.Count() == 0)
            {
                GameManager.RefreshDrawDeck(KomponentenNachziehDeck, KomponentenAblageDeck);
                KomponentenNachziehDeck = GameManager.ShuffleDeck(KomponentenNachziehDeck);
            }

            GameManager.DealSpecific(s.HandKarten, KomponentenNachziehDeck, k);
            s.HandKarten = GameManager.SortCards(s.HandKarten);
            s.AnzahlAktionen--;
            s.Gold -= 2;
        }
        public void Haendler_Verkaufen()
        {
            Spieler s = ActivePlayer;

            s.Gold += s.AktuelleAuswahl.Count();
            GameManager.Discard(s.HandKarten, KomponentenAblageDeck, s.AktuelleAuswahl);
            s.AnzahlAktionen--;
            s.AktuelleAuswahl.Clear();
        }
        public void Haendler_Tauschen()
        {
            Spieler s = ActivePlayer;

            //falls nicht mehr genug Nachziehkarten, dann aus Ablagestapel neu bilden und mischen
            if (s.AktuelleAuswahl.Count() > KomponentenNachziehDeck.Count())
            {
                GameManager.RefreshDrawDeck(KomponentenNachziehDeck, KomponentenAblageDeck);
                KomponentenNachziehDeck = GameManager.ShuffleDeck(KomponentenNachziehDeck);
            }

            GameManager.Change(s.HandKarten, s.AktuelleAuswahl, KomponentenNachziehDeck, KomponentenAblageDeck);
            s.HandKarten = GameManager.SortCards(s.HandKarten);
            s.AktuelleAuswahl.Clear();
            s.AnzahlAktionen--;
        }
        public bool Haendler_VerfuegbarkeitPruefen(int elementIndex)
        {
            if (GameManager.CountSpecificCard(KomponentenNachziehDeck, elementIndex) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Arbeitszimmer_Hinzufuegen()
        {
            Spieler s = ActivePlayer;
            GameManager.Discard(s.HandKarten, s.ArbeitszimmerKarten, s.AktuelleAuswahl);
            s.ArbeitszimmerKarten = GameManager.SortCards(s.ArbeitszimmerKarten);
        }
        public void Arbeitszimmer_Entfernen()
        {
            Spieler s = ActivePlayer;
            GameManager.Discard(s.ArbeitszimmerKarten, s.HandKarten, s.AktuelleAuswahl2);
            s.HandKarten = GameManager.SortCards(s.HandKarten);
        }
        public void Foyer_Anheuern(Karte k)
        {
            Spieler s = ActivePlayer;

            if (DienerNachziehDeck.Count() == 0)
            {
                GameManager.RefreshDrawDeck(DienerNachziehDeck, DienerAblageDeck);
                KomponentenNachziehDeck = GameManager.ShuffleDeck(DienerNachziehDeck);
            }

            GameManager.DealSpecific(s.DienerPlaettchen, DienerNachziehDeck, k);
            s.DienerPlaettchen = GameManager.SortCards(s.DienerPlaettchen);
            s.AnzahlAktionen--;
            s.Gold -= 2;
        }
        public bool Patentamt_KomponentenPruefen(Idee id)
        {
            Spieler s = ActivePlayer;

            //erst für alle Karten prüfen, ob genug vorhanden
            for (int kompIndex = 0; kompIndex < 6; kompIndex++)
            {
                if (s.HandKarten.Count(k => k.RefElement.GlobalIndex == kompIndex) < id.KompKosten[kompIndex])
                {
                    return false;
                }
            }

            //nur wenn alle verfügbar, alle Kosten entfernen
            for (int kompIndex2 = 0; kompIndex2 < 6; kompIndex2++)
            {
                for (int j = 0; j < id.KompKosten[kompIndex2]; j++)
                {
                    s.HandKarten.Remove(s.HandKarten.Find(k => k.RefElement.GlobalIndex == kompIndex2));
                }
            }

            return true;
        }
        public bool Patentamt_ErfindungPruefen(Idee id)
        {
            if (id.Patente.Count() == 0)
            {
                return true;
            }

            foreach (Idee i in id.Patente)
            {
                if (!i.Erfunden)
                {
                    return false;
                }
            }
            return true;
        }
        public void Patentamt_IdeePatentieren(Idee id)
        {
            Spieler s = ActivePlayer;

            id.Erfunden = true;
            id.Erfinder = s;
            s.Erfindungen.Add(id);
            s.Punkte += 10 * id.Ebene;

            GameManager.Discard(s.HandKarten, IdeenAblageDeck, s.AktuelleAuswahl);

            s.AnzahlAktionen--;
            s.HandKarten = GameManager.SortCards(s.HandKarten);
            s.AktuelleAuswahl.Clear();
        }
    }
}
