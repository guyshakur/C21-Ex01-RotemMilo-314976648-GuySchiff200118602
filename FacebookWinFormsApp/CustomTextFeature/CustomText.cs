using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.CostumText
{
    public class CustomText
    {
        public List<string> m_TextMessage { get; set; }
        private static readonly string r_fileName = "CustomMessages.txt";
        private static readonly CustomText sr_customText = new CustomText();


        private CustomText()
        {
            m_TextMessage = new List<string>();
        }

        public static CustomText CustomTextInstance
        {
            get
            {
                return sr_customText;
            }
        }

        public void createMessageAndAddToList(string i_message)
        {
            if(String.IsNullOrEmpty(i_message))
            {
                throw new Exception("can't create empty message");
            }
            m_TextMessage.Add(i_message);
            
        }

        public void ClearMessages()
        {
           
            m_TextMessage.Clear();
            
        }

        public void RemoveMessageFromList(int i_index)
        {
            m_TextMessage.RemoveAt(i_index);
        }

        public void SaveToFile()
        {
            FileUtils.SaveToFile(CustomText.r_fileName, this);
        }
        public static CustomText LoadFile()
        {
          
              return FileUtils.LoadFile(CustomText.r_fileName, sr_customText) as CustomText;
            
        }

    }
}
