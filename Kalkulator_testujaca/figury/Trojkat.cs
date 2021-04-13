using System;

namespace Kalkulator_testujaca
{
    public class Trojkat
    {
        private float _a;
        private float _b;
        private float _c;
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
        public void setH(float h)
        {
            _h = h;
        }
        public float poleTrojkat()
        {
            P = (float)(0.5 * _a * _h);
            return P;
        }
        public float obwodTrojkat()
        {
            O = _a + _b + _c;
            return O;
        }
    }
}
