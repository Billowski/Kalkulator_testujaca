using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_testujaca
{
    class Deltoid
    {
        private float _e;
        private float _f;
        private float _a;
        private float _b;
        private float P;
        private float O;

        public void setE(float e)
        {
            _e = e;
        }
        public void setF(float f)
        {
            _f = f;
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
            P = (float)(0.5 * _e * _f);
            return P;
        }
        public float obwodDeltoid()
        {
            O = (2 * _a) + (2 * _b);
            return O;
        }
    }
}
