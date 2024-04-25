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
        public string path = "utazasok.csv";

        Utazas utazas = new Utazas();

        public List<Utazas> ListaFeltoltese()
        {
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

        

    }
}
