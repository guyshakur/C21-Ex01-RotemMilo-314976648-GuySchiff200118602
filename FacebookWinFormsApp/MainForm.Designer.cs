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
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 389);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonFetchPosts);
            this.tabPage3.Controls.Add(this.listBoxPosts);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Posts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(524, 111);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(110, 23);
            this.buttonFetchPosts.TabIndex = 4;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(145, 14);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(366, 121);
            this.listBoxPosts.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxLikedPages);
            this.tabPage2.Controls.Add(this.buttonLikedPages);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(768, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;;
            this.listBoxLikedPages.Location = new System.Drawing.Point(145, 14);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(366, 121);
            this.listBoxLikedPages.TabIndex = 2;
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Location = new System.Drawing.Point(524, 111);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(110, 23);
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
            this.tabControlPages.Location = new System.Drawing.Point(14, 11);
            this.tabControlPages.Name = "tabControlPages";
            this.tabControlPages.SelectedIndex = 0;
            this.tabControlPages.Size = new System.Drawing.Size(776, 415);
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
            this.myProfileTab.Location = new System.Drawing.Point(4, 22);
            this.myProfileTab.Name = "myProfileTab";
            this.myProfileTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.myProfileTab.Size = new System.Drawing.Size(768, 389);
            this.myProfileTab.TabIndex = 0;
            this.myProfileTab.Text = "My Profile";
            this.myProfileTab.UseVisualStyleBackColor = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(29, 301);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(29, 279);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(48, 13);
            this.labelGender.TabIndex = 7;
            this.labelGender.Text = "Gender: ";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(29, 255);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(53, 13);
            this.labelBirthday.TabIndex = 6;
            this.labelBirthday.Text = "BirthDay: ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(29, 230);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(64, 13);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name: ";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(29, 206);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(63, 13);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "First Name: ";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(624, 362);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(146, 30);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(32, 28);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(166, 151);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlPages);
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