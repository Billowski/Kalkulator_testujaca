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
    public partial class P_Trojkat : Form
    {
        public P_Trojkat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trojkat trojkat = new Trojkat();
            bool resulta = float.TryParse(trojkat_a.Text, out float a);
            bool resulth = float.TryParse(trojkat_h.Text, out float h);
            if (resulta && resulth)
            {
                trojkat.setA(a);
                trojkat.setH(h);
                trojkat_pole.Text = Convert.ToString(trojkat.poleTrojkat());
            } else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trojkat trojkat = new Trojkat();
            bool resulta = float.TryParse(trojkat_a.Text, out float a);
            bool resultb = float.TryParse(trojkat_b.Text, out float b);
            bool resultc = float.TryParse(trojkat_c.Text, out float c);
            if (resulta && resultb && resultc)
            {
                trojkat.setA(a);
                trojkat.setB(b);
                trojkat.setC(c);
                trojkat_obwod.Text = Convert.ToString(trojkat.obwodTrojkat());
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
            trojkat_a.BackColor = SystemColors.ControlDark;
            trojkat_b.BackColor = SystemColors.ControlDark;
            trojkat_c.BackColor = SystemColors.ControlDark;
            trojkat_h.BackColor = SystemColors.ControlDark;
            trojkat_pole.BackColor = SystemColors.ControlDark;
            trojkat_obwod.BackColor = SystemColors.ControlDark;

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
            trojkat_a.BackColor = SystemColors.Window;
            trojkat_b.BackColor = SystemColors.Window;
            trojkat_c.BackColor = SystemColors.Window;
            trojkat_h.BackColor = SystemColors.Window;
            trojkat_pole.BackColor = SystemColors.Window;
            trojkat_obwod.BackColor = SystemColors.Window;

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
