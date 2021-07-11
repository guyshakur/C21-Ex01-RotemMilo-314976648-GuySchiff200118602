namespace BasicFacebookFeatures
{
    
    partial class MainForm
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
        /// 
        
        
        private void InitializeComponent()
        {
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.tabControlPages = new System.Windows.Forms.TabControl();
            this.myProfileTab = new System.Windows.Forms.TabPage();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControlPages.SuspendLayout();
            this.myProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1027, 482);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 320);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonFetchPosts);
            this.tabPage3.Controls.Add(this.listBoxPosts);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1027, 482);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Posts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(699, 137);
            this.buttonFetchPosts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(147, 28);
            this.buttonFetchPosts.TabIndex = 4;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(193, 17);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(487, 148);
            this.listBoxPosts.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxLikedPages);
            this.tabPage2.Controls.Add(this.buttonLikedPages);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1027, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 16;
            this.listBoxLikedPages.Location = new System.Drawing.Point(193, 17);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(487, 148);
            this.listBoxLikedPages.TabIndex = 2;
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Location = new System.Drawing.Point(699, 137);
            this.buttonLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(147, 28);
            this.buttonLikedPages.TabIndex = 1;
            this.buttonLikedPages.Text = "Fetch Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = true;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // tabControlPages
            // 
            this.tabControlPages.Controls.Add(this.myProfileTab);
            this.tabControlPages.Controls.Add(this.tabPage2);
            this.tabControlPages.Controls.Add(this.tabPage3);
            this.tabControlPages.Controls.Add(this.tabPage4);
            this.tabControlPages.Location = new System.Drawing.Point(19, 13);
            this.tabControlPages.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPages.Name = "tabControlPages";
            this.tabControlPages.SelectedIndex = 0;
            this.tabControlPages.Size = new System.Drawing.Size(1035, 511);
            this.tabControlPages.TabIndex = 0;
            // 
            // myProfileTab
            // 
            this.myProfileTab.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.myProfileTab.Controls.Add(this.labelEmail);
            this.myProfileTab.Controls.Add(this.labelGender);
            this.myProfileTab.Controls.Add(this.labelBirthday);
            this.myProfileTab.Controls.Add(this.labelLastName);
            this.myProfileTab.Controls.Add(this.labelFirstName);
            this.myProfileTab.Controls.Add(this.logOutButton);
            this.myProfileTab.Controls.Add(this.profilePicture);
            this.myProfileTab.Location = new System.Drawing.Point(4, 25);
            this.myProfileTab.Margin = new System.Windows.Forms.Padding(4);
            this.myProfileTab.Name = "myProfileTab";
            this.myProfileTab.Padding = new System.Windows.Forms.Padding(4);
            this.myProfileTab.Size = new System.Drawing.Size(1027, 482);
            this.myProfileTab.TabIndex = 0;
            this.myProfileTab.Text = "My Profile";
            this.myProfileTab.UseVisualStyleBackColor = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(39, 371);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 17);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(39, 343);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(64, 17);
            this.labelGender.TabIndex = 7;
            this.labelGender.Text = "Gender: ";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(39, 314);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(70, 17);
            this.labelBirthday.TabIndex = 6;
            this.labelBirthday.Text = "BirthDay: ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(39, 283);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(84, 17);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name: ";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(39, 254);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(84, 17);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "First Name: ";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(832, 445);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(195, 37);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(42, 35);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(221, 186);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlPages);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControlPages.ResumeLayout(false);
            this.myProfileTab.ResumeLayout(false);
            this.myProfileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.TabControl tabControlPages;
        private System.Windows.Forms.TabPage myProfileTab;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
    }
}