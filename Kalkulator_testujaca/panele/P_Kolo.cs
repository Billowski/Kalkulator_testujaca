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
    public partial class P_Kolo : Form
    {
        public P_Kolo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kolo kolo = new Kolo();
            bool resultr = float.TryParse(kolo_r.Text, out float r);
            if (resultr)
            {
                kolo.setR(r);
                kolo_pole.Text = Convert.ToString(kolo.poleKolo());
            } else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kolo kolo = new Kolo();
            bool resultr = float.TryParse(kolo_r.Text, out float r);
            if (resultr)
            {
                kolo.setR(r);
                kolo_obwod.Text = Convert.ToString(kolo.obwodKolo());
            } else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }
    }
}
