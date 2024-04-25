using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Doga
{
    public class Utazas
    {
        public int ID { get; set; }
        public string Orszag { get; set; }
        public int Honap { get; set; }
        public int Nap { get; set; }
        public int Hossz { get; set; }
        public int Ar { get; set; }
        public string Ellatas { get; set; }


        public Utazas UtazasFromLine(string line, char delimiter)
        {
            string[] darabolva = new string[7];

            darabolva = line.Split(delimiter);

            Utazas utazas = new Utazas
            {
                ID = int.Parse(darabolva[0]),
                Orszag = darabolva[1],
                Honap = int.Parse(darabolva[2]),
                Nap = int.Parse(darabolva[3]),
                Hossz = int.Parse(darabolva[4]),
                Ar = int.Parse(darabolva[5]),
                Ellatas = darabolva[6]
            };

            return utazas;
        }

        public override string ToString()
        {
            return ($"{ID}, {Orszag}, {Honap}, {Nap}, {Hossz}, {Ar}, {Ellatas}");
        }
    }
}
