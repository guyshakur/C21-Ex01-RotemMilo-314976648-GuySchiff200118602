using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.weatherFeature
{
    public static class WeatherFeature
    {
        public static WeatherDetails GetWeatherDetails(string i_Location)
        {
            WebRequest request = HttpWebRequest.Create($"http://api.weatherapi.com/v1/current.json?key=653ce11ceb1a4b3ba0195804211707&q={i_Location}&aqi=no");
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string rootStr = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<WeatherDetails>(rootStr);
        }
    }
}
