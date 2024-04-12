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

        private DataTable dataTable;
        private int pageSize = 5;
        private int currentPage = 1;

        private void DataGridView_Load(object sender, EventArgs e)
        {

            dataTable = new DataTable();

            // Add columns to the DataTable
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));

            // Add rows to the DataTable (hardcoded data)
            dataTable.Rows.Add("Dilshan1", "Matara1", "Male");
            dataTable.Rows.Add("Dilshan2", "Matara2", "Male");
            dataTable.Rows.Add("Dilshan3", "Matara3", "Male");
            dataTable.Rows.Add("Dilshan4", "Matara3", "Male");
            dataTable.Rows.Add("Dilshan5", "Matara3", "Male");
            dataTable.Rows.Add("Dilshan6", "Matara3", "Male");
            dataTable.Rows.Add("Dilshan7", "Matara3", "Male");
            dataTable.Rows.Add("Dilshan8", "Matara3", "Male");
            dataTable.Rows.Add("Dilshan9", "Matara3", "Male");
            dataTable.Rows.Add("Dilshan10", "Matara3", "Male");
            dataTable.Rows.Add("Dilshan11", "Matara3", "Male");
            dataTable.Rows.Add("Dilshan12", "Matara3", "Male");
            dataTable.Rows.Add("Dilshan13", "Matara3", "Male");
            dataTable.Rows.Add("Dilshan14", "Matara3", "Male");
            dataTable.Rows.Add("Dilshan15", "Matara3", "Male");

            //dataGridView1.DataSource = dataTable;

            DisplayData();

            // Add Image Column
            Image img = Image.FromFile("C:/Z - MY DATA/- My Projects/.Net/ApiRequsetFromWindowsApplication/ApiRequsetFromWindowsApplication/Assets/icon.png");


            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "Action";
            imgCol.HeaderText = "Action/Print";
            imgCol.Image = img;
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView1.Columns.Add(imgCol);

            // Disable the last blank line in DatagridView
            dataGridView1.AllowUserToAddRows = false;

            // set page size
            cmbxPageSize.SelectedIndex = 0;

        }

        private void DisplayData()
        {
            int startIndex = (currentPage - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, dataTable.Rows.Count);

            DataTable pageDataTable = dataTable.Clone();

            for (int i = startIndex; i < endIndex; i++)
            {
                pageDataTable.ImportRow(dataTable.Rows[i]);
            }

            dataGridView1.DataSource = pageDataTable;            

            lblPaging.Text = $"Page {currentPage} of {CalculateTotalPages()}";
        }


        private int CalculateTotalPages()
        {
            return (int)Math.Ceiling((double)dataTable.Rows.Count / pageSize);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = CalculateTotalPages();
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayData();

                
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayData();
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            int selectedColumnIndex = e.ColumnIndex;

            MessageBox.Show($"{selectedRowIndex}"+" "+(selectedColumnIndex));

            if (selectedRowIndex >= 0 && selectedColumnIndex >= 0)
            {
                // Get the column of the selected cell
                DataGridViewColumn selectedColumn = dataGridView1.Columns[selectedColumnIndex];
                // Get the column name or header text
                string actionColumnName = selectedColumn.Name;

                if (actionColumnName.ToString() == "Action") 
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                    var dataCellIndex0 = selectedRow.Cells[1].Value.ToString();

                    MessageBox.Show($"{dataCellIndex0}");
                }
            }
        }

        private void cmbxPageSize_SelectedValueChanged(object sender, EventArgs e)
        {
            pageSize = Int32.Parse(cmbxPageSize.SelectedItem.ToString());

            DisplayData();
        }
    }
}
