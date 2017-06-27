using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppZeitgeist
{
    public class ContentManagerDB
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
                neu.Front = Image.FromFile(AsValue<string>(rd[i++]));

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
                neu.Front = Image.FromFile(AsValue<string>(rd[i++]));

                //Ausgewählten Ideen die Patentobjekte hinzufügen    
                if (neu.IdeeIndex >= 5)
                {
                    neu.Patente.Add(IdeenElemente[AsValue<int>(rd[8])]);
                    neu.Patente.Add(IdeenElemente[AsValue<int>(rd[9])]);
                }

                IdeenElemente.Add(neu);
            }
            rd.Close();


            //DienerElemente laden
            command.CommandText = "Servant";
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
                neu.Front = Image.FromFile(AsValue<string>(rd[i++]));

                DienerElemente.Add(neu);
            }
            rd.Close();


            //Den Ideen die Komponentenkosten hinzufuegen
            command.CommandText = "IdeaCost";
            command.CommandType = CommandType.TableDirect;

            rd = command.ExecuteReader();

            while (rd.Read())
            {
                Idee i = IdeenElemente[AsValue<int>(rd[1])];
                i.KompKosten[AsValue<int>(rd[2])] = AsValue<int>(rd[3]);
            }
            rd.Close();

        }
        public void BuildComponentBank()
        {
            //hier die eigentlichen KompKarten erstellen 
            //und dem Vorrat hinzufügen

            foreach (Komponente k in KomponentenElemente)
            {
                for (int j = 0; j < k.Quantity; j++)
                {
                    Karte neu = new Karte(k);
                    KomponentenVorrat.Add(neu);
                }
            }
        }
        public void BuildIdeaBank()
        {
            //hier die eigentlichen IdeeKarten erstellen 
            //und dem Vorrat hinzufügen

            foreach (Idee i in IdeenElemente)
            {
                for (int j = 0; j < i.Quantity; j++)
                {
                    Karte neu = new Karte(i);
                    IdeenVorrat.Add(neu);
                }
            }
        }
        public void BuildServantBank()
        {
            //hier die eigentlichen DienerPlättchen erstellen 
            //und dem Vorrat hinzufügen

            foreach (Diener d in DienerElemente)
            {
                for (int j = 0; j < d.Quantity; j++)
                {
                    Karte neu = new Karte(d);
                    DienerVorrat.Add(neu);
                }
            }
        }
        public void CreateGameObjects()
        {
            LoadGameElements();
            BuildComponentBank();
            BuildIdeaBank();
            BuildServantBank();
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
