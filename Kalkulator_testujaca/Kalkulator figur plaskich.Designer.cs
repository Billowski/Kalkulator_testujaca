
namespace Kalkulator_testujaca
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.P_Trojkat = new System.Windows.Forms.ToolStripButton();
            this.P_Kwadrat = new System.Windows.Forms.ToolStripButton();
            this.P_Prostokat = new System.Windows.Forms.ToolStripButton();
            this.P_Romb = new System.Windows.Forms.ToolStripButton();
            this.P_Rownoleglobok = new System.Windows.Forms.ToolStripButton();
            this.P_Trapez = new System.Windows.Forms.ToolStripButton();
            this.P_Deltoid = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.P_Trojkat,
            this.P_Kwadrat,
            this.P_Prostokat,
            this.P_Romb,
            this.P_Rownoleglobok,
            this.P_Trapez,
            this.P_Deltoid});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 28);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 421);
            this.MainPanel.TabIndex = 5;
            // 
            // P_Trojkat
            // 
            this.P_Trojkat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Trojkat.Image = ((System.Drawing.Image)(resources.GetObject("P_Trojkat.Image")));
            this.P_Trojkat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Trojkat.Name = "P_Trojkat";
            this.P_Trojkat.Size = new System.Drawing.Size(46, 22);
            this.P_Trojkat.Text = "Trojkąt";
            this.P_Trojkat.Click += new System.EventHandler(this.P_Trojkat_Click);
            // 
            // P_Kwadrat
            // 
            this.P_Kwadrat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Kwadrat.Image = ((System.Drawing.Image)(resources.GetObject("P_Kwadrat.Image")));
            this.P_Kwadrat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Kwadrat.Name = "P_Kwadrat";
            this.P_Kwadrat.Size = new System.Drawing.Size(54, 22);
            this.P_Kwadrat.Text = "Kwadrat";
            this.P_Kwadrat.Click += new System.EventHandler(this.P_Kwadrat_Click);
            // 
            // P_Prostokat
            // 
            this.P_Prostokat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Prostokat.Image = ((System.Drawing.Image)(resources.GetObject("P_Prostokat.Image")));
            this.P_Prostokat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Prostokat.Name = "P_Prostokat";
            this.P_Prostokat.Size = new System.Drawing.Size(61, 22);
            this.P_Prostokat.Text = "Prostokąt";
            this.P_Prostokat.Click += new System.EventHandler(this.P_Prostokat_Click);
            // 
            // P_Romb
            // 
            this.P_Romb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Romb.Image = ((System.Drawing.Image)(resources.GetObject("P_Romb.Image")));
            this.P_Romb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Romb.Name = "P_Romb";
            this.P_Romb.Size = new System.Drawing.Size(43, 22);
            this.P_Romb.Text = "Romb";
            this.P_Romb.Click += new System.EventHandler(this.P_Romb_Click);
            // 
            // P_Rownoleglobok
            // 
            this.P_Rownoleglobok.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Rownoleglobok.Image = ((System.Drawing.Image)(resources.GetObject("P_Rownoleglobok.Image")));
            this.P_Rownoleglobok.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Rownoleglobok.Name = "P_Rownoleglobok";
            this.P_Rownoleglobok.Size = new System.Drawing.Size(94, 22);
            this.P_Rownoleglobok.Text = "Równoległobok";
            this.P_Rownoleglobok.Click += new System.EventHandler(this.P_Rownoleglobok_Click);
            // 
            // P_Trapez
            // 
            this.P_Trapez.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Trapez.Image = ((System.Drawing.Image)(resources.GetObject("P_Trapez.Image")));
            this.P_Trapez.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Trapez.Name = "P_Trapez";
            this.P_Trapez.Size = new System.Drawing.Size(44, 22);
            this.P_Trapez.Text = "Trapez";
            this.P_Trapez.Click += new System.EventHandler(this.P_Trapez_Click);
            // 
            // P_Deltoid
            // 
            this.P_Deltoid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.P_Deltoid.Image = ((System.Drawing.Image)(resources.GetObject("P_Deltoid.Image")));
            this.P_Deltoid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.P_Deltoid.Name = "P_Deltoid";
            this.P_Deltoid.Size = new System.Drawing.Size(49, 22);
            this.P_Deltoid.Text = "Deltoid";
            this.P_Deltoid.Click += new System.EventHandler(this.P_Deltoid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator figur płaskich";
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
    }
}

