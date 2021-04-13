using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_biblioteka
{
    class Rownoleglobok
    {
        private float _a;
        private float _b;
        private float _h;
        private float _sina;
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
        public void setH(float h)
        {
            _h = h;
        }
        public void setSina(float sina)
        {
            _sina = sina;
        }
        public float poleRownoleglobok()
        {
            P = _a * _h;
            return P;
        }
        public float poleRownoleglobok2()
        {
            P = _a * _b * _sina;
            return P;
        }
        public float obwodRownoleglobok()
        {
            O = (2 * _a) + (2 * _b);
            return O;
        }
    }
}
