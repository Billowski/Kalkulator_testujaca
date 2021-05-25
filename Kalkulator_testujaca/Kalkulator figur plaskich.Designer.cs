
namespace Kalkulator_testujaca
{
    partial class Kalkulator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalkulator));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.P_Trojkat = new System.Windows.Forms.ToolStripButton();
            this.P_Kwadrat = new System.Windows.Forms.ToolStripButton();
            this.P_Prostokat = new System.Windows.Forms.ToolStripButton();
            this.P_Romb = new System.Windows.Forms.ToolStripButton();
            this.P_Rownoleglobok = new System.Windows.Forms.ToolStripButton();
            this.P_Trapez = new System.Windows.Forms.ToolStripButton();
            this.P_Deltoid = new System.Windows.Forms.ToolStripButton();
            this.P_Kolo = new System.Windows.Forms.ToolStripButton();
            this.btnNM = new System.Windows.Forms.ToolStripButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.P_Trojkat,
            this.P_Kwadrat,
            this.P_Prostokat,
            this.P_Romb,
            this.P_Rownoleglobok,
            this.P_Trapez,
            this.P_Deltoid,
            this.P_Kolo,
            this.btnNM});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // P_Trojkat
            // 
            this.P_Trojkat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Trojkat.Image = ((System.Drawing.Image)(resources.GetObject("P_Trojkat.Image")));
            this.P_Trojkat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Trojkat.Name = "P_Trojkat";
            this.P_Trojkat.Size = new System.Drawing.Size(58, 24);
            this.P_Trojkat.Text = "Trojkąt";
            this.P_Trojkat.Click += new System.EventHandler(this.P_Trojkat_Click);
            // 
            // P_Kwadrat
            // 
            this.P_Kwadrat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Kwadrat.Image = ((System.Drawing.Image)(resources.GetObject("P_Kwadrat.Image")));
            this.P_Kwadrat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Kwadrat.Name = "P_Kwadrat";
            this.P_Kwadrat.Size = new System.Drawing.Size(67, 24);
            this.P_Kwadrat.Text = "Kwadrat";
            this.P_Kwadrat.Click += new System.EventHandler(this.P_Kwadrat_Click);
            // 
            // P_Prostokat
            // 
            this.P_Prostokat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Prostokat.Image = ((System.Drawing.Image)(resources.GetObject("P_Prostokat.Image")));
            this.P_Prostokat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Prostokat.Name = "P_Prostokat";
            this.P_Prostokat.Size = new System.Drawing.Size(75, 24);
            this.P_Prostokat.Text = "Prostokąt";
            this.P_Prostokat.Click += new System.EventHandler(this.P_Prostokat_Click);
            // 
            // P_Romb
            // 
            this.P_Romb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Romb.Image = ((System.Drawing.Image)(resources.GetObject("P_Romb.Image")));
            this.P_Romb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Romb.Name = "P_Romb";
            this.P_Romb.Size = new System.Drawing.Size(53, 24);
            this.P_Romb.Text = "Romb";
            this.P_Romb.Click += new System.EventHandler(this.P_Romb_Click);
            // 
            // P_Rownoleglobok
            // 
            this.P_Rownoleglobok.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Rownoleglobok.Image = ((System.Drawing.Image)(resources.GetObject("P_Rownoleglobok.Image")));
            this.P_Rownoleglobok.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Rownoleglobok.Name = "P_Rownoleglobok";
            this.P_Rownoleglobok.Size = new System.Drawing.Size(118, 24);
            this.P_Rownoleglobok.Text = "Równoległobok";
            this.P_Rownoleglobok.Click += new System.EventHandler(this.P_Rownoleglobok_Click);
            // 
            // P_Trapez
            // 
            this.P_Trapez.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Trapez.Image = ((System.Drawing.Image)(resources.GetObject("P_Trapez.Image")));
            this.P_Trapez.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Trapez.Name = "P_Trapez";
            this.P_Trapez.Size = new System.Drawing.Size(57, 24);
            this.P_Trapez.Text = "Trapez";
            this.P_Trapez.Click += new System.EventHandler(this.P_Trapez_Click);
            // 
            // P_Deltoid
            // 
            this.P_Deltoid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Deltoid.Image = ((System.Drawing.Image)(resources.GetObject("P_Deltoid.Image")));
            this.P_Deltoid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Deltoid.Name = "P_Deltoid";
            this.P_Deltoid.Size = new System.Drawing.Size(63, 24);
            this.P_Deltoid.Text = "Deltoid";
            this.P_Deltoid.Click += new System.EventHandler(this.P_Deltoid_Click);
            // 
            // P_Kolo
            // 
            this.P_Kolo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Kolo.Image = ((System.Drawing.Image)(resources.GetObject("P_Kolo.Image")));
            this.P_Kolo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Kolo.Name = "P_Kolo";
            this.P_Kolo.Size = new System.Drawing.Size(44, 24);
            this.P_Kolo.Text = "Koło";
            this.P_Kolo.Click += new System.EventHandler(this.P_Kolo_Click);
            // 
            // btnNM
            // 
            this.btnNM.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnNM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNM.Image = ((System.Drawing.Image)(resources.GetObject("btnNM.Image")));
            this.btnNM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNM.Name = "btnNM";
            this.btnNM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNM.Size = new System.Drawing.Size(93, 24);
            this.btnNM.Text = "Night Mode";
            this.btnNM.Click += new System.EventHandler(this.btnNM_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 31);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1067, 521);
            this.MainPanel.TabIndex = 5;
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kalkulator";
            this.Size = new System.Drawing.Size(1067, 554);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton P_Trojkat;
        private System.Windows.Forms.ToolStripButton P_Kwadrat;
        private System.Windows.Forms.ToolStripButton P_Prostokat;
        private System.Windows.Forms.ToolStripButton P_Romb;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripButton P_Rownoleglobok;
        private System.Windows.Forms.ToolStripButton P_Trapez;
        private System.Windows.Forms.ToolStripButton P_Deltoid;
        private System.Windows.Forms.ToolStripButton P_Kolo;
        private System.Windows.Forms.ToolStripButton btnNM;
    }
}

