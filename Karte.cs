using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppZeitgeist
{
    public class Karte
    {
        public GameElement RefElement { get; set; }
        public Control ObjectControl { get; set; }

        public Karte()
        {
            RefElement = null;
        }
        public Karte(GameElement refElement)
        {
            RefElement = refElement;
            ObjectControl = null;
        }
    }
}
