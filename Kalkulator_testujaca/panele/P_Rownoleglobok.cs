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

        public void NMOn()
        {
            //Backgroud
            this.BackColor = SystemColors.WindowFrame;

            //TextFields
            rownoleglobok_a.BackColor = SystemColors.ControlDark;
            rownoleglobok_b.BackColor = SystemColors.ControlDark;
            rownoleglobok_h.BackColor = SystemColors.ControlDark;
            rownoleglobok_sina.BackColor = SystemColors.ControlDark;
            rownoleglobok_pole.BackColor = SystemColors.ControlDark;
            rownoleglobok_obwod.BackColor = SystemColors.ControlDark;

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
            button3.BackColor = SystemColors.ScrollBar;
        }

        public void NMOff()
        {
            //Backgroud
            this.BackColor = SystemColors.Control;

            //TextFields
            rownoleglobok_a.BackColor = SystemColors.Window;
            rownoleglobok_b.BackColor = SystemColors.Window;
            rownoleglobok_h.BackColor = SystemColors.Window;
            rownoleglobok_sina.BackColor = SystemColors.Window;
            rownoleglobok_pole.BackColor = SystemColors.Window;
            rownoleglobok_obwod.BackColor = SystemColors.Window;

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
            button3.BackColor = SystemColors.ControlLight;
        }
    }
}
