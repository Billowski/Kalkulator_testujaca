using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_testujaca.panele
{
    public partial class P_Trojkat : Form
    {
        public P_Trojkat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trojkat trojkat = new Trojkat();
            bool resulta = float.TryParse(trojkat_a.Text, out float a);
            bool resulth = float.TryParse(trojkat_h.Text, out float h);
            if (resulta && resulth)
            {
                trojkat.setA(a);
                trojkat.setH(h);
                trojkat_pole.Text = Convert.ToString(trojkat.poleTrojkat());
            } else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trojkat trojkat = new Trojkat();
            bool resulta = float.TryParse(trojkat_a.Text, out float a);
            bool resultb = float.TryParse(trojkat_b.Text, out float b);
            bool resultc = float.TryParse(trojkat_c.Text, out float c);
            if (resulta && resultb && resultc)
            {
                trojkat.setA(a);
                trojkat.setB(b);
                trojkat.setC(c);
                trojkat_obwod.Text = Convert.ToString(trojkat.obwodTrojkat());
            } else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }
    }
}
