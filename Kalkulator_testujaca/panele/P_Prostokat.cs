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
            bool resulta = float.TryParse(prostokat_a.Text, out float a);
            bool resultb = float.TryParse(prostokat_a.Text, out float b);
            if (resulta && resultb)
            {
                prostokat.setA(a);
                prostokat.setB(b);
                prostokat_pole.Text = Convert.ToString(prostokat.poleProstokat());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prostokat prostokat = new Prostokat();
            bool resulta = float.TryParse(prostokat_a.Text, out float a);
            bool resultb = float.TryParse(prostokat_a.Text, out float b);
            if (resulta && resultb)
            {
                prostokat.setA(a);
                prostokat.setB(b);
                prostokat_obwod.Text = Convert.ToString(prostokat.obwodProstokat());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }
    }
}
