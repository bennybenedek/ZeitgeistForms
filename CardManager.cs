using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppZeitgeist
{
    public class CardManager
    {
        public Random Rand { get; set; }

        public CardManager()
        {
            Rand = new Random();
        }
        public List<Karte> ShuffleDeck(List<Karte> deck)
        {
            return deck.OrderBy(x => Rand.Next()).ToList();
        }
        public List<Karte> SortCards(List<Karte> cards)
        {
            return cards.OrderBy(x => x.RefElement.GlobalIndex).ToList();
        }
        public void Deal(List<Karte> hand, List<Karte> drawDeck, int toDraw)
        {
            for (int i = 0; i < toDraw; i++)
            {               
                hand.Add(drawDeck.Last());
                drawDeck.Remove(drawDeck.Last());
            }

            SortCards(hand);
        }
        public void DealSpecific(List<Karte> hand, List<Karte> drawDeck, Karte k)
        {
            Karte toRemove = null;

            foreach (Karte ka in drawDeck)
            {
                if (ka.RefElement.GlobalIndex == k.RefElement.GlobalIndex)
                {
                    hand.Add(ka);
                    toRemove = ka;
                    break;
                }
            }

            drawDeck.Remove(toRemove);
            SortCards(hand);
        }
        public void Discard(List<Karte> hand, List<Karte> discardDeck, Karte toDiscard, int index)
        {
            discardDeck.Add(toDiscard);
            hand.Remove(toDiscard);
        }
        public void Discard(List<Karte> hand, List<Karte> discardDeck, List<Karte> toDiscard)
        {
            foreach (Karte k in toDiscard)
            {
                discardDeck.Add(k);
                hand.Remove(k);
            }
            toDiscard.Clear();
        }
        public void Change(List<Karte> hand, List<Karte> toChange, List<Karte> drawDeck, List<Karte> discardDeck)
        {
            foreach (Karte k in toChange)
            {
                hand.Remove(k);
                discardDeck.Add(k);

                hand.Add(drawDeck.Last());
                drawDeck.Remove(drawDeck.Last());
            }
            toChange.Clear();
        }
        public void RefreshDrawDeck(List<Karte> drawDeck, List<Karte> discardDeck)
        {
            foreach (Karte k in discardDeck)
            {
                drawDeck.Add(k);
            }
            discardDeck.Clear();
        }
        public int CountSpecificCard(List<Karte> deck, int index)
        {
            return deck.Count(c => c.RefElement.GlobalIndex == index);
        }
    }
}
