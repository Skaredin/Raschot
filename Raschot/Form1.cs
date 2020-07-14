using Raschot.Worcer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Raschot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

     

        private void Schet_button_Click(object sender, EventArgs e)
        {
           // double Deapozon1 = double.Parse(kMTextBox.Text);
           // double Deapozon2 = double.Parse(kMTextBox1.Text);
           //double Kg = double.Parse(textBox1.Text);
           // double Obem = double.Parse(textBox2.Text);
           // //double Deapozon2 = double.Parse(kMTextBox1.Text);
           // double ProcentCenZaKm = 1.4;
           // double OcenkaVesa = 0.51;
           // double OcenkaObem = 0.51;

           // double Poscet = ((Deapozon2 - Deapozon1) * ProcentCenZaKm)+(Kg * OcenkaVesa)+(Obem * OcenkaObem) ;

           // textBox6.Text = Poscet.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var auth = new Worcer.PGAunten(cityPickupNameTotal.Text, cityDeliveryNameTotal.Text, weightStr.Text, volumeStr.Text);
            auth.ParsDataAuth();
            string GetInfo = auth.Auch();

        }

     
    }
}
