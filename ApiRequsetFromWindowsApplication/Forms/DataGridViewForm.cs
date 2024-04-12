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
            
            // Add Button Column
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.HeaderText = "Action";
            //btn.Text = "Print";
            //btn.Name = "btn";
            //btn.DefaultCellStyle.BackColor = SystemColors.Control;
            //btn.DefaultCellStyle.ForeColor = SystemColors.Control;
            //btn.UseColumnTextForButtonValue = true;
            //btn.FlatStyle = FlatStyle.System;
            //dataGridView1.Columns.Add(btn);


            // Add Image Column
            Image img = Image.FromFile("C:/Z - MY DATA/- My Projects/.Net/ApiRequsetFromWindowsApplication/ApiRequsetFromWindowsApplication/Assets/icon.png");

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "Action";
            imgCol.HeaderText = "Action/Print";
            imgCol.Image = img;
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView1.Columns.Add(imgCol);

            // Add data into data grid
            string[] row = new string[] { "Dilshan1", "Matara1", "Male" };
            string[] row2 = new string[] { "Dilshan2", "Matara2", "Male" };
            string[] row3 = new string[] { "Dilshan3", "Matara3", "Male" };
            dataGridView1.Rows.Add(row);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);

            // Disable the last blank line in DatagridView
            dataGridView1.AllowUserToAddRows = false;


        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            int selectedColumnIndex = e.ColumnIndex;

            if (selectedRowIndex >= 0 && selectedColumnIndex >= 0)
            {
                // Get the column of the selected cell
                DataGridViewColumn selectedColumn = dataGridView1.Columns[selectedColumnIndex];
                // Get the column name or header text
                string actionColumnName = selectedColumn.Name;

                if (actionColumnName.ToString() == "Action") 
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                    var cellCount = selectedRow.Cells.Count;
                    var dataCellIndex0 = selectedRow.Cells[0].Value.ToString();

                    MessageBox.Show($"{dataCellIndex0}");
                }
            }
        }
    }
}
