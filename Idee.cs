using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppZeitgeist
{
    [Serializable]
    public class Idee : GameElement
    {
        public virtual int IdeeIndex { get; set; }
        public bool Erfunden { get; set; }
        public bool PatentGeprueft { get; set; }
        public int[] KompKosten { get; set; }
        public int Ebene { get; set; }
        public int Punktewert { get; set; }
        public int Patentwert { get; set; }
        public Spieler Erfinder { get; set; }
        public List<Idee> Patente { get; set; }

        public Idee()
        {
            KompKosten = new int[6] { 0, 0, 0, 0, 0, 0 };
            Erfinder = null;
            Patente = new List<Idee>();
            Quantity = 2;
        }
    }
}

