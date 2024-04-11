using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiRequsetFromWindowsApplication.Forms
{
    public partial class DataGridViewForm : Form
    {
        public DataGridViewForm()
        {
            InitializeComponent();
        }

        private void DataGridView_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Name"; 
            dataGridView1.Columns[1].Name = "Address";
            dataGridView1.Columns[2].Name = "Gender";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Text = "Print";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            btn.FlatStyle = FlatStyle.System;
            dataGridView1.Columns.Add(btn);

            string[] row = new string[] { "Dilshan", "Matara", "Male" };
            dataGridView1.Rows.Add(row);
        }
    }
}
