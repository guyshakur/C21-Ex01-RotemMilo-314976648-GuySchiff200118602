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
        public FacebookWrapper.ObjectModel.User m_LoggedUser { get; set; }
        public MainForm(FacebookWrapper.ObjectModel.User m_LoginUser)
        {
            m_LoggedUser = m_LoginUser;
            InitializeComponent();
            fetchLoginDetails();

        }

        public void fetchLoginDetails()
        {
            profilePicture.ImageLocation = m_LoggedUser.PictureLargeURL;
            this.Text=$"{m_LoggedUser.FirstName} {m_LoggedUser.LastName}";
            loadPages();
        }

        private void loadPages()
        {
            // your code here
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            Close();
        }
    }
}
