
namespace Kalkulator_testujaca.panele
{
    partial class P_Kwadrat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kwadrat_obwod = new System.Windows.Forms.TextBox();
            this.kwadrat_pole = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kwadrat_a = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Obwód";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Pole";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "a";
            // 
            // kwadrat_obwod
            // 
            this.kwadrat_obwod.Location = new System.Drawing.Point(528, 294);
            this.kwadrat_obwod.Name = "kwadrat_obwod";
            this.kwadrat_obwod.ReadOnly = true;
            this.kwadrat_obwod.Size = new System.Drawing.Size(100, 20);
            this.kwadrat_obwod.TabIndex = 20;
            // 
            // kwadrat_pole
            // 
            this.kwadrat_pole.Location = new System.Drawing.Point(298, 294);
            this.kwadrat_pole.Name = "kwadrat_pole";
            this.kwadrat_pole.ReadOnly = true;
            this.kwadrat_pole.Size = new System.Drawing.Size(100, 20);
            this.kwadrat_pole.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Oblicz pole";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kwadrat_a
            // 
            this.kwadrat_a.Location = new System.Drawing.Point(54, 71);
            this.kwadrat_a.Name = "kwadrat_a";
            this.kwadrat_a.Size = new System.Drawing.Size(100, 20);
            this.kwadrat_a.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kalkulator_testujaca.Properties.Resources.kwadrat;
            this.pictureBox1.InitialImage = global::Kalkulator_testujaca.Properties.Resources.kwadrat;
            this.pictureBox1.Location = new System.Drawing.Point(226, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Oblicz obwód";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // P_Kwadrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kwadrat_obwod);
            this.Controls.Add(this.kwadrat_pole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kwadrat_a);
            this.Name = "P_Kwadrat";
            this.Text = "P_Kwadrat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kwadrat_obwod;
        private System.Windows.Forms.TextBox kwadrat_pole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kwadrat_a;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}