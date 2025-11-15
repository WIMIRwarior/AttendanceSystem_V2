namespace AttendanceSystem_V2
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroButton_Login = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton_Login
            // 
            this.metroButton_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton_Login.BackColor = System.Drawing.Color.Lime;
            this.metroButton_Login.DisplayFocus = true;
            this.metroButton_Login.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton_Login.ForeColor = System.Drawing.Color.Black;
            this.metroButton_Login.Location = new System.Drawing.Point(282, 134);
            this.metroButton_Login.MaximumSize = new System.Drawing.Size(133, 46);
            this.metroButton_Login.MinimumSize = new System.Drawing.Size(133, 46);
            this.metroButton_Login.Name = "metroButton_Login";
            this.metroButton_Login.Size = new System.Drawing.Size(133, 46);
            this.metroButton_Login.TabIndex = 0;
            this.metroButton_Login.Text = "LOGIN";
            this.metroButton_Login.UseCustomBackColor = true;
            this.metroButton_Login.UseCustomForeColor = true;
            this.metroButton_Login.UseSelectable = true;
            this.metroButton_Login.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 367);
            this.Controls.Add(this.metroButton_Login);
            this.Name = "MainForm";
            this.Text = "Class Register V2";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Enter += new System.EventHandler(this.MainForm_Enter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton_Login;
    }
}

