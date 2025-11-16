namespace AttendanceSystem_V2
{
    partial class AdminPanel_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel_Form));
            this.metroButton_AddUser = new MetroFramework.Controls.MetroButton();
            this.metroButton_AddClass = new MetroFramework.Controls.MetroButton();
            this.metroButton_AddGroup = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton_AddUser
            // 
            this.metroButton_AddUser.Location = new System.Drawing.Point(35, 26);
            this.metroButton_AddUser.Name = "metroButton_AddUser";
            this.metroButton_AddUser.Size = new System.Drawing.Size(92, 23);
            this.metroButton_AddUser.TabIndex = 0;
            this.metroButton_AddUser.Text = "Add/Del User";
            this.metroButton_AddUser.UseSelectable = true;
            this.metroButton_AddUser.Click += new System.EventHandler(this.metroButton_AddUser_Click);
            // 
            // metroButton_AddClass
            // 
            this.metroButton_AddClass.Location = new System.Drawing.Point(35, 55);
            this.metroButton_AddClass.Name = "metroButton_AddClass";
            this.metroButton_AddClass.Size = new System.Drawing.Size(92, 23);
            this.metroButton_AddClass.TabIndex = 1;
            this.metroButton_AddClass.Text = "Add/Del Class";
            this.metroButton_AddClass.UseSelectable = true;
            // 
            // metroButton_AddGroup
            // 
            this.metroButton_AddGroup.Location = new System.Drawing.Point(35, 84);
            this.metroButton_AddGroup.Name = "metroButton_AddGroup";
            this.metroButton_AddGroup.Size = new System.Drawing.Size(92, 23);
            this.metroButton_AddGroup.TabIndex = 2;
            this.metroButton_AddGroup.Text = "Add/Del Group";
            this.metroButton_AddGroup.UseSelectable = true;
            // 
            // AdminPanel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton_AddGroup);
            this.Controls.Add(this.metroButton_AddClass);
            this.Controls.Add(this.metroButton_AddUser);
            this.Name = "AdminPanel_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminPanel_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton_AddUser;
        private MetroFramework.Controls.MetroButton metroButton_AddClass;
        private MetroFramework.Controls.MetroButton metroButton_AddGroup;
    }
}