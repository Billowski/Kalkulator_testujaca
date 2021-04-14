
namespace Kalkulator_testujaca.panele
{
    partial class P_Romb
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
            this.romb_a = new System.Windows.Forms.TextBox();
            this.romb_h = new System.Windows.Forms.TextBox();
            this.romb_sina = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.romb_pole = new System.Windows.Forms.TextBox();
            this.romb_obwod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // romb_a
            // 
            this.romb_a.Location = new System.Drawing.Point(54, 71);
            this.romb_a.Name = "romb_a";
            this.romb_a.Size = new System.Drawing.Size(100, 20);
            this.romb_a.TabIndex = 0;
            // 
            // romb_h
            // 
            this.romb_h.Location = new System.Drawing.Point(54, 97);
            this.romb_h.Name = "romb_h";
            this.romb_h.Size = new System.Drawing.Size(100, 20);
            this.romb_h.TabIndex = 1;
            // 
            // romb_sina
            // 
            this.romb_sina.Location = new System.Drawing.Point(54, 123);
            this.romb_sina.Name = "romb_sina";
            this.romb_sina.Size = new System.Drawing.Size(100, 20);
            this.romb_sina.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Oblicz pole z a oraz h";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // romb_pole
            // 
            this.romb_pole.Location = new System.Drawing.Point(298, 294);
            this.romb_pole.Name = "romb_pole";
            this.romb_pole.ReadOnly = true;
            this.romb_pole.Size = new System.Drawing.Size(100, 20);
            this.romb_pole.TabIndex = 5;
            // 
            // romb_obwod
            // 
            this.romb_obwod.Location = new System.Drawing.Point(528, 294);
            this.romb_obwod.Name = "romb_obwod";
            this.romb_obwod.ReadOnly = true;
            this.romb_obwod.Size = new System.Drawing.Size(100, 20);
            this.romb_obwod.TabIndex = 6;
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
            this.label2.Text = "h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "sina";
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
            this.button2.Location = new System.Drawing.Point(298, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Oblicz pole z a oraz sina";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kalkulator_testujaca.Properties.Resources.romb;
            this.pictureBox1.Location = new System.Drawing.Point(226, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Oblicz obwód";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // P_Romb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.romb_obwod);
            this.Controls.Add(this.romb_pole);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.romb_sina);
            this.Controls.Add(this.romb_h);
            this.Controls.Add(this.romb_a);
            this.Name = "P_Romb";
            this.Text = "P_Romb";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox romb_a;
        private System.Windows.Forms.TextBox romb_h;
        private System.Windows.Forms.TextBox romb_sina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox romb_pole;
        private System.Windows.Forms.TextBox romb_obwod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}