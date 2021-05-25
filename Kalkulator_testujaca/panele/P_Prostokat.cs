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

        public void NMOn()
        {
            //Backgroud
            this.BackColor = SystemColors.WindowFrame;

            //TextFields
            prostokat_a.BackColor = SystemColors.ControlDark;
            prostokat_b.BackColor = SystemColors.ControlDark;

            //Labels
            label1.ForeColor = SystemColors.ButtonHighlight;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label6.ForeColor = SystemColors.ButtonHighlight;

            //Buttons
            button1.BackColor = SystemColors.ScrollBar;
            button2.BackColor = SystemColors.ScrollBar;
        }

        public void NMOff()
        {
            //Backgroud
            this.BackColor = SystemColors.Control;

            //TextFields
            prostokat_a.BackColor = SystemColors.Window;
            prostokat_b.BackColor = SystemColors.Window;

            //Labels
            label1.ForeColor = SystemColors.ControlText;
            label2.ForeColor = SystemColors.ControlText;
            label5.ForeColor = SystemColors.ControlText;
            label6.ForeColor = SystemColors.ControlText;

            //Buttons
            button1.BackColor = SystemColors.ControlLight;
            button2.BackColor = SystemColors.ControlLight;
        }

    }
}
