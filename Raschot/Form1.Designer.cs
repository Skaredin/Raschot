﻿namespace Raschot
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Otpravka = new System.Windows.Forms.TextBox();
            this.Priem = new System.Windows.Forms.TextBox();
            this.Ves = new System.Windows.Forms.TextBox();
            this.Obem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Vs = new System.Windows.Forms.TextBox();
            this.cityPickupNameTotal = new System.Windows.Forms.TextBox();
            this.cityDeliveryNameTotal = new System.Windows.Forms.TextBox();
            this.weightStr = new System.Windows.Forms.TextBox();
            this.volumeStr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Otpravka
            // 
            this.Otpravka.Location = new System.Drawing.Point(28, 103);
            this.Otpravka.Name = "Otpravka";
            this.Otpravka.Size = new System.Drawing.Size(100, 22);
            this.Otpravka.TabIndex = 0;
            // 
            // Priem
            // 
            this.Priem.Location = new System.Drawing.Point(134, 103);
            this.Priem.Name = "Priem";
            this.Priem.Size = new System.Drawing.Size(100, 22);
            this.Priem.TabIndex = 1;
            // 
            // Ves
            // 
            this.Ves.Location = new System.Drawing.Point(240, 103);
            this.Ves.Name = "Ves";
            this.Ves.Size = new System.Drawing.Size(100, 22);
            this.Ves.TabIndex = 2;
            // 
            // Obem
            // 
            this.Obem.Location = new System.Drawing.Point(346, 103);
            this.Obem.Name = "Obem";
            this.Obem.Size = new System.Drawing.Size(100, 22);
            this.Obem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "От";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "До";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Обьём";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Пощитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vs
            // 
            this.Vs.Location = new System.Drawing.Point(28, 167);
            this.Vs.Name = "Vs";
            this.Vs.Size = new System.Drawing.Size(312, 22);
            this.Vs.TabIndex = 10;
            // 
            // cityPickupNameTotal
            // 
            this.cityPickupNameTotal.Location = new System.Drawing.Point(731, 66);
            this.cityPickupNameTotal.Name = "cityPickupNameTotal";
            this.cityPickupNameTotal.Size = new System.Drawing.Size(100, 22);
            this.cityPickupNameTotal.TabIndex = 17;
            // 
            // cityDeliveryNameTotal
            // 
            this.cityDeliveryNameTotal.Location = new System.Drawing.Point(731, 97);
            this.cityDeliveryNameTotal.Name = "cityDeliveryNameTotal";
            this.cityDeliveryNameTotal.Size = new System.Drawing.Size(100, 22);
            this.cityDeliveryNameTotal.TabIndex = 18;
            // 
            // weightStr
            // 
            this.weightStr.Location = new System.Drawing.Point(731, 125);
            this.weightStr.Name = "weightStr";
            this.weightStr.Size = new System.Drawing.Size(100, 22);
            this.weightStr.TabIndex = 26;
            // 
            // volumeStr
            // 
            this.volumeStr.Location = new System.Drawing.Point(731, 153);
            this.volumeStr.Name = "volumeStr";
            this.volumeStr.Size = new System.Drawing.Size(100, 22);
            this.volumeStr.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Номер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Обьём";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(610, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Номер";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Город отправки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(610, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Город приёма";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(610, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Вес";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.volumeStr);
            this.Controls.Add(this.weightStr);
            this.Controls.Add(this.cityDeliveryNameTotal);
            this.Controls.Add(this.cityPickupNameTotal);
            this.Controls.Add(this.Vs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Obem);
            this.Controls.Add(this.Ves);
            this.Controls.Add(this.Priem);
            this.Controls.Add(this.Otpravka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Otpravka;
        private System.Windows.Forms.TextBox Priem;
        private System.Windows.Forms.TextBox Ves;
        private System.Windows.Forms.TextBox Obem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Vs;
        private System.Windows.Forms.TextBox cityPickupNameTotal;
        private System.Windows.Forms.TextBox cityDeliveryNameTotal;
        private System.Windows.Forms.TextBox weightStr;
        private System.Windows.Forms.TextBox volumeStr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

