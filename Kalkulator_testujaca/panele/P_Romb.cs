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
            romb.setA((float)Convert.ToDouble(romb_a.Text));
            romb.setH((float)Convert.ToDouble(romb_h.Text));
            romb_pole.Text = Convert.ToString(romb.poleRomb());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Romb romb = new Romb();
            romb.setA((float)Convert.ToDouble(romb_a.Text));
            romb.setSina((float)Convert.ToDouble(romb_sina.Text));
            romb_pole.Text = Convert.ToString(romb.poleRomb2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Romb romb = new Romb();
            romb.setA((float)Convert.ToDouble(romb_a.Text));
            romb_obwod.Text = Convert.ToString(romb.obwodRomb());
        }
    }
}
