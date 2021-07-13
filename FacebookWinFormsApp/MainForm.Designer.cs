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
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.listBoxPhotos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxPhotosComments = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.checkBoxSortPostsByOrder = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.webBrowserPages = new System.Windows.Forms.WebBrowser();
            this.tabControlAlbums = new System.Windows.Forms.TabControl();
            this.myProfileTab = new System.Windows.Forms.TabPage();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.tabPageAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlAlbums.SuspendLayout();
            this.myProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.Controls.Add(this.splitContainer3);
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabPageAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Size = new System.Drawing.Size(1027, 482);
            this.tabPageAlbums.TabIndex = 3;
            this.tabPageAlbums.Text = "Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listBoxAlbums);
            this.splitContainer3.Panel1.Controls.Add(this.buttonFetchAlbums);
            this.splitContainer3.Panel1.Controls.Add(this.listBoxPhotos);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label5);
            this.splitContainer3.Panel2.Controls.Add(this.pictureBoxPhoto);
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Panel2.Controls.Add(this.listBoxPhotosComments);
            this.splitContainer3.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel2_Paint);
            this.splitContainer3.Size = new System.Drawing.Size(1021, 476);
            this.splitContainer3.SplitterDistance = 384;
            this.splitContainer3.TabIndex = 9;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(6, 34);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(375, 132);
            this.listBoxAlbums.TabIndex = 1;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFetchAlbums.Location = new System.Drawing.Point(0, 443);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(384, 33);
            this.buttonFetchAlbums.TabIndex = 8;
            this.buttonFetchAlbums.Text = "Fetch Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // listBoxPhotos
            // 
            this.listBoxPhotos.FormattingEnabled = true;
            this.listBoxPhotos.ItemHeight = 16;
            this.listBoxPhotos.Location = new System.Drawing.Point(5, 247);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.Size = new System.Drawing.Size(376, 164);
            this.listBoxPhotos.TabIndex = 4;
            this.listBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Albums";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Photos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comments";
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(206, 34);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(218, 185);
            this.pictureBoxPhoto.TabIndex = 3;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preview";
            // 
            // listBoxPhotosComments
            // 
            this.listBoxPhotosComments.FormattingEnabled = true;
            this.listBoxPhotosComments.ItemHeight = 16;
            this.listBoxPhotosComments.Location = new System.Drawing.Point(6, 247);
            this.listBoxPhotosComments.Name = "listBoxPhotosComments";
            this.listBoxPhotosComments.Size = new System.Drawing.Size(627, 164);
            this.listBoxPhotosComments.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1027, 482);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Posts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxSortPostsByOrder);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxSearch);
            this.splitContainer2.Panel1.Controls.Add(this.buttonFetchPosts);
            this.splitContainer2.Panel1.Controls.Add(this.listBoxPosts);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBoxComments);
            this.splitContainer2.Size = new System.Drawing.Size(1021, 476);
            this.splitContainer2.SplitterDistance = 337;
            this.splitContainer2.TabIndex = 52;
            // 
            // checkBoxSortPostsByOrder
            // 
            this.checkBoxSortPostsByOrder.AutoSize = true;
            this.checkBoxSortPostsByOrder.Location = new System.Drawing.Point(4, 61);
            this.checkBoxSortPostsByOrder.Name = "checkBoxSortPostsByOrder";
            this.checkBoxSortPostsByOrder.Size = new System.Drawing.Size(190, 21);
            this.checkBoxSortPostsByOrder.TabIndex = 51;
            this.checkBoxSortPostsByOrder.Text = "Sort Post By Name Order";
            this.checkBoxSortPostsByOrder.UseVisualStyleBackColor = true;
            this.checkBoxSortPostsByOrder.CheckedChanged += new System.EventHandler(this.checkBoxSortPostsByOrder_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-464, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(4, 22);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(329, 22);
            this.textBoxSearch.TabIndex = 48;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFetchPosts.Location = new System.Drawing.Point(0, 448);
            this.buttonFetchPosts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(337, 28);
            this.buttonFetchPosts.TabIndex = 4;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(4, 103);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(330, 340);
            this.listBoxPosts.TabIndex = 3;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxComments
            // 
            this.listBoxComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 16;
            this.listBoxComments.Location = new System.Drawing.Point(0, 0);
            this.listBoxComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(680, 476);
            this.listBoxComments.TabIndex = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1027, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(7, 7);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxLikedPages);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLikedPages);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowserPages);
            this.splitContainer1.Size = new System.Drawing.Size(1017, 472);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 3;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 16;
            this.listBoxLikedPages.Location = new System.Drawing.Point(0, 0);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(339, 444);
            this.listBoxLikedPages.TabIndex = 2;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLikedPages.Location = new System.Drawing.Point(0, 444);
            this.buttonLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(339, 28);
            this.buttonLikedPages.TabIndex = 1;
            this.buttonLikedPages.Text = "Fetch Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = true;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // webBrowserPages
            // 
            this.webBrowserPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPages.Location = new System.Drawing.Point(0, 0);
            this.webBrowserPages.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPages.Name = "webBrowserPages";
            this.webBrowserPages.Size = new System.Drawing.Size(674, 472);
            this.webBrowserPages.TabIndex = 0;
            // 
            // tabControlAlbums
            // 
            this.tabControlAlbums.Controls.Add(this.myProfileTab);
            this.tabControlAlbums.Controls.Add(this.tabPage2);
            this.tabControlAlbums.Controls.Add(this.tabPage3);
            this.tabControlAlbums.Controls.Add(this.tabPageAlbums);
            this.tabControlAlbums.Controls.Add(this.tabPage1);
            this.tabControlAlbums.Location = new System.Drawing.Point(19, 14);
            this.tabControlAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlAlbums.Name = "tabControlAlbums";
            this.tabControlAlbums.SelectedIndex = 0;
            this.tabControlAlbums.Size = new System.Drawing.Size(1035, 511);
            this.tabControlAlbums.TabIndex = 0;
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
            this.myProfileTab.Text = "Profile";
            this.myProfileTab.UseVisualStyleBackColor = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(39, 373);
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
            this.logOutButton.Location = new System.Drawing.Point(832, 446);
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
            this.profilePicture.Location = new System.Drawing.Point(8, 25);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(221, 186);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonFetchEvents);
            this.tabPage1.Controls.Add(this.listBoxEvents);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1027, 482);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Events";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Location = new System.Drawing.Point(681, 196);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(136, 40);
            this.buttonFetchEvents.TabIndex = 1;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(26, 18);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(624, 180);
            this.listBoxEvents.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlAlbums);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPageAlbums.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlAlbums.ResumeLayout(false);
            this.myProfileTab.ResumeLayout(false);
            this.myProfileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageAlbums;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.TabControl tabControlAlbums;
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
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.CheckBox checkBoxSortPostsByOrder;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowserPages;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPhotos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxPhotosComments;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label5;
    }
}