using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using Facebook;
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
        private FacebookWrapper.ObjectModel.User m_LoggedUser { get; set; }
        private readonly List<object> r_LastPostsCollection = new List<object>();
        public MainForm(FacebookWrapper.ObjectModel.User m_LoginUser)
        {
            m_LoggedUser = m_LoginUser;
            InitializeComponent();
            fetchLoginDetails();
        }

        public void fetchLoginDetails()
        {
            profilePicture.ImageLocation = m_LoggedUser.PictureLargeURL;
            this.Text = $"{m_LoggedUser.FirstName} {m_LoggedUser.LastName}";
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
            if (listBoxLikedPages.Items.Count == 0)
            {
                listBoxLikedPages.Items.Add("There are no liked pages for this user");
            }

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {

            FacebookService.LogoutWithUI();
            FormLoginPage formLoginPage = new FormLoginPage();
            formLoginPage.m_AppSettings.LastAcsessToken = "";
            formLoginPage.m_AppSettings.SaveToFile();
            Hide();
            formLoginPage.ShowDialog();
            formLoginPage.m_LoginResult = null;
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
            m_LoggedUser.ReFetch();
            listBoxPosts.Items.Clear();
            listBoxPosts.DisplayMember = "Message";
            foreach (Post post in m_LoggedUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post);
                }

            }

            if (m_LoggedUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve.");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchInPost(listBoxPosts.Text);
        }

        private void searchInPost(string i_StringToSearch)
        {
            if (listBoxPosts.Items.Count != 0)
            {
                int id = listBoxPosts.FindString(i_StringToSearch);
                if (id >= 0)
                {
                    listBoxPosts.SetSelected(id, true);
                }
            }
            else
            {
                MessageBox.Show("Please fetch posts before");
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = m_LoggedUser.Posts[listBoxPosts.SelectedIndex];
            listBoxComments.DisplayMember = "Message";
            listBoxComments.DataSource = selected.Comments;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            searchInPost((sender as TextBox)?.Text);
        }

        private void checkBoxSortPostsByOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxPosts.Items.Count != 0 && (sender as CheckBox)?.Checked == true)
            {
                r_LastPostsCollection.Clear();
                foreach(object obj in listBoxPosts.Items)
                {
                    r_LastPostsCollection.Add(obj);
                }

                listBoxPosts.Sorted = true;
            }
            else if(listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("Please fetch posts before");
            }
            else
            {
                listBoxPosts.Sorted = false;
                listBoxPosts.Items.Clear();
                foreach (object obj in r_LastPostsCollection)
                {
                    listBoxPosts.Items.Add(obj);
                }
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page selected = m_LoggedUser.LikedPages[listBoxLikedPages.SelectedIndex];
            webBrowserPages.Navigate(selected.URL);
        }
    }
}

