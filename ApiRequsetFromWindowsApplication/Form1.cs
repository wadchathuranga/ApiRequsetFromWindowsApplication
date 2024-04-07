using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiRequsetFromWindowsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.GetAsync();
            txtResponse.Text = response.ToString();
        }
    }
}
