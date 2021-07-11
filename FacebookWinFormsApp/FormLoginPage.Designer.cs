namespace BasicFacebookFeatures
{
    partial class FormLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginPage));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.PictureLogoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Location = new System.Drawing.Point(32, 225);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(390, 147);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // PictureLogoBox
            // 
            this.PictureLogoBox.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Facebook_Logo_%282019%2" +
    "9.png/1024px-Facebook_Logo_%282019%29.png";
            this.PictureLogoBox.Location = new System.Drawing.Point(76, 45);
            this.PictureLogoBox.Margin = new System.Windows.Forms.Padding(4);
            this.PictureLogoBox.Name = "PictureLogoBox";
            this.PictureLogoBox.Size = new System.Drawing.Size(299, 138);
            this.PictureLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLogoBox.TabIndex = 53;
            this.PictureLogoBox.TabStop = false;
            // 
            // FormLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 399);
            this.Controls.Add(this.PictureLogoBox);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogoBox)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox PictureLogoBox;
    }
}

