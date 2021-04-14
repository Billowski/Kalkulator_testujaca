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
    public partial class P_Prostokat : Form
    {
        public P_Prostokat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prostokat prostokat = new Prostokat();
            prostokat.setA((float)Convert.ToDouble(prostokat_a.Text));
            prostokat.setB((float)Convert.ToDouble(prostokat_b.Text));
            prostokat_pole.Text = Convert.ToString(prostokat.poleProstokat());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prostokat prostokat = new Prostokat();
            prostokat.setA((float)Convert.ToDouble(prostokat_a.Text));
            prostokat.setB((float)Convert.ToDouble(prostokat_b.Text));
            prostokat_obwod.Text = Convert.ToString(prostokat.obwodProstokat());
        }
    }
}
