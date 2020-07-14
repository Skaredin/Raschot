using Raschot.Worcer;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.GetAll();
            txtResporens.Text = RestHelper.BeautifyJson(responce);

        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.Post(txtName.Text, txtJob.Text);
            txtResporens.Text = RestHelper.BeautifyJson(responce);
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.Get(txtID.Text);
            txtResporens.Text = RestHelper.BeautifyJson(responce);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.GetRe();
            txtResporens.Text = responce;

        }
    }
}
