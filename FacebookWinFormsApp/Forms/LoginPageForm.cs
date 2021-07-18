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
using System.Web;
using System.Web.Caching;
using CefSharp.DevTools.Network;

namespace BasicFacebookFeatures
{
    

    public partial class LoginPageForm : Form
    {
        public AppSettings m_AppSettings { get; set; }
        private FacebookWrapper.ObjectModel.User m_LoginUser;
        public LoginResult m_LoginResult { get; set; }

        public LoginPageForm()
        {
            m_AppSettings = AppSettings.AppSettingsInstance;
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            labelLogin.Text = "Login...";
            Login();
            if(rememberMeChecked.Checked)
            {
                m_AppSettings.LastAcsessToken = m_LoginResult.AccessToken;
            }
            m_AppSettings.RememberUser = rememberMeChecked.Checked;
            m_AppSettings.SaveToFile();
            
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoginUser = m_LoginResult.LoggedInUser;
                //buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
                MainForm mf = new MainForm(m_LoginUser);
                
                Hide();
                Close();
                mf.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
            

        }

        public LoginResult Login()
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
            return m_LoginResult;
        
        }

    }

}
