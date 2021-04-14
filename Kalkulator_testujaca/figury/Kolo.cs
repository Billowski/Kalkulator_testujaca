using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_testujaca
{
    class Kolo
    {
        private float _r;
        private float P;
        private float O;

        public void setR(float r)
        {
            _r = r;
        }
        public float poleKolo()
        {
            P = (float)(3.14 * _r * _r);
            return P;
        }
        public float obwodKolo()
        {
            O = (float)(2 * 3.14 * _r);
            return O;
        }
    }
}
