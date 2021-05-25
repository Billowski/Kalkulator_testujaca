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
    public partial class P_Kwadrat : Form
    {
        public P_Kwadrat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kwadrat kwadrat = new Kwadrat();
            bool resulta = float.TryParse(kwadrat_a.Text, out float a);
            if (resulta)
            {
                kwadrat.setA(a);
                kwadrat_pole.Text = Convert.ToString(kwadrat.poleKwadrat());
            } 
            else
            {
                Blad blad = new Blad();
                blad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kwadrat kwadrat = new Kwadrat();
            bool resulta = float.TryParse(kwadrat_a.Text, out float a);
            if (resulta)
            {
                kwadrat.setA(a);
                kwadrat_obwod.Text = Convert.ToString(kwadrat.obwodKwadrat());
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

            //Textfields
            kwadrat_a.BackColor = SystemColors.ControlDark;
            kwadrat_pole.BackColor = SystemColors.ControlDark;
            kwadrat_obwod.BackColor = SystemColors.ControlDark;

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

            //Textfields
            kwadrat_a.BackColor = SystemColors.Window;
            kwadrat_pole.BackColor = SystemColors.Window;
            kwadrat_obwod.BackColor = SystemColors.Window;

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
