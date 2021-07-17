using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.weatherFeature
{
    public class Condition
    {
        private string m_PredictText { get; set; }
        private string m_PredictIcon { get; set; }

        public string Text
        {
            get
            {
                return m_PredictText;
            }
            set
            {
                m_PredictText = value;
            }
        }

        public string Icon
        {
            get
            {
                return m_PredictIcon;
            }
            set
            {
                m_PredictIcon = value;
            }
        }
    }
    
}
