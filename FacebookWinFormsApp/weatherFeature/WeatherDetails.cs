using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.weatherFeature
{
    public class WeatherDetails
    {
        private Location m_Location;
        private Current m_DailyPredict;

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
        public Current Current
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
