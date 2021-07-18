using System;

namespace BasicFacebookFeatures
{
    [Serializable]
    public sealed class AppSettings
    {
        private static readonly AppSettings sr_AppSettings = new AppSettings();
        public bool RememberUser { get; set; }
        public string LastAcsessToken { get; set; }
        private static readonly string sr_fileName = "Settings.txt";

        static AppSettings()
        {

        }
        private AppSettings()
        {

        }

        public static AppSettings AppSettingsInstance
        {
            get
            {
                return sr_AppSettings;
            }
        }

        public static string FileName
        {
            get
            {
                return sr_fileName;
            }

        }

        public void SaveToFile()
        {
            FileUtils.SaveToFile(AppSettings.FileName, this);
        }

        public static AppSettings LoadFile()
        {
            return  FileUtils.LoadFile(AppSettings.FileName, sr_AppSettings) as AppSettings;
        }
    }
}
