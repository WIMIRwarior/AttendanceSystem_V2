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
    public partial class MainForm : Form
    {
        public string User_ID { get; set; }
        public string User_Type { get; set; }
        public string User_Name { get; set; }


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            metroButton_Login.UseSelectable = false;
        }




        private void metroButton1_Click(object sender, EventArgs e)
        {
            Login_Form new_Login_Form = new Login_Form();
            this.Hide();
            new_Login_Form.ShowDialog();
            User_ID = new_Login_Form.User_ID;
            User_Type = new_Login_Form.User_Type;
            User_Name = new_Login_Form.User_Name;
            new_Login_Form.Dispose();

            if (User_Type != null)
            {
                if (User_Type == "Administrator")
                {
                    //Run Admin panel
                    this.Hide();
                    AdminPanel_Form new_AdminPanel = new AdminPanel_Form();
                    new_AdminPanel.ShowDialog();
                    this.Show();

                }
                else if (User_Type == "Teacher")
                {
                    //Run Teacher panel
                    TeacherPanel_Form teacherPanel_Form = new TeacherPanel_Form();
                    this.Hide();
                    teacherPanel_Form.ShowDialog();
                    this.Show();

                }
                else if (User_Type == "Student")
                {
                    //Run Student panel
                    this.Hide();
                    StudentPanel_Form studentPanel_Form = new StudentPanel_Form();
                    studentPanel_Form.ShowDialog();
                    this.Show();
                }
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
            
        
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            metroButton_Login.Left = (this.ClientSize.Width - metroButton_Login.Width) / 2;
            metroButton_Login.Top = (this.ClientSize.Height - metroButton_Login.Height) / 2;
        }
    }
}
