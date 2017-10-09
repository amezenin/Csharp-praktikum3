using System;
using System.Collections.Generic;
using System.Text;

namespace praktikum3
{
    class Punkt
    {
        private int _x;
        private int _y;

        public Punkt(int x, int y)
        {
            _x = x;
            _y = y;

        }
//leia kaugust teisest punktist
        // meetodi tagastustyyp? double
        // meetodi nimi - kaugusTeisest
        
        public double kaugusTeisest(Punkt p)
        {
            double xVal = Math.Pow(p._x - _x, 2);
            double yVal = Math.Pow(p._y - _y, 2);
            double punktideVahelineKaugus = Math.Sqrt(xVal + yVal);
            
            return punktideVahelineKaugus;
            //return Math.Sqrt(xVal + yVal);
            
        }

        public double kaugusNullist()
        {
            
            return kaugusTeisest(new Punkt(0, 0));
            
        }

        public string teataAndmed()
        {
            
            string koor = string.Format("({0};{1})", _x, _y);
            

            return koor;
        }

        public bool kasOnAlguspunkt()
        {
            if (_x == 0 && _y == 0)
            {
                
                return true;
            }
            
            return false;
        }


    }
}
