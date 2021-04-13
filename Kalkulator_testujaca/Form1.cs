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
            MainPanel.Controls.Clear();
            panele.P_Trojkat p = new panele.P_Trojkat();
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            MainPanel.Controls.Add(p);
            p.Show();
        }
    }
}
