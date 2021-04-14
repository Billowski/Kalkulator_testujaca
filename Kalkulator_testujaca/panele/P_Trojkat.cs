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
            trojkat.setA((float)Convert.ToDouble(trojkat_a.Text));
            trojkat.setH((float)Convert.ToDouble(trojkat_h.Text));
            trojkat_pole.Text = Convert.ToString(trojkat.poleTrojkat());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trojkat trojkat = new Trojkat();
            trojkat.setA((float)Convert.ToDouble(trojkat_a.Text));
            trojkat.setB((float)Convert.ToDouble(trojkat_b.Text));
            trojkat.setC((float)Convert.ToDouble(trojkat_c.Text));
            trojkat_obwod.Text = Convert.ToString(trojkat.obwodTrojkat());
        }
    }
}
