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
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Settings.txt");

            using (Stream stream = new FileStream(@startupPath, FileMode.Truncate, FileAccess.ReadWrite))
            {
                XmlSerializer serlizer = new XmlSerializer(this.GetType());
                serlizer.Serialize(stream, this);
            }

        }

        public static Settings LoadFile()
        {

            Settings obj = null;
            string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Settings.txt");
            using (Stream stream = new FileStream(@startupPath, FileMode.Open,FileAccess.ReadWrite))
            {
                XmlSerializer serlizer = new XmlSerializer(typeof(Settings));
                obj = serlizer.Deserialize(stream) as Settings;
               
            }
            
            return obj;
        }
    }

    
}
