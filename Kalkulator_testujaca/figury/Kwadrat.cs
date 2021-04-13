using System;
using System.Collections.Generic;
using System.Text;

namespace Kalkulator_biblioteka
{
    class Kwadrat
    {
        private float _a;
        private float P;
        private float O;

        public void setA(float a)
        {
            _a = a;
        }
        public float poleKwadrat()
        {
            P = _a * _a;
            return P;
        }
        public float obwodKwadrat()
        {
            O = 4 * _a;
            return O;
        }
    }
}
