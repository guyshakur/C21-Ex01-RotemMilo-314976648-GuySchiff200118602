using Newtonsoft.Json;

namespace BasicFacebookFeatures.WeatherFeature
{
    public class Condition
    {
        private string m_PredictText;
        private string m_PredictIcon;

        [JsonProperty("Text")]
        public string PredictText
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

        [JsonProperty("Icon")]
        public string PredictIcon
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