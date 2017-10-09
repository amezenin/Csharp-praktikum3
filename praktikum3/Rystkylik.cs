using System;
using System.Collections.Generic;
using System.Text;

namespace praktikum3
{

    //vaikimisi on see klass internel
    //mis on nähtav terve selle assembly (ehk konkretse projekti sees)  
    class Rystkylik
    {
        private int _pikkus;
        private int _laius;

        public Rystkylik(int pikkus, int laius)
        {

            _pikkus = pikkus;
            _laius = laius;

        }

        /*public Ristkylik() : this(0,0)
        {
            
        }*/

        //arvuta pidnala
        public int ArvutaPindala()
        {
            return _laius * _pikkus;


        }

        public bool KasOnVordne(Rystkylik r)
        {
            return this.ArvutaPindala() == r.ArvutaPindala();
            
        }

        public bool KasOnRuut()
        {
            /*if (_laius == _pikkus)
            {
                Console.WriteLine("Ristkylik on ruut!");
                return true;
            } else
            {
                Console.WriteLine("Ristkylik ei ole ruut!");
            return false;
            }*/

            return this._laius == _pikkus;



        }
    }
}
