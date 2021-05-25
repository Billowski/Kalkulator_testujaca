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
    public partial class P_Trapez : Form
    {
        public P_Trapez()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trapez trapez = new Trapez();
            bool resulta = float.TryParse(trapez_a.Text, out float a);
            bool resultb = float.TryParse(trapez_b.Text, out float b);
            bool resultc = float.TryParse(trapez_c.Text, out float c);
            if (resulta && resultb && resultc)
            {
                trapez.setA(a);
                trapez.setB(b);
                trapez.setH(c);
                trapez_pole.Text = Convert.ToString(trapez.poleTrapez());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trapez trapez = new Trapez();
            bool resulta = float.TryParse(trapez_a.Text, out float a);
            bool resultb = float.TryParse(trapez_b.Text, out float b);
            bool resultc = float.TryParse(trapez_c.Text, out float c);
            bool resultd = float.TryParse(trapez_c.Text, out float d);
            if (resulta && resultb && resultc && resultd)
            {
                trapez.setA(a);
                trapez.setB(b);
                trapez.setC(c);
                trapez.setD(d);
                trapez_obwod.Text = Convert.ToString(trapez.obwodTrapez());
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
            trapez_a.BackColor = SystemColors.ControlDark;
            trapez_b.BackColor = SystemColors.ControlDark;
            trapez_c.BackColor = SystemColors.ControlDark;
            trapez_d.BackColor = SystemColors.ControlDark;
            trapez_h.BackColor = SystemColors.ControlDark;
            trapez_pole.BackColor = SystemColors.ControlDark;
            trapez_obwod.BackColor = SystemColors.ControlDark;

            //Labels
            label1.ForeColor = SystemColors.ButtonHighlight;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label7.ForeColor = SystemColors.ButtonHighlight;

            //Buttons
            button1.BackColor = SystemColors.ScrollBar;
            button2.BackColor = SystemColors.ScrollBar;
        }

        public void NMOff()
        {
            //Backgroud
            this.BackColor = SystemColors.Control;

            //TextFields
            trapez_a.BackColor = SystemColors.Window;
            trapez_b.BackColor = SystemColors.Window;
            trapez_c.BackColor = SystemColors.Window;
            trapez_d.BackColor = SystemColors.Window;
            trapez_h.BackColor = SystemColors.Window;
            trapez_pole.BackColor = SystemColors.Window;
            trapez_obwod.BackColor = SystemColors.Window;

            //Labels
            label1.ForeColor = SystemColors.ControlText;
            label2.ForeColor = SystemColors.ControlText;
            label3.ForeColor = SystemColors.ControlText;
            label4.ForeColor = SystemColors.ControlText;
            label5.ForeColor = SystemColors.ControlText;
            label6.ForeColor = SystemColors.ControlText;
            label7.ForeColor = SystemColors.ControlText;

            //Buttons
            button1.BackColor = SystemColors.ControlLight;
            button2.BackColor = SystemColors.ControlLight;
        }
    }
}
