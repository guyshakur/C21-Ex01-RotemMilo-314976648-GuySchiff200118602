using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.WeatherFeature
{
    public class WeatherDetails
    {
        private Location m_Location;
        private Current m_DailyPredict;
        [JsonProperty("Location")]
        public Location Location
        {
            get
            {
                return m_Location;
            }
            set
            {
                m_Location = value;
            }
        }

        [JsonProperty("Current")]
        public Current DailyPredict
        {
            get
            {
                return m_DailyPredict;
            }
            set
            {
                m_DailyPredict = value;
            }
        }

    }
}
