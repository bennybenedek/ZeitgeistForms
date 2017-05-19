using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppZeitgeist
{
    [Serializable]
    public class Diener : GameElement
    {
        public int DienerIndex { get; set; }
        public static Image Back { get; set; }
        public void Spionieren()
        {

        }
        public void Dienen()
        {

        }
        public static void setBack(Image back)
        {
            Back = back;
        }
    }
}
