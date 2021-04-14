using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_testujaca
{
    class Trapez
    {
        private float _a;
        private float _b;
        private float _c;
        private float _d;
        private float _h;
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
        public void setC(float c)
        {
            _c = c;
        }
        public void setD(float d)
        {
            _d = d;
        }
        public void setH(float h)
        {
            _h = h;
        }
        public float poleTrapez()
        {
            P = (float)(0.5 * (_a + _b) * _h);
            return P;
        }
        public float obwodTrapez()
        {
            O = _a + _b + _c + _d;
            return O;
        }
    }
}
