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
    public partial class AdminPanel_Form : Form
    {
        public AdminPanel_Form()
        {
            InitializeComponent();
        }

        private void metroButton_AddUser_Click(object sender, EventArgs e)
        {
            //Run AddUser Form
            AddUser_Form addUser_Form = new AddUser_Form();
            this.Hide();
            addUser_Form.ShowDialog();
            this.Show();
        }
    }
}
