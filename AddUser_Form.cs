using AttendanceSystem_V2.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem_V2
{
    public partial class AddUser_Form : Form
    {
        public AddUser_Form()
        {
            InitializeComponent();
        }

        private void AddUser_Form_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.Users' . Możesz go przenieść lub usunąć.
            this.usersTableAdapter.Fill(this.dataSet1.Users);

        }

        private void metroTextBox_SearchText_TextChanged(object sender, EventArgs e)
        {
            //Load the new query
            UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
            DataSet1.UsersDataTable dataTable = new DataSet1.UsersDataTable();

            string SearchText = "%";

            if (metroTextBox_SearchText.Text != null)
            {
                SearchText = "%" + metroTextBox_SearchText.Text + "%";
            }
            usersTableAdapter.FillBy_SearchText(dataTable, SearchText);
            dataGridView.DataSource = dataTable;
        }

        private void metroButton_DeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Select user to delete.");
            }
            else
            {
                //Delete the choosen record from the DB
                UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
                int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

                usersTableAdapter.DeleteUser(ID);
            }
        }

        private void metroButton_Update_Click(object sender, EventArgs e)
        {
            UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
            DataSet1.UsersDataTable dataTable = new DataSet1.UsersDataTable();
            dataGridView.DataSource = dataTable;   
        }
    }
}
