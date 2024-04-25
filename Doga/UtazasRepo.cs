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

        public void SaveList(List<Utazas> utazasok, string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {

                streamWriter.WriteLine("id,orszag,honap,nap,hossz,ar,ellatas");

                foreach (var item in utazasok)
                    streamWriter.WriteLine(item);

            }
        }

        

    }
}
