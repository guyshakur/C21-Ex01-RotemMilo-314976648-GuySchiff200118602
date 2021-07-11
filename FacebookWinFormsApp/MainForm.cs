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
            loadSelfDetails();
        }

        private void loadSelfDetails()
        {
            labelFirstName.Text += m_LoggedUser.FirstName;
            labelLastName.Text += m_LoggedUser.LastName;
            labelEmail.Text += m_LoggedUser.Email;
            labelGender.Text += m_LoggedUser.Gender.ToString();
            labelBirthday.Text += m_LoggedUser.Birthday;

        }

        private void loadLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            foreach (Page page in m_LoggedUser.LikedPages)
            {
                    
                    listBoxLikedPages.Items.Add(page.Name);
                
            }
            if(listBoxLikedPages.Items.Count==0)
            {
                listBoxLikedPages.Items.Add("There are no liked pages for this user");
            }

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            Close();
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            loadLikedPages();
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            loadPosts();
        }

        private void loadPosts()
        {
            listBoxPosts.Items.Clear();
                foreach (FacebookWrapper.ObjectModel.Post post in m_LoggedUser.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Items.Add(post.Message);
                        post.ReFetch(DynamicWrapper.eLoadOptions.Full);
                    }
                }
            }
        }
    }

