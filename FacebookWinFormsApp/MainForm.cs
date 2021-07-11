using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        public User m_LoggedUser { get; set; }
        public MainForm()
        {
            
            InitializeComponent();
            fetchLoginDetails();

        }

        public void fetchLoginDetails()
        {
            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "226428995869586",
                    /// requested permissions:
                    "email",
                    "public_profile"
                    //"user_friends"


                    /// add any relevant permissions
                    );
            m_LoggedUser = new User();
            m_LoggedUser.m_FirstName = loginResult.LoggedInUser.FirstName;
            m_LoggedUser.m_LastName = loginResult.LoggedInUser.LastName;
            m_LoggedUser.m_UrlPic = loginResult.LoggedInUser.PictureLargeURL;
            profilePicture.ImageLocation = m_LoggedUser.m_UrlPic;
            this.Text=$"{m_LoggedUser.m_FirstName} {m_LoggedUser.m_LastName}";
            
            
       
            
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
