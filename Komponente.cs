using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppZeitgeist
{
    [Serializable]
    public class Komponente : GameElement
    {
        public int KompIndex {get; set;}

        public Komponente()
        {
            Quantity = 15;
        }
    }
}

