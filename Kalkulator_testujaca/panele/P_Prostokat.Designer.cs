
namespace Kalkulator_testujaca.panele
{
    partial class P_Prostokat
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
            this.prostokat_a = new System.Windows.Forms.TextBox();
            this.prostokat_b = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.prostokat_pole = new System.Windows.Forms.TextBox();
            this.prostokat_obwod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prostokat_a
            // 
            this.prostokat_a.Location = new System.Drawing.Point(54, 71);
            this.prostokat_a.Name = "prostokat_a";
            this.prostokat_a.Size = new System.Drawing.Size(100, 20);
            this.prostokat_a.TabIndex = 0;
            // 
            // prostokat_b
            // 
            this.prostokat_b.Location = new System.Drawing.Point(54, 97);
            this.prostokat_b.Name = "prostokat_b";
            this.prostokat_b.Size = new System.Drawing.Size(100, 20);
            this.prostokat_b.TabIndex = 1;
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
            // prostokat_pole
            // 
            this.prostokat_pole.Location = new System.Drawing.Point(298, 294);
            this.prostokat_pole.Name = "prostokat_pole";
            this.prostokat_pole.ReadOnly = true;
            this.prostokat_pole.Size = new System.Drawing.Size(100, 20);
            this.prostokat_pole.TabIndex = 5;
            // 
            // prostokat_obwod
            // 
            this.prostokat_obwod.Location = new System.Drawing.Point(528, 294);
            this.prostokat_obwod.Name = "prostokat_obwod";
            this.prostokat_obwod.ReadOnly = true;
            this.prostokat_obwod.Size = new System.Drawing.Size(100, 20);
            this.prostokat_obwod.TabIndex = 6;
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
            this.pictureBox1.Image = global::Kalkulator_testujaca.Properties.Resources.prostokat;
            this.pictureBox1.Location = new System.Drawing.Point(226, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Oblicz obwód";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // P_Prostokat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.prostokat_obwod);
            this.Controls.Add(this.prostokat_pole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prostokat_b);
            this.Controls.Add(this.prostokat_a);
            this.Name = "P_Prostokat";
            this.Text = "P_Prostokat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prostokat_a;
        private System.Windows.Forms.TextBox prostokat_b;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox prostokat_pole;
        private System.Windows.Forms.TextBox prostokat_obwod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}