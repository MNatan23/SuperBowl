using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowl
{
    internal class Döntő
    {
        public string sSz { get; set; }
        public string Dátum { get; set; }
        public string Győztes { get; set; }
        public string Eredmény { get; set; }
        public string Vesztes { get; set; }
        public string Helyszín { get; set; }
        public string VárosÁllam { get; set; }
        public int Nézőszám { get; set; }

        public Döntő(string sor)
        {
            string[ ] s =  sor.Split(';');
            sSz = s[0];
            Dátum = s[1];
            Győztes = s[2];
            Eredmény = s[3];
            Vesztes = s[4];
            Helyszín = s[5];
            VárosÁllam = s[6];
            Nézőszám = int.Parse(s[7]);
        }
    }
}
