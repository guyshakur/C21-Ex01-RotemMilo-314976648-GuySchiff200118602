using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
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
            
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            FormLoginPage formLoginPage = new FormLoginPage();
            //formLoginPage.m_AppSettings = Settings.LoadFile();
            try
            {
                formLoginPage.m_AppSettings = AppSettings.LoadFile();

                if (!String.IsNullOrEmpty(formLoginPage.m_AppSettings.LastAcsessToken) && formLoginPage.m_AppSettings.RememberUser)
                {
                    LoginResult loginResult = FacebookService.Connect(formLoginPage.m_AppSettings.LastAcsessToken);
                    MainForm mf = new MainForm(loginResult.LoggedInUser);
                    mf.ShowDialog();

                }

                else
                {
                    formLoginPage.ShowDialog();
                }
            }

            catch(Exception ex)
            {
                formLoginPage.ShowDialog();
            }

               


        }


    }
    
}
