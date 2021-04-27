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
    public partial class P_Romb : Form
    {
        public P_Romb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Romb romb = new Romb();
            bool resulta = float.TryParse(romb_a.Text, out float a);
            bool resulth = float.TryParse(romb_h.Text, out float h);
            if (resulta && resulth)
            {
                romb.setA(a);
                romb.setH(h);
                romb_pole.Text = Convert.ToString(romb.poleRomb());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Romb romb = new Romb();
            bool resulta = float.TryParse(romb_a.Text, out float a);
            bool resultsina = float.TryParse(romb_sina.Text, out float sina);
            if (resulta && resultsina)
            {
                romb.setA(a);
                romb.setSina(sina);
                romb_pole.Text = Convert.ToString(romb.poleRomb2());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Romb romb = new Romb();
            bool resulta = float.TryParse(romb_a.Text, out float a);
            if (resulta)
            {
                romb.setA((float)Convert.ToDouble(romb_a.Text));
                romb_obwod.Text = Convert.ToString(romb.obwodRomb());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }
    }
}
