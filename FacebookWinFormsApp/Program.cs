using System;
using System.Collections.Generic;
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
            formLoginPage.m_AppSettings = Settings.LoadFile();
        if(formLoginPage.m_AppSettings.RememberUser && !String.IsNullOrEmpty(formLoginPage.m_AppSettings.LastAcsessToken))
            {

                LoginResult loginResult = new LoginResult();
                

                 MainForm mf = new MainForm(loginResult.LoggedInUser);
                //this.Hide();
                mf.ShowDialog();
                //this.Show();
            }*/
            
            
                formLoginPage.ShowDialog();
            
           
                
            
                
            
        }
    }
}
