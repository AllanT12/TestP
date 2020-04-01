using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Cutie
    {
        public int Lungime { get; set; }
        public int Latime { get; set; }
        public int Adancime { get; set; }
        public Culoare Culoare { get; set; }

        public Cutie(int _lungime,int _latime,int _adancime)
        {
            Lungime = _lungime;
            Latime = _latime;
            Adancime = _adancime;
        }
        public string ConversieLaSir()
        {
            string s=string.Format("L:{0} l:{1} A:{2} Cul:{3}",Lungime,Latime,Adancime,Culoare);
            return s;
        }
        public int ComparaCuAltaCutie(Cutie _cutie)
        {
            if (Lungime < _cutie.Lungime && Latime < _cutie.Latime && Adancime < _cutie.Adancime)
                return 0;
            else if (Lungime == _cutie.Lungime && Latime == _cutie.Latime && Adancime == _cutie.Adancime)
                return 1;
            else
                return 2;
        }
    }
}
