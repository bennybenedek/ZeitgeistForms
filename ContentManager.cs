using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppZeitgeist
{
    public class ContentManager
    {      
        public List<Idee> IdeenElemente { get; set; } 
        public List<Komponente> KomponentenElemente { get; set; }
        public List<Diener> DienerElemente { get; set; }

        public List<Karte> IdeenVorrat { get; set; }
        public List<Karte> KomponentenVorrat { get; set; }
        public List<Karte> DienerVorrat { get; set; }

        public ContentManager()
        {
            IdeenElemente = new List<Idee>();
            KomponentenElemente = new List<Komponente>();
            DienerElemente = new List<Diener>();

            IdeenVorrat = new List<Karte>();
            KomponentenVorrat = new List<Karte>();
            DienerVorrat = new List<Karte>();
        }
        public void CreateGameElements()
        {
            //zuerst Liste an Elementen anlegen (3 stück) 

            //KomponentenElemente erstellen
            Komponente holz = new Komponente();
            holz.Bezeichnung = "Holz";
            holz.GlobalIndex = 0;
            holz.KompIndex = 0;
            holz.Front = Image.FromFile("Komponente00_Holz.png");
            KomponentenElemente.Add(holz);           

            Komponente stahl = new Komponente();
            stahl.Bezeichnung = "Stahl";
            stahl.GlobalIndex = 1;
            stahl.KompIndex = 1;
            stahl.Front = Image.FromFile("Komponente01_Stahl.png");
            KomponentenElemente.Add(stahl);

            Komponente kupfer = new Komponente();
            kupfer.Bezeichnung = "Kupfer";
            kupfer.GlobalIndex = 2;
            kupfer.KompIndex = 2;
            kupfer.Front = Image.FromFile("Komponente02_Kupfer.png");
            KomponentenElemente.Add(kupfer);

            Komponente glas = new Komponente();
            glas.Bezeichnung = "Glas";
            glas.GlobalIndex = 3;
            glas.KompIndex = 3;
            glas.Front = Image.FromFile("Komponente03_Glas.png");
            KomponentenElemente.Add(glas);

            Komponente schraube = new Komponente();
            schraube.Bezeichnung = "Schraube";
            schraube.GlobalIndex = 4;
            schraube.KompIndex = 4;
            schraube.Front = Image.FromFile("Komponente04_Schraube.png");
            KomponentenElemente.Add(schraube);

            Komponente zahnrad = new Komponente();
            zahnrad.Bezeichnung = "Zahnrad";
            zahnrad.GlobalIndex = 5;
            zahnrad.KompIndex = 5;
            zahnrad.Front = Image.FromFile("Komponente05_Zahnrad.png");
            KomponentenElemente.Add(zahnrad);


            //IdeeElemente erstellen
            Idee brillenglas = new Idee();
            brillenglas.Bezeichnung = "Brillenglas";
            brillenglas.GlobalIndex = 6;
            brillenglas.IdeeIndex = 0;
            brillenglas.Front = Image.FromFile("Idee00_Brillenglas.png");
            brillenglas.Ebene = 1;
            brillenglas.Punktewert = 3;
            brillenglas.Patentwert = 2;
            brillenglas.KompKosten[2] = 1;
            brillenglas.KompKosten[3] = 1;
            brillenglas.KompKosten[4] = 1;
            IdeenElemente.Add(brillenglas);

            Idee taschenuhr = new Idee();
            taschenuhr.Bezeichnung = "Taschenuhr";
            taschenuhr.GlobalIndex = 7;
            taschenuhr.IdeeIndex = 1;
            taschenuhr.Front = Image.FromFile("Idee01_Taschenuhr.png");
            taschenuhr.Ebene = 1;
            taschenuhr.Punktewert = 3;
            taschenuhr.Patentwert = 1;
            taschenuhr.KompKosten[3] = 1;
            taschenuhr.KompKosten[4] = 1;
            taschenuhr.KompKosten[5] = 1;
            IdeenElemente.Add(taschenuhr);

            Idee druckerpresse = new Idee();
            druckerpresse.Bezeichnung = "Druckerpresse";
            druckerpresse.GlobalIndex = 8;
            druckerpresse.IdeeIndex = 2;
            druckerpresse.Front = Image.FromFile("Idee02_Druckerpresse.png");
            druckerpresse.Ebene = 1;
            druckerpresse.Punktewert = 3;
            druckerpresse.Patentwert = 1;
            druckerpresse.KompKosten[1] = 1;
            druckerpresse.KompKosten[5] = 2;
            IdeenElemente.Add(druckerpresse);

            Idee bleistift = new Idee();
            bleistift.Bezeichnung = "Bleistift";
            bleistift.GlobalIndex = 9;
            bleistift.IdeeIndex = 3;
            bleistift.Front = Image.FromFile("Idee03_Bleistift.png");
            bleistift.Ebene = 1;
            bleistift.Punktewert = 3;
            bleistift.Patentwert = 1;
            bleistift.KompKosten[0] = 2;
            bleistift.KompKosten[1] = 1;
            IdeenElemente.Add(bleistift);

            Idee kompass = new Idee();
            kompass.Bezeichnung = "Kompass";
            kompass.GlobalIndex = 10;
            kompass.IdeeIndex = 4;
            kompass.Front = Image.FromFile("Idee04_Kompass.png");
            kompass.Ebene = 1;
            kompass.Punktewert = 3;
            kompass.Patentwert = 2;
            kompass.KompKosten[2] = 2;
            kompass.KompKosten[3] = 1;
            IdeenElemente.Add(kompass);

            Idee fernrohr = new Idee();
            fernrohr.Bezeichnung = "Fernrohr";
            fernrohr.GlobalIndex = 11;
            fernrohr.IdeeIndex = 5;
            fernrohr.Front = Image.FromFile("Idee05_Fernrohr.png");
            fernrohr.Ebene = 2;
            fernrohr.Punktewert = 6;
            fernrohr.Patentwert = 2;
            fernrohr.KompKosten[1] = 1;
            fernrohr.KompKosten[3] = 3;
            fernrohr.Patente.Add(brillenglas);
            fernrohr.Patente.Add(taschenuhr);
            IdeenElemente.Add(fernrohr);

            Idee rechenschieber = new Idee();
            rechenschieber.Bezeichnung = "Rechenschieber";
            rechenschieber.GlobalIndex = 12;
            rechenschieber.IdeeIndex = 6;
            rechenschieber.Front = Image.FromFile("Idee06_Rechenschieber.png");
            rechenschieber.Ebene = 2;
            rechenschieber.Punktewert = 6;
            rechenschieber.Patentwert = 1;
            rechenschieber.KompKosten[0] = 3;
            rechenschieber.KompKosten[4] = 1;
            rechenschieber.Patente.Add(taschenuhr);
            rechenschieber.Patente.Add(druckerpresse);
            IdeenElemente.Add(rechenschieber);

            Idee buchdruck = new Idee();
            buchdruck.Bezeichnung = "Buchdruck";
            buchdruck.GlobalIndex = 13;
            buchdruck.IdeeIndex = 7;
            buchdruck.Front = Image.FromFile("Idee07_Buchdruck.png");
            buchdruck.Ebene = 2;
            buchdruck.Punktewert = 6;
            buchdruck.Patentwert = 1;
            buchdruck.KompKosten[0] = 2;
            buchdruck.KompKosten[4] = 1;
            buchdruck.KompKosten[5] = 1;
            buchdruck.Patente.Add(bleistift);
            buchdruck.Patente.Add(druckerpresse);
            IdeenElemente.Add(buchdruck);

            Idee globus = new Idee();
            globus.Bezeichnung = "Globus";
            globus.GlobalIndex = 14;
            globus.IdeeIndex = 8;
            globus.Front = Image.FromFile("Idee08_Globus.png");
            globus.Ebene = 2;
            globus.Punktewert = 6;
            globus.Patentwert = 2;
            globus.KompKosten[0] = 2;
            globus.KompKosten[1] = 1;
            globus.KompKosten[4] = 1;
            globus.Patente.Add(bleistift);
            globus.Patente.Add(kompass);
            IdeenElemente.Add(globus);

            Idee fotoapparat = new Idee();
            fotoapparat.Bezeichnung = "Fotoapparat";
            fotoapparat.GlobalIndex = 15;
            fotoapparat.IdeeIndex = 9;
            fotoapparat.Front = Image.FromFile("Idee09_Fotoapparat.png");
            fotoapparat.Ebene = 3;
            fotoapparat.Punktewert = 9;
            fotoapparat.Patentwert = 2;
            fotoapparat.KompKosten[2] = 1;
            fotoapparat.KompKosten[3] = 3;
            fotoapparat.KompKosten[5] = 1;
            fotoapparat.Patente.Add(fernrohr);
            fotoapparat.Patente.Add(rechenschieber);
            IdeenElemente.Add(fotoapparat);

            Idee dampfmaschine = new Idee();
            dampfmaschine.Bezeichnung = "Dampfmaschine";
            dampfmaschine.GlobalIndex = 16;
            dampfmaschine.IdeeIndex = 10;
            dampfmaschine.Front = Image.FromFile("Idee10_Dampfmaschine.png");
            dampfmaschine.Ebene = 3;
            dampfmaschine.Punktewert = 9;
            dampfmaschine.Patentwert = 1;
            dampfmaschine.KompKosten[1] = 2;
            dampfmaschine.KompKosten[4] = 2;
            dampfmaschine.KompKosten[5] = 1;
            dampfmaschine.Patente.Add(buchdruck);
            dampfmaschine.Patente.Add(rechenschieber);
            IdeenElemente.Add(dampfmaschine);

            Idee fahrrad = new Idee();
            fahrrad.Bezeichnung = "Fahrrad";
            fahrrad.GlobalIndex = 17;
            fahrrad.IdeeIndex = 11;
            fahrrad.Front = Image.FromFile("Idee11_Fahrrad.png");
            fahrrad.Ebene = 3;
            fahrrad.Punktewert = 9;
            fahrrad.Patentwert = 2;
            fahrrad.KompKosten[0] = 1;
            fahrrad.KompKosten[2] = 2;
            fahrrad.KompKosten[4] = 1;
            fahrrad.KompKosten[5] = 1;
            fahrrad.Patente.Add(buchdruck);
            fahrrad.Patente.Add(globus);
            IdeenElemente.Add(fahrrad);

            Idee elektromotor = new Idee();
            elektromotor.Bezeichnung = "Elektromotor";
            elektromotor.GlobalIndex = 18;
            elektromotor.IdeeIndex = 12;
            elektromotor.Front = Image.FromFile("Idee12_Elektromotor.png");
            elektromotor.Ebene = 4;
            elektromotor.Punktewert = 12;
            elektromotor.Patentwert = 2;
            elektromotor.KompKosten[1] = 1;
            elektromotor.KompKosten[2] = 3;
            elektromotor.KompKosten[4] = 2;
            elektromotor.Patente.Add(fotoapparat);
            elektromotor.Patente.Add(dampfmaschine);
            IdeenElemente.Add(elektromotor);

            Idee lokomotive = new Idee();
            lokomotive.Bezeichnung = "Lokomotive";
            lokomotive.GlobalIndex = 19;
            lokomotive.IdeeIndex = 13;
            lokomotive.Front = Image.FromFile("Idee13_Lokomotive.png");
            lokomotive.Ebene = 4;
            lokomotive.Punktewert = 12;
            lokomotive.Patentwert = 2;
            lokomotive.KompKosten[1] = 3;
            lokomotive.KompKosten[5] = 3;
            lokomotive.Patente.Add(fahrrad);
            lokomotive.Patente.Add(dampfmaschine);
            IdeenElemente.Add(lokomotive);

            Idee gluehbirne = new Idee();
            gluehbirne.Bezeichnung = "Gluehbirne";
            gluehbirne.GlobalIndex = 20;
            gluehbirne.IdeeIndex = 14;
            gluehbirne.Front = Image.FromFile("Idee14_Gluehbirne.png");
            gluehbirne.Ebene = 5;
            gluehbirne.Punktewert = 15;
            gluehbirne.Quantity = 1;
            gluehbirne.KompKosten[2] = 1;
            gluehbirne.KompKosten[3] = 1;
            gluehbirne.Patente.Add(elektromotor);
            gluehbirne.Patente.Add(lokomotive);
            IdeenElemente.Add(gluehbirne);

            //DienerElemente erstellen
            Diener.setBack(Image.FromFile("Diener03_Back.png"));

            Diener spion = new Diener();
            spion.Bezeichnung = "Spion";
            spion.GlobalIndex = 21;
            spion.DienerIndex = 0;
            spion.Front = Image.FromFile("Diener00_Spion.png");
            spion.Quantity = 20;
            DienerElemente.Add(spion);

            Diener waechter = new Diener();
            waechter.Bezeichnung = "Waechter";
            waechter.GlobalIndex = 22;
            waechter.DienerIndex = 1;
            waechter.Front = Image.FromFile("Diener01_Waechter.png");
            waechter.Quantity = 20;
            DienerElemente.Add(waechter);

            Diener bote = new Diener();
            bote.Bezeichnung = "Bote";
            bote.GlobalIndex = 23;
            bote.DienerIndex = 2;
            bote.Front = Image.FromFile("Diener02_Bote.png");
            bote.Quantity = 20;
            DienerElemente.Add(bote);

            SaveElements();
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
        public void SaveElements()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream streamComponents = new FileStream(
                 "componentElements.bin",
                 FileMode.Create,
                 FileAccess.Write, FileShare.None);
            formatter.Serialize(streamComponents, KomponentenElemente);
            streamComponents.Close();

            Stream streamIdeas = new FileStream(
                "ideaElements.bin",
                FileMode.Create,
                FileAccess.Write, FileShare.None);
            formatter.Serialize(streamIdeas, IdeenElemente);
            streamIdeas.Close();

            Stream streamServants = new FileStream(
                "servantElements.bin",
                FileMode.Create,
                FileAccess.Write, FileShare.None);
            formatter.Serialize(streamServants, DienerElemente);
            streamServants.Close();
        }
        public void LoadElements()
        {
            IFormatter formatter = new BinaryFormatter();

            Stream streamComponents = new FileStream(
                "componentElements.bin",
                 FileMode.Open,
                 FileAccess.Read,
                 FileShare.Read);
            KomponentenElemente = (List<Komponente>)formatter.Deserialize(streamComponents);
            streamComponents.Close();

            Stream streamIdeas = new FileStream(
                "ideaElements.bin",
                 FileMode.Open,
                 FileAccess.Read,
                 FileShare.Read);
            IdeenElemente = (List<Idee>)formatter.Deserialize(streamIdeas);
            streamIdeas.Close();

            Stream streamServants = new FileStream(
                "servantElements.bin",
                 FileMode.Open,
                 FileAccess.Read,
                 FileShare.Read);
            DienerElemente = (List<Diener>)formatter.Deserialize(streamServants);
            streamServants.Close();
        }
        public void CreateGameObjects()
        {
            LoadElements();
            BuildComponentBank();
            BuildIdeaBank();
            BuildServantBank();
        }
    }
}
