using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_testujaca
{
    class Prostokat
    {
        private float _a;
        private float _b;
        private float P;
        private float O;

        public void setA(float a)
        {
            _a = a;
        }
        public void setB(float b)
        {
            _b = b;
        }
        public float poleProstokat()
        {
            P = _a * _b;
            return P;
        }
        public float obwodProstokat()
        {
            O = (2 * _a) + (2 * _b);
            return O;
        }
    }
}
