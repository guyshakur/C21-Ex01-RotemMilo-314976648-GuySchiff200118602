using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    

    public partial class FormLoginPage : Form
    {
        public Settings m_AppSettings { get; set; }
        private FacebookWrapper.ObjectModel.User m_LoginUser;
        public LoginResult m_LoginResult { get; set; }

        public FormLoginPage()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            LoginResult loginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "226428995869586", 
                    /// requested permissions:
					"email",
                    "user_posts",
                    "user_friends",
                    "user_likes",
                    "user_photos",
                    "user_events",
                    "user_birthday",
                    "user_location",
                    "user_gender"
                    /// add any relevant permissions
                    );

            
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoginUser = m_LoginResult.LoggedInUser;
                //buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
                MainForm mf = new MainForm(m_LoginUser);
                this.Hide();
                mf.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }

        }

        private void login()
        {
             m_LoginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "226428995869586",
                    /// requested permissions:
                    "email",
                        "user_posts",
                        "user_friends",
                        "user_likes",
                        "user_photos",
                        "user_events",
                        "user_birthday",
                        "user_location",
                        "user_gender"
                    /// add any relevant permissions
                    );
        }
    }
   
}
