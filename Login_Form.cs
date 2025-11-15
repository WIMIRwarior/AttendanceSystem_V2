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
    public partial class Login_Form : Form
    {
        private int number_of_attempts = 0;
        private int max_number_of_attempts = 3;

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroButton_Login_Click(object sender, EventArgs e)
        {
            UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
            DataTable LoginsAndPasswords_DT = new DataTable();
            LoginsAndPasswords_DT = usersTableAdapter.GetDataBy_LoginAndPassword(metroTextBox_Login.Text,
                                                                                 metroTextBox_Password.Text);

            if (LoginsAndPasswords_DT.Rows.Count > 0)
            {
                MessageBox.Show("Login OK");
                this.Close();
            }
            else
            {
                number_of_attempts += 1;
                MessageBox.Show("Wrong Login or Password.\nTry again.\n You've " +
                                (max_number_of_attempts - number_of_attempts).ToString() +
                                " attempts left");
            }

            if(number_of_attempts>=max_number_of_attempts)
            {
                MessageBox.Show("Sorry, You've give me no choice.\n Goodbye");
                Application.Exit();
            }


        }
    }
}
