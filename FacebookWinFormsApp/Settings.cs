using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class Settings
    {
        public bool RememberUser { get; set; }
        public String LastAcsessToken { get; set; }

        public Settings()
        {
            RememberUser = false;
            LastAcsessToken = "";
            
        }
        public void SaveToFile()
        {
            using(Stream stream = new FileStream(@"C:\Users\USER\Desktop\Settings.txt", FileMode.Truncate))
            {
                XmlSerializer serlizer = new XmlSerializer(this.GetType());
                serlizer.Serialize(stream, this);
            }

        }

        public static Settings LoadFile()
        {
            Settings obj = new Settings();
            using (Stream stream = new FileStream(@"C:\Users\USER\Desktop\Settings.txt", FileMode.Open,FileAccess.ReadWrite))
            {
                XmlSerializer serlizer = new XmlSerializer(typeof(Settings));
                obj = serlizer.Deserialize(stream) as Settings;
               
            }
            return obj;
        }
    }

    
}
