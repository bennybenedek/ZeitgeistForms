using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppZeitgeist
{
    [Serializable]
    public class GameElement
    {
        public int GlobalIndex { get; set; }
        public string Bezeichnung { get; set; }
        public int Quantity { get; set; }
        public Image Front { get; set; }
        public GameElement()
        {
            Front = null;
        }

        public override string ToString()
        {
            return Bezeichnung;
        }
    }
}
