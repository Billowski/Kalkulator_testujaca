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
            trapez.setA((float)Convert.ToDouble(trapez_a.Text));
            trapez.setB((float)Convert.ToDouble(trapez_b.Text));
            trapez.setH((float)Convert.ToDouble(trapez_h.Text));
            trapez_pole.Text = Convert.ToString(trapez.poleTrapez());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trapez trapez = new Trapez();
            trapez.setA((float)Convert.ToDouble(trapez_a.Text));
            trapez.setB((float)Convert.ToDouble(trapez_b.Text));
            trapez.setC((float)Convert.ToDouble(trapez_c.Text));
            trapez.setD((float)Convert.ToDouble(trapez_d.Text));
            trapez_obwod.Text = Convert.ToString(trapez.obwodTrapez());
        }
    }
}
