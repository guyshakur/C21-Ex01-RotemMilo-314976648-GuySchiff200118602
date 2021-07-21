using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class LoginPageForm : Form
    {
        private User m_LoginUser;
        private LoginResult m_LoginResult;
        private AppSettings m_AppSettings;

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

            if (rememberMeChecked.Checked)
            {
                m_AppSettings.LastAcsessToken = m_LoginResult.AccessToken;
            }

            m_AppSettings.RememberUser = rememberMeChecked.Checked;
            m_AppSettings.SaveToFile();

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoginUser = m_LoginResult.LoggedInUser;
                MainForm mf = new MainForm(m_LoginUser);

                Hide();
                Close();
                mf.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        public LoginResult Login()
        {
            m_LoginResult = FacebookService.Login(
                    "226428995869586",
                    "email",
                    "user_posts",
                    "user_friends",
                    "user_likes",
                    "user_photos",
                    "user_events",
                    "user_birthday",
                    "user_location",
                    "user_gender",
                    "groups_access_member_info");

            return m_LoginResult;
        }

        public LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }

            set
            {
                m_LoginResult = value;
            } 
        }

        public AppSettings AppSettings
        {
            get
            {
                return m_AppSettings;
            }

            set
            {
                m_AppSettings = value;
            }
        }
    }
}