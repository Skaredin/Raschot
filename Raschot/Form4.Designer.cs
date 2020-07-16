namespace Raschot
{
    partial class Form4
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.Vs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.city1 = new System.Windows.Forms.ComboBox();
            this.city2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Shirina = new System.Windows.Forms.TextBox();
            this.Visota = new System.Windows.Forms.TextBox();
            this.Dlina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Город отправки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Город приёма";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(392, 63);
            this.length.Margin = new System.Windows.Forms.Padding(2);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(123, 20);
            this.length.TabIndex = 47;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(265, 63);
            this.weight.Margin = new System.Windows.Forms.Padding(2);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(123, 20);
            this.weight.TabIndex = 46;
            // 
            // Vs
            // 
            this.Vs.Location = new System.Drawing.Point(11, 226);
            this.Vs.Margin = new System.Windows.Forms.Padding(2);
            this.Vs.Name = "Vs";
            this.Vs.Size = new System.Drawing.Size(235, 20);
            this.Vs.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 24);
            this.button1.TabIndex = 42;
            this.button1.Text = "Пощитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Обьём";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Вес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Город";
            // 
            // city1
            // 
            this.city1.FormattingEnabled = true;
            this.city1.Items.AddRange(new object[] {
            "Абакан",
            "Алматы",
            "Анапа",
            "Ангарск",
            "Армавир",
            "Архангельск",
            "Астрахань",
            "Атырау",
            "Ачинск",
            "Балаково",
            "Барнаул",
            "Белгород",
            "Белово",
            "Бийск",
            "Биробиджан"});
            this.city1.Location = new System.Drawing.Point(12, 62);
            this.city1.Name = "city1";
            this.city1.Size = new System.Drawing.Size(121, 21);
            this.city1.TabIndex = 50;
            // 
            // city2
            // 
            this.city2.FormattingEnabled = true;
            this.city2.Items.AddRange(new object[] {
            "Абакан",
            "Алматы",
            "Анапа",
            "Ангарск",
            "Армавир",
            "Архангельск",
            "Астрахань",
            "Атырау",
            "Ачинск",
            "Балаково",
            "Барнаул",
            "Белгород",
            "Белово",
            "Бийск",
            "Биробиджан"});
            this.city2.Location = new System.Drawing.Point(139, 62);
            this.city2.Name = "city2";
            this.city2.Size = new System.Drawing.Size(121, 21);
            this.city2.TabIndex = 51;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 24);
            this.button2.TabIndex = 52;
            this.button2.Text = "Номер города";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Shirina
            // 
            this.Shirina.Location = new System.Drawing.Point(138, 116);
            this.Shirina.Margin = new System.Windows.Forms.Padding(2);
            this.Shirina.Name = "Shirina";
            this.Shirina.Size = new System.Drawing.Size(122, 20);
            this.Shirina.TabIndex = 54;
            // 
            // Visota
            // 
            this.Visota.Location = new System.Drawing.Point(265, 117);
            this.Visota.Margin = new System.Windows.Forms.Padding(2);
            this.Visota.Name = "Visota";
            this.Visota.Size = new System.Drawing.Size(123, 20);
            this.Visota.TabIndex = 55;
            // 
            // Dlina
            // 
            this.Dlina.Location = new System.Drawing.Point(12, 117);
            this.Dlina.Margin = new System.Windows.Forms.Padding(2);
            this.Dlina.Name = "Dlina";
            this.Dlina.Size = new System.Drawing.Size(121, 20);
            this.Dlina.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Длина груза (м)\t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Ширина груза (м)\t";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Высота груза (м)\t";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(576, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 59;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(519, 113);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 24);
            this.button3.TabIndex = 60;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 161);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Visota);
            this.Controls.Add(this.Shirina);
            this.Controls.Add(this.Dlina);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.city2);
            this.Controls.Add(this.city1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.length);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.Vs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox Vs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox city1;
        private System.Windows.Forms.ComboBox city2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Shirina;
        private System.Windows.Forms.TextBox Visota;
        private System.Windows.Forms.TextBox Dlina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
    }
}