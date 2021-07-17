using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.WeatherFeature
{
    public class Location
    {
        private string m_CityName;
        private string m_Country;
        public string m_LocalTime;
        public string Name
        {
            get
            {
                return m_CityName;
            }
            set
            {
                m_CityName = value;
            }
        }
        public string Country
        {
            get
            {
                return m_Country;
            }
            set
            {
                m_Country = value;
            }
        }
        public string LocalTime
        {
            get
            {
                return m_LocalTime;
            }
            set
            {
                m_LocalTime = value;
            }
        }

    }
}
