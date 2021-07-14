using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    [Serializable]
    public sealed class AppSettings
    {
        private static readonly AppSettings r_AppSettingsInstance = new AppSettings();
        public bool RememberUser { get; set; }
        public String LastAcsessToken { get; set; }

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

                return r_AppSettingsInstance;
            }
        }

        public void SaveToFile()
        {
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Settings.txt");

            using (Stream stream = new FileStream(@startupPath, FileMode.Truncate, FileAccess.ReadWrite))
            {
                XmlSerializer serlizer = new XmlSerializer(this.GetType());
                serlizer.Serialize(stream, this);
            }

        }

        public static AppSettings LoadFile()
        {

            AppSettings obj = null;
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Settings.txt");
            using (Stream stream = new FileStream(@startupPath, FileMode.Open, FileAccess.ReadWrite))
            {
                XmlSerializer serlizer = new XmlSerializer(typeof(AppSettings));
                obj = serlizer.Deserialize(stream) as AppSettings;

            }

            return obj;
        }
    }

}

