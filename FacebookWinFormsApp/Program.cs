using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StartBasicFeatureFacebookApp();
        }

        private static void StartBasicFeatureFacebookApp()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLoginPage formLoginPage = new FormLoginPage();
            formLoginPage.m_AppSettings = Settings.LoadFile();
            if (formLoginPage.m_AppSettings == null)
            {
                formLoginPage.ShowDialog();
            }

            if (!String.IsNullOrEmpty(formLoginPage.m_AppSettings.LastAcsessToken) && formLoginPage.m_AppSettings.RememberUser)
            {
                //formLoginPage.Login();

                //m_LoginUser = FormLoginPage.s_LoginResult.LoggedInUser;
                //buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
                //MainForm mf2 = new MainForm(formLoginPage.m_AppSettings.LastAcsessToken);
                try
                {
                    LoginResult lg = FacebookService.Connect(formLoginPage.m_AppSettings.LastAcsessToken);
                    MainForm mf = new MainForm(lg.LoggedInUser);
                    mf.ShowDialog();
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
    }
    
}
