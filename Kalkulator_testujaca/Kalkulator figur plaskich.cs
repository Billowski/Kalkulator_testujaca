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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panele.P_Trojkat p = new panele.P_Trojkat();
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(p);
            p.Show();
        }

        private void P_Trojkat_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            panele.P_Trojkat p = new panele.P_Trojkat();
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(p);
            p.Show();
        }

        private void P_Kwadrat_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            panele.P_Kwadrat p = new panele.P_Kwadrat();
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(p);
            p.Show();
        }

        private void P_Prostokat_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            panele.P_Prostokat p = new panele.P_Prostokat();
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(p);
            p.Show();
        }

        private void P_Romb_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            panele.P_Romb p = new panele.P_Romb();
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(p);
            p.Show();
        }

        private void P_Rownoleglobok_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            panele.P_Rownoleglobok p = new panele.P_Rownoleglobok();
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(p);
            p.Show();
        }

        private void P_Trapez_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            panele.P_Trapez p = new panele.P_Trapez();
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(p);
            p.Show();
        }

        private void P_Deltoid_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            panele.P_Deltoid p = new panele.P_Deltoid();
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(p);
            p.Show();
        }
    }
}
