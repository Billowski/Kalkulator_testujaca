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
    public partial class P_Kwadrat : Form
    {
        public P_Kwadrat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kwadrat kwadrat = new Kwadrat();
            kwadrat.setA((float)Convert.ToDouble(kwadrat_a.Text));
            kwadrat_pole.Text = Convert.ToString(kwadrat.poleKwadrat());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kwadrat kwadrat = new Kwadrat();
            kwadrat.setA((float)Convert.ToDouble(kwadrat_a.Text));
            kwadrat_obwod.Text = Convert.ToString(kwadrat.obwodKwadrat());
        }
    }
}
