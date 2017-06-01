using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppZeitgeist
{
    class ContentManagerDB
    {
        public List<Idee> IdeenElemente { get; set; }
        public List<Komponente> KomponentenElemente { get; set; }
        public List<Diener> DienerElemente { get; set; }
        public List<Karte> IdeenVorrat { get; set; }
        public List<Karte> KomponentenVorrat { get; set; }
        public List<Karte> DienerVorrat { get; set; }


        OleDbConnection con;
        OleDbConnectionStringBuilder strbuild;
        OleDbCommand command;
        OleDbDataReader rd;

        con.ConnectionString = Properties.Settings.Default.DbPath;
        con.Open();
        public ContentManagerDB()
        {
            IdeenElemente = new List<Idee>();
            KomponentenElemente = new List<Komponente>();
            DienerElemente = new List<Diener>();

            IdeenVorrat = new List<Karte>();
            KomponentenVorrat = new List<Karte>();
            DienerVorrat = new List<Karte>();
        }
    }
}
