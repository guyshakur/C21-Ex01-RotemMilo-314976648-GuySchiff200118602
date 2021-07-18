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

            LoginPageForm formLoginPage = new LoginPageForm();
            try
            {
                formLoginPage.m_AppSettings = AppSettings.LoadFile();
                if (!String.IsNullOrEmpty(formLoginPage.m_AppSettings.LastAcsessToken) && formLoginPage.m_AppSettings.RememberUser)
                {
                    try
                    {
                        LoginResult loginResult = FacebookService.Connect(formLoginPage.m_AppSettings.LastAcsessToken);
                        MainForm mainForm = new MainForm(loginResult.LoggedInUser);
                        mainForm.ShowDialog();
                    }
                    catch(Exception)
                    {
                        formLoginPage.ShowDialog();
                    }

                    
                }
                else
                {
                    formLoginPage.ShowDialog();
                }
                
                
            }
            catch(Exception)
            {
                formLoginPage.ShowDialog();
            }
            
        }
    }
    
}
