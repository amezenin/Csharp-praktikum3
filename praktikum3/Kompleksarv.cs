using System;
using System.Collections.Generic;
using System.Text;

namespace praktikum3
{
    class Kompleksarv
    {
        private double _reaalarv;

        private double _imaginaararv;

        public Kompleksarv(double reaalarv, double imaginaararv)
        {
            _reaalarv = reaalarv;
            _imaginaararv = imaginaararv;
        }

        public Kompleksarv liida(Kompleksarv arv)
        {
            double reaalosa = _reaalarv + arv._reaalarv;
            double imaginaarosa = _imaginaararv + arv._imaginaararv;
            Kompleksarv tulemus = new Kompleksarv(reaalosa, imaginaarosa);
            Console.WriteLine("Summa: " + reaalosa + " + " + imaginaarosa + "i");

            return tulemus;

            //teine variant tagastame string. siis tuleb meetod ka stringigks muuta. Näide allpool lahutamisega. 
            // return string.Format("{0} + {1}i", _reaalarv + arv._reaalarv, _imaginaararv + arv._imaginaararv);
        }

        public string lahuta(Kompleksarv arv)
        {
            return string.Format("{0} + {1}i", _reaalarv - arv._reaalarv, _imaginaararv - arv._imaginaararv);
        }
    }
}
