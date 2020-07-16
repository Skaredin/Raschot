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
using OpenQA.Selenium;
using System.Net;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace Raschot
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            


            //var auth = new ff.Class1(city1.Text, city2.Text, weight.Text, length.Text);
            //auth.ParsDataAuth();
            //string GetInfo = auth.Auch();
            //string url = "https://glav-dostavka.ru/api/calc/?method=api_calc&responseFormat=xml&depPoint=35&arrPoint=36&depDoor=1&arrDoor=1&cargoMest[1]=8&cargoKg[1]=5&cargoL[1]=1.2&cargoW[1]=1.1&cargoH[1]=1.5&cargoCalculation[1]=1&cargoPackHard[1]=1&cargoMest[2]=5&cargoKg[2]=30&cargoL[2]=10&cargoW[2]=1&cargoH[2]=0.8&cargoCalculation[2]=0&cargoPackPallet[2]=1&insure=350000";
            //HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            //HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //string responce;
            //using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            //{
            //    responce = streamReader.ReadToEnd();
            //}
            double raion1 = 0;
            double raion2 = 0;
            double dlinaVic = 0;
            double VisotaVic = 0;
            double ShirinaVic = 0;
            double Vsvic3 = 0;  
            double Vsvic = 0;
            double Vsvic2 = 0;

            if (length.Text == "")
            {
                dlinaVic = Convert.ToDouble(Dlina.Text);
                VisotaVic = Convert.ToDouble(Visota.Text);
                ShirinaVic = Convert.ToDouble(Shirina.Text);

                Vsvic = dlinaVic * VisotaVic * ShirinaVic;
             
                length.Text = Convert.ToString(Vsvic);
                switch (city1.SelectedIndex)
                {
                    case 0: raion1 = 557; break;
                    case 1: raion1 = 3081218; break;
                    case 2: raion1 = 545377; break;
                    case 3: raion1 = 545379; break;
                    case 4: raion1 = 545386; break;
                    case 5: raion1 = 558; break;
                    case 6: raion1 = 584; break;
                    case 7: raion1 = 1924392; break;
                    case 8: raion1 = 545393; break;
                    case 9: raion1 = 545398; break;
                    case 10: raion1 = 585; break;
                    case 11: raion1 = 586; break;
                    case 12: raion1 = 21072318; break;
                    case 13: raion1 = 545405; break;
                    case 14: raion1 = 545409; break;
                    case 15: raion1 = 18973803; break;
                    case 16: raion1 = 587; break;




                }
                switch (city2.SelectedIndex)
                {
                    case 0: raion2 = 557; break;
                    case 1: raion2 = 3081218; break;
                    case 2: raion2 = 545377; break;
                    case 3: raion2 = 545379; break;
                    case 4: raion2 = 545386; break;
                    case 5: raion2 = 558; break;
                    case 6: raion2 = 584; break;
                    case 7: raion2 = 1924392; break;
                    case 8: raion2 = 545393; break;
                    case 9: raion2 = 545398; break;
                    case 10: raion2 = 585; break;
                    case 11: raion2 = 586; break;
                    case 12: raion2 = 21072318; break;
                    case 13: raion2 = 545405; break;
                    case 14: raion2 = 545409; break;
                    case 15: raion2 = 18973803; break;
                    case 16: raion2 = 587; break;


                }

                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(@"https://glav-dostavka.ru/api/calc/?method=api_calc&responseFormat=xml&" + "depPoint=" + raion1 + "&arrPoint=" + raion2 + "&cargoKg[1]=" + weight.Text + "&cargoMest[1]=1" + "&cargoL[1]=" + dlinaVic + "&cargoW[1]=" + ShirinaVic + "&cargoH[1]=" + VisotaVic + "&cargoCalculation[1]=1");



            }
            else
            {
                Vsvic3 = Convert.ToDouble(length.Text);
                Vsvic2 = Vsvic3 / 3;
                Dlina.Text = Convert.ToString(Vsvic2);
                Visota.Text = Convert.ToString(Vsvic2);
                Shirina.Text = Convert.ToString(Vsvic2);

                switch (city1.SelectedIndex)
                {
                    case 0: raion1 = 557; break;
                    case 1: raion1 = 3081218; break;
                    case 2: raion1 = 545377; break;
                    case 3: raion1 = 545379; break;
                    case 4: raion1 = 545386; break;
                    case 5: raion1 = 558; break;
                    case 6: raion1 = 584; break;
                    case 7: raion1 = 1924392; break;
                    case 8: raion1 = 545393; break;
                    case 9: raion1 = 545398; break;
                    case 10: raion1 = 585; break;
                    case 11: raion1 = 586; break;
                    case 12: raion1 = 21072318; break;
                    case 13: raion1 = 545405; break;
                    case 14: raion1 = 545409; break;
                    case 15: raion1 = 18973803; break;
                    case 16: raion1 = 587; break;




                }
                switch (city2.SelectedIndex)
                {
                    case 0: raion2 = 557; break;
                    case 1: raion2 = 3081218; break;
                    case 2: raion2 = 545377; break;
                    case 3: raion2 = 545379; break;
                    case 4: raion2 = 545386; break;
                    case 5: raion2 = 558; break;
                    case 6: raion2 = 584; break;
                    case 7: raion2 = 1924392; break;
                    case 8: raion2 = 545393; break;
                    case 9: raion2 = 545398; break;
                    case 10: raion2 = 585; break;
                    case 11: raion2 = 586; break;
                    case 12: raion2 = 21072318; break;
                    case 13: raion2 = 545405; break;
                    case 14: raion2 = 545409; break;
                    case 15: raion2 = 18973803; break;
                    case 16: raion2 = 587; break;





                }

                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(@"https://glav-dostavka.ru/api/calc/?method=api_calc&responseFormat=xml&" + "depPoint=" + raion1 + "&arrPoint=" + raion2 + "&cargoKg[1]=" + weight.Text + "&cargoMest[1]=1" + "&cargoL[1]=" + Dlina.Text + "&cargoW[1]=" + Visota.Text + "&cargoH[1]=" + Shirina.Text + "&cargoCalculation[1]=1");


            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            double raion1 = 0;
            double raion2 = 0;
            switch (city1.SelectedIndex)
            {
                case 0: raion1 = 557; break;
                case 1: raion1 = 3081218; break;
                case 2: raion1 = 545377; break;
                case 3: raion1 = 545379; break;
                case 4: raion1 = 545386; break;
                case 5: raion1 = 558; break;
                case 6: raion1 = 584; break;
                case 7: raion1 = 1924392; break;
                case 8: raion1 = 545393; break;
                case 9: raion1 = 545398; break;
                case 10: raion1 = 585; break;
                case 11: raion1 = 586; break;
                case 12: raion1 = 21072318; break;
                case 13: raion1 = 545405; break;
                case 14: raion1 = 545409; break;
                case 15: raion1 = 18973803; break;
                case 16: raion1 = 587; break;



            }
            switch (city2.SelectedIndex)
            {
                case 0: raion1 = 557; break;
                case 1: raion1 = 3081218; break;
                case 2: raion1 = 545377; break;
                case 3: raion1 = 545379; break;
                case 4: raion1 = 545386; break;
                case 5: raion1 = 558; break;
                case 6: raion1 = 584; break;
                case 7: raion1 = 1924392; break;
                case 8: raion1 = 545393; break;
                case 9: raion1 = 545398; break;
                case 10: raion1 = 585; break;
                case 11: raion1 = 586; break;
                case 12: raion1 = 21072318; break;
                case 13: raion1 = 545405; break;
                case 14: raion1 = 545409; break;
                case 15: raion1 = 18973803; break;
                case 16: raion1 = 587; break;




            }

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"https://glav-dostavka.ru/api/calc/?method=api_city&responseFormat=xml&" + "depPoint=" + raion1 + "&arrPoint=" + raion2 + "&cargoKg[1]=" + weight.Text + "&cargoMest[1]=1" + "&cargoL[1]=1" + "&cargoW[1]=1" + "&cargoH[1]=1" + "&cargoCalculation[1]=1" + "");




         
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Dlina.Visible = false;
            Shirina.Visible = false;
            Visota.Visible = false;
            length.Visible = true;
            label6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label5.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Dlina.Visible = true;
                Shirina.Visible = true;
                Visota.Visible = true;
                length.Visible = false;

                label6.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label5.Visible = false;

            }
            else {

                Dlina.Visible = false;
                Shirina.Visible = false;
                Visota.Visible = false;
                length.Visible = true;
                label6.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label5.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            city1.Text = "";
            city2.Text = "";
            weight.Text = "";
            length.Text = "";
            Dlina.Text = "";
            Visota.Text = "";
            Shirina.Text = "";
        }
    }
}
