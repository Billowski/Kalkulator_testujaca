using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_biblioteka
{
    class Deltoid
    {
        private float _d1;
        private float _d2;
        private float _a;
        private float _b;
        private float P;
        private float O;

        public void setD1(float d1)
        {
            _d1 = d1;
        }
        public void setD2(float d2)
        {
            _d2 = d2;
        }
        public void setA(float a)
        {
            _a = a;
        }
        public void setB(float b)
        {
            _b = b;
        }
        public float poleDeltoid()
        {
            P = (float)(0.5 * _d1 * _d2);
            return P;
        }
        public float obwodDeltoid()
        {
            O = (2 * _a) + (2 * _b);
            return O;
        }
    }
}
