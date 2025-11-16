namespace AttendanceSystem_V2
{
    partial class AddUser_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser_Form));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.metroButton_Save = new MetroFramework.Controls.MetroButton();
            this.metroButton_Update = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_SearchText = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton_DeleteUser = new MetroFramework.Controls.MetroButton();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AttendanceSystem_V2.DataSet1();
            this.usersTableAdapter = new AttendanceSystem_V2.DataSet1TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.userLoginDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.usersBindingSource;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            // 
            // metroButton_Save
            // 
            resources.ApplyResources(this.metroButton_Save, "metroButton_Save");
            this.metroButton_Save.Name = "metroButton_Save";
            this.metroButton_Save.UseSelectable = true;
            // 
            // metroButton_Update
            // 
            resources.ApplyResources(this.metroButton_Update, "metroButton_Update");
            this.metroButton_Update.Name = "metroButton_Update";
            this.metroButton_Update.UseSelectable = true;
            this.metroButton_Update.Click += new System.EventHandler(this.metroButton_Update_Click);
            // 
            // metroTextBox_SearchText
            // 
            // 
            // 
            // 
            this.metroTextBox_SearchText.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.metroTextBox_SearchText.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.metroTextBox_SearchText.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.metroTextBox_SearchText.CustomButton.Name = "";
            this.metroTextBox_SearchText.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.metroTextBox_SearchText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_SearchText.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.metroTextBox_SearchText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_SearchText.CustomButton.UseSelectable = true;
            this.metroTextBox_SearchText.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.metroTextBox_SearchText.Lines = new string[0];
            resources.ApplyResources(this.metroTextBox_SearchText, "metroTextBox_SearchText");
            this.metroTextBox_SearchText.MaxLength = 32767;
            this.metroTextBox_SearchText.Name = "metroTextBox_SearchText";
            this.metroTextBox_SearchText.PasswordChar = '\0';
            this.metroTextBox_SearchText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_SearchText.SelectedText = "";
            this.metroTextBox_SearchText.SelectionLength = 0;
            this.metroTextBox_SearchText.SelectionStart = 0;
            this.metroTextBox_SearchText.ShortcutsEnabled = true;
            this.metroTextBox_SearchText.UseSelectable = true;
            this.metroTextBox_SearchText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_SearchText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox_SearchText.TextChanged += new System.EventHandler(this.metroTextBox_SearchText_TextChanged);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // metroButton_DeleteUser
            // 
            this.metroButton_DeleteUser.BackColor = System.Drawing.Color.Red;
            this.metroButton_DeleteUser.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.metroButton_DeleteUser, "metroButton_DeleteUser");
            this.metroButton_DeleteUser.Name = "metroButton_DeleteUser";
            this.metroButton_DeleteUser.UseCustomBackColor = true;
            this.metroButton_DeleteUser.UseCustomForeColor = true;
            this.metroButton_DeleteUser.UseSelectable = true;
            this.metroButton_DeleteUser.Click += new System.EventHandler(this.metroButton_DeleteUser_Click);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            resources.ApplyResources(this.userIDDataGridViewTextBoxColumn, "userIDDataGridViewTextBoxColumn");
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "User_Name";
            resources.ApplyResources(this.userNameDataGridViewTextBoxColumn, "userNameDataGridViewTextBoxColumn");
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "User_Type";
            resources.ApplyResources(this.userTypeDataGridViewTextBoxColumn, "userTypeDataGridViewTextBoxColumn");
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "User_Password";
            resources.ApplyResources(this.userPasswordDataGridViewTextBoxColumn, "userPasswordDataGridViewTextBoxColumn");
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            // 
            // userLoginDataGridViewTextBoxColumn
            // 
            this.userLoginDataGridViewTextBoxColumn.DataPropertyName = "User_Login";
            resources.ApplyResources(this.userLoginDataGridViewTextBoxColumn, "userLoginDataGridViewTextBoxColumn");
            this.userLoginDataGridViewTextBoxColumn.Name = "userLoginDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // AddUser_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroButton_DeleteUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTextBox_SearchText);
            this.Controls.Add(this.metroButton_Update);
            this.Controls.Add(this.metroButton_Save);
            this.Controls.Add(this.dataGridView);
            this.Name = "AddUser_Form";
            this.Load += new System.EventHandler(this.AddUser_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLoginDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton metroButton_Save;
        private MetroFramework.Controls.MetroButton metroButton_Update;
        private MetroFramework.Controls.MetroTextBox metroTextBox_SearchText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton_DeleteUser;
    }
}