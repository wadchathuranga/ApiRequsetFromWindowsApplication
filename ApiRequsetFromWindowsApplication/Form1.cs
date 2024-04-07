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
            var response = await RestHelper.GetUsersAsync();
            txtResponse.Text = RestHelper.BeautifyJson(response.ToString());
        }

        private async void btnGetById_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.GetUserByIdAsync(txtById.Text);
            txtResponse.Text = RestHelper.BeautifyJson(response.ToString());
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.CreateUserAsync(txtName.Text, txtJob.Text);
            txtResponse.Text = RestHelper.BeautifyJson(response.ToString());
        }

        private async void btnPut_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.UpdateUserAsync(txtById.Text, txtName.Text, txtJob.Text);
            txtResponse.Text = RestHelper.BeautifyJson(response.ToString());
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.DeleteUserByIdAsync(txtById.Text);
            txtResponse.Text = response.ToString();
        }
    }
}
