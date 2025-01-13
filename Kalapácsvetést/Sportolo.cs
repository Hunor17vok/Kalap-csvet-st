using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalapácsvetést
{
    internal class Sportolo
    {
        public int Helyezés { get; set; }
        public double Eredmyény { get; set; }
        public string Sportolok { get; set; }
        public string Orszagkod { get; set; }
        public string Hejszin { get; set; }
        public string Dátum { get; set; }
        public Sportolo(string sor)
        {
            string[] s = sor.Split(';');
            Helyezés = int.Parse(s[0]);
            Eredmyény = double.Parse(s[1]);
            Sportolok = s[2];
            Orszagkod = s[3];
            Hejszin = s[4];
            Dátum = s[5];
        }
    }
}
