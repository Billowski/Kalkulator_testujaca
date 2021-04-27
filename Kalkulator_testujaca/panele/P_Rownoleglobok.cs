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
            bool resulta = float.TryParse(rownoleglobok_a.Text, out float a);
            bool resulth = float.TryParse(rownoleglobok_h.Text, out float h);
            if (resulta && resulth)
            {
                rownoleglobok.setA(a);
                rownoleglobok.setH(h);
                rownoleglobok_pole.Text = Convert.ToString(rownoleglobok.poleRownoleglobok());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rownoleglobok rownoleglobok = new Rownoleglobok();
            bool resulta = float.TryParse(rownoleglobok_a.Text, out float a);
            bool resultb = float.TryParse(rownoleglobok_b.Text, out float b);
            bool resultsina = float.TryParse(rownoleglobok_sina.Text, out float sina);
            if (resulta && resultb && resultsina)
            {
                rownoleglobok.setA(a);
                rownoleglobok.setB(b);
                rownoleglobok.setSina(sina);
                rownoleglobok_pole.Text = Convert.ToString(rownoleglobok.poleRownoleglobok2());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rownoleglobok rownoleglobok = new Rownoleglobok();
            bool resulta = float.TryParse(rownoleglobok_a.Text, out float a);
            bool resultb = float.TryParse(rownoleglobok_b.Text, out float b);
            if (resulta && resultb)
            {
                rownoleglobok.setA(a);
                rownoleglobok.setB(b);
                rownoleglobok_obwod.Text = Convert.ToString(rownoleglobok.obwodRownoleglobok());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }
    }
}
