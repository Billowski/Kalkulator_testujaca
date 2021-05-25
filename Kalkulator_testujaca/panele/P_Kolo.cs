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
    public partial class P_Kolo : Form
    {
        public P_Kolo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kolo kolo = new Kolo();
            bool resultr = float.TryParse(kolo_r.Text, out float r);
            if (resultr)
            {
                kolo.setR(r);
                kolo_pole.Text = Convert.ToString(kolo.poleKolo());
            } else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kolo kolo = new Kolo();
            bool resultr = float.TryParse(kolo_r.Text, out float r);
            if (resultr)
            {
                kolo.setR(r);
                kolo_obwod.Text = Convert.ToString(kolo.obwodKolo());
            } else
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
            kolo_r.BackColor = SystemColors.ControlDark;
            kolo_pole.BackColor = SystemColors.ControlDark;
            kolo_obwod.BackColor = SystemColors.ControlDark;

            //Labels
            label1.ForeColor = SystemColors.ButtonHighlight;
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
            kolo_r.BackColor = SystemColors.Window;
            kolo_pole.BackColor = SystemColors.Window;
            kolo_obwod.BackColor = SystemColors.Window;

            //Labels
            label1.ForeColor = SystemColors.ControlText;
            label5.ForeColor = SystemColors.ControlText;
            label6.ForeColor = SystemColors.ControlText;

            //Buttons
            button1.BackColor = SystemColors.ControlLight;
            button2.BackColor = SystemColors.ControlLight;
        }
    }
}
