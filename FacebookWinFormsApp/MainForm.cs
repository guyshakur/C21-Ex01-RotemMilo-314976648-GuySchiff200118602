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
using BasicFacebookFeatures.weatherFeature;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private readonly FacebookWrapper.ObjectModel.User r_LoggedUser;
        private readonly List<object> r_LastPostsCollection = new List<object>();
        public MainForm(FacebookWrapper.ObjectModel.User m_LoginUser)
        {
            r_LoggedUser = m_LoginUser;
            InitializeComponent();
            fetchLoginDetails();
        }

        public User LoggedUser
        {
            get
            {
                return r_LoggedUser;
            }
        }

        public void fetchLoginDetails()
        {
            pictureBoxProfile.ImageLocation = r_LoggedUser.PictureLargeURL;
            this.Text = $"{r_LoggedUser.FirstName} {r_LoggedUser.LastName}";
            fetchSelfDetails();
            try 
            {
                fetchWeatherDetails(r_LoggedUser.Location.Name);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't fetch weather details");
            }
        }

        private void fetchWeatherDetails(string i_CityLocation)
        {
            WeatherDetails weatherDetails = WeatherFeature.GetWeatherDetails(i_CityLocation);
            labelCountry.Text = $"Country: {weatherDetails.Location.Country}";
            labelCountry.Visible = true;
            labelLastUpdate.Text = $"Last Update: {weatherDetails.Location.LocalTime}";
            labelLastUpdate.Visible = true;
            labelCity.Text = $"City: {weatherDetails.Location.Name}";
            labelCity.Visible = true;
            labelPredictWeather.Text = $"Predict: {weatherDetails.Current.Condition.Text}";
            labelPredictWeather.Visible = true;
            labelTemperatureInCelcius.Text = $"Temperture in Celcius: {weatherDetails.Current.Temp_C}";
            labelTemperatureInCelcius.Visible = true;
            labelTemperatureInFahrnheit.Text = $"Temperture in Fahrenheit: {weatherDetails.Current.Temp_F}";
            labelTemperatureInFahrnheit.Visible = true;
            pictureBoxWeatherPredict.ImageLocation = "Http:"+weatherDetails.Current.Condition.Icon;
            pictureBoxWeatherPredict.Visible = true;
            buttonFetchWeatherDetails.Visible = true;
            labelWeatherDetails.Visible = true;
        }

        private void fetchSelfDetails()
        {
            labelFirstName.Text += r_LoggedUser.FirstName;
            labelLastName.Text += r_LoggedUser.LastName;
            labelEmail.Text += r_LoggedUser.Email;
            labelGender.Text += r_LoggedUser.Gender.ToString();
            labelBirthday.Text += r_LoggedUser.Birthday;

        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            foreach (Page page in r_LoggedUser.LikedPages)
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
            formLoginPage.m_AppSettings.RememberUser = false;
            AppSettings.SaveToFile();
            Hide();
            formLoginPage.ShowDialog();
            formLoginPage.m_LoginResult = null;
            Close();
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            fetchLikedPages();    
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            r_LoggedUser.ReFetch();
            listBoxPosts.Items.Clear();
            listBoxPosts.DisplayMember = "Message";
            foreach (Post post in r_LoggedUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post);
                }

            }

            if (r_LoggedUser.Posts.Count == 0)
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
            Post selected = r_LoggedUser.Posts[listBoxPosts.SelectedIndex];
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
                foreach (object obj in listBoxPosts.Items)
                {
                    r_LastPostsCollection.Add(obj);
                }

                listBoxPosts.Sorted = true;
            }
            else if (listBoxPosts.Items.Count == 0)
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
            Page selected = r_LoggedUser.LikedPages[listBoxLikedPages.SelectedIndex];
            webBrowserPages.Navigate(selected.URL);
        }

        private void listBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPhotos.SelectedItem != null)
            {
                Photo selectedPhoto = listBoxPhotos.SelectedItem as Photo;
                if(selectedPhoto!=null)
                {
                    pictureBoxPhoto.ImageLocation = selectedPhoto.PictureNormalURL;
                    pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    listBoxPhotosComments.DataSource = selectedPhoto.Comments;
                }
                
            }
        }

        

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            foreach (Album album in r_LoggedUser.Albums)
            {
                listBoxAlbums.Items.Add(album);
            }
            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPhotos.Items.Clear();
            listBoxPhotos.DisplayMember = "Name";
            Album albumSelected = listBoxAlbums.SelectedItem as Album;
            try
            {

                foreach (Photo photo in albumSelected.Photos)
                {
                    listBoxPhotos.Items.Add(photo);
                }
            }
            catch(Exception)
            {

            }
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";

            try
            {
                foreach (Event userEvent in r_LoggedUser.Events)
                {
                    listBoxEvents.Items.Add(userEvent);
                }
                
                if (r_LoggedUser.Events.Count == 0)
                {
                    MessageBox.Show("No Events to retrieve.");
                }
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("Authentication error. Cannot fetch events for current user from Facebook.");
            }
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxPhotos.SelectedItem != null)
                {
                    Photo photo = (listBoxPhotos.SelectedItem) as Photo;
                    if (!photo.LikedBy.Contains(r_LoggedUser))
                    {
                        photo.Like();
                    }
                    else
                    {
                        photo.Unlike();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("problem has been deteced with liking post. Contact FaceBook administrator.");
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            postMessage();
        }

        private void postMessage()
        {
            try
            {
                r_LoggedUser.PostStatus(textBoxPost.Text);
                MessageBox.Show("Your post shared sucessfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Your post can't be shared. Please contact facebook administrator ");
            }
            finally
            {
                textBoxPost.Text = string.Empty;
            }
        }


        private void buttonMatch_Click(object sender, EventArgs e)
        {
            if(listBoxMatchFriends.SelectedItem!=null)
            {
                DatingFeature.Match(r_LoggedUser, listBoxMatchFriends.SelectedItem as User);
            }
        }


        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            listBoxFriends.Items.Clear();
            listBoxMatchFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";

            try
            {
                foreach (User friend in r_LoggedUser.Friends)
                {
                    listBoxFriends.Items.Add(friend);
                    listBoxMatchFriends.Items.Add(friend);
                }

                if (r_LoggedUser.Friends.Count == 0)
                {
                    MessageBox.Show("No friends to retrieve.");
                    //listBoxFriends.Items.Add(r_LoggedUser);
                    //listBoxMatchFriends.Items.Add(r_LoggedUser);
                }
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("Authentication error. Cannot fetch friends for current user from Facebook.");
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User friend = listBoxFriends.SelectedItem as User;
            fetchFriendsDetails(friend);
        }
        private void fetchFriendsDetails(User i_Friend)
        {
            if(i_Friend!=null)
            {
                labelFriendFirstName.Text = $"First Name: {r_LoggedUser.FirstName}";
                labelFriendLastName.Text = $"Last Name: {r_LoggedUser.LastName}";
                labelFriendEmail.Text = $"Email: {r_LoggedUser.Email}";
                labelFriendGender.Text = $"Gender: {r_LoggedUser.Gender.ToString()}";
                labelFriendBirthday.Text = $"Birthday: {r_LoggedUser.Birthday}";
                pictureBoxFriend.ImageLocation = i_Friend.PictureLargeURL;
            }
        }

        private void listBoxMatchFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchFriendsDetails(sender as User);
        }

        private void buttonFindMatches_Click(object sender, EventArgs e)
        {
            List<User> matchesList = DatingFeature.FindMatches(r_LoggedUser);
            if(matchesList != null)
            {
                listBoxFindMatches.DataSource = matchesList;
            }
        }

        private void listBoxFindMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchFriendsDetails(listBoxFindMatches.SelectedItem as User);
        }

        private void buttonFetchWeatherDetails_Click(object sender, EventArgs e)
        {
            try
            {
                fetchWeatherDetails(r_LoggedUser.Location.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't fetch weather details");
            }
        }

    }
}

