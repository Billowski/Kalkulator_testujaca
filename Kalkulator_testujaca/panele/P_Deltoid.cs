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

        public void NMOn()
        {
            //Backgroud
            this.BackColor = SystemColors.WindowFrame;

            //TextFields
            deltoid_e.BackColor = SystemColors.ControlDark;
            deltoid_f.BackColor = SystemColors.ControlDark;
            deltoid_a.BackColor = SystemColors.ControlDark;
            deltoid_b.BackColor = SystemColors.ControlDark;
            deltoid_pole.BackColor = SystemColors.ControlDark;
            deltoid_obwod.BackColor = SystemColors.ControlDark;

            //Labels
            label1.ForeColor = SystemColors.ButtonHighlight;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label4.ForeColor = SystemColors.ButtonHighlight;
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
            deltoid_e.BackColor = SystemColors.Window;
            deltoid_f.BackColor = SystemColors.Window;
            deltoid_a.BackColor = SystemColors.Window;
            deltoid_b.BackColor = SystemColors.Window;
            deltoid_pole.BackColor = SystemColors.Window;
            deltoid_obwod.BackColor = SystemColors.Window;

            //Labels
            label1.ForeColor = SystemColors.ControlText;
            label2.ForeColor = SystemColors.ControlText;
            label3.ForeColor = SystemColors.ControlText;
            label4.ForeColor = SystemColors.ControlText;
            label5.ForeColor = SystemColors.ControlText;
            label6.ForeColor = SystemColors.ControlText;

            //Buttons
            button1.BackColor = SystemColors.ControlLight;
            button2.BackColor = SystemColors.ControlLight;
        }
    }
}
