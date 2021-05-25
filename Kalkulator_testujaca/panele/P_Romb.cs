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
    public partial class P_Romb : Form
    {
        public P_Romb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Romb romb = new Romb();
            bool resulta = float.TryParse(romb_a.Text, out float a);
            bool resulth = float.TryParse(romb_h.Text, out float h);
            if (resulta && resulth)
            {
                romb.setA(a);
                romb.setH(h);
                romb_pole.Text = Convert.ToString(romb.poleRomb());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Romb romb = new Romb();
            bool resulta = float.TryParse(romb_a.Text, out float a);
            bool resultsina = float.TryParse(romb_sina.Text, out float sina);
            if (resulta && resultsina)
            {
                romb.setA(a);
                romb.setSina(sina);
                romb_pole.Text = Convert.ToString(romb.poleRomb2());
            }
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Romb romb = new Romb();
            bool resulta = float.TryParse(romb_a.Text, out float a);
            if (resulta)
            {
                romb.setA((float)Convert.ToDouble(romb_a.Text));
                romb_obwod.Text = Convert.ToString(romb.obwodRomb());
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
            romb_a.BackColor = SystemColors.ControlDark;
            romb_h.BackColor = SystemColors.ControlDark;
            romb_sina.BackColor = SystemColors.ControlDark;
            romb_pole.BackColor = SystemColors.ControlDark;
            romb_obwod.BackColor = SystemColors.ControlDark;

            //Labels
            label1.ForeColor = SystemColors.ButtonHighlight;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label6.ForeColor = SystemColors.ButtonHighlight;

            //Buttons
            button1.BackColor = SystemColors.ScrollBar;
            button2.BackColor = SystemColors.ScrollBar;
            button3.BackColor = SystemColors.ScrollBar;
        }

        public void NMOff()
        {
            //Backgroud
            this.BackColor = SystemColors.Control;

            //TextFields
            romb_a.BackColor = SystemColors.Window;
            romb_h.BackColor = SystemColors.Window;
            romb_sina.BackColor = SystemColors.Window;
            romb_pole.BackColor = SystemColors.Window;
            romb_obwod.BackColor = SystemColors.Window;

            //Labels
            label1.ForeColor = SystemColors.ControlText;
            label2.ForeColor = SystemColors.ControlText;
            label3.ForeColor = SystemColors.ControlText;
            label5.ForeColor = SystemColors.ControlText;
            label6.ForeColor = SystemColors.ControlText;

            //Buttons
            button1.BackColor = SystemColors.ControlLight;
            button2.BackColor = SystemColors.ControlLight;
            button3.BackColor = SystemColors.ControlLight;
        }
    }
}
