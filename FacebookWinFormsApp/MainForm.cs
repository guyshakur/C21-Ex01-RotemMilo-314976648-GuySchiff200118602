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
using BasicFacebookFeatures.WeatherFeature;
using BasicFacebookFeatures.FinanceFeature;
using BasicFacebookFeatures.CostumText;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        public CustomText m_customText { get; set;}
        private readonly FacebookWrapper.ObjectModel.User r_LoggedUser;
        private readonly List<object> r_LastPostsCollection = new List<object>();
        public MainForm(FacebookWrapper.ObjectModel.User m_LoginUser)
        {
            
            r_LoggedUser = m_LoginUser;
            InitializeComponent();
            fetchLoginDetails();
            fillMessagesListBoxFromFile();
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
            catch (Exception)
            {
                MessageBox.Show("Can't fetch weather details");
            }
        }

        private void fetchWeatherDetails(string i_CityLocation)
        {

            WeatherDetails weatherDetails = WeatherFeature.WeatherFeature.GetWeatherDetails(i_CityLocation);
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
            pictureBoxWeatherPredict.ImageLocation = "Http:" + weatherDetails.Current.Condition.Icon;
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
            formLoginPage.m_AppSettings.SaveToFile();
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
                if (selectedPhoto != null)
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
            catch (Exception)
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
            catch (Exception)
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


        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User friend = listBoxFriends.SelectedItem as User;
            fetchFriendsDetails(friend);
        }
        private void fetchFriendsDetails(User i_Friend)
        {
            if (i_Friend != null)
            {
                labelFriendFirstName.Text = $"First Name: {i_Friend.FirstName}";
                labelFriendLastName.Text = $"Last Name: {i_Friend.LastName}";
                labelFriendEmail.Text = $"Email: {i_Friend.Email}";
                labelFriendGender.Text = $"Gender: {i_Friend.Gender.ToString()}";
                labelFriendBirthday.Text = $"Birthday: {i_Friend.Birthday}";
                pictureBoxFriend.ImageLocation = i_Friend.PictureLargeURL;
            }
        }

        private void listBoxMatchFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchFriendsDetails(sender as User);
        }





        private void buttonFetchWeatherDetails_Click(object sender, EventArgs e)
        {
            try
            {
                fetchWeatherDetails(r_LoggedUser.Location.Name);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't fetch weather details");
            }
        }

        private void buttonFetchStockDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Stock searchStock = FinanceFeature.FinanceFeature.GetStocksDetails(textBoxSearchStock.Text);
                labelStockPrice.Text = $"Price: {searchStock.Price.ToString()}";
                labelStockIpo.Text = $"Stock Ipo: {searchStock.IpoDate}";
                labelStockChanges.Text = $"Changes: {searchStock.Changes.ToString()}";
                pictureBoxStock.ImageLocation = searchStock.Image;
            }
            catch
            {
                MessageBox.Show("Invalid Stock Name");
            }
        }

        private void saveToListButton_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(messageTextBox.Text))
            {
                m_customText.createMessageAndAddToList(messageTextBox.Text);
                listBoxMessages.Items.Add(m_customText.Messages.ElementAt(m_customText.Messages.Count-1));
                m_customText.SaveToFile();
                messageTextBox.Clear();
            }
        }

        private void clearTextButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(messageTextBox.Text))
            {
                messageTextBox.Clear();
            }
            
        }

        private void clearAllMessagesButton_Click(object sender, EventArgs e)
        {
            if (m_customText != null)
            {
                if(m_customText.Messages.Count!=0&&listBoxMessages!=null)
                {
                    listBoxMessages.Items.Clear();
                    m_customText.ClearMessages();
                    m_customText.SaveToFile();
                    
                }
                
            }
        }

        private void removeMessageButton_Click(object sender, EventArgs e)
        {
            if(m_customText!=null)
            {
                
                if (m_customText.Messages.Count != 0&&listBoxMessages.SelectedItem!=null)
                {
                    m_customText.RemoveMessageFromList(listBoxMessages.SelectedIndex);
                    listBoxMessages.Items.Remove(listBoxMessages.SelectedItem);
                    m_customText.SaveToFile();

                }
            }
           
        }
        
        private void fillMessagesListBoxFromFile()
        {
            m_customText = CustomText.CustomTextInstance;
            try
            {
                m_customText = CustomText.LoadFile();
                foreach(string message in m_customText.Messages)
                {
                    listBoxMessages.Items.Add(message);
                }

            }
            catch(Exception ex)
            {
                m_customText.SaveToFile();
            }


        }

        private void editMessageButton_Click(object sender, EventArgs e)
        {
            if(m_customText!=null)
            {
                if (m_customText.Messages.Count != 0 && listBoxMessages.SelectedItem != null)
                {
                    int index = listBoxMessages.SelectedIndex;
                    messageTextBox.Text = listBoxMessages.SelectedItem.ToString();
                    messageTextBox.Focus();
                    m_customText.RemoveMessageFromList(index);
                    listBoxMessages.Items.RemoveAt(index);
                    m_customText.SaveToFile();


                }
            }
            
        }
    }
    
}

