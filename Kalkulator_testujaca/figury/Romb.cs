using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_biblioteka
{
    class Romb
    {
        private float _a;
        private float _h;
        private float _sina;
        private float P;
        private float O;

        public void setA(float a)
        {
            _a = a;
        }
        public void setH(float h)
        {
            _h = h;
        }
        public void setSina(float sina)
        {
            _sina = sina;
        }
        public float poleRomb()
        {
            P = _a * _h;
            return P;
        }
        public float poleRomb2()
        {
            P = _a * _a * _sina;
            return P;
        }
        public float obwodRomb()
        {
            O = 4 * _a;
            return O;
        }
    }
}
