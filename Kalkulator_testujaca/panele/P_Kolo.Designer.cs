
namespace Kalkulator_testujaca.panele
{
    partial class P_Kolo
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
            this.kolo_r = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kolo_pole = new System.Windows.Forms.TextBox();
            this.kolo_obwod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kolo_r
            // 
            this.kolo_r.Location = new System.Drawing.Point(54, 71);
            this.kolo_r.Name = "kolo_r";
            this.kolo_r.Size = new System.Drawing.Size(100, 20);
            this.kolo_r.TabIndex = 0;
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
            // kolo_pole
            // 
            this.kolo_pole.Location = new System.Drawing.Point(298, 294);
            this.kolo_pole.Name = "kolo_pole";
            this.kolo_pole.ReadOnly = true;
            this.kolo_pole.Size = new System.Drawing.Size(100, 20);
            this.kolo_pole.TabIndex = 5;
            // 
            // kolo_obwod
            // 
            this.kolo_obwod.Location = new System.Drawing.Point(528, 294);
            this.kolo_obwod.Name = "kolo_obwod";
            this.kolo_obwod.ReadOnly = true;
            this.kolo_obwod.Size = new System.Drawing.Size(100, 20);
            this.kolo_obwod.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "r";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kalkulator_testujaca.Properties.Resources.kolo;
            this.pictureBox1.Location = new System.Drawing.Point(226, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // P_Kolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kolo_obwod);
            this.Controls.Add(this.kolo_pole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kolo_r);
            this.Name = "P_Kolo";
            this.Text = "P_Trojkat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kolo_r;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kolo_pole;
        private System.Windows.Forms.TextBox kolo_obwod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}