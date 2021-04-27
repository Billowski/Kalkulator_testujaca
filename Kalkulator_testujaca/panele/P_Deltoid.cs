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
            bool resulted = float.TryParse(deltoid_e.Text, out float ed);
            bool resultf = float.TryParse(deltoid_f.Text, out float f);
            if (resulted && resultf)
            {
                deltoid.setE(ed);
                deltoid.setF(f);
                deltoid_pole.Text = Convert.ToString(deltoid.poleDeltoid());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deltoid deltoid = new Deltoid();
            bool resulta = float.TryParse(deltoid_a.Text, out float a);
            bool resultb = float.TryParse(deltoid_b.Text, out float b);
            if (resulta && resultb)
            {
                deltoid.setA(a);
                deltoid.setB(b);
                deltoid_obwod.Text = Convert.ToString(deltoid.obwodDeltoid());
            } 
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }
    }
}
