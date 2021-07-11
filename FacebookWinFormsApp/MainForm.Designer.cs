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
            this.AppTab = new System.Windows.Forms.TabControl();
            this.myProfileTab = new System.Windows.Forms.TabPage();
            this.logOutButton = new System.Windows.Forms.Button();
            this.friendsList = new System.Windows.Forms.ListBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.AppTab.SuspendLayout();
            this.myProfileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppTab
            // 
            this.AppTab.Controls.Add(this.myProfileTab);
            this.AppTab.Controls.Add(this.tabPage2);
            this.AppTab.Controls.Add(this.tabPage3);
            this.AppTab.Controls.Add(this.tabPage4);
            this.AppTab.Location = new System.Drawing.Point(12, 12);
            this.AppTab.Name = "AppTab";
            this.AppTab.SelectedIndex = 0;
            this.AppTab.Size = new System.Drawing.Size(776, 415);
            this.AppTab.TabIndex = 0;
            // 
            // myProfileTab
            // 
            this.myProfileTab.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.myProfileTab.Controls.Add(this.logOutButton);
            this.myProfileTab.Controls.Add(this.friendsList);
            this.myProfileTab.Controls.Add(this.profilePicture);
            this.myProfileTab.Location = new System.Drawing.Point(4, 22);
            this.myProfileTab.Name = "myProfileTab";
            this.myProfileTab.Padding = new System.Windows.Forms.Padding(3);
            this.myProfileTab.Size = new System.Drawing.Size(768, 389);
            this.myProfileTab.TabIndex = 0;
            this.myProfileTab.Text = "My Profile";
            this.myProfileTab.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(203, 349);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(183, 23);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // friendsList
            // 
            this.friendsList.FormattingEnabled = true;
            this.friendsList.Location = new System.Drawing.Point(606, 20);
            this.friendsList.Name = "friendsList";
            this.friendsList.Size = new System.Drawing.Size(120, 277);
            this.friendsList.TabIndex = 2;
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(184, 6);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(287, 224);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AppTab);
            this.Name = "MainForm";
            this.AppTab.ResumeLayout(false);
            this.myProfileTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AppTab;
        private System.Windows.Forms.TabPage myProfileTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox friendsList;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button logOutButton;
    }
}