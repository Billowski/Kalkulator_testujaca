
namespace Kalkulator_testujaca.panele
{
    partial class P_Trapez
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
            this.trapez_a = new System.Windows.Forms.TextBox();
            this.trapez_b = new System.Windows.Forms.TextBox();
            this.trapez_c = new System.Windows.Forms.TextBox();
            this.trapez_d = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trapez_pole = new System.Windows.Forms.TextBox();
            this.trapez_obwod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trapez_h = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trapez_a
            // 
            this.trapez_a.Location = new System.Drawing.Point(54, 71);
            this.trapez_a.Name = "trapez_a";
            this.trapez_a.Size = new System.Drawing.Size(100, 20);
            this.trapez_a.TabIndex = 0;
            // 
            // trapez_b
            // 
            this.trapez_b.Location = new System.Drawing.Point(54, 97);
            this.trapez_b.Name = "trapez_b";
            this.trapez_b.Size = new System.Drawing.Size(100, 20);
            this.trapez_b.TabIndex = 1;
            // 
            // trapez_c
            // 
            this.trapez_c.Location = new System.Drawing.Point(54, 123);
            this.trapez_c.Name = "trapez_c";
            this.trapez_c.Size = new System.Drawing.Size(100, 20);
            this.trapez_c.TabIndex = 2;
            // 
            // trapez_d
            // 
            this.trapez_d.Location = new System.Drawing.Point(54, 149);
            this.trapez_d.Name = "trapez_d";
            this.trapez_d.Size = new System.Drawing.Size(100, 20);
            this.trapez_d.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Oblicz pole";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trapez_pole
            // 
            this.trapez_pole.Location = new System.Drawing.Point(298, 294);
            this.trapez_pole.Name = "trapez_pole";
            this.trapez_pole.ReadOnly = true;
            this.trapez_pole.Size = new System.Drawing.Size(100, 20);
            this.trapez_pole.TabIndex = 5;
            // 
            // trapez_obwod
            // 
            this.trapez_obwod.Location = new System.Drawing.Point(528, 294);
            this.trapez_obwod.Name = "trapez_obwod";
            this.trapez_obwod.ReadOnly = true;
            this.trapez_obwod.Size = new System.Drawing.Size(100, 20);
            this.trapez_obwod.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "d";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pole";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Obwód";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kalkulator_testujaca.Properties.Resources.trapez;
            this.pictureBox1.Location = new System.Drawing.Point(226, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "h";
            // 
            // trapez_h
            // 
            this.trapez_h.Location = new System.Drawing.Point(54, 175);
            this.trapez_h.Name = "trapez_h";
            this.trapez_h.Size = new System.Drawing.Size(100, 20);
            this.trapez_h.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Oblicz obwód";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // P_Trapez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trapez_h);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trapez_obwod);
            this.Controls.Add(this.trapez_pole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trapez_d);
            this.Controls.Add(this.trapez_c);
            this.Controls.Add(this.trapez_b);
            this.Controls.Add(this.trapez_a);
            this.Name = "P_Trapez";
            this.Text = "P_Trapez";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox trapez_a;
        private System.Windows.Forms.TextBox trapez_b;
        private System.Windows.Forms.TextBox trapez_c;
        private System.Windows.Forms.TextBox trapez_d;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox trapez_pole;
        private System.Windows.Forms.TextBox trapez_obwod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox trapez_h;
        private System.Windows.Forms.Button button2;
    }
}