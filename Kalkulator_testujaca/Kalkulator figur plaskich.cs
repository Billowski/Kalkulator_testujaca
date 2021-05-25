using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_testujaca
{
    public partial class Kalkulator : UserControl
    {
        private panele.P_Trojkat pTrojkat = new panele.P_Trojkat();
        private panele.P_Kwadrat pKwadrat = new panele.P_Kwadrat();
        private panele.P_Prostokat pProstokat = new panele.P_Prostokat();
        private panele.P_Romb pRomb = new panele.P_Romb();
        private panele.P_Rownoleglobok pRownoleglobok = new panele.P_Rownoleglobok();
        private panele.P_Trapez pTrapez = new panele.P_Trapez();
        private panele.P_Deltoid pDeltoid = new panele.P_Deltoid();
        private panele.P_Kolo pKolo = new panele.P_Kolo();

        private bool NM_OnOff = false;


        public Kalkulator()
        {
            InitializeComponent();
            //pTrojkat = new panele.P_Trojkat();
            pTrojkat.TopLevel = false;
            pTrojkat.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(pTrojkat);
            pTrojkat.Show();
        }

        private void P_Trojkat_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            //pTrojkat = new panele.P_Trojkat();
            pTrojkat.TopLevel = false;
            pTrojkat.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(pTrojkat);
            pTrojkat.Show();
        }

        private void P_Kwadrat_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            //pKwadrat = new panele.P_Kwadrat();
            pKwadrat.TopLevel = false;
            pKwadrat.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(pKwadrat);
            pKwadrat.Show();
        }

        private void P_Prostokat_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
           // pProstokat = new panele.P_Prostokat();
            pProstokat.TopLevel = false;
            pProstokat.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(pProstokat);
            pProstokat.Show();
        }

        private void P_Romb_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            //pRomb = new panele.P_Romb();
            pRomb.TopLevel = false;
            pRomb.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(pRomb);
            pRomb.Show();
        }

        private void P_Rownoleglobok_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            //pRownoleglobok = new panele.P_Rownoleglobok();
            pRownoleglobok.TopLevel = false;
            pRownoleglobok.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(pRownoleglobok);
            pRownoleglobok.Show();
        }

        private void P_Trapez_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
           // pTrapez = new panele.P_Trapez();
            pTrapez.TopLevel = false;
            pTrapez.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(pTrapez);
            pTrapez.Show();
        }

        private void P_Deltoid_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            //pDeltoid = new panele.P_Deltoid();
            pDeltoid.TopLevel = false;
            pDeltoid.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(pDeltoid);
            pDeltoid.Show();
        }

        private void P_Kolo_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
           // pKolo = new panele.P_Kolo();
            pKolo.TopLevel = false;
            pKolo.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(pKolo);
            pKolo.Show();
        }

        private void btnNM_Click(object sender, EventArgs e)
        {
            if (NM_OnOff == false) //NightMode ON
            {
                this.BackColor = SystemColors.WindowFrame;
                toolStrip1.BackColor = SystemColors.ControlDarkDark;
                pTrojkat.NMOn();
                pKwadrat.NMOn();
                pProstokat.NMOn();
                pRomb.NMOn();
                pRownoleglobok.NMOn();
                pTrapez.NMOn();
                pDeltoid.NMOn();
                pKolo.NMOn();

                //Zmiana stanu
                NM_OnOff = true;
            }
            else //NightMode OFF
            {
                this.BackColor = SystemColors.Control;
                toolStrip1.BackColor = SystemColors.Control;
                pTrojkat.NMOff();
                pKwadrat.NMOff();
                pProstokat.NMOff();
                pRomb.NMOff();
                pRownoleglobok.NMOff();
                pTrapez.NMOff();
                pDeltoid.NMOff();
                pKolo.NMOff();

                //Zmiana stanu
                NM_OnOff = false;
            }
        }
    }
}
