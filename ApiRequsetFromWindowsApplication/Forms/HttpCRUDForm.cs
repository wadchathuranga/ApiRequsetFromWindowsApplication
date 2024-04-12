using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiRequsetFromWindowsApplication
{
    public partial class HttpCRUDForm : Form
    {
        public HttpCRUDForm()
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


        // create seperate thread to check internet connection availability
        private Thread connectionThread;
        private bool isConnected;

        private void HttpCRUDForm_Load(object sender, EventArgs e)
        {
            // Start the thread when the form loads
            connectionThread = new Thread(new ThreadStart(CheckInternetConnection));
            connectionThread.Start();
        }

        private void CheckInternetConnection()
        {
            while (true)
            {

                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    isConnected = true;
                }
                else
                {
                    isConnected = false;
                }

                // Update UI accordingly (you might want to use Invoke if accessing UI controls)
                UpdateUI();

                // Wait for some time before checking again (e.g., every 5 seconds)
                Thread.Sleep(5000);
            }
        }

        private void UpdateUI()
        {
            if (InvokeRequired)
            {
                // If called from a thread other than the UI thread, marshal the call to the UI thread
                Invoke(new MethodInvoker(UpdateUI));
                return;
            }

            if (isConnected)
            {
                this.Enabled = true;

            }
            else
            {
                this.Enabled = false;

            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Make sure to stop the thread when the form is closing
            connectionThread.Abort();
            base.OnFormClosing(e);
        }
    }
}
