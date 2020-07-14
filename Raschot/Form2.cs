using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raschot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string street1 = textBox1.Text;
            string street2 = textBox2.Text;
            string street3 = textBox3.Text;
            string street4 = textBox4.Text;
            try
            {
                StringBuilder que = new StringBuilder();
                que.Append("https://www.google.com/maps?q=");
                if (street1 != string.Empty)
                {
                    que.Append(street1 + "," + "+");
                
                }
                if (street2 != string.Empty)
                {
                    que.Append(street2 + "," + "+");

                }
                if (street3 != string.Empty)
                {
                    que.Append(street3 + "," + "+");

                }
                if (street4 != string.Empty)
                {
                    que.Append(street4 + "," + "+");

                }

                webBrowser1.Navigate(que.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(),"Error");
            }

        }
    }
}
