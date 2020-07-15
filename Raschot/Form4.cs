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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var auth = new ff.Class1(city1.Text, city2.Text, weight.Text, length.Text);
            auth.ParsDataAuth();
            string GetInfo = auth.Auch();
        }
    }
}
