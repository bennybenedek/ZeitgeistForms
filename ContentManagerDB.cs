using System;
using System.Collections.Generic;
using System.Data;
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

        public ContentManagerDB()
        {
            IdeenElemente = new List<Idee>();
            KomponentenElemente = new List<Komponente>();
            DienerElemente = new List<Diener>();

            IdeenVorrat = new List<Karte>();
            KomponentenVorrat = new List<Karte>();
            DienerVorrat = new List<Karte>();

            con = new OleDbConnection();
            con.ConnectionString = Properties.Settings.Default.DBPath;
            con.Open();
        }

        public void LoadGameElements()
        {
            command = con.CreateCommand();


            //KomponentenElemente laden
            command.CommandText = "Component";
            command.CommandType = CommandType.TableDirect;

            rd = command.ExecuteReader();

            while (rd.Read())
            {
                Komponente neu = new Komponente();
                int i = 0;

                neu.KompIndex = AsValue<int>(rd[i++]);
                neu.GlobalIndex = AsValue<int>(rd[i++]);
                neu.Bezeichnung = AsValue<string>(rd[i++]);
                neu.Quantity = AsValue<int>(rd[i++]);

                KomponentenElemente.Add(neu);
            }
            rd.Close();


            //IdeeElemente laden
            command.CommandText = "Idea";
            command.CommandType = CommandType.TableDirect;

            rd = command.ExecuteReader();

            while (rd.Read())
            {
                Idee neu = new Idee();
                int i = 0;

                neu.IdeeIndex = AsValue<int>(rd[i++]);
                neu.GlobalIndex = AsValue<int>(rd[i++]);
                neu.Bezeichnung = AsValue<string>(rd[i++]);
                neu.Punktewert = AsValue<int>(rd[i++]);
                neu.Patentwert = AsValue<int>(rd[i++]);
                neu.Ebene = AsValue<int>(rd[i++]);
                neu.Quantity = AsValue<int>(rd[i++]);
            }
            rd.Close();


            //DienerElemente laden
            command.CommandText = "Idea";
            command.CommandType = CommandType.TableDirect;

            rd = command.ExecuteReader();

            while (rd.Read())
            {
                Diener neu = new Diener();
                int i = 0;

                neu.DienerIndex = AsValue<int>(rd[i++]);
                neu.GlobalIndex = AsValue<int>(rd[i++]);
                neu.Bezeichnung = AsValue<string>(rd[i++]);
                neu.Quantity = AsValue<int>(rd[i++]);
            }
            rd.Close();
        }

        private T AsValue<T>(object o)
        {
            if (o == DBNull.Value)
            {
                return default(T);
            }
            return (T)o;
        }
    }
}
