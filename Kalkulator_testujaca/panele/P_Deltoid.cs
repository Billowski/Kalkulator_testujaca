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
    public partial class P_Deltoid : Form
    {
        public P_Deltoid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deltoid deltoid = new Deltoid();
            deltoid.setE((float)Convert.ToDouble(deltoid_e.Text));
            deltoid.setF((float)Convert.ToDouble(deltoid_f.Text));
            deltoid_pole.Text = Convert.ToString(deltoid.poleDeltoid());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deltoid deltoid = new Deltoid();
            deltoid.setA((float)Convert.ToDouble(deltoid_a.Text));
            deltoid.setB((float)Convert.ToDouble(deltoid_b.Text));
            deltoid_obwod.Text = Convert.ToString(deltoid.obwodDeltoid());
        }
    }
}
