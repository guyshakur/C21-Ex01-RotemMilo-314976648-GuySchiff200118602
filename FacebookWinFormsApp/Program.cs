using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            StartBasicFeatureFacebookApp();
        }

        private static void StartBasicFeatureFacebookApp()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginPageForm formLoginPage = new LoginPageForm();
            try
            {
                formLoginPage.AppSettings = AppSettings.LoadFile();
                if (!string.IsNullOrEmpty(formLoginPage.AppSettings.LastAcsessToken) && formLoginPage.AppSettings.RememberUser)
                {
                    try
                    {
                        LoginResult loginResult = FacebookService.Connect(formLoginPage.AppSettings.LastAcsessToken);
                        MainForm mainForm = new MainForm(loginResult.LoggedInUser);
                        mainForm.ShowDialog();
                    }
                    catch (Exception)
                    {
                        formLoginPage.ShowDialog();
                    }
                }
                else
                {
                    formLoginPage.ShowDialog();
                }
            }
            catch (Exception)
            {
                formLoginPage.ShowDialog();
            }
        }
    }
}