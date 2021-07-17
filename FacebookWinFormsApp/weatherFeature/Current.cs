using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.weatherFeature
{
    public class Current
    {
        public double m_TempertureInCelsius { get; set; }
        public double m_TempertureInFahrenheit { get; set; }
        public Condition m_Condition { get; set; }

        public double Temp_C
        {
            get
            {
                return m_TempertureInCelsius;
            }
            set
            {
                m_TempertureInCelsius = value;
            }
        }
        public double Temp_F
        {
            get
            {
                return m_TempertureInFahrenheit;
            }
            set
            {
                m_TempertureInFahrenheit = value;
            }
        }

        public Condition Condition
        {
            get
            {
                return m_Condition;
            }
            set
            {
                m_Condition = value;
            }
        }

    }
}
