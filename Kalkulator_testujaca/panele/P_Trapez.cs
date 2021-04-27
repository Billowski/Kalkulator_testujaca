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
    public partial class P_Trapez : Form
    {
        public P_Trapez()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trapez trapez = new Trapez();
            bool resulta = float.TryParse(trapez_a.Text, out float a);
            bool resultb = float.TryParse(trapez_b.Text, out float b);
            bool resultc = float.TryParse(trapez_c.Text, out float c);
            if (resulta && resultb && resultc)
            {
                trapez.setA(a);
                trapez.setB(b);
                trapez.setH(c);
                trapez_pole.Text = Convert.ToString(trapez.poleTrapez());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trapez trapez = new Trapez();
            bool resulta = float.TryParse(trapez_a.Text, out float a);
            bool resultb = float.TryParse(trapez_b.Text, out float b);
            bool resultc = float.TryParse(trapez_c.Text, out float c);
            bool resultd = float.TryParse(trapez_c.Text, out float d);
            if (resulta && resultb && resultc && resultd)
            {
                trapez.setA(a);
                trapez.setB(b);
                trapez.setC(c);
                trapez.setD(d);
                trapez_obwod.Text = Convert.ToString(trapez.obwodTrapez());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }
    }
}
