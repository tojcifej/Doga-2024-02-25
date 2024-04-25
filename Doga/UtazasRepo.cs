using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Doga
{
    class UtazasRepo
    {
        public bool skip = true;
        public char delimiter = ',';
        public string path = "";

        Utazas utazas = new Utazas();

        public List<Utazas> FindAll()
        {
            if (path == "")
                return null;

            List<Utazas> utazasok = new List<Utazas>();

            using (StreamReader streamReader = new StreamReader(path))
            {
                if (skip)
                    streamReader.ReadLine();

                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    utazasok.Add(utazas.UtazasFromLine(line, delimiter));
                }
            }

            return utazasok;
        }

        public List<Utazas> FindByID(int id)
        {
            if (path == "")
                return null;

            List<Utazas> utazasok = new List<Utazas>();

            using (StreamReader streamReader = new StreamReader(path))
            {
                if (skip)
                    streamReader.ReadLine();

                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    Utazas FromLine = utazas.UtazasFromLine(line, delimiter);
                    if (FromLine.ID == id)
                    {
                        utazasok.Add(FromLine);
                        return utazasok;
                    }

                }
            }

            return null;
        }

        public void SaveList(List<Utazas> utazasok, string path, string id, string orszag, string honap, string nap, string hossz, string ar, string ellatas)
        {
            if (id == "" || id == "0")
            { //új
                Utazas uj = new Utazas
                {
                    ID = utazasok.Last().ID + 1,
                    Orszag = orszag,
                    Honap = int.Parse(honap),
                    Nap = int.Parse(nap),
                    Hossz = int.Parse(hossz),
                    Ar = int.Parse(ar),
                    Ellatas = ellatas
                };
                utazasok.Add(uj);
            }
            else
            { //firssítés
                for (int i = 0; i < utazasok.Count; i++)
                    if (utazasok[i].ID == int.Parse(id))
                    {
                        if (orszag != "")
                            utazasok[i].Orszag = orszag.Trim();
                        if (honap != "")
                            utazasok[i].Honap = int.Parse(honap);
                        if (nap != "")
                            utazasok[i].Nap = int.Parse(nap);
                        if (ar != "")
                            utazasok[i].Hossz = int.Parse(ar);
                        if (ellatas != null)
                            utazasok[i].Ellatas = ellatas.Trim();
                    }
            }

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("id,orszag,honap,nap,hossz,ar,ellatas");

                foreach (var item in utazasok)
                    streamWriter.WriteLine(item);
            }
        }

        

    }
}
