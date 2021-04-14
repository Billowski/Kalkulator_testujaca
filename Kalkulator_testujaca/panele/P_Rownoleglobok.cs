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
    public partial class P_Rownoleglobok : Form
    {
        public P_Rownoleglobok()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rownoleglobok rownoleglobok = new Rownoleglobok();
            rownoleglobok.setA((float)Convert.ToDouble(rownoleglobok_a.Text));
            rownoleglobok.setH((float)Convert.ToDouble(rownoleglobok_h.Text));
            rownoleglobok_pole.Text = Convert.ToString(rownoleglobok.poleRownoleglobok());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rownoleglobok rownoleglobok = new Rownoleglobok();
            rownoleglobok.setA((float)Convert.ToDouble(rownoleglobok_a.Text));
            rownoleglobok.setB((float)Convert.ToDouble(rownoleglobok_b.Text));
            rownoleglobok.setSina((float)Convert.ToDouble(rownoleglobok_sina.Text));
            rownoleglobok_pole.Text = Convert.ToString(rownoleglobok.poleRownoleglobok2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rownoleglobok rownoleglobok = new Rownoleglobok();
            rownoleglobok.setA((float)Convert.ToDouble(rownoleglobok_a.Text));
            rownoleglobok.setB((float)Convert.ToDouble(rownoleglobok_b.Text));
            rownoleglobok_obwod.Text = Convert.ToString(rownoleglobok.obwodRownoleglobok());
        }
    }
}
